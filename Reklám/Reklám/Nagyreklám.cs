using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklám
{
    class Nagyreklám
    {
        //adattagok
        public int rendeles_napja; //1 - 30
        public string varos; //TV PL NR
        public int rendelt_db; //1-10

        //konstruktor - fájlból jövő adatok
        public Nagyreklám(string sor)
        {
            string[] egysor = sor.Split(' '); //egysor: 1|TV|2
            rendeles_napja = Convert.ToInt32(egysor[0]);
            varos = egysor[1];
            rendelt_db = Convert.ToInt32(egysor[2]);
        }
    }
}
