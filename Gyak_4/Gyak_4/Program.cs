using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            while (y < 5+1)
            {
                Console.WriteLine(y);
                y++;
            }
            Console.Write("Adj meg egy számot: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
