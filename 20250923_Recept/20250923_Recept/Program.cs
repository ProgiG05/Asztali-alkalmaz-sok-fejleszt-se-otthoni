using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250923_Recept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Recept recept1 = new Recept("Palacsinta", new List<string> { "liszt", "tojás", "tej", "cukor", "só" }, 20, DateTime.Now);
                recept1.AllergenekEllenorzes();
                recept1.HozzavalokListazasa();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
