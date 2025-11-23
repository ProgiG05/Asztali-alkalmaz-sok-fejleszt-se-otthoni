using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251018_DKÉ_autok
{
    internal class Auto
    {
        public string rendszam;
        public int jelÓra, jelPerc, sebesség;

        public string KezdVegRendszam;
        public int kezdesOra, kezdesPerc, vegeOra, vegePerc;

        public Auto(string egysor)
        {
            string[] sor = egysor.Split('\t');
            rendszam = sor[0];
            jelÓra = int.Parse(sor[1]);
            jelPerc = int.Parse(sor[2]);
            sebesség = int.Parse(sor[3]);
        }
        public Auto(string rendszam, int kezdOra, int kezdPerc, int vegOra, int vegPerc) 
        {
            this.rendszam = rendszam;
            KezdVegRendszam = rendszam;
            kezdesOra = kezdOra;
            kezdesPerc = kezdPerc;
            vegeOra = vegOra;
            vegePerc = vegPerc;
        }
        public Auto() { }
    }
}
