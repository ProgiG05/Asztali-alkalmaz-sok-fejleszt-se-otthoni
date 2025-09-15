using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240916_berek
{
    class berek
    {
        public string nev, nem, reszleg;
        public int belepes, ber;

        public berek(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            nem = egysor[1];
            reszleg = egysor[2];
            belepes = Convert.ToInt32(egysor[3]);
            ber = Convert.ToInt32(egysor[4]);
        }

    }
}
