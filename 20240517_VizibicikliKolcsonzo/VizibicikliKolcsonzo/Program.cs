using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VizibicikliKolcsonzo
{
    class Program
    {
        static List<Kolcsonzes> adatok = new List<Kolcsonzes>();
        static void beolvas1()
        {
            StreamReader sr = new StreamReader("kolcsonzesek.txt");
            string[] elsosor = sr.ReadLine().Split(';');
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                Kolcsonzes seged = new Kolcsonzes(egysor[0], egysor[1], Convert.ToInt32(egysor[2]), Convert.ToInt32(egysor[3]), Convert.ToInt32(egysor[4]), Convert.ToInt32(egysor[5]));
                adatok.Add(seged);
            }
            sr.Close();
        }
        static void beolvas2()
        {
            foreach (var item in File.ReadAllLines("kolcsonzesek.txt").Skip(1))
            {
                Kolcsonzes sor = new Kolcsonzes(item);
                adatok.Add(sor);
            }
        }
        static void beolvas3()
        {
            StreamReader sr = new StreamReader("kolcsonzesek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Kolcsonzes sor = new Kolcsonzes(sr.ReadLine());
                adatok.Add(sor);
            }
            sr.Close();
        }
        static void feladat6()
        {
            Console.Write("6. feladat: Kérek egy nevet: ");
            string nev = Console.ReadLine();
            int db = 0;
            Console.WriteLine($"\t{nev} kölcsönzései:");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].nev == nev)
                {
                    Console.WriteLine($"\t{adatok[i].elvÓra}:{adatok[i].elvPerc}-{adatok[i].visszaÓra}:{adatok[i].visszaPerc}");
                }
                else
                {
                    db++;
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző");
            }
        }
        static int összead(int ora, int perc)
        {
            return ora * 60 + perc;
        }
        //static string makezero(string x)
        //{
            
        //}
        static void feladat7()
        {
            Console.Write("7. feladat: Adjon meg egy időpontot óra:perc alakban: ");
            string ido = Console.ReadLine();
            string[] result = ido.Split(':');
            int Óra = Convert.ToInt32(result[0]);
            int Perc = Convert.ToInt32(result[1]);
            int ido1 = összead(Óra, Perc);
            Console.WriteLine("\t A vízen lévő járművek:");
            for (int i = 0; i < adatok.Count; i++)
            {
                int elv = összead(adatok[i].elvÓra, adatok[i].elvPerc);
                int vissza = összead(adatok[i].visszaÓra, adatok[i].visszaPerc);
                if (ido1 > elv && ido1 < vissza)
                {
                    Console.WriteLine($"\t{adatok[i].elvÓra}:{adatok[i].elvPerc}-{adatok[i].elvÓra}:{adatok[i].elvPerc} : {adatok[i].nev}");
                }
            }
        }
        static void feladat8()
        {
            int díj = 2400;
            int összidő = 0;//percben
            for (int i = 0; i < adatok.Count; i++)
            {
                összidő += összead(adatok[i].elvÓra, adatok[i].elvPerc);
            }
            Console.WriteLine($"8. feladat: A napi bevétel: {(összidő*díj)/2} Ft");
        }
        static void feladat9()
        {
            StreamWriter sw = new StreamWriter("F.txt");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].jarmuAz == "F")
                {
                    sw.WriteLine($"{adatok[i].elvÓra}:{adatok[i].elvPerc}-{adatok[i].visszaÓra}:{adatok[i].visszaPerc} : {adatok[i].nev}");
                }
            }
            sw.Close();
        }
        static void feladat10()
        {
            Dictionary<string, int> stat = new Dictionary<string, int>();
            for (int i = 0; i < adatok.Count; i++)
            {
                if (stat.ContainsKey(adatok[i].jarmuAz))
                {
                    stat[adatok[i].jarmuAz]++;
                }
                else
                {
                    stat.Add(adatok[i].jarmuAz, 1);
                }
            }
            var sortedDict = stat.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        static void Main(string[] args)
        {
            beolvas1();
            Console.WriteLine($"5. feladat: Napi kölcsönzések száma: {adatok.Count}");
            //beolvas2();
            //Console.WriteLine($"5. feladat: Napi kölcsönzések száma: {adatok.Count}");
            //beolvas3();
            //Console.WriteLine($"5. feladat: Napi kölcsönzések száma: {adatok.Count}");
            feladat6();
            feladat7();
            feladat8();
            feladat9();
            feladat10();
            Console.ReadKey();
        }
    }
}
