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
    public partial class Feladatok : Form
    {
        static List<cserkeszadatokklassz> adatok2 = new List<cserkeszadatokklassz>();
        public Feladatok()
        {
            InitializeComponent();
            System.IO.File.ReadAllLines("cserkesz.txt").Skip(1).ToList().ForEach(x => adatok2.Add(new cserkeszadatokklassz(x)));
            tagok_száma.Text = adatokoldal.darabszám.ToString();
            össz_tagdíj.Text = adatokoldal.össztagdíj.ToString();
        }
        
        private void vissza_Click(object sender, EventArgs e)
        {
            adatokoldal vissza = new adatokoldal();
            vissza.Show();
            this.Hide();
        }

        private void főoldali_btn_Click(object sender, EventArgs e)
        {
            Form1 főoldal = new Form1();
            főoldal.Show();
            this.Hide();
        }

    }
}
