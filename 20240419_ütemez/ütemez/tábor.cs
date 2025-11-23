using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ütemez
{
    class tábor
    {
        //adattagok - fájl tartalma
        public int kezdHo, kezdNap, vegHo, vegNap, diakokSzama;
        public string diakok, taborfajta;
        //konstruktor
        public tábor(string sor)
        {
            string[] egysor = sor.Split('\t');
            kezdHo = Convert.ToInt32(egysor[0]);
            kezdNap = Convert.ToInt32(egysor[1]);
            vegHo = Convert.ToInt32(egysor[2]);
            vegNap = Convert.ToInt32(egysor[3]);
            diakok = egysor[4];
            diakokSzama = diakok.Length;
            taborfajta = egysor[5];
        }
        public tábor()
        { }
        
    }
}
