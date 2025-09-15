using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240929_gyak_kosarlabda
{
    class kosar
    {
        public string hazai, idegen, helyszín;
        public int hazai_pont, idegen_pont;
        public DateTime időpont;

        public kosar(string sor)
        {
            string[] egysor = sor.Split(';');
            hazai = egysor[0];
            idegen = egysor[1];
            hazai_pont = Convert.ToInt32(egysor[2]);
            idegen_pont = Convert.ToInt32(egysor[3]);
            helyszín = egysor[4];
            időpont = Convert.ToDateTime(egysor[5]);
        }
    }
}
