using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazimunkak
{
    class HazimunkaKezelo : Hazimunka, IMunka 
    {
        public string[] sorr;
        public HazimunkaKezelo(string egysor)
        {
            string[] sor = egysor.Split(';');
            sor = sorr;
        }
        public override string MunkaElvegzese()
        {
            throw new NotImplementedException();
        }

        public double IdotartamOsszesites(List<Hazimunka> lista)
        {
            double eredmeny = lista.Sum(x => x.VegreHajtasIdeje);
            return Math.Round(eredmeny,2);
        }
        public List<Hazimunka> LeggyorsabbFeladat(List<Hazimunka> lista)
        {
            int legrövidebbIdo = lista.Min(x => x.VegreHajtasIdeje);

            List<Hazimunka> legrövidebb = lista.Where(x => x.VegreHajtasIdeje == legrövidebbIdo).ToList();

            return legrövidebb;

        }
    }
}
