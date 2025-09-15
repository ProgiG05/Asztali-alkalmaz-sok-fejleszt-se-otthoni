using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzo
{
    class Kolcsonzes
    {
        public string nev, jarmuAz;
        public int elvÓra, elvPerc, visszaÓra, visszaPerc;

        public Kolcsonzes(string nev, string jarmuAz, int elvÓra, int elvPerc, int visszaÓra, int visszaPerc)
        {
            this.nev = nev;
            this.jarmuAz = jarmuAz;
            this.elvÓra = elvÓra;
            this.elvPerc = elvPerc;
            this.visszaÓra = visszaÓra;
            this.visszaPerc = visszaPerc;
        }
        public Kolcsonzes(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            jarmuAz = egysor[1];
            elvÓra = Convert.ToInt32(egysor[2]);
            elvPerc = Convert.ToInt32(egysor[3]);
            visszaÓra = Convert.ToInt32(egysor[4]);
            visszaÓra = Convert.ToInt32(egysor[5]);
        }

        
    }
}
