using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241014_radio
{
    public partial class Form1 : Form
    {
        //Timer a folyamatos színváltáshoz
        Timer timer = new Timer();
        //futó állapot nyomon követése
        bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;

            //időzítő beállítása
            timer.Interval = 100;
            timer.Tick += Timer_Tick; 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            this.BackColor = Color.FromArgb(r,g,b);

            string szinNeve = GetColorName(this.BackColor);

            if (szinNeve != null)
            {
                this.Text = $"Ablak színe: {szinNeve}";
            }
            else
            {
                this.Text = $"Ablak színe: RGB({r},{g},{b})";
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        

        private string GetColorName(Color color)
        {
            //ismert szinek - KnownColor
            foreach (KnownColor ismertszinek in Enum.GetValues(typeof(KnownColor)))
            {
                Color ismert = Color.FromKnownColor(ismertszinek);
                if (ismert.R == color.R && ismert.G == color.G && ismert.B == color.B)
                {
                    return ismert.Name;
                }
            }
            return null; //nincs egyezés
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                //leállítjuk az időzítőt
                timer.Stop();
                button2.Text = "Start";
                isRunning = false;
            }
            else
            {
                //indítsuk újra
                timer.Start();
                button2.Text = "Stop";
                isRunning = true;
            }
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_szín.BackColor = Color.FromArgb(hScrollBarRed.Value,hScrollBarGreen.Value,hScrollBarBlue.Value);
            this.Text = hScrollBarRed.Value + ";" + hScrollBarGreen.Value + ";" + hScrollBarBlue.Value + ";";
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_szín.BackColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            this.Text = hScrollBarRed.Value + ";" + hScrollBarGreen.Value + ";" + hScrollBarBlue.Value + ";";
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_szín.BackColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            this.Text = hScrollBarRed.Value + ";" + hScrollBarGreen.Value + ";" + hScrollBarBlue.Value + ";";
        }
    }
}
