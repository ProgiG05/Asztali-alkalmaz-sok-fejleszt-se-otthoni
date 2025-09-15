using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250324_cserkesz
{
    public partial class adatokoldal : Form
    {
        public static int darabszám = adatok.Count();
        public static int össztagdíj = adatok.Sum(x => x.tagdíj);
        public adatokoldal()
        {
            InitializeComponent();
        }
        static List<cserkeszadatokklassz> adatok = new List<cserkeszadatokklassz>();
        private void beolvas_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\\Users";
            open.Filter = "Text|* .txt|All|*.*";
            open.FilterIndex = 0;
            open.RestoreDirectory = true;
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var file = open.FileName;
            System.IO.File.ReadAllLines(file).Skip(1).ToList().ForEach(x => adatok.Add(new cserkeszadatokklassz(x)));
            cserkeszek_lista.Items.Clear();
            for (int i = 0; i < adatok.Count; i++)
            {
                if (!cserkeszek_lista.Items.Contains(adatok[i].azonosító))
                {
                    cserkeszek_lista.Items.Add($"{adatok[i].azonosító} - {adatok[i].nev} - {adatok[i].szüldat.ToString()} - {adatok[i].tagdíj.ToString()}");
                }
            }
        }

        private void cserkeszek_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                if (cserkeszek_lista.SelectedItem == adatok[i])
                {
                    MessageBox.Show($"Cserkész azonosítója: {adatok[i].azonosító}\nCserkész neve: {adatok[i].nev}\nCserkész születési dátuma: {adatok[i].szüldat}\nCserkész fizetett tagdíja: {adatok[i].tagdíj} ","Cserkész adatai:");
                }
            }
        }
        private void felvetel_btn_Click(object sender, EventArgs e)
        {
            int számítás = 0;
            DateTime szülidö = Convert.ToDateTime(szülúj.Text);
            DateTime most = DateTime.Today;
            int kor = most.Year - szülidö.Year;
            if (kor < 14)
            {
                számítás = 0;
            }
            else if (kor < 18 && kor > 14)
            {
                számítás = 1000;
            }
            else if (kor >= 19)
            {
                számítás = 3000;
            }
            string hozzáadsor = $"{aziúj.Text}\t{nevúj.Text}\t{Convert.ToDateTime(szülúj.Text)}\t{számítás}";
            cserkeszek_lista.Items.Add(hozzáadsor);
            adatok.Add(new cserkeszadatokklassz(hozzáadsor));
            szamitott_tagdíj.Text = számítás.ToString();
            darabszám = adatok.Count();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 vissza = new Form1();
            vissza.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feladatok tovább = new Feladatok();
            tovább.Show();
            this.Hide();
        }
    }
}
