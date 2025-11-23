using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függőhíd_20250310
{
    class hidak
    {
        public string helyezes, hidnev, földrajzihely, orszag;
        public int hossz, atadasev;

        public hidak(string sor) 
        {
            string[] egysor = sor.Split('\t');
            helyezes = egysor[0];
            hidnev = egysor[1];
            földrajzihely = egysor[2];
            orszag = egysor[3];
            hossz = Convert.ToInt32(egysor[4]);
            atadasev = Convert.ToInt32(egysor[5]);
        }    
    }
}
