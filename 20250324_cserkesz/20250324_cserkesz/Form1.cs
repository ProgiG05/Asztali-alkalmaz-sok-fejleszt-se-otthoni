using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250324_cserkesz
{
    public partial class Form1 : Form
    {
        static string felhasznalonev = "FőCserkész";
        static string jelszo = "cserkesz123!";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepes_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static int hibaszámláló = 0;
        private void belepes_btn_Click(object sender, EventArgs e)
        {
            if (felh_input.Text == "" && jelszo_input.Text == "")
            {
                MessageBox.Show("Nem hagyhatod üresen a mezőket!","Hiba");
            }
            if (felh_input.Text != felhasznalonev && jelszo_input.Text != jelszo && hibaszámláló != 3)
            {
                MessageBox.Show($"Hibás felhasználónév vagy jelszó!\nHibáid száma: {hibaszámláló + 1}", "Hiba");
                hibaszámláló = hibaszámláló + 1;
                hibák_száma.Text = hibaszámláló.ToString();
                felh_input.Text = "";
                jelszo_input.Text = "";             
            }
            if (felh_input.Text != felhasznalonev && jelszo_input.Text != jelszo && hibaszámláló == 3)
            {
                Random rnd = new Random();
                int randomszám = rnd.Next(1, 5);
                string kitalálás = Microsoft.VisualBasic.Interaction.InputBox("Gondoltam egy számra 1-től 5-ig\nTaláld ki melyik ez a szám!", "Bünti");
                while (randomszám != Convert.ToInt32(kitalálás))
                {
                    kitalálás = Microsoft.VisualBasic.Interaction.InputBox("Gondoltam egy számra 1-től 5-ig\nTaláld ki melyik ez a szám!", "Bünti");
                }
                if (randomszám == Convert.ToInt32(kitalálás))
                {
                    hibaszámláló = 0;
                    hibák_száma.Text = "0";
                }
            }
            else if (felh_input.Text == felhasznalonev && jelszo_input.Text == jelszo)
            {
                adatokoldal megnyit = new adatokoldal();
                megnyit.Show();
                this.Hide();
            }
        }

        private void hint_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felhasználónév: FőCserkész\nJelszó: cserkesz123!","Segítség");
        }

    }
}
