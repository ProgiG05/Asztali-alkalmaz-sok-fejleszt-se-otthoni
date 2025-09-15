using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241118_gyakszi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista_elemei.Items.Add(be.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista_elemei.Items.Remove(lista_elemei.SelectedItem); //kiválasztott elem törlése

            lista_elemei.Items.RemoveAt(0); //első elem törlése 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int össz = lista_elemei.Items.Count;
            elemek_szama.Text = össz.ToString();
        }

        private void kilép_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Számol_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(a_oldal_be.Text);
            double b = Convert.ToDouble(b_oldal_be.Text);
            double ker = 2 * a + 2 * b;
            double ter = a * b;
            ker_ter_lista.Items.Add($"a = {a},b = {b}, Ker = {ker}, Ter = {ter}");
        }


        private void hozzáad_Click(object sender, EventArgs e)
        {
            string gyümi = Convert.ToString(adatbe.Text);
            int gyümihossz = gyümi.Count();

            gyümi_lista.Items.Add(gyümi);
            karakterszám_lista.Items.Add(gyümihossz);
        }

        private void remdez_Click(object sender, EventArgs e)
        {
            gyümi_lista.Sorted = true;

            for (int i = 0; i < gyümi_lista.Items.Count; i++)
            {
                karakterszám_lista.Items[i] = gyümi_lista.Items[i].ToString().Length;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                szamok.Items.Add(rnd.Next(1, 50));
            }

            for (int i = 0; i < szamok.Items.Count; i++)
            {
                int szam = Convert.ToInt32(szamok.Items[i]);
                if (szam % 2 == 0)
                {
                    paros.Items.Add(szam);
                }
                else
                {
                    paratlan.Items.Add(szam);
                }
            }

        }

        private void eredmeny_Click(object sender, EventArgs e)
        {
            List<int> paross = new List<int>();
            List<int> parattlan = new List<int>();
            for (int i = 0; i < paros.Items.Count; i++)
            {
                paross.Add(Convert.ToInt32(paros.Items[i]));
            }
            for (int i = 0; i < paratlan.Items.Count; i++)
            {
                parattlan.Add(Convert.ToInt32(paratlan.Items[i]));
            }

            int prs_össz = paross.Sum();
            int prtln_össz = parattlan.Sum();

            MessageBox.Show($"A páros számok összege: {prs_össz}\nA páratlan számok összege: {prtln_össz}", "Eredmény");
        }
    }
}
