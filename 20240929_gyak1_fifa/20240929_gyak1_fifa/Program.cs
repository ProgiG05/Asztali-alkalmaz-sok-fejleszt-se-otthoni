using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240929_gyak1_fifa
{
    class Program
    {
        static List<fifa> data = new List<fifa>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("fifa.txt").Skip(1).ToList().ForEach(x => data.Add(new fifa(x)));
            Console.WriteLine($"3. feladat: A világranglistán {data.Count} csapat szerepel");
            Console.WriteLine($"4. feladat: A csapatok átlagos pontszáma: {Math.Round(data.Average(x => x.pont),2)} pont");
            Console.WriteLine("5. feladat: A legtöbbet javító csapat:");
            var legtöbb = data.Max(x => x.valtozas);
            data.Where(x => x.valtozas == legtöbb).ToList().ForEach(x => Console.WriteLine($"\tHelyezés: {x.hely}\n\tCsapat: {x.csapat}\n\tPontszám: {x.pont}"));
            Console.WriteLine($"6. feladat: ");
            Console.WriteLine(data.Any(x => x.csapat == "Magyarország") ? "A csapatok között van Magyarország": "A csapatok között nincs Magyarország");
            Console.WriteLine("7. feladat: Statisztika");
            var stat = data.GroupBy(x => x.valtozas).ToDictionary(y => y.Key, z => z.ToList().Count);
            foreach (var item in stat)
            {
                Console.WriteLine($"\t{item.Key} helyet változott: {item.Value} csapat");
            }
            Console.ReadKey();
            //ha van/nincs => .Any
        }
    }
}
