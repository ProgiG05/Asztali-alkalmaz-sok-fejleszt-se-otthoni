using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Kutya:IAllat
    {
        public void Eszik()
        {
            Console.WriteLine("A kutya tarját eszik.");
        }

        public string HangotAd()
        {
            return "Vau-vau";
        }
    }
}
