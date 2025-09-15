using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250127_karacsonyCLI
{
    public partial class Angyalka : Form
    {
        static List<NapiMunka> adatok = new List<NapiMunka>();
        public Angyalka()
        {
            InitializeComponent();
            System.IO.File.ReadAllLines("diszek.txt").ToList().ForEach(x => adatok.Add(new NapiMunka(x)));
        }
        private void bezár_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Biztos, hogy ki akarsz lépni?", "Bezárás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void hozzáad_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
