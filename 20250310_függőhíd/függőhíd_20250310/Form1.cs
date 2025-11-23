using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace függőhíd_20250310
{
    public partial class Főoldal : Form
    {
        static List<hidak> adatok = new List<hidak>();

        public Főoldal() 
        {
            InitializeComponent();
        }
        private void megnyitas_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //open.InitialDirectory = "C:\\Users";
            open.InitialDirectory = @"C:\Users\szabo.gergo.1005\source\repos\függőhíd_20250310\függőhíd_20250310\bin\Debug";
            open.Filter = "csv files (*.csv) | *.csv";
            open.FilterIndex = 0;
            open.RestoreDirectory = true;
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string selectedFileName = open.FileName;
            adatok.Clear();
            System.IO.File.ReadAllLines("fuggohidak.csv", Encoding.UTF8).Skip(1).ToList().ForEach(x => adatok.Add(new hidak(x)));
            for (int i = 0; i < adatok.Count; i++)
            {
                if (!orszag_lista.Items.Contains(adatok[i].orszag))
                {
                    orszag_lista.Items.Add(adatok[i].orszag);
                }
            }
        }
        private void orszag_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            hidak_lista.Items.Clear();
            for (int i = 0; i < adatok.Count; i++)
            {
                if (orszag_lista.SelectedItem.ToString() == adatok[i].orszag)
                {
                    if (egykiló_check.Checked)
                    {
                        if (adatok[i].hossz < 1000)
                        {
                            hidak_lista.Items.Add(adatok[i].hidnev);
                        }
                    }
                    else
                    {
                        hidak_lista.Items.Add(adatok[i].hidnev);
                    }
                }
            }
        }

        private void bezaras_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kereses_btn_Click(object sender, EventArgs e)
        {
            keresés_form belepes = new keresés_form();
            belepes.Show();
            this.Hide();
        }
    }
}
                 
           
        

