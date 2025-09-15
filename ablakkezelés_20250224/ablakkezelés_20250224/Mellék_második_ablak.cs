using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ablakkezelés_20250224
{
    public partial class Mellék_második_ablak : Form
    {
        public Mellék_második_ablak()
        {
            InitializeComponent();
            //if (megfelel1 && megfelel2)
            //{
            //    btn_belépés.Enabled = true;
            //}
        }
        frm_Főablak foablak = new frm_Főablak();
        private void bezárás2_Click(object sender, EventArgs e)
        {
            this.Hide();
            foablak.Show();
        }
        Form adatokAblak = new Form();

        TextBox txtb = new TextBox();
        ListBox lb_adatok = new ListBox();
        Label lb_darab = new Label();

        private void belépés2_Click(object sender, EventArgs e)
        {
            //Ablak
            adatokAblak.Size = new Size(200, 400);
            adatokAblak.Text = "Adatok bevitele";

            //FőCímke - név
            Label lb_nev = new Label();
            lb_nev.Text = "Név: ";
            lb_nev.Width = 50;
            lb_nev.Height = 30;
            lb_nev.Location = new Point(10, 10);
            adatokAblak.Controls.Add(lb_nev);

            //textbox
            txtb.Width = 100;
            txtb.Height = 30;
            txtb.BackColor = Color.Azure;
            txtb.Location = new Point(10, 40);
            adatokAblak.Controls.Add(txtb);

            //listbox lb_adatok
            lb_adatok.Width = 100;
            lb_adatok.Height = 100;
            lb_adatok.Location = new Point(10, 110);
            adatokAblak.Controls.Add(lb_adatok);

            //gomb - Hozzáad
            Button hozzáad = new Button();
            hozzáad.Width = 100;
            hozzáad.Height = 30;
            hozzáad.ForeColor = Color.Black;
            hozzáad.BackColor = Color.White;
            hozzáad.Location = new Point(10, 70);
            hozzáad.Text = "Hozzáad";
            hozzáad.Click += Hozzáadás_klikk;
            adatokAblak.Controls.Add(hozzáad);

            //gomb - Törlés
            Button törlés = new Button();
            törlés.Width = 100;
            törlés.Height = 30;
            törlés.BackColor = Color.White;
            törlés.ForeColor = Color.Black;
            törlés.Location = new Point(10, 240);
            törlés.Text = "Törlés";
            törlés.Click += Törlés_Click;
            adatokAblak.Controls.Add(törlés);

            //címke - lista elemszáma
            lb_darab.Text = "Darabszám: ";
            lb_darab.Width = 75;
            lb_darab.Height = 40;
            lb_darab.Location = new Point(10, 210);
            adatokAblak.Controls.Add(lb_darab);

            //Gomb - Bezárás
            Button btn = new Button();
            btn.Width = 100;
            btn.Height = 30;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.Black;
            btn.Location = new Point(10, 280);
            btn.Text = "Bezárás";
            btn.Click += Btn_Click;
            adatokAblak.Controls.Add(btn);

            adatokAblak.Show();

        }
        private void ell_Click(object sender, EventArgs e)
        {

            if (!username_input.Text.Contains(" ") && username_input.Text.Length > 5 && email_input.Text.Contains("@") && email_input.Text.Contains("."))
            {
                btn_belépés.Enabled = true;
            }

        }
        private void Törlés_Click(object sender, EventArgs e)
        {
            if (lb_adatok.Items.Count == 0)
            {
                MessageBox.Show("A lista üres!","Hahó");
            }
            else
            {
                lb_adatok.Items.Remove(lb_adatok.SelectedItem);
                lb_darab.Text = $"Darabszám: {lb_adatok.Items.Count}";
                //lb_adatok.Items.Remove(lb_adatok.Items[0]);
            }
        }

        private void Hozzáadás_klikk(object sender, EventArgs e)
        {
            if (txtb.Text == "" && txtb.Text == " ")
            {
                MessageBox.Show("Semmit nem adhatsz hozzá!", "Hahó");
            }
            else
            {
                lb_adatok.Items.Add(txtb.Text);
                lb_darab.Text = $"Darabszám: {lb_adatok.Items.Count}";
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            adatokAblak.Close();
            this.Close();
            foablak.Show();
        }

        //public bool megfelel1 = false;
        //public bool megfelel2 = false;
        private void username_input_TextChanged(object sender, EventArgs e)
        {
            //if (!username_input.Text.Contains(" ") && username_input.Text.Length > 5)
            //{
            //    megfelel1 = true;
            //}
        }

        private void email_input_TextChanged(object sender, EventArgs e)
        {
            //if (email_input.Text.Contains("@") && email_input.Text.Contains("."))
            //{
            //    megfelel2 = true;
            //}
        }
    }
}
