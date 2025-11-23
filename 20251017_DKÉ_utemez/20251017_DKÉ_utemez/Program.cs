using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251017_DKÉ_utemez
{
    internal class Program
    {
        static List<Tabor> dataCamp = new List<Tabor>();

        static void Exercise1()
        {
           System.IO.File.ReadAllLines("taborok.txt").ToList().ForEach(x => dataCamp.Add(new Tabor(x)));
        }
        static void Exercise2() 
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az adatsorok száma: {dataCamp.Count}");
            Console.WriteLine($"Az először rögzített tábor témája: {dataCamp[0].tema}");
            Console.WriteLine($"Az utoljára rögzített tábor témája: {dataCamp[dataCamp.Count - 1].tema}");
        }
        static void Exercise3()
        {
            Console.WriteLine("3. feladat");
            int zeneiTaborok = 0;
            for (int i = 0; i < dataCamp.Count; i++)
            {
                if (dataCamp[i].tema == "zenei")
                {
                    zeneiTaborok++;
                }
            }
            if (zeneiTaborok > 0)
            {
                for (int i = 0; i < dataCamp.Count; i++)
                {
                    if (dataCamp[i].tema == "zenei")
                    {
                        Console.WriteLine($"Zenei tábor kezdődik {dataCamp[i].kezdhonap}. hó {dataCamp[i].kezdnap}. napján");
                    }  
                }
            }
            else
            {
                Console.WriteLine("Nem volt zenei tábor");
            }
        }
        static void Exercise4()
        {
            Console.WriteLine("4. feladat");
            int maxDiak = 0;
            int maxIndex = 0;
            for (int i = 0; i < dataCamp.Count; i++)
            {
                if (dataCamp[i].diakok.ToString().Length > maxDiak)
                {
                    maxDiak = dataCamp[i].diakok.ToString().Length;
                    maxIndex = i;
                }
            }
            Console.WriteLine("Legnépszerűbbek:");
            Console.WriteLine($"{dataCamp[maxIndex].kezdhonap} {dataCamp[maxIndex].kezdnap} {dataCamp[maxIndex].tema}");
        }
        public static int sorszam(int honap, int nap)
        {
            int sorszam = 0;
            if (honap == 6)
            {
                sorszam = nap - 15;
                return sorszam;
            }
            else if (honap == 7)
            {
                sorszam = 15 + nap;
                return sorszam;
            }
            else if (honap == 8)
            {
                sorszam = 15 + 31 + nap;
                return sorszam;
            }
            else
            {
                return -1;
            }

        }
        static void Exercise6()
        {
            Console.WriteLine("6. feladat");
            Console.Write("hó: ");
            int honapBe = int.Parse(Console.ReadLine());
            Console.Write("nap: ");
            int napBe = int.Parse(Console.ReadLine());
            int beSorszam = sorszam(honapBe, napBe);
            int db = 0;
            for (int i = 0; i < dataCamp.Count; i++)
            {
                int kezdSorszam = sorszam(dataCamp[i].kezdhonap, dataCamp[i].kezdnap);
                int vegSorszam = sorszam(dataCamp[i].veghonap, dataCamp[i].vegnap);
                if (kezdSorszam <= beSorszam && beSorszam <= vegSorszam)
                {
                    db++;
                }
            }
            Console.WriteLine($"Ekkor éppen {db} tábor tart.");
        }
        static void Exercise7()
        {
            Console.WriteLine("7. feladat");
            Console.Write("Adja meg egy tanuló betűjelét: ");
            char betuBe = char.Parse(Console.ReadLine().ToUpper());
            System.IO.StreamWriter sw = new System.IO.StreamWriter("egytanulo.txt");
            List<Tabor> egyDiak = new List<Tabor>();
            for (int i = 0; i < dataCamp.Count; i++)
            {
                if (dataCamp[i].diakok.ToString().Contains(betuBe))
                {
                    Tabor seged = new Tabor();
                    seged.kezdhonap = dataCamp[i].kezdhonap;
                    seged.kezdnap = dataCamp[i].kezdnap;
                    seged.veghonap = dataCamp[i].veghonap;
                    seged.vegnap = dataCamp[i].vegnap;
                    seged.tema = dataCamp[i].tema;
                    dataCamp.Add(seged);
                }
            }
            var rendezett = egyDiak.OrderBy(x => x.kezdhonap).ThenBy(x => x.kezdnap).ToList();
            foreach (var item in rendezett)
            {
                sw.WriteLine($"{item.kezdhonap}.{item.kezdnap}-{item.veghonap}.{item.vegnap}. {item.tema}");
            }
            sw.Close();
            bool ottTudLenni = true;
            int vegenap = 0;
            for (int i = 0; i < rendezett.Count; i++)
            {
                if (sorszam(rendezett[i].kezdhonap, rendezett[i].kezdnap) <= vegenap)
                {
                    ottTudLenni = false;
                }
                vegenap = sorszam(rendezett[i].kezdhonap, rendezett[i].kezdnap);

            }
            Console.WriteLine(ottTudLenni == false ? "Nem mehet el mindegyik táborba." : "Elmehet mindegyik táborba");
        }
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise6();
            Exercise7();
            Console.ReadKey();
        }
    }
}
