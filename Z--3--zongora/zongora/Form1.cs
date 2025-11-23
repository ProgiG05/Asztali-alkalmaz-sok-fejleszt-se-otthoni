using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace zongora
{
    public partial class Form1 : Form
    {
        private SoundPlayer C4;
        private SoundPlayer C4sharp;
        private SoundPlayer D4;
        private SoundPlayer D4sharp;
        private SoundPlayer E4;
        private SoundPlayer F4;
        private SoundPlayer F4sharp;
        private SoundPlayer G4;
        private SoundPlayer G4sharp;
        private SoundPlayer A4;
        private SoundPlayer A4Sharp;
        private SoundPlayer B4;
        private SoundPlayer C5;
        public Form1()
        {
            InitializeComponent();
            C4 = new SoundPlayer("wav_c1.wav");
            C4sharp = new SoundPlayer("wav_c1s.wav");
            D4 = new SoundPlayer("wav_d1.wav");
            D4sharp = new SoundPlayer("wav_d1s.wav");
            E4 = new SoundPlayer("wav_e1.wav");
            F4 = new SoundPlayer("wav_f1.wav");
            F4sharp = new SoundPlayer("wav_f1s.wav");
            G4 = new SoundPlayer("wav_g1.wav");
            G4sharp = new SoundPlayer("wav_g1s.wav");
            A4 = new SoundPlayer("wav_a1.wav");
            A4Sharp = new SoundPlayer("wav_a1s.wav");
            B4 = new SoundPlayer("wav_b1.wav");
            C5 = new SoundPlayer("wav_c2.wav");
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            C4.Play();
        }

        private void C_sharp_D_flat_Click(object sender, EventArgs e)
        {
            C4sharp.Play();
        }

        private void D_Click(object sender, EventArgs e)
        {
            D4.Play();
        }

        private void D_sharp_E_flat_Click(object sender, EventArgs e)
        {
            D4sharp.Play();
        }

        private void E_Click(object sender, EventArgs e)
        {
            E4.Play();
        }

        private void F_Click(object sender, EventArgs e)
        {
            F4.Play();
        }

        private void F_sharp_G_flat_Click(object sender, EventArgs e)
        {
            F4sharp.Play();
        }

        private void G_Click(object sender, EventArgs e)
        {
            G4.Play();
        }

        private void G_sharp_A_flat_Click(object sender, EventArgs e)
        {
            G4sharp.Play();
        }

        private void A_Click(object sender, EventArgs e)
        {
            A4.Play();
        }

        private void A_sharp_B_flat_Click(object sender, EventArgs e)
        {
            A4Sharp.Play();
        }

        private void B_Click(object sender, EventArgs e)
        {
            B4.Play();
        }

        private void Ck_Click(object sender, EventArgs e)
        {
            C5.Play();
        }
    }
}
