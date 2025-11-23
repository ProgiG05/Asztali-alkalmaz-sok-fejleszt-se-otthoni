using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251019_DKÉ_konyvek
{
    internal class Konyv
    {
        //public int kiadasEv, negyedev, peldanySzam;
        //public string eredet, leiras, szerzo, cim;

        //public Konyv(string oneline)
        //{
        //    string[] line = oneline.Split(';');
        //    kiadasEv = int.Parse(line[0]);
        //    negyedev = int.Parse(line[1]);
        //    eredet = line[2];
        //    leiras = line[3];
        //    leiras.Split(':')[0] = szerzo;
        //    leiras.Split(':')[1] = cim;
        //    peldanySzam = int.Parse(line[4]);
        //}
        public int kiadasEv, negyedev, peldanySzam;
        public string eredet, szerzo,leiras, cim;

        public Konyv(string oneline)
        {
            string[] line = oneline.Split(';');
            kiadasEv = int.Parse(line[0]);
            negyedev = int.Parse(line[1]);
            eredet = line[2];
            leiras = line[3];
            peldanySzam = int.Parse(line[4]);
        }
    }
}
