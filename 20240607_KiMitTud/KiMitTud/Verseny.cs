using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiMitTud
{
    class Verseny
    {
        public string nev;
        public int zs1, zs2, zs3, zs4, zs5, zs6;

        public Verseny(string sor)
        {
            string[] egysor = sor.Split(';');
            string[] kettosor = egysor[1].Split(' ');
            egysor[0] = nev;
            zs1 = Convert.ToInt32(kettosor[0]);
            zs2 = Convert.ToInt32(kettosor[1]);
            zs3 = Convert.ToInt32(kettosor[2]);
            zs4 = Convert.ToInt32(kettosor[3]);
            zs5 = Convert.ToInt32(kettosor[4]);
            zs6 = Convert.ToInt32(kettosor[5]);
        }
    }
}
