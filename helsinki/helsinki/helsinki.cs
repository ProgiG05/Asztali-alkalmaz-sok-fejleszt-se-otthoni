using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki
{
    class helsinki
    {
        public int helyezes, sportoloszam ,pontozas;
        public string ágnev, versenynev;

        public helsinki(string sor)
        {
            string[] egysor = sor.Split(' ');
            helyezes = Convert.ToInt32(egysor[0]);
            sportoloszam = Convert.ToInt32(egysor[1]);
            ágnev = egysor[2];
            versenynev = egysor[3];

            if (helyezes == 1)
            {
                pontozas = 7;
            }
            else
            {
                pontozas = 7 - helyezes;
            }

            if (ágnev == "kajakkenu")
            {
                ágnev = "kajak-kenu";
            }
        }
    }
}
