using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Beolvasás_20241202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            minmax.Items.Add("Minimum");
            minmax.Items.Add("Maximum");
        }

        private void kilep_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static List<Class1> adat = new List<Class1>();
        private void betölt_btn_Click(object sender, EventArgs e)
        {
            if (forrasfajl_neve.Text == "")
            {
                MessageBox.Show("Még nem töltött be fájlt!", "hibaüzi");
            }
            else
            {
                System.IO.File.ReadAllLines($"{forrasfajl_neve.Text}.txt", Encoding.UTF8).ToList().ForEach(x => adat.Add(new Class1(x)));
            }

            for (int i = 0; i < adat.Count; i++)
            {
                lista.Items.Add($"{adat[i].nev} {adat[i].terulet}");
            }
        }

        private void ter_átl_btn_Click(object sender, EventArgs e)
        {
            double avg = adat.Average(x => x.terulet);
            MessageBox.Show($"A területek átlaga: {Math.Round(avg,2)}","Eredmény");
        }

        
        private void megszamol_btn_Click(object sender, EventArgs e)
        {
            if (nagyobb_radio.Checked)
            {
                MessageBox.Show($"{adat.Where(x => x.terulet > 100000).Count()} db");
            }
            if (legfeljebb_radio.Checked)
            {
                MessageBox.Show($"{adat.Where(x => x.terulet < 100000).Count()} db");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter($"{eredmeny_fajlnev.Text}.txt");
            if (nagyobb_radio.Checked)
            {
                MessageBox.Show("A 100 000 km2-nél nagyobb területű országok kiírása fájlba ");
                adat.Where(x => x.terulet > 100000).ToList().ForEach(x => sw.WriteLine($"{x.nev} {x.terulet}"));
            }
            if (legfeljebb_radio.Checked)
            {
                MessageBox.Show("A 100 000 km2-nél kisebb területű országok kiírása fájlba ");
                adat.Where(x => x.terulet < 100000).ToList().ForEach(x => sw.WriteLine($"{x.nev} {x.terulet}"));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < minmax.Items.Count; i++)
            {
                if (minmax.Items[i].ToString() == "Minimum")
                {
                    adat.Where(x => x.terulet == adat.Min(y => y.terulet)).ToList().ForEach(x => MessageBox.Show($"A legkisebb területű ország: {x.nev} területe: {x.terulet} "));
                }
                else if (minmax.Items[i].ToString() == "Maximum")
                {
                    adat.Where(x => x.terulet == adat.Max(y => y.terulet)).ToList().ForEach(x => MessageBox.Show($"A legkisebb területű ország: {x.nev} területe: {x.terulet} "));
                }
            }
        }

        private void keres_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
