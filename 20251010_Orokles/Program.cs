using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Terkep terkep = new Terkep(50, 50);
            TerkepRajzolo rajz = new TerkepRajzolo(terkep);
            rajz.Kirajzol();
            Console.ReadKey();
        }
    }
}
