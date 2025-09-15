using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Kérek egy számot: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kérek még egy számot: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Oszthato(a, b);

            Console.WriteLine(oszthato() ? "A két szám osztható" : "A két szám nem osztható");
            Fibo();
            Kiiras();
            Console.WriteLine();
            Feltolt();
            Kiiras();
            Console.WriteLine();
            Darab();
            Console.WriteLine();
            Legek();
            Console.WriteLine();
            Szoveg();
            Console.ReadKey();
        }
        static void Oszthato(int a, int b)
        {
            if (a % b == 0)
            {
                Console.WriteLine("Az első osztható a másodikkal");
            }
            else
            {
                Console.WriteLine("Az első nem osztható a másodikkal");
            }
        }
        static bool oszthato()
        {
            Console.Write("Kérek egy számot: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek még egy számot: ");
            int B = Convert.ToInt32(Console.ReadLine());
            bool igaz = false;
            if (A % B == 0)
            {
                igaz = true;
            }
            else
            {
                igaz = false;
            }
            return igaz;
        }
        static List<int> fibo = new List<int>();
        static Random rnd = new Random();
        static void Fibo()
        {
            int prev = 0;
            int next = 1;
            fibo.Add(prev);
            fibo.Add(next);
            for (int i = 0; i < 20; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
                fibo.Add(next);
            }
        }
        static void Kiiras()
        {
            foreach (var item in fibo)
            {
                Console.Write($"{item} ");
            }
        }
        static void Feltolt()
        {
            for (int i = 0; i < 20; i++)
            {
                fibo.Add(rnd.Next(10, 100));
            }
        }
        static void Darab()
        {
            int sum = fibo.Sum();
            int db = fibo.Count();
            double avg = sum / db;
            Math.Round(avg, 0);
            int dbb = 0;
            List<int> nagyobb = new List<int>();
            for (int i = 0; i < fibo.Count; i++)
            {
                if (fibo[i] > avg)
                {
                    nagyobb.Add(fibo[i]);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Az átlag: {avg}");
            Console.WriteLine($"Az átlagnál nagyobb számok darabja: {nagyobb.Count}");
        }
        static void Legek()
        {
            Console.WriteLine($"A lista legnagyobb eleme: {fibo.Max()} és az indexe: {fibo.IndexOf(fibo.Max())}");
            Console.WriteLine($"A lista legkisebb eleme: {fibo.Min()} és az indexe: {fibo.IndexOf(fibo.Min())}");
        }
        static void Szoveg()
        {
            Console.Write("Adj meg egy mondatot: ");
            string mondat = Console.ReadLine();
            mondat.Split();
            mondat.Reverse();
            foreach (var item in mondat)
            {
                Console.Write(item);
            }
        }
    }
    
}
