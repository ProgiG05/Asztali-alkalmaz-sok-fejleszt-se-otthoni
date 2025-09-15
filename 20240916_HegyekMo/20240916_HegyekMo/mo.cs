using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240916_HegyekMo
{
    class mo
    {
        public string nev, hegyseg;
        public int magas;

        public mo(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            hegyseg = egysor[1];
            magas = Convert.ToInt32(egysor[2]);
        }
    }
}
