using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ultrabalaton_0517
{
    class Program
    {
        static List<ultraB> UB = new List<ultraB>();
        static void beolvas1()
        {
            //automatikusan elkésszített konstruktor használata
            StreamReader sr = new StreamReader("ub2017egyeni.txt");
            //fájl első sora a mezőneveket tartalmazza
            string elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                ultraB seged = new ultraB(egysor[0], egysor[1], Convert.ToInt32(egysor[2]),egysor[3],Convert.ToInt32(egysor[4]));
                UB.Add(seged);
            }
            sr.Close();
        }
        static void beolvas2()
        {
            StreamReader sr = new StreamReader("ub2017egyeni.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                ultraB egysor = new ultraB(sr.ReadLine());
                UB.Add(egysor);
            }
            sr.Close();

        }
        static void beolvas3()
        {
            foreach (var item in File.ReadAllLines("ub2017egyeni.txt").Skip(1))
            {
                ultraB sor = new ultraB(item);
                UB.Add(sor);
            }
        }
        static void feladat4()
        {
            int db = 0;
            for (int i = 0; i < UB.Count; i++)
            {
                if (UB[i].kategoria == "Noi" && UB[i].tavszazalek == 100)
                {
                    db++;
                }
            }
            Console.WriteLine($"4.feladat: célba érkező női sprtolók: {db} fő");
        }
        static void feladat5()
        {
            Console.Write("5.feladat: Kérem a sportoló nevét: ");
            string nev = Console.ReadLine();
            bool indult = false;
            bool teljesítette = false; 
            for (int i = 0; i < UB.Count; i++)
            {
                if (UB[i].nev == nev)
                {
                    indult = true;
                    if (UB[i].tavszazalek == 100)
                    {
                        teljesítette = true;
                    }
                    break;
                }
            }
            Console.Write("\tIndult egyéniben a sportoló?");
            if (indult)
            {
                Console.Write(" Igen");
                Console.Write("\tTeljesítette a teljes távot ");
                if (teljesítette)
                {
                    Console.Write(" Igen");
                }
                else
                {
                    Console.Write(" Nem");
                }
            }
            else
            {
                Console.Write(" Nem");
            }
        }
        static double IdőÓrában(double óra,double perc,double mp)
        {
            return óra + perc / 60 + mp / 3600;
        }

        static void feladat7()
        {
            int db = 0;
            double osszido = 0;
            for (int i = 0; i < UB.Count; i++)
            {
                if (UB[i].kategoria == "Ferfi" && UB[i].tavszazalek == 100)
                {
                    db++;
                    osszido += IdőÓrában(UB[i].ora, UB[i].perc, UB[i].mp);
                }
            }
            Console.WriteLine($"7.feladat: Átlagos idő: {osszido/db}");
        }
        static void feladat8()
        {
            Console.WriteLine($"8. feladat: A verseny győztesei: ");
            double noiIdo = IdőÓrában(UB[0].ora, UB[0].perc, UB[0].mp);
            int noiIndex = 0;
            for (int i = 0; i < UB.Count; i++)
            {
                double ido = IdőÓrában(UB[i].ora, UB[i].perc, UB[i].mp);
                if (UB[i].kategoria == "Noi" && UB[i].tavszazalek == 100 && ido < noiIdo)
                {
                    noiIdo = IdőÓrában(UB[i].ora, UB[i].perc, UB[i].mp);
                    noiIndex = i;
                }
            }
            Console.WriteLine($"\t Nők: {UB[noiIndex].nev} ({UB[noiIndex].rajtszam}.) - {UB[noiIndex].vido}");
            double ferfiIdo = IdőÓrában(UB[0].ora, UB[0].perc, UB[0].mp);
            int ferfiIndex = 0;
            for (int i = 0; i < UB.Count; i++)
            {
                double ido = IdőÓrában(UB[i].ora, UB[i].perc, UB[i].mp);
                if (UB[i].kategoria == "Noi" && UB[i].tavszazalek == 100 && ido < ferfiIdo)
                {
                    ferfiIdo = IdőÓrában(UB[i].ora, UB[i].perc, UB[i].mp);
                    ferfiIndex = i;
                }
            }
            Console.WriteLine($"\t Férfiak: {UB[ferfiIndex].nev} ({UB[ferfiIndex].rajtszam}.) - {UB[ferfiIndex].vido}");
        }
        static void Main(string[] args)
        {
            //beolvas1();
            //Console.WriteLine($"3.feladat: Egyéni indulók: {UB.Count} fő");
            beolvas2();
            Console.WriteLine($"3.feladat: Egyéni indulók: {UB.Count} fő");
            //beolvas3();
            //Console.WriteLine($"3.feladat: Egyéni indulók: {UB.Count} fő");
            feladat4();
            feladat5();
            Console.WriteLine();
            feladat7();
            feladat8();
            Console.ReadKey();
        }
    }
}
