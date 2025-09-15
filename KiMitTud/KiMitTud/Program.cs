using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KiMitTud
{
    class Program
    {
        static List<Verseny> adatok = new List<Verseny>();
        static void beolvas()
        {
            foreach (var item in File.ReadAllLines("selejtezo.txt"))
            {
                Verseny sor = new Verseny(item);
                adatok.Add(sor);
            }
            //Console.WriteLine("A fájl beolvasása megtörtént!");
        }
        static void kérem()
        {
            double összeg = 0;
            Console.WriteLine("6. feladat: Kérem egy zsűritag sorszámát [1...6]: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            if (sorszam > 0 && sorszam < 7)
            {
                for (int i = 0; i < adatok.Count; i++)
                {

                }
            }
            else
            {
                Console.WriteLine($"Nincs {sorszam}. számú zsűritag!");
            }
        }
        static int Osszes(int egy, int ketto, int harom, int negy, int ot, int hat)
        {
            return egy + ketto + harom + negy + ot + hat;
        }
        static void legtöbb_atlagalatt()
        {
            StreamWriter sw = new StreamWriter("atlagalatt.txt");
            int max = 0;
            int maxi = 0;
            List<int> pontok = new List<int>();
            List<double> átlagok = new List<double>();
            double összes = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                pontok.Add(Osszes(adatok[i].zs1, adatok[i].zs2, adatok[i].zs3, adatok[i].zs4, adatok[i].zs5, adatok[i].zs6));
                összes += Osszes(adatok[i].zs1, adatok[i].zs2, adatok[i].zs3, adatok[i].zs4, adatok[i].zs5, adatok[i].zs6);
                átlagok.Add(Osszes(adatok[i].zs1, adatok[i].zs2, adatok[i].zs3, adatok[i].zs4, adatok[i].zs5, adatok[i].zs6) / 6);
            }
            max = pontok.Max();
            for (int i = 0; i < pontok.Count; i++)
            {
                if (pontok[i] == max)
                {
                    i = maxi;
                }
            }
            double átlag = összes / adatok.Count;
            Console.WriteLine($"8. feladat: A legmagasabb pontszámot ekérő versenyző:\n\tVersenyző neve: {adatok[maxi].nev}\tPontszáma:{max}");
            Console.WriteLine($"9. feladat:\nAz összes versenyző összpontszáma: {összes}\nAz átlagos pontszám: {Math.Round(átlag,2)}");
            Console.WriteLine("Az átlag alatt teljesítők:");
            Console.WriteLine("\tNév     Elért pontszám");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (pontok[i] < átlag)
                {
                    Console.WriteLine($"\t{adatok[i].nev} {pontok[i]} pont");
                }
            }
            sw.Write("Az átlag alatt teljesítők:");
            sw.Write("\tNév     Elért pontszám");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (pontok[i] < átlag)
                {
                    sw.Write($"\t{adatok[i].nev} {pontok[i]} pont");
                }
            }
            Console.WriteLine("Az adatok állományba írása megtörtént.");
        }
        static void Main(string[] args)
        {
            beolvas();
            Console.WriteLine($"5. feladat: A versenyen {adatok.Count()} versenyző vett részt.");
            legtöbb_atlagalatt();
            Console.ReadKey();
        }
    }
}
