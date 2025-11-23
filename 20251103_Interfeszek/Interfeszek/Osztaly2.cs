using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Osztaly2:IEgyik,IMasik
    {
        public string Nevem()
        {
            return "Saját nevem";
        }
        string IEgyik.Nevem()
        {
            return "Egyik nevem";
        }

        void IEgyik.Varos()
        {
            Console.WriteLine("Székesfehérvár");
        }

        void IMasik.Varos()
        {
            Console.WriteLine("Budapest");
        }
    }
}
