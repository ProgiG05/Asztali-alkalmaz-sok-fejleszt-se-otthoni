using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fáujlkezelés_gyak_2024._04._04
{
    class Program
    {
        struct itokak
        {
            public string nev;
            public int egysegar, mennyiseg;
        }
        static List<itokak> adatok = new List<itokak>();
        static void Feladat1()
        {
            StreamReader sr = new StreamReader("ital.txt",Encoding.Default);
            itokak seged = new itokak();
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                seged.nev = egysor[0];
                seged.egysegar = Convert.ToInt32(egysor[1]);
                seged.mennyiseg = Convert.ToInt32(egysor[2]);
                adatok.Add(seged);
            }
            Console.WriteLine("A beolvasás megtörtént! xd");
        }
        static void Feladat2()
        {
            Console.WriteLine("A kocsma italválasztéka:");
            List<string> italok = new List<string>();
            for (int i = 0; i < adatok.Count; i++)
            {
                italok.Add(adatok[i].nev);
                Console.WriteLine($"{i+1}. {adatok[i].nev}");
            }
            Console.WriteLine($"db: {italok.Count}");
        }
        static void Feladat3()
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                Console.WriteLine($"{i+1}. {adatok[i].nev}: {adatok[i].egysegar*adatok[i].mennyiseg}Ft");
            }
        }
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();

            Console.ReadKey();
        }
    }
}
