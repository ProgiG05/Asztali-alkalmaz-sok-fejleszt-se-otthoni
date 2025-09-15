using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShuttle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<SpaceClass> adatok = new List<SpaceClass>();
        private void megnyitas_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //open.InitialDirectory = "C:\\Users\\szabo.gergo.1005\\source\\repos\\SpaceShuttle\\SpaceShuttle\\bin\\Debug"; //suli
            open.InitialDirectory = "C:\\Users\\Pali\\source\\repos\\SpaceShuttle\\SpaceShuttle\bin\\Debug"; //otthon
            //open.InitialDirectory = "C:\\Users"; //general
            open.Filter = "csv files (*.csv) | *.csv"; 
            open.FilterIndex = 0;
            open.RestoreDirectory = true;
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string selectedFileName = open.FileName;
            adatok.Clear();
            System.IO.File.ReadAllLines(selectedFileName).ToList().ForEach(x => adatok.Add(new SpaceClass(x)));
            for (int i = 0; i < adatok.Count; i++)
            {
                adatok_lista.Items.Add($"{adatok[i].kód.ToString()},{adatok[i].kilövés.ToString()},{adatok[i].ursiklonev.ToString()},{adatok[i].nap.ToString()},{adatok[i].óra.ToString()},{adatok[i].tamasznev.ToString()},{adatok[i].legénység.ToString()}");
            }
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].tamasznev == "nem landolt")
                {
                    continue;
                }
                else if (!állomásnév_selected.Items.Contains(adatok[i].tamasznev))
                {
                    állomásnév_selected.Items.Add(adatok[i].tamasznev.ToString());
                }
            }
            állomásnév_selected.SelectedIndex = állomásnév_selected.FindStringExact("Kennedy");
        }
        private void close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos, hogy ki akarsz lépni?", "Bezárás", MessageBoxButtons.OKCancel ,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
        //a)
        private void kuldetesek_szama_CheckedChanged(object sender, EventArgs e)
        {
            if (adatok_lista.Items.Count == 0)
            {
                MessageBox.Show("Nem választottál fájlt!","Hiba");
            }
            else
            {
                szamlalo.Text = adatok.Count().ToString();
            }
        }
        //b)
        private void utasok_szama_CheckedChanged(object sender, EventArgs e)
        {
            if (adatok_lista.Items.Count == 0)
            {
                MessageBox.Show("Nem választottál fájlt!","Hiba");
            }
            else
            {
                szamlalo.Text = adatok.Sum(x => x.legénység).ToString();
            }
            
        }
        //c)
        private void max_ot_utas_CheckedChanged(object sender, EventArgs e)
        {
            if (adatok_lista.Items.Count == 0)
            {
                MessageBox.Show("Nem választottál fájlt!","Hiba");
            }
            else
            {
                szamlalo.Text = adatok.Where(x => x.legénység < 5).Sum(x => x.legénység).ToString();
            }
            
        }
        private void show_Click(object sender, EventArgs e)
        {
            if (adatok_lista.Items.Count == 0)
            {
                MessageBox.Show("Nem választottál fájlt!","Hiba");
            }
            else if (év_be.Text == "")
            {
                MessageBox.Show("Nem adtál meg évet!","Hiba");
            }
            else
            {
                // d)
                var c = adatok.Where(x => x.ursiklonev == "Columbia").ToList().Last();
                columbia.Text = c.legénység.ToString();
                //e)
                legtöbb_lista.Items.Clear();
                var max = adatok.Max(x => x.nap);
                var legtöbb = adatok.Where(x => x.nap == max).ToList().First();
                legtöbb_lista.Items.Add($"Űrsikló neve: {legtöbb.ursiklonev}");
                legtöbb_lista.Items.Add($"Űrsikló küldetésének kódja: {legtöbb.kód}");
                legtöbb_lista.Items.Add($"Űrsikló küldetésének ideje: {legtöbb.nap * 24 + legtöbb.óra}");
                //f)
                var küldetes_szamlalo = adatok.Where(x => x.kilövés.Year.ToString() == év_be.Text.ToString()).Count();
                if (küldetes_szamlalo == 0)
                {
                    nincs.Text = "Ebben az évben nem indult küldetés! ";
                    küld_szam.Text = "";
                }
                else
                {
                    nincs.Text = "";
                    küld_szam.Text = küldetes_szamlalo.ToString();
                }
                //g)
                double szazalek = adatok.Where(x => x.tamasznev.ToString() == állomásnév_selected.SelectedItem.ToString()).Count();
                double eredmeny = (szazalek / Convert.ToDouble(adatok.Count)) * 100;
                százalék.Text = Math.Round(eredmeny, 2).ToString();
            }
        }
        //h)
        private void írás_Click(object sender, EventArgs e)
        {
            try
            {
                if (adatok.Count == 0)
                {
                    MessageBox.Show("Nem olvastál be fájlt!", "Hiba");
                }
                else if (fajlneve.Text == "")
                {
                    MessageBox.Show("Nem adtál meg fájlnevet!","Hiba");
                }
                else
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter($"{fajlneve.Text.ToString()}.txt");
                    List<string> name = new List<string>();
                    List<int> time = new List<int>();
                    for (int i = 0; i < adatok.Count; i++)
                    {
                        if (!name.Contains(adatok[i].ursiklonev))
                        {
                            name.Add(adatok[i].ursiklonev);
                        }
                    }
                    for (int i = 0; i < name.Count; i++)
                    {
                        if (órába.Checked)
                        {
                            sw.WriteLine($"Név:   {name[i]}   ---   Idő:   {adatok.Where(x => x.ursiklonev == name[i]).Sum(y => y.nap + y.óra / 24)} nap = {adatok.Where(x => x.ursiklonev == name[i]).Sum(y => y.nap * 24 + y.óra)} óra");
                        }
                        else
                        {
                            sw.WriteLine($"Név:   {name[i]}   ---   Idő:   {adatok.Where(x => x.ursiklonev == name[i]).Sum(y => y.nap + y.óra / 24)} nap");
                        }

                    }
                    sw.Close();
                    MessageBox.Show("A fájlbaírás megtörtént!","Írás");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Hibás fájlnév","Hiba");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Hibás fájlnév", "Hiba");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Hibás fájlnév", "Hiba");
            }
        }


    }
}
