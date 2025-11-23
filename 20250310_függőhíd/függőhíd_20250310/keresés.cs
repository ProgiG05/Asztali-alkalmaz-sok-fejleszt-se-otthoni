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
    public partial class keresés_form : Form
    {
        static List<hidak> adatok2 = new List<hidak>(); 
        public keresés_form()
        {
            InitializeComponent();
            System.IO.File.ReadAllLines("fuggohidak.csv", Encoding.UTF8).Skip(1).ToList().ForEach(x => adatok2.Add(new hidak(x)));
            for (int i = 0; i < adatok2.Count; i++)
            {
                if (!hidak_lista2.Items.Contains(adatok2[i].hidnev))
                {
                    hidak_lista2.Items.Add(adatok2[i].hidnev);
                }
            }
        }

        private void bezaras_btn_Click(object sender, EventArgs e)
        {
            Főoldal vissza = new Főoldal();
            vissza.Show();
            this.Hide();
        }

        private void hidak_lista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < adatok2.Count; i++)
            {
                if (hidak_lista2.SelectedItem.ToString() == adatok2[i].hidnev)
                {
                    hely_show.Text = adatok2[i].földrajzihely;
                    orszag_show.Text = adatok2[i].orszag;
                    hossz_show.Text = adatok2[i].hossz.ToString();
                    ev_show.Text = adatok2[i].atadasev.ToString();
                }
            }
        }

        private void előtte_radio_CheckedChanged(object sender, EventArgs e)
        {
            darab_show.Text = adatok2.Where(x => x.atadasev < 2000).Count().ToString();
        }

        private void utána_radio_CheckedChanged(object sender, EventArgs e)
        {
            darab_show.Text = adatok2.Where(x => x.atadasev >= 2000).Count().ToString();
        }
    }
}
