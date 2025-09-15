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
    public partial class frm_Főablak : Form
    {
        public frm_Főablak()
        {
            InitializeComponent();
        }

        private void btn_kilépés_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_belépés_Click(object sender, EventArgs e)
        {
            Mellék_második_ablak belepes = new Mellék_második_ablak();
            belepes.Show();
            this.Hide();
        }
    }
}
