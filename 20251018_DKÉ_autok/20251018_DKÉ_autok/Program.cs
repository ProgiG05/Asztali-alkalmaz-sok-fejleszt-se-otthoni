using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251018_DKÉ_autok
{
    internal class Program
    {
        static List<Auto> adatAuto = new List<Auto>();
        static void Feladat1() 
        {
            // 1. feladat:
            System.IO.File.ReadAllLines("jeladas.txt").ToList().ForEach(x => adatAuto.Add(new Auto(x)));
        }
        static void Feladat2()
        {
            Console.WriteLine("2. feladat: ");
            Console.WriteLine($"Az utolsó jeladás időpontja: {adatAuto.Last().jelÓra}:{adatAuto.Last().jelPerc}, a jármű rendszáma: {adatAuto.Last().rendszam}");
        }
        static void Feladat3()
        {
            Console.WriteLine("3. feladat: ");
            Console.WriteLine($"Az első jármű: {adatAuto.First().rendszam}");
            Console.Write($"Jeladásainak időpontjai: ");
            adatAuto.Where(x => x.rendszam == adatAuto.First().rendszam).ToList().ForEach(y => Console.Write($" {y.jelÓra}:{y.jelPerc}"));
            //kiegészítés
        }
        static void Feladat4()
        {
            Console.WriteLine("\n4. feladat: ");
            Console.Write("Kérem adja meg az órát: ");
            int óraBe = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a percet:");
            int percBe = int.Parse(Console.ReadLine());
            Console.WriteLine($"A jeladások száma: {adatAuto.Where(x => x.jelÓra == óraBe && x.jelPerc == percBe).Count()}");
        }
        static void Feladat5()
        {
            Console.WriteLine("5. feladat: ");
            Console.WriteLine($"A legnagyobb sebesség km/h: {adatAuto.Max(x => x.sebesség)}");
            Console.Write($"A járművek:");
            adatAuto.Where(x => x.sebesség == adatAuto.Max(y => y.sebesség)).ToList().ForEach(z => Console.Write($" {z.rendszam}"));
        }
        //static void Feladat6()
        //{
        //    Console.WriteLine("\n6. feladat: ");
        //    Console.Write("Kérem adja meg a rendszámot: ");
        //    string rendszamBe = Console.ReadLine();
        //    for (int i = 0; i < adatAuto.Count; i++)
        //    {
        //        if (adatAuto[i].rendszam == rendszamBe)
        //        {
        //            for (int j = 0; j < adatAuto.Count; j++)
        //            {
        //                for (int k = j + 1; k < adatAuto.Count; k++)
        //                {
        //                    if (adatAuto[k].jelÓra - adatAuto[j].jelÓra >= 1)
        //                    {
        //                        int percbe = (60 - adatAuto[j].jelPerc) + adatAuto[k].jelPerc;
        //                        double oraba = percbe / 60;
        //                        Console.WriteLine($"{adatAuto[i].jelÓra}:{adatAuto[i].jelPerc} {Math.Round(oraba * adatAuto[i].sebesség,2)} km");
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        int percbe = adatAuto[k].jelPerc - adatAuto[j].jelPerc;
        //                        double oraba = percbe / 60;
        //                        Console.WriteLine($"{adatAuto[i].jelÓra}:{adatAuto[i].jelPerc} {Math.Round(oraba * adatAuto[i].sebesség, 2)} km");
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        static void Feladat6()
        {
            Console.WriteLine("\n6. feladat: ");
            Console.Write("Kérem adja meg a rendszámot: ");
            string rendszamBe = Console.ReadLine();

            var readings = adatAuto.Where(a => a.rendszam == rendszamBe).OrderBy(a => a.jelÓra).ThenBy(a => a.jelPerc).ToList();

            if (!readings.Any())
            {
                Console.WriteLine("Nincs ilyen rendszám.");
                return;
            }

            double cumulativeKm = 0.0;
            // first reading is at 0.00 km
            var first = readings.First();
            Console.WriteLine($"{first.jelÓra:D2}:{first.jelPerc:D2} {cumulativeKm:F2} km");

            for (int i = 1; i < readings.Count; i++)
            {
                var prev = readings[i - 1];
                var curr = readings[i];

                int prevMinutes = prev.jelÓra * 60 + prev.jelPerc;
                int currMinutes = curr.jelÓra * 60 + curr.jelPerc;
                int minutesDiff = currMinutes - prevMinutes;
                if (minutesDiff < 0) minutesDiff += 24 * 60; // handle midnight wrap

                double hours = minutesDiff / 60.0; // ensure double division
                                                   // assume speed (km/h) recorded at prev applies for the interval until curr
                double distance = prev.sebesség * hours;
                cumulativeKm += distance;

                Console.WriteLine($"{curr.jelÓra:D2}:{curr.jelPerc:D2} {cumulativeKm:F2} km");
            }
        }
        static void Feladat7()
        {
            // 7. feladat:
            System.IO.StreamWriter sw = new System.IO.StreamWriter("ido.txt");
            //List<Auto> megfigyelés = new List<Auto>();
            //for (int i = 0; i < adatAuto.Count; i++)
            //{
            //    Auto seged = new Auto();
            //    seged.rendszam = adatAuto[i].rendszam;
            //    seged.kezdesOra = adatAuto.Where(x => x.rendszam == adatAuto[i].rendszam).First().jelÓra;
            //    seged.kezdesPerc = adatAuto.Where(x => x.rendszam == adatAuto[i].rendszam).First().jelPerc;
            //    seged.vegeOra = adatAuto.Where(x => x.rendszam == adatAuto[i].rendszam).Last().jelÓra;
            //    seged.vegePerc = adatAuto.Where(x => x.rendszam == adatAuto[i].rendszam).Last().jelPerc;
            //    megfigyelés.Add(seged);
            //}
            //foreach (var item in megfigyelés)
            //{
            //    Console.WriteLine($"{item.rendszam} {item.kezdesOra} {item.kezdesPerc} {item.vegeOra} {item.vegePerc}");
            //    sw.WriteLine($"{item.rendszam} {item.kezdesOra} {item.kezdesPerc} {item.vegeOra} {item.vegePerc}");
            //}
            Console.WriteLine();
            List<Auto> megfigyelés = new List<Auto>();
            // Group by rendszam so we create exactly one entry per vehicle
            var grouped = adatAuto.GroupBy(a => a.rendszam);
            foreach (var g in grouped)
            {
                var first = g.First();
                var last = g.Last();
                Auto seged = new Auto
                {
                    rendszam = g.Key,
                    kezdesOra = first.jelÓra,
                    kezdesPerc = first.jelPerc,
                    vegeOra = last.jelÓra,
                    vegePerc = last.jelPerc
                };
                megfigyelés.Add(seged);
            }

            foreach (var item in megfigyelés)
            {
                Console.WriteLine($"{item.rendszam} {item.kezdesOra} {item.kezdesPerc} {item.vegeOra} {item.vegePerc}");
                sw.WriteLine($"{item.rendszam} {item.kezdesOra} {item.kezdesPerc} {item.vegeOra} {item.vegePerc}");
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Console.ReadKey();
        }
    }
}
