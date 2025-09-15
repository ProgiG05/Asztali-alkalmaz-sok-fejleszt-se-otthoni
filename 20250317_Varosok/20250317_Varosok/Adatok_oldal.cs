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
    public partial class Adatok_oldal : Form
    {
        public Adatok_oldal()
        {
            InitializeComponent();
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            //Főablak vissza = new Főablak();
            //vissza.Show();
            //this.Hide();
        }
        static List<varosok> adatok = new List<varosok>();
        private void megnyit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\\Users";
            open.Filter = "csv files (*.csv) || *.csv";
            open.FilterIndex = 0;
            open.RestoreDirectory = true;
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string file = open.FileName;
            adatok.Clear();
            varosok_lista.Items.Clear();
            System.IO.File.ReadAllLines(file).ToList().ForEach(x => adatok.Add(new varosok(x)));
            for (int i = 0; i < adatok.Count; i++)
            {
                if (!varosok_lista.Items.Contains(adatok[i].varos))
                {
                    varosok_lista.Items.Add(adatok[i].varos);
                }              
            }
        }

        private void varosok_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].varos == varosok_lista.SelectedItem.ToString())
                {
                    varos_neve_show.Text = adatok[i].varos;
                    orszag_neve_show.Text = adatok[i].orszag;
                    lakossag_show.Text = adatok[i].nepesseg.ToString();
                }
            }
        }

        private void felvetel_Click(object sender, EventArgs e)
        {
            //Felvitel felvitel = new Felvitel();
            //felvitel.Show();
            //this.Hide();
        }
    }
}
