using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShuttle
{
    class SpaceClass
    {
        public string kód,ursiklonev,tamasznev;
        public DateTime kilövés;
        public int nap, óra, legénység;

        public SpaceClass(string sor)
        {
            string[] egysor = sor.Split(';');
            kód = egysor[0];
            kilövés = Convert.ToDateTime(egysor[1]);
            ursiklonev = egysor[2];
            nap = Convert.ToInt32(egysor[3]);
            óra = Convert.ToInt32(egysor[4]);
            tamasznev = egysor[5];
            legénység = Convert.ToInt32(egysor[6]);
        }

    }
}
