using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240909_vb2018
{
    class Program
    {
        static List<vb> data = new List<vb>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("vb2018.txt").Skip(1).ToList().ForEach(x => data.Add(new vb(x)));
            Console.WriteLine("1. feladat:      Az adatok beolvasása megörtént");
            Console.WriteLine("2. feladat:      A beolvasott adatok");
            data.ToList().ForEach(x => Console.WriteLine($"\t{x.varos} {x.nev1} {x.nev2} {x.ferohely}"));
            Console.WriteLine($"3. feladat:\n\tStadionok száma: {data.Count}");
            Console.WriteLine($"4. feladat: a legkisebb férőhely:");
            int kicsi = data.Min(x => x.ferohely);
            data.Where(x => x.ferohely == kicsi).ToList().ForEach(x => Console.WriteLine($"\n\t Város: {x.varos}\n\t Stadion neve: {x.nev1}\n\t Férőhely: {kicsi}"));
            Console.WriteLine($"5. feladat: Átlagos férőhelyek száma: {Math.Round(data.Average(x => x.ferohely),1)}");
            Console.WriteLine($"6. feladat: Moszkvai stadionok összesen {data.Where(x => x.varos == "Moszkva").Sum(x => x.ferohely)} főt fogadanak.");
            Console.ReadKey();
        }
    }
}
