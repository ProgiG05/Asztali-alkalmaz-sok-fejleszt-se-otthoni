using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Kutya2:IAllat,IKutya
    {
        //IAllat metódusainak implementáció
        public void Eszik()
        {
            Console.WriteLine("Ham-ham pörkölt");
        }

        public string HangotAd()
        {
            return "A kutya ugat.";
        }
        //IKutya 
        public void Iszik()
        {
            Console.WriteLine("Lafaty");
        }
    }
}
