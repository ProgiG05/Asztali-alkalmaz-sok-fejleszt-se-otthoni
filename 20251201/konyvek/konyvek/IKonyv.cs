using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    interface IKonyv
    {
        int OldalszamOsszesites(int osszOldalszam);
        List<Konyv> LegrovidebbKonyv(List<Konyv> keresettKonyv);
    }
}
