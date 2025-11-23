using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _20251020_Abstract_Szallitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Teherauto tehi = new Teherauto("Mercedes Benz Actros", 120, 18000, 25, true);
                Console.WriteLine(tehi.ToString());
                Szemelyauto szemi = new Szemelyauto("Volswagen Arteon",210,500,8,5);
                Console.WriteLine(szemi.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
            Console.ReadKey();
        }
    }
}
