using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241007_gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bezár_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plusz_Click(object sender, EventArgs e)
        {
            eredmény.Text = (Convert.ToInt32(elsoszam.Text) + Convert.ToInt32(masodikszam.Text)).ToString();
             
        }

        private void minusz_Click(object sender, EventArgs e)
        {
            eredmény.Text = (Convert.ToInt32(elsoszam.Text) - Convert.ToInt32(masodikszam.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eredmény.Text = (Convert.ToInt32(elsoszam.Text) / Convert.ToInt32(masodikszam.Text)).ToString();
            if (eredmény.Text == "0")
            {
                eredmény.Text = " ";
            }
        }

        private void egyenlő_Click(object sender, EventArgs e)
        {

        }

        private void szorzas_Click(object sender, EventArgs e)
        {
            eredmény.Text = (Convert.ToInt32(elsoszam.Text) * Convert.ToInt32(masodikszam.Text)).ToString();
        }
    }
}
