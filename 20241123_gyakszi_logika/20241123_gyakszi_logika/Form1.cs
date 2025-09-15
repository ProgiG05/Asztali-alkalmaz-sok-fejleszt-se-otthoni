using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241123_gyakszi_logika
{
    public partial class Logika : Form
    {
        public Logika()
        {
            InitializeComponent();

            muveletek_dropdown.Items.Add("NOT");
            muveletek_dropdown.Items.Add("AND");
        }


    }
}
