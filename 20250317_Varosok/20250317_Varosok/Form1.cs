using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _20250317_Varosok
{
    public partial class Főablak : Form
    {
        public Főablak()
        {
            InitializeComponent();
        }
        private void belepes_Click(object sender, EventArgs e)
        {
            //string titkosjelszo = "titok123!";
            //string jelszokeres = Interaction.InputBox("Mi a titkos jelszó? ");
            //if (jelszokeres == titkosjelszo)
            //{
                
            //}
            Adatok_oldal megnyit = new Adatok_oldal();
            megnyit.Show();
            this.Hide();
        }
        private void kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
