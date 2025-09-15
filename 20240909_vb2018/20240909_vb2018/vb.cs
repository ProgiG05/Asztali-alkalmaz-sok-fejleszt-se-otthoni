using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240909_vb2018
{
    class vb
    {
        public string varos, nev1, nev2;
        public int ferohely;

        public vb(string sor)
        {
            string[] egysor = sor.Split(';');
            varos = egysor[0];
            nev1 = egysor[2];
            nev2 = egysor[2];
            ferohely = Convert.ToInt32(egysor[3]);
        }
    }
}
