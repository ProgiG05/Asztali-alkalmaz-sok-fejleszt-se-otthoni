using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240929_gyak1_fifa
{
    class fifa
    {
        public string csapat;
        public int hely, valtozas, pont;

        public fifa(string sor)
        {
            string[] egysor = sor.Split(';');
            csapat = egysor[0];
            hely = Convert.ToInt32(egysor[1]);
            valtozas = Convert.ToInt32(egysor[2]);
            pont = Convert.ToInt32(egysor[3]);
        }
    }
}
