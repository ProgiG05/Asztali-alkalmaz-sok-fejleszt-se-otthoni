using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklám
{
    class Program
    {
        //nagyreklam típúsú adatszerkezet létrehozása
        static List<Nagyreklám> adatok = new List<Nagyreklám>(); //1 TV 2
        static void Robot()
        {
            Console.WriteLine("MENTÉÉS");
            Console.WriteLine("       0       ");
            Console.WriteLine("   .___|___    ");
            Console.WriteLine("   |      |   ");
            Console.WriteLine("0--| 0  0 |--0");
            Console.WriteLine("   |  __  |   ");
            Console.WriteLine("   |______|   ");
        }
        static void Feladat1_a()
        {
            StreamReader sr = new StreamReader("rendel.txt");
            while (!sr.EndOfStream)
            {
                adatok.Add(new Nagyreklám(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("A fájl beolvasása megtörtént");
        }
        static void Feladat1_b()
        {
            foreach (var item in File.ReadAllLines("rendel.txt"))
            {
                adatok.Add(new Nagyreklám(item));
            }
        }
        static void Feladat1_c()
        {
            File.ReadAllLines("rendel.txt").ToList().ForEach(x=>adatok.Add(new Nagyreklám(x)));
        }
        static void Feladat3()
        {
            Console.Write("3. feldat:\nKérem,adjon meg egy napot: ");
            int nap = Convert.ToInt32(Console.ReadLine());
            int db = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].rendeles_napja == nap)
                {
                    db++;
                }
            }
            Console.WriteLine($"A rendelések száma az adott napon: {db}");
            Console.WriteLine($"A rendelések száma az adott napon: {adatok.Where(x=>x.rendeles_napja == nap).Count()}");
            Console.WriteLine($"A rendelések száma az adott napon: {adatok.Count(x=>x.rendeles_napja==nap)}");
        }
        static void Feladat4()
        {
            //ide gyüjtjük azoknak a napokank a sorszámát (rendelesNapja) ahol a város = NR
            HashSet<int> napokSzama = new HashSet<int>();
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].varos == "NR")
                {
                    napokSzama.Add(adatok[i].rendeles_napja);
                }
            }
            if (napokSzama.Count == 30)
            {
                Console.WriteLine("4. feldat:\nMinden nap volt rendelés a reklámban érintett városból");
            }
            else
            {
                Console.WriteLine($"4. feldat:\n{30-napokSzama.Count} nap nem volt rendelés a reklámban érintett városból");
            }
        }
        static void Feladat5()
        {
            int max = adatok[0].rendelt_db;
            int maxNap = adatok[0].rendeles_napja;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].rendelt_db>max)
                {
                    max = adatok[i].rendelt_db;
                    maxNap = adatok[i].rendeles_napja;
                }
            }
            Console.WriteLine($"5. feladat:\nA legnagyobb darabszam: {max}, rendelés napja: {maxNap}");

            Console.WriteLine($"5. feladat: {adatok.OrderBy(x=>x.rendelt_db).Last().rendeles_napja} db: {adatok.OrderBy(x=>x.rendelt_db).Last().rendelt_db}");
            var seged = adatok.OrderByDescending(x => x.rendelt_db).First();
            Console.WriteLine($"Nap: {seged.rendeles_napja} db: {seged.rendelt_db}");
        }
        static int osszeg(string varos,int nap)
        {
            int db = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].varos == varos && adatok[i].rendeles_napja == nap)
                {
                    db += adatok[i].rendelt_db;
                }
            }
            return db;
        }
        static void Feladat8()
        {
            //PL             //1...10,1
            //kulcs          //kulcs,érték    
            Dictionary<string, Dictionary<string, int>> osszesites = new Dictionary<string, Dictionary<string, int>>();

            //városonkénti összesítés inicializálása
            osszesites["PL"] = new Dictionary<string, int>() { {"elso10",0 } ,{"masodik10",0 },{"harmadik10",0} };
            osszesites["PL"] = new Dictionary<string, int>() { {"elso10",0 } ,{"masodik10",0 },{"harmadik10",0} };
            osszesites["PL"] = new Dictionary<string, int>() { {"elso10",0 } ,{"masodik10",0 },{"harmadik10",0} };
        }
        static void Main(string[] args)
        {
            //Feladat1_a();
            //Feladat1_b();
            Feladat1_c();
            Console.WriteLine($"2.feladat:\nA rendelések száma: {adatok.Count}");
            Feladat3();
            Feladat4();
            Feladat5();
            Console.WriteLine($"7. feladat: A rendelt termékek darabszáma a 21. napon PL: {osszeg("PL",21)} TV: {"TV",21} NR: {osszeg("NR",21)}");




            Console.Write("El szeretnéd menteni(y/n)? ");
            string yn = Convert.ToString(Console.ReadLine());
            if (yn == "y")
            {
                Robot();
            }
            else
            {
                Console.WriteLine(":(");
            }
            Console.ReadKey();
        }
    }
}
