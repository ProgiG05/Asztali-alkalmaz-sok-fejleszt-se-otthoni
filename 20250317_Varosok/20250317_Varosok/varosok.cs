using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250317_Varosok
{
    class varosok
    {
        public string varos, orszag;
        public int nepesseg;

        public varosok(string sor)
        {
            string[] egysor = sor.Split(';');
            varos = egysor[0];
            orszag = egysor[1];
            nepesseg = Convert.ToInt32(egysor[2]);
        }
    }
}
