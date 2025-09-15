using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241014_radiogomb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(sugar.Text);
            double ker = Math.Round(2 * r * Math.PI,2);
            double ter = Math.Round(Math.Pow(r, 2) * Math.PI,2);

            if (terület.Checked)
            {
                lbl_eredmény.Text = "Terület eredmény";
                eredmény.Text = ter.ToString();
            }
            else
            {
                lbl_eredmény.Text = "Terület eredmény";
                eredmény.Text = ker.ToString();
            }
            MessageBox.Show("Ügyes voltál!","Üzenet",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void kerület_CheckedChanged(object sender, EventArgs e)
        {
            if (kerület.Checked)
            {
                double ker = 2 * Convert.ToDouble(sugar.Text) * Math.PI;
                MessageBox.Show(ker.ToString());
            }
            else
            {
                double ter = Math.Pow(Convert.ToDouble(sugar.Text), 2) * Math.PI;
                MessageBox.Show(ter.ToString());
            }
        }
    }
}
