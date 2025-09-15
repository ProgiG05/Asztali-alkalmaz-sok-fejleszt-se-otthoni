using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240929_gyak_kosarlabda
{
    class Program
    {
        static List<kosar> data = new List<kosar>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("eredmenyek.csv").Skip(1).ToList().ForEach(x => data.Add(new kosar(x)));
            Console.WriteLine($"3. feladat: A fájlban {data.Count} adat került rögzítésre.");
            Console.WriteLine($"4. feladat: Real Madrid: hazai: {data.Where(x => x.hazai == "Real Madrid").Count()}, idegen: {data.Where(x => x.idegen == "Real Madrid").Count()}");
            Console.Write($"5. feladat: Volt döntetlen?");
            Console.Write(data.Any(x => x.hazai_pont == x.idegen_pont)?" Igen":" Nem");
            Console.WriteLine();
            var vau = data.Where(x => x.hazai.Contains("Barcelona")).GroupBy(y => y.hazai).Last();
            Console.WriteLine($"6. feladat: A barcelonai csapat pontos neve: {vau.Key}");
            Console.WriteLine("7. feladat: ");
            DateTime ido = new DateTime(2004,11,21);
            data.Where(x => x.időpont == ido).ToList().ForEach(x => Console.WriteLine($"\t{x.hazai} - {x.idegen} ({x.hazai_pont}:{x.idegen_pont})"));
            var stat = data.GroupBy(x => x.helyszín).ToDictionary(y => y.Key, z => z.Count());
            System.IO.StreamWriter sw = new System.IO.StreamWriter("stadionok.txt");
            sw.WriteLine("8. feladat: ");
            foreach (var item in stat)
            {
                if (item.Value > 20)
                {
                    sw.WriteLine($"\t {item.Key} - {item.Value} db");
                }
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
