using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251015_DKÉ_reklam
{
    internal class Reklam
    {
        public int rendelesNap;
        public string varos;
        public int db;

        public Reklam(string oneline)
        {
            string[] oneAdv = oneline.Split(' ');
            rendelesNap = int.Parse(oneAdv[0]);
            varos = oneAdv[1];
            db = int.Parse(oneAdv[2]);
        }
    }
}
