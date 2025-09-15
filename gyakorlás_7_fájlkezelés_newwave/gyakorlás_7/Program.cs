using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyakorlás_7 //helsink1952 lenne a neve
{
    class Program
    {
        struct sport
        {
            public int helyezes, sportolokSzama;
            public string sportag, versenySzam;
        }
        static List<sport> adatok = new List<sport>();
        static void Feladat2()
        {
            StreamReader sr = new StreamReader("helsinki.txt");
            while (!sr.EndOfStream)
            {
                sport seged = new sport();
                string[] egysor = sr.ReadLine().Split(' ');
                seged.helyezes = Convert.ToInt32(egysor[0]);
                seged.sportolokSzama = Convert.ToInt32(egysor[1]);
                seged.sportag = egysor[2];
                seged.versenySzam = egysor[3];
                adatok.Add(seged);
            }
            sr.Close();
        }
        static void Feladat4()
        {
            int arany = 0;
            int ezüst = 0;
            int bronz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].helyezes == 1)
                {
                    arany++;
                }
                if (adatok[i].helyezes == 2)
                {
                    ezüst++;
                }
                if (adatok[i].helyezes == 3)
                {
                    bronz++;
                }
            }
            Console.WriteLine($"4.feladat:\nArany: {arany}\nEzüst: {ezüst}\nBronz: {bronz}\nÖsszesen: {arany+ezüst+bronz}");
        }
        static void Feladat5()
        {
            int olimpiaiPont = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                switch (adatok[i].helyezes)
                {
                    case 1:
                        olimpiaiPont += 7;
                        break;
                    case 2:
                        olimpiaiPont += 5;
                        break;
                    case 3:
                        olimpiaiPont += 4;
                        break;
                    case 4:
                        olimpiaiPont += 3;
                        break;
                    case 5:
                        olimpiaiPont += 2;
                        break;
                    case 6:
                        olimpiaiPont += 1;
                        break;
                    default:
                        break;
                } 
            }
            Console.WriteLine($"5.feladat\nOlimpiai pontok száma: {olimpiaiPont}");
        }
        static void Feladat6()
        {
            int uszas = 0;
            int torna = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].helyezes < 4 && adatok[i].sportag == "uszas")
                {
                    uszas++;
                }
                if (adatok[i].helyezes < 4 && adatok[i].sportag == "torna")
                {
                    torna++;
                }
            }
            Console.WriteLine("6. feladat:");
            if (torna == uszas)
            {
                Console.WriteLine("Egyenlő volt az érmek száma");
            }
            else
            {
                if (uszas> torna)
                {
                    Console.WriteLine("Úszás sportágban szerezttek több érmet");
                }
                else
                {
                    Console.WriteLine("Torna sportágban szerezttek több érmet");
                }
            }
        }
        static int Pontszam(int helyezes)
        {
            switch (helyezes)
            {
                case 1: 
                    return 7;
                case 2:
                    return 5;
                case 3:
                    return 4;
                case 4:
                    return 3;
                case 5:
                    return 2;
                case 6:
                    return 1;
                default:
                    return 0;
            }
        }
        static void Feladat7()
        {
            StreamWriter sw = new StreamWriter("helsinki2.txt");
            //sw.WriteLine("2 1 5 kajak-kenu kenu_egyes_1000m");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].sportag == "kajakkenu")
                {
                    sw.WriteLine($"{adatok[i].helyezes} {adatok[i].sportolokSzama} {Pontszam(adatok[i].helyezes)} kajak-kenu {adatok[i].versenySzam}");
                }
                else
                {
                    sw.WriteLine($"{adatok[i].helyezes} {adatok[i].sportolokSzama} {Pontszam(adatok[i].helyezes)} {adatok[i].sportag} {adatok[i].versenySzam}");
                }
            }
            sw.Close();
        }
        static void Feladat8()
        {
            int max = adatok[0].sportolokSzama;
            int maxi = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].sportolokSzama>max)
                {
                    max = adatok[i].sportolokSzama;
                    maxi = i;
                }
            }
            Console.WriteLine($"8.feladat:");
            Console.WriteLine($"Helyezés: {adatok[maxi].helyezes}");
            Console.WriteLine($"Sportág: {adatok[maxi].sportag}");
            Console.WriteLine($"Versenyszám: {adatok[maxi].versenySzam}");
            Console.WriteLine($"Sportolók száma: {max}");
        }
        static void Main(string[] args)
        {
            Feladat2();
            Console.WriteLine($"3.feladat:\nPontszerző helyezések száma: {adatok.Count()}");
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Console.ReadKey();
        }
    }
}
