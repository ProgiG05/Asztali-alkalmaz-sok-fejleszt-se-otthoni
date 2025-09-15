using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240916_snooker
{
    class snooker
    {
        public int helyezes, nyeremeny;
        public string nev, orszag;

        public snooker(string sor)
        {
            string[] egysor = sor.Split(';');
            helyezes = Convert.ToInt32(egysor[0]);
            nev = egysor[1];
            orszag = egysor[2];
            nyeremeny = Convert.ToInt32(egysor[3]);
        }
    }
}
