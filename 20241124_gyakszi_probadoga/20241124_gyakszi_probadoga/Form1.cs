using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241124_gyakszi_probadoga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kombo.Items.Add("Minimumkiválasztás");
            kombo.Items.Add("Maximumkiválasztás");
        }

        static List<int> harom = new List<int>();
        private void kilep_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void masolas_btn_Click(object sender, EventArgs e)
        {
            változó_lbl.Text = nev_input.Text.ToString();
        }

        private void feltolto_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                harom.Add(rnd.Next(100, 1000));
            }
            for (int i = 0; i < harom.Count; i++)
            {
                haromjegy_list.Items.Add(harom[i].ToString());
            }

        }

        private void megjelenit_btn_Click(object sender, EventArgs e)
        {
            if (kombo.SelectedItem.ToString() == "")
            {
                MessageBox.Show("HIBA !");
            }
            if (kombo.SelectedItem.ToString() == "Minimumkiválasztás")
            {
                MessageBox.Show($"A lista legkisebb eleme: {harom.Min()}");
            }
            else if (kombo.SelectedItem.ToString() == "Maximumkiválasztás")
            {
                MessageBox.Show($"A lista legnagyobb eleme: {harom.Max()}");
            }
        }

        private void paros_radio_CheckedChanged(object sender, EventArgs e)
        {
            int prs = 0;
            int prtln = 0;
            foreach (var item in harom)
            {
                if (item % 2 == 0)
                {
                    prs++;
                }
                else
                {
                    prtln++;
                }
            }
            show.Text = prs.ToString();
            show_lbl.Text = "db páros szám van";
        }

        private void paratlan_radio_CheckedChanged(object sender, EventArgs e)
        {
            int prs = 0;
            int prtln = 0;
            foreach (var item in harom)
            {
                if (item % 2 == 0)
                {
                    prs++;
                }
                else
                {
                    prtln++;
                }
            }
            show.Text = prtln.ToString();
            show_lbl.Text = "db páratlan szám van";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> har = new List<int>();
            List<int> ot = new List<int>();
            for (int i = 0; i < harom.Count; i++)
            {
                if (harom[i] % 2 == 0)
                {
                    har.Add(harom[i]);
                }
                else if (harom[i] % 5 == 0)
                {
                    ot.Add(harom[i]);
                }
            }

            if (harommal_check.Checked && ottel_check.Checked)
            {
                for (int i = 0; i < har.Count; i++)
                {
                    oszthatok_lista.Items.Add(har[i].ToString());
                }
                for (int i = 0; i < ot.Count; i++)
                {
                    oszthatok_lista.Items.Add(ot[i].ToString());
                }
            }
            else if (harommal_check.Checked)
            {
                for (int i = 0; i < har.Count; i++)
                {
                    oszthatok_lista.Items.Add(har[i].ToString());
                }
            }
            else if (ottel_check.Checked)
            {
                for (int i = 0; i < ot.Count; i++)
                {
                    oszthatok_lista.Items.Add(ot[i].ToString());
                }
            }
            else if (harommal_check.Checked == false && ottel_check.Checked == false)
            {
                MessageBox.Show("Nem választottál semmit!");
            }
            
        }
    }
}
