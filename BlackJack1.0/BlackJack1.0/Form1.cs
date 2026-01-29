using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack1._0
{
    public partial class LoginPage : Form
    {
        public static LoginPage instance;
        public LoginPage()
        {
            InitializeComponent();
            instance = this;
        }
        public double BetAmount1()
        {
            return Convert.ToDouble(Math.Floor(betAmount.Value));
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (BetAmount1() > 0 && checkAge.Checked)
            {
                Form2 form2 = new Form2();
                form2.betAmount = BetAmount1();
                form2.Show();
                this.Hide();
            }
            else 
            { 
                MessageBox.Show("You must be at least 18 years old and place a minimum 100 amount bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
