using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_kglb_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kg/lb: ");
            string kglb = Console.ReadLine();
            if (kglb == "kg")
            {
                Console.WriteLine("kg to lb:");
                Console.Write("kg: ");
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{kg}kg = {kg * 2.2}");
            }
            else if (kglb == "lb")
            {
                Console.WriteLine("lb to kg:");
                Console.Write("lb: ");
                double lb = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{lb}lb = {lb * 0.45}");
            }
            Console.ReadKey();
        }
    }
}
