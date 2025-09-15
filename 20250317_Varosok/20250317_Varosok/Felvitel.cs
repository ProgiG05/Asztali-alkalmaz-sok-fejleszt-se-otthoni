using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250317_Varosok
{
    public partial class Felvitel : Form
    {
        static List<varosok> adatok2 = new List<varosok>();
        public Felvitel()
        {
            InitializeComponent();
            System.IO.File.ReadAllLines("varosok.csv").ToList().ForEach(x => adatok2.Add(new varosok(x)));
            rekordok_combo.Items.Add("A városok összlakossága");
            rekordok_combo.Items.Add("Legkevesebb lakossággal rendelkező város");
        }
        private void vissza_Click(object sender, EventArgs e)
        {
            //Adatok_oldal visszaegyet = new Adatok_oldal();
            //visszaegyet.Show();
            //this.Hide();
        }
        private void hozzaad_Click(object sender, EventArgs e)
        {
            ujadatok_lista.Items.Add($"Város neve: {varos_be.Text}");
            ujadatok_lista.Items.Add($"Országa: {orszag_be.Text}");
            ujadatok_lista.Items.Add($"Lakossága. {lakossag_be.Text} millió fő");
            string hozzadsor = $"{varos_be.Text};{orszag_be.Text};{lakossag_be.Text}";
            adatok2.Add(new varosok(hozzadsor));
        }

        private void rekordok_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rekordok_combo.SelectedIndex == 1)
            {
                MessageBox.Show($"A felvitt városok összlakossága: {adatok2.Sum(x => x.nepesseg)} fő");
            }
            if (rekordok_combo.SelectedIndex == 2)
            {
                var legkisebbszam = adatok2.Min(x => x.nepesseg);
                var legkisebbvaros = "";
                for (int i = 0; i < adatok2.Count; i++)
                {
                    if (adatok2[i].nepesseg == legkisebbszam)
                    {
                        legkisebbvaros = adatok2[i].varos;
                    }
                }
                MessageBox.Show($"A legalacsonyabb lakosságú város neve: {legkisebbvaros}");
            }
        }

        private void kiir_Click(object sender, EventArgs e)
        {
            if (fájlbaírás_check.Checked)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter($"{fajlneve_be}");
                for (int i = 0; i < adatok2.Count; i++)
                {
                    sw.WriteLine("-------------------------------------------");
                    sw.WriteLine($"{adatok2[i].varos}\t{adatok2[i].orszag}\t{adatok2[i].nepesseg}");
                }
                sw.Close();
            }
        }

        private void fájlbaírás_check_CheckedChanged(object sender, EventArgs e)
        {
            if (fájlbaírás_check.Checked)
            {
                kiir.Enabled = true;
            }
            else
            {
                kiir.Enabled = false;
            }
        }
    }
}
