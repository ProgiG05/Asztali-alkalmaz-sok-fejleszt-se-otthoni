using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                KonyvKezelo kezelo = new KonyvKezelo();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
