using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240916_HegyekMo
{
    class Program
    {
        static List<mo> data = new List<mo>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("HegyekMo.txt", Encoding.UTF8).Skip(1).ToList().ForEach(x => data.Add(new mo(x)));
            Console.WriteLine($"Fel3: {data.Count}");
            Console.WriteLine("Fel7:");
            data.Where(x => x.magas * 3.28 < 3000).ToList().ForEach(x => Console.WriteLine(x.nev));

            Console.ReadKey();
        }
    }
}
