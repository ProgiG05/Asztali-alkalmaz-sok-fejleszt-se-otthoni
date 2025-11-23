using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251015_DKÉ_reklam
{
    internal class Program
    {
        static List<Reklam> advData = new List<Reklam>();
        static void Feladat1()
        {
            System.IO.File.ReadAllLines("rendel.txt").ToList().ForEach(x => advData.Add(new Reklam(x)));
        }
        static void Feladat2() 
        { 
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"A rendelések száma: {advData.Count}");
        }
        static void Feladat3() 
        {
            Console.WriteLine("3. feladat:");
            Console.Write("Kérem adjon meg egy napot: ");
            int givenDay = int.Parse(Console.ReadLine());
            Console.WriteLine($"A rendelések száma az adott napon: {advData.Where(x => x.rendelesNap == givenDay).Sum(x => x.db)}");
        }
        static void Feladat4()
        {
            Console.WriteLine("4. feladat:");
            int noCityCount = 0;
            for (int i = 0; i < advData.Count; i++)
            {
                if (advData[i].varos == "NR" && advData[i].db == 0)
                {
                    noCityCount++;
                }
            }
            if (noCityCount == 0)
            {
                Console.WriteLine("Minden nap volt rendelés a reklámban nem érintett városból");
            }
            else
            {
                Console.WriteLine($"{noCityCount} nap nem volt a reklámban nem érintett városból rendelés");
            }
        }
        static void Feladat5()
        {
            Console.WriteLine("5. feladat:");
            Console.WriteLine($"A legnagyobb darabszám: {advData.Max(x => x.db)}, a rendelés napja: {advData.First(x => x.db == advData.Max(y => y.db)).rendelesNap}");
        }
        //Feladat6
        static int osszes(string cityIn, int dayIn)
        {
            return advData.Where(x => x.varos == cityIn && x.rendelesNap == dayIn).Sum(x => x.db);
        }
        static void Feladat7()
        {
            Console.WriteLine("7. feladat:");
            Console.WriteLine($"A rendelt termékek darabszáma a 21. napon PL: {osszes("PL",21)} TV: {osszes("TV", 21)} NR: {osszes("NR", 21)}");
        }
        static void Feladat8()
        {
            Console.WriteLine("8. feladat:");
            Console.WriteLine("Napok\t1..10\t11..20\t21..30");
            Console.WriteLine($"PL\t{advData.Where(x => x.varos == "PL" && x.rendelesNap > 1 && x.rendelesNap < 10).Sum(y => y.db)}\t{advData.Where(x => x.varos == "PL" && x.rendelesNap > 11 && x.rendelesNap < 20).Sum(y => y.db)}\t{advData.Where(x => x.varos == "PL" && x.rendelesNap > 21 && x.rendelesNap < 30).Sum(y => y.db)}");
            Console.WriteLine($"TV\t{advData.Where(x => x.varos == "TV" && x.rendelesNap > 1 && x.rendelesNap < 10).Sum(y => y.db)}\t{advData.Where(x => x.varos == "TV" && x.rendelesNap > 11 && x.rendelesNap < 20).Sum(y => y.db)}\t{advData.Where(x => x.varos == "TV" && x.rendelesNap > 21 && x.rendelesNap < 30).Sum(y => y.db)}");
            Console.WriteLine($"NR\t{advData.Where(x => x.varos == "NR" && x.rendelesNap > 1 && x.rendelesNap < 10).Sum(y => y.db)}\t{advData.Where(x => x.varos == "NR" && x.rendelesNap > 11 && x.rendelesNap < 20).Sum(y => y.db)}\t{advData.Where(x => x.varos == "NR" && x.rendelesNap > 21 && x.rendelesNap < 30).Sum(y => y.db)}");
            System.IO.StreamWriter sw = new System.IO.StreamWriter("kampany.txt");
            sw.WriteLine("Napok\t1..10\t11..20\t21..30");
            sw.WriteLine($"PL\t{advData.Where(x => x.varos == "PL" && x.rendelesNap > 1 && x.rendelesNap < 10).Sum(y => y.db)}\t{advData.Where(x => x.varos == "PL" && x.rendelesNap > 11 && x.rendelesNap < 20).Sum(y => y.db)}\t{advData.Where(x => x.varos == "PL" && x.rendelesNap > 21 && x.rendelesNap < 30).Sum(y => y.db)}");
            sw.WriteLine($"TV\t{advData.Where(x => x.varos == "TV" && x.rendelesNap > 1 && x.rendelesNap < 10).Sum(y => y.db)}\t{advData.Where(x => x.varos == "TV" && x.rendelesNap > 11 && x.rendelesNap < 20).Sum(y => y.db)}\t{advData.Where(x => x.varos == "TV" && x.rendelesNap > 21 && x.rendelesNap < 30).Sum(y => y.db)}");
            sw.WriteLine($"NR\t{advData.Where(x => x.varos == "NR" && x.rendelesNap > 1 && x.rendelesNap < 10).Sum(y => y.db)}\t{advData.Where(x => x.varos == "NR" && x.rendelesNap > 11 && x.rendelesNap < 20).Sum(y => y.db)}\t{advData.Where(x => x.varos == "NR" && x.rendelesNap > 21 && x.rendelesNap < 30).Sum(y => y.db)}");
            sw.Close();
        }
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat7();
            Feladat8();
            Console.ReadKey();
        }
    }
}
