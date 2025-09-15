using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240916_berek
{
    class Program
    {
        static List<berek> data = new List<berek>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("berek2020.txt", Encoding.UTF8).Skip(1).ToList().ForEach(x => data.Add(new berek(x)));
            Console.WriteLine($"Feladat 3: Dolgozók száma: {data.Count} fő");
            Console.WriteLine($"Feladat 4: Bérek száma: {Math.Round(data.Average(x => x.ber), 2)} e Ft");
            Console.Write("Feladat 5: Kérem egy részleg nevét: ");
            string r = Console.ReadLine();
            var nagyi = data.Where(x => x.reszleg == r).OrderBy(y => y.ber).Last();
            Console.WriteLine($"Feladat 6: A legtöbbet kereső dolgozó a megadott részlegen: \n\tNév: {nagyi.nev}\n\tNeme: {nagyi.nem}\n\tBelépés: {nagyi.belepes}\n\tBér: {nagyi.ber}");
            Console.WriteLine("7. Feladat: Statisztika");
            System.IO.StreamWriter sw = new System.IO.StreamWriter("reszlegstat.txt");
            //data.GroupBy(x => x.reszleg).ToDictionary(y => y.Key, z => z.ToList().Count).ToList().ForEach(item => sw.WriteLine($"{item.Key} - {item.Value}fő"));
            var stat = data.GroupBy(x => x.reszleg).ToDictionary(y => y.Key, z => z.ToList().Count);
            foreach (var item in stat)
            {
                sw.WriteLine($"{item.Key} - {item.Value} fő");
            }
            sw.Close();


            Console.ReadKey();
        }
    }
}
