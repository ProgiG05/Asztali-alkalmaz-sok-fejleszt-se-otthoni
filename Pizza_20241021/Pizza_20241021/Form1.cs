using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_20241021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vega.Checked = true;
            magyar.Checked = true;
            negysajt.Checked = true;
            sonkagomba.Checked = true;
        }

        private void kilép_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void szamolas_Click(object sender, EventArgs e)
        {
            int vegamenny = Convert.ToInt32(vega_txt.Text);
            int magyarmenny = Convert.ToInt32(magyar_txt.Text);
            int negysajtmenny = Convert.ToInt32(negysajt_txt.Text);
            int sonkagombamenny = Convert.ToInt32(sonkagomba_txt.Text);
            össz_mennyiség.Text = (vegamenny + magyarmenny + negysajtmenny + sonkagombamenny).ToString();

            int vega_pr = vega_kicsi.Checked ? 2690 : vega_nagy.Checked ? 3650: 0;
            int magyar_pr = magyar_kicsi.Checked ? 2895 : magyar_nagy.Checked ? 4890 : 0;
            int negysajt_pr = negysajt_kicsi.Checked ? 2790 : negysajt_nagy.Checked ? 4790 : 0;
            int sonkagomba_pr = sonkagomba_kicsi.Checked ? 2450 : sonkagomba_nagy.Checked? 3990: 0;
            fizetendo_txt.Text = (vega_pr*vegamenny + magyar_pr*magyarmenny + negysajt_pr*negysajtmenny + sonkagomba_pr*sonkagombamenny).ToString();
        }

        private void töröl_Click(object sender, EventArgs e)
        {
            fizetendo_txt.Text = "0";
            vega_txt.Text = "0";
            magyar_txt.Text = "0";
            negysajt_txt.Text = "0";
            sonkagomba_txt.Text = "0";

            //foreach (Control cBox in fajták.Controls)
            //{
            //    if (cBox is CheckBox)
            //    {
            //        ((CheckBox)cBox).Checked = false;
            //    }
            //}

            vega_kicsi.Checked = false;
            vega_nagy.Checked = false;

            magyar_kicsi.Checked = false;
            magyar_nagy.Checked = false;

            negysajt_kicsi.Checked = false;
            negysajt_nagy.Checked = false;

            sonkagomba_kicsi.Checked = false;
            sonkagomba_nagy.Checked = false;
        }

        private void vega_CheckStateChanged(object sender, EventArgs e)
        {
            if (vega.Checked == false)
            {
                vega_kicsi.Enabled = false;
                vega_kicsi.Checked = false;
                vega_nagy.Enabled = false;
                vega_nagy.Checked = false;
                vega_txt.Text = "0";
                vega_txt.Enabled = false;
            }
            else
            {
                vega_kicsi.Enabled = true;
                vega_kicsi.Checked = true;
                vega_nagy.Enabled = true;
                vega_nagy.Checked = true;
                vega_txt.Text = "0";
                vega_txt.Enabled = true;
            }
        }

        private void magyar_CheckStateChanged(object sender, EventArgs e)
        {
            if (magyar.Checked == false)
            {
                magyar_kicsi.Enabled = false;
                magyar_kicsi.Checked = false;
                magyar_nagy.Enabled = false;
                magyar_nagy.Checked = false;
                magyar_txt.Text = "0";
                magyar_txt.Enabled = false;
            }
            else
            {
                magyar_kicsi.Enabled = true;
                magyar_kicsi.Checked = true;
                magyar_nagy.Enabled = true;
                magyar_nagy.Checked = true;
                magyar_txt.Text = "0";
                magyar_txt.Enabled = true;
            }
        }

        private void negysajt_CheckStateChanged(object sender, EventArgs e)
        {
            if (negysajt.Checked == false)
            {
                negysajt_kicsi.Enabled = false;
                negysajt_kicsi.Checked = false;
                negysajt_nagy.Enabled = false;
                negysajt_nagy.Checked = false;
                negysajt_txt.Text = "0";
                negysajt_txt.Enabled = false;
            }
            else
            {
                negysajt_kicsi.Enabled = true;
                negysajt_kicsi.Checked = true;
                negysajt_nagy.Enabled = true;
                negysajt_nagy.Checked = true;
                negysajt_txt.Text = "0";
                negysajt_txt.Enabled = true;
            }
        }

        private void sonkagomba_CheckStateChanged(object sender, EventArgs e)
        {
            if (sonkagomba.Checked == false)
            {
                sonkagomba_kicsi.Enabled = false;
                sonkagomba_kicsi.Checked = false;
                sonkagomba_nagy.Enabled = false;
                sonkagomba_nagy.Checked = false;
                sonkagomba_txt.Text = "0";
                sonkagomba_txt.Enabled = false;
            }
            else
            {
                sonkagomba_kicsi.Enabled = true;
                sonkagomba_kicsi.Checked = true;
                sonkagomba_nagy.Enabled = true;
                sonkagomba_nagy.Checked = true;
                sonkagomba_txt.Text = "0";
                sonkagomba_txt.Enabled = true;
            }
        }
    }
}
