using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ütemez
{
    class Program
    {
        static List<tábor> adatok = new List<tábor>();
        static void Feladat1_a()
        {
            StreamReader sr = new StreamReader("taborok.txt");
            while (!sr.EndOfStream)
            {
                adatok.Add(new tábor(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("A fájl beolvasása megtörtént");
        }
        static void Feladat1_b()
        {
            foreach (var item in File.ReadAllLines("taborok.txt"))
            {
                adatok.Add(new tábor(item));
            }
            Console.WriteLine("A fájl beolvasása megtörtént");
        }
        static void Feladat1_c()
        {
            File.ReadAllLines("taborok.txt").ToList().ForEach(x => adatok.Add(new tábor(x)));
            Console.WriteLine("A fájl beolvasása megtörtént");
        }
        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az adatsorok száma: {adatok.Count}");
            Console.WriteLine($"Az először rögzített tábor témája: {adatok[0].taborfajta}");
            Console.WriteLine($"Az utoljára rögzített tábor témája: {adatok[adatok.Count-1].taborfajta}");
            Console.WriteLine($"Az először rögzített tábor témája: {adatok.First().taborfajta}");
            Console.WriteLine($"Az utoljára rögzített tábor témája: {adatok.Last().taborfajta}");
        }
        static void Feladat3_a()
        {
            int db = 0;
            Console.WriteLine("3. feladat");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].taborfajta == "zenei")
                {
                    Console.WriteLine($"Zenei tábor kezdődik: {adatok[i].kezdHo}. hó {adatok[i].kezdNap}. napján.");
                    db++;   
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem volt zenai tábor");
            }
        }
        static void Feladat3_b()
        {
            Console.WriteLine("3. feladat");
            if (adatok.Count(x=>x.taborfajta == "zenei") == 0)
            {
                Console.WriteLine("Nem volt zenei tábor");
            }
            else
            {
                foreach (var item in adatok.FindAll(x => x.taborfajta == "zenei"))
                {
                    Console.WriteLine($"Zenei tábor kezdődik: {item.kezdHo}. hó {item.kezdNap}. napján.");
                }
            }
        }
        static void Feladat4()
        {
            var seged = adatok.FindAll(x => x.diakokSzama == adatok.Max(y => y.diakokSzama));
            foreach (var item in seged)
            {
                Console.WriteLine($"{item.kezdHo} {item.kezdNap} {item.taborfajta}");
            }
        }
        static int sorszam(int honap,int nap)
        {
            int db = 0;
            if (honap == 6)
            {
                db = nap - 15;
            }
            else
            {
                if (honap == 7)
                {
                    db = nap + 15;
                }
                else
                {
                    if (honap == 8)
                    {
                        db = nap + 46;
                    }
                }
            }
            return db;
        }
        static void Feladat6()
        {
            Console.WriteLine("6. feladat");
            Console.Write("hó: ");
            int hónap = Convert.ToInt32(Console.ReadLine());
            Console.Write("nap: ");
            int nap = Convert.ToInt32(Console.ReadLine());
            int db = 0;//hány tábor
            int sorsz = sorszam(hónap, nap);
            for (int i = 0; i < adatok.Count; i++)
            {
                if (sorszam(adatok[i].kezdHo,adatok[i].kezdNap)<= sorsz && sorsz<=sorszam(adatok[i].vegHo,adatok[i].vegNap))
                {
                    db++;
                }
            }
            Console.WriteLine($"Ekkor éppen {db} tábor tart.");
        }
        static void Feladat7()
        {
            Console.WriteLine("7. feladat");
            Console.Write("Adja meg a tanuló betűjét");
            char betu = Convert.ToChar(Console.ReadLine());
            List<tábor> taborAdatok = new List<tábor>();
            for (int i = 0; i < adatok.Count; i++)
            {
                for (int j = 0; j < adatok[i].diakok.Length; j++)
                {
                    if (adatok[i].diakok[j] == betu)
                    {
                        tábor seged = new tábor();
                        seged.kezdHo = adatok[i].kezdHo;
                        seged.kezdNap = adatok[i].kezdNap;
                        seged.vegHo = adatok[i].vegHo;
                        seged.vegNap = adatok[i].vegNap;
                        seged.taborfajta = adatok[i].taborfajta;
                        taborAdatok.Add(seged);
                    }
                }
            }
            var rendezett = taborAdatok.OrderBy(x => x.kezdHo).ThenBy(y => y.kezdNap).ToList();
            StreamWriter sw = new StreamWriter("egytanulo.txt");
            foreach (var item in rendezett)
            {
                sw.WriteLine($"{item.kezdHo}.{item.kezdNap}-{item.vegHo}.{item.vegNap}. {item.taborfajta}");
            }
            sw.Close();
            bool ottTudLenni = true;
            int vegenap = 0;
            for (int i = 0; i < rendezett.Count; i++)
            {
                if (sorszam(rendezett[i].kezdHo,rendezett[i].kezdNap)<=vegenap)
                {
                    ottTudLenni = false;    
                }
                vegenap = sorszam(rendezett[i].kezdHo, rendezett[i].kezdNap);

            }
            Console.WriteLine(ottTudLenni == false?"Nem mehet el mindegyik táborba.":"Elmehet mindegyik táborba");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat(a,b,c)");
            char egy = Convert.ToChar(Console.ReadLine());
            switch (egy)
            {
                case 'a':
                    Feladat1_a();
                    break;
                case 'b':
                    Feladat1_b();
                    break;
                case 'c':
                    Feladat1_c();
                    break;
                default:
                    break;
            }
            Feladat2();
            //Feladat3_a();
            Feladat3_b();
            Feladat4();
            //Console.WriteLine(sorszam(7,15));
            Feladat6();
            Feladat7();
            Console.ReadKey();
        }
    }
}
