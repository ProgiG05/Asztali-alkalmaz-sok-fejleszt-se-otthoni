using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250324_cserkesz
{
    class cserkeszadatokklassz
    {
        public string azonosító, nev;
        public int tagdíj;
        public DateTime szüldat;

        public cserkeszadatokklassz(string sor)
        {
            string[] egysor = sor.Split('\t');
            azonosító = egysor[0];
            nev = egysor[1];
            szüldat = Convert.ToDateTime(egysor[2]);
            tagdíj = Convert.ToInt32(egysor[3]);
        }
    }
}
