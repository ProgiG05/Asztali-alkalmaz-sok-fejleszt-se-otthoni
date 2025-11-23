using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20251019_DKÉ_konyvek
{
    internal class Program
    {
        static List<Konyv> adatKonyv = new List<Konyv>();
        static void Feladat1()
        {
            //Feladat1
            System.IO.File.ReadAllLines("kiadas2.txt",Encoding.UTF8).ToList().ForEach(x => adatKonyv.Add(new Konyv(x)));
        }
        static void Feladat2()
        {
            Console.WriteLine("2. feladat:");
            Console.Write("Szerző: ");
            string szerzoBe = Console.ReadLine();
            if (adatKonyv.Where(x => x.leiras.Split(':')[0] == szerzoBe).Count() > 0)
            {
                Console.WriteLine($"{adatKonyv.Where(x => x.leiras.Split(':')[0] == szerzoBe).Count()} könyvkiadás");
            }
            else
            {
                Console.WriteLine("Nem adtak ki.");
            }
        }
        static void Feladat3()
        {
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"Legnagyobb példányszám: {adatKonyv.Max(x => x.peldanySzam)}, előfordult {adatKonyv.Where(x => x.peldanySzam == adatKonyv.Max(y => y.peldanySzam)).Count()} alkalommal");
        }
        static void Feladat4()
        {
            Console.WriteLine("4. feladat:");
            Console.WriteLine($"{adatKonyv.Where(x => x.peldanySzam > 40000 && x.eredet != "ma").First().kiadasEv}/{adatKonyv.Where(x => x.peldanySzam > 40000 && x.eredet != "ma").First().negyedev}. {adatKonyv.Where(x => x.peldanySzam > 40000 && x.eredet != "ma").First().leiras}");
        }
        static void Feladat5()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("tabla.html");
            Console.WriteLine("5. feladat:");
            Console.WriteLine("Év\tMagyar kiadás\tMagyar példányszám\tKülföldi kiadás\tKülföldi példányszám");
            //level3
            var grouped1 = adatKonyv.GroupBy(x => x.kiadasEv).OrderBy(g => g.Key);
            sw.WriteLine("<table>");
            sw.WriteLine("<tr><th>Év</th>\t<th>Magyar kiadás</th>\t<th>Magyar példányszám</th>\t<th>Külföldi kiadás</th>\t<th>Külföldi példányszám</th></tr>");
            foreach (var g in grouped1)
            {
                int ev = g.Key;
                int magyarKiadas = g.Count(x => x.eredet == "ma");
                int magyarPeldany = g.Where(x => x.eredet == "ma").Sum(x => x.peldanySzam);
                int kulfoldiKiadas = g.Count(x => x.eredet != "ma");
                int kulfoldiPeldany = g.Where(x => x.eredet != "ma").Sum(x => x.peldanySzam);

                Console.WriteLine($"{ev}\t{magyarKiadas}\t{magyarPeldany}\t{kulfoldiKiadas}\t{kulfoldiPeldany}");
                
                sw.WriteLine($"<tr><td>{ev}</td>\t<td>{magyarKiadas}</td>\t<td>{magyarPeldany}</td>\t<td>{kulfoldiKiadas}</td>\t<td>{kulfoldiPeldany}</td></tr>");
            }
            sw.WriteLine("</table>");
            sw.Close();


            ////level2
            //var grouped2 = adatKonyv.GroupBy(x => x.kiadasEv);
            //foreach (var item in grouped2)
            //{
            //    Console.WriteLine($"{item.Key}\t{adatKonyv.Where(x => x.eredet == "ma" && x.kiadasEv == item.Key).Count()}\t{adatKonyv.Where(x => x.eredet == "ma" && x.kiadasEv == item.Key).Sum(y => y.peldanySzam)}\t{adatKonyv.Where(x => x.eredet != "ma" && x.kiadasEv == item.Key).Count()}\t{adatKonyv.Where(x => x.eredet != "ma" && x.kiadasEv == item.Key).Sum(y => y.peldanySzam)}");
            //}
            ////level1
            //for (int i = 0; i < adatKonyv.Count; i++)
            //{
            //    Console.WriteLine($"{adatKonyv[i].kiadasEv}\t{adatKonyv.Where(x => x.eredet == "ma" && x.kiadasEv == adatKonyv[i].kiadasEv).Count()}\t{adatKonyv.Where(x => x.eredet == "ma" && x.kiadasEv == adatKonyv[i].kiadasEv).Sum(y => y.peldanySzam)}\t{adatKonyv.Where(x => x.eredet != "ma" && x.kiadasEv == adatKonyv[i].kiadasEv).Count()}\t{adatKonyv.Where(x => x.eredet != "ma" && x.kiadasEv == adatKonyv[i].kiadasEv).Sum(y => y.peldanySzam)}");
            //}

            
        }
        static void Feladat6()
        {
            Console.WriteLine("6. feladat:");
            Console.WriteLine("Legalább kétszer, nagyobb példányszámban újra kiadott könyvek: ");
            var grouped = adatKonyv.GroupBy(x => x.leiras);
            foreach (var item in grouped)
            {
                var editions = item.OrderBy(x => x.kiadasEv).ThenBy(x => x.negyedev).ToList();
                if (editions.Count >= 1)
                {
                    continue;
                }
                var firstEdition = editions.First();
                int largers = editions.Skip(1).Count(e => e.peldanySzam > firstEdition.peldanySzam);
                if (largers >= 2)
                {
                    string[] parts = firstEdition.leiras.Split(':');
                    if (parts.Length >= 2)
                        Console.WriteLine($"{parts[0].Trim()}: {parts[1].Trim()}");
                    else
                        Console.WriteLine(firstEdition.leiras);
                }
            }
        }
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Console.ReadKey();
        }
    }
}
