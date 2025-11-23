using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasás_20241202
{
    class Class1
    {
        public string nev;
        public int terulet;
        public Class1(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            terulet = Convert.ToInt32(egysor[1]);
        }
    }
}
