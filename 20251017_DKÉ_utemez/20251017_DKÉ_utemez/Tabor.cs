using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251017_DKÉ_utemez
{
    internal class Tabor
    {
        public int kezdhonap, kezdnap, veghonap,vegnap;
        public string diakok,tema;

        public Tabor(string oneline)
        {
            string[] line = oneline.Split('\t');
            kezdhonap = int.Parse(line[0]);
            kezdnap = int.Parse(line[1]);
            veghonap = int.Parse(line[2]);
            vegnap = int.Parse(line[3]);
            diakok = line[4];
            tema = line[5];
        }
        public Tabor() { }
    }
}
