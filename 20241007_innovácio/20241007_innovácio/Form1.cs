using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241007_innovácio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_osztaly.Text = "12G";
            txt_box.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_vmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            lbl_osztaly.ForeColor = Color.Red;
        }

        private void txt_box_TextChanged(object sender, EventArgs e)
        {
            lbl_geri.Text = txt_box.Text;
        }

        private void minden_látszik_Click(object sender, EventArgs e)
        {
            minden_látszik.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //plusz
            eredmény.Text += Convert.ToInt32(elso_input.Text) + Convert.ToInt32(masodik_input.Text);
        }
    }
}
