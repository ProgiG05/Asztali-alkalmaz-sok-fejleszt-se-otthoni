using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat:");
            Console.Write("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam < 0 || szam > 100)
            {
                Console.WriteLine("Hibaüzi");
            }
            else
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine("A szám páros");
                }
                else
                {
                    Console.WriteLine("A szám páratlan");
                }
            }


            Console.WriteLine("2. feladat:");
            int[] szamok = new int[] { 10 };
            int összeg = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Adj meg egy számot: ");
                int x = Convert.ToInt32(Console.ReadLine());
                összeg = összeg + x;
                szamok = szamok.Append(x).ToArray();
            }
            Console.WriteLine($"A számok összege: {összeg}");
            Console.WriteLine($"A számok átlaga: {összeg / 10}");
            int[] harom = new int[] { };
            foreach (var item in szamok)
            {
                if (item % 3 == 0)
                {
                    harom = harom.Append(item).ToArray();
                }
            }
            foreach (var i in harom)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine("3. feladat:");
            int tól = 0;
            int ig = 100;
            int[] tömb = new int[] { 10 };
            Random RND = new Random();
            for (int i = 0; i < 10; i++)
            {
                tömb = tömb.Append(RND.Next(tól, ig)).ToArray();
            }
            foreach (var item in tömb)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            int elso = tömb[0];
            int uccso = tömb[10];
            Console.WriteLine($"A tömb első eleme: {elso}");
            Console.WriteLine($"A tömb utolsó eleme: {uccso}");


            Console.WriteLine("(Extra)");
            Console.WriteLine("Faktoriális");
            Console.Write("Adj meg egy számot: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[] fakt = new int[] { };
            for (int i = 1; i < y + 1; i++)
            {
                fakt = fakt.Append(i).ToArray();
            }
            int prod = 1;
            foreach (var item in fakt)
            {
                prod *= item;
            }
            Console.WriteLine(prod);

            Console.WriteLine("5.feladat: ");
            int tóll = 0;
            int igg = 100;
            int[] nums = new int[] { 100 };
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                nums = nums.Append(rnd.Next(tóll, igg)).ToArray();
            }
            int[] paros = new int[] { };
            int[] paratlan = new int[] { };
            int prodd = 1;
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    paros = paros.Append(item).ToArray();
                }
                else
                {
                    paratlan = paratlan.Append(item).ToArray();
                }
            }
            foreach (var item in nums)
            {
                prodd += item;
            }
            Console.WriteLine($"Számok összege: {prodd}");
            Console.Write("Páros számok: ");
            foreach (var item in paros)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            Console.Write("Páratlan számok: ");
            foreach (var item in paratlan)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
