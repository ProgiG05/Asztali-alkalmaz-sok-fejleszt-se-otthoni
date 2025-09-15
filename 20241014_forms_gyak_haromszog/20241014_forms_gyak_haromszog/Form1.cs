using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241014_forms_gyak_haromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépés_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void szögek_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToDouble(alfa_input.Text) + Convert.ToDouble(béta_input.Text) < 180)
            {
                gamma_input.Text = (180 - (Convert.ToDouble(alfa_input.Text) + Convert.ToDouble(béta_input.Text))).ToString();
            }
            else
            {
                gamma_input.Text = "0";
                MessageBox.Show("A háromszög belső szögeinek összege 180° ");
            }
            
        }

        private void kérdések_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(alfa_input.Text) == 90 || Convert.ToDouble(béta_input.Text) == 90 || Convert.ToDouble(gamma_input.Text) == 90)
            {
                válasz1.Text = "Igen";
            }
            else
            {
                válasz1.Text = "Nem";
            }

            if (Convert.ToDouble(alfa_input.Text) == Convert.ToDouble(béta_input.Text))
            {
                válasz2.Text = "Igen";
            }
            else if (Convert.ToDouble(alfa_input.Text) == Convert.ToDouble(gamma_input.Text))
            {
                válasz2.Text = "Igen";
            }
            else if (Convert.ToDouble(béta_input.Text) == Convert.ToDouble(gamma_input.Text))
            {
                válasz2.Text = "Igen";
            }
            else
            {
                válasz2.Text = "Nem";
            }

            if (Convert.ToDouble(alfa_input.Text) == 60 && Convert.ToDouble(béta_input.Text) == 60 && Convert.ToDouble(gamma_input.Text) == 60)
            {
                válasz3.Text = "Igen";
            }
            else
            {
                válasz3.Text = "Nem";
            }
        }
    }
}
