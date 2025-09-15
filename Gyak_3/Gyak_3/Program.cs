using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.)
            Console.WriteLine("Melyik a nagyobb");
            System.Console.Write("Adj meg egy számot: ");
            double aa = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Adj meg egy számot: ");
            double bb = Convert.ToDouble(Console.ReadLine());
            if (aa > bb)
            {
                System.Console.WriteLine($"{aa} a nagyobb");
            }
            else
            {
                System.Console.WriteLine($"{bb} a nagyobb");

            }
            //9.)
            Console.WriteLine("3 szám közül melyik a legnagyobb");
            System.Console.Write("Adj meg egy számot: ");
            double x = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Adj meg egy számot: ");
            double y = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Adj meg egy számot: ");
            double z = Convert.ToDouble(Console.ReadLine());
            if (x > y && x > z)
            {
                System.Console.WriteLine($"{x} a legnagyobb");
            }
            else if (y > x && y > z)
            {
                System.Console.WriteLine($"{y} a legnagyobb");
            }
            else if (z > x && z > y)
            {
                System.Console.WriteLine($"{z} a legnagyobb");
            }
            //13.)
            Console.WriteLine("Nagysági sorrend 2 szám közt");
            System.Console.Write("Adj meg egy számot: ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Adj meg egy számot: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                System.Console.WriteLine($"{a},{b}");
            }
            else
            {
                System.Console.WriteLine($"{b},{a}");
            }
            //14.)
            Console.WriteLine("A/B");
            System.Console.Write("Add meg a neved: ");
            string nev = Convert.ToString(Console.Read());
            System.Console.Write("Adj meg egy betűt: ");
            char betu = Convert.ToChar(Console.Read());
            if (betu == 'a' || betu == 'A')
            {
                System.Console.WriteLine($"Heló {nev}");
            }
            else if (betu == 'b' || betu == 'B')
            {
                System.Console.WriteLine("Testtömegindex");
                System.Console.Write("Add meg a testsúlyod ");
                double suly = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Add meg a magasságod ");
                double mgs = Convert.ToDouble(Console.ReadLine());
                double tsti = Math.Pow(suly, 2) / mgs;
                System.Console.WriteLine($"A testtömegindexxed: {Math.Round(tsti, 2)}");
            }
            else
            {
                System.Console.WriteLine("Rossz betű\nPróbáld újra");
            }
            //15.)
            System.Console.Write("Add meg a víz hőmérsékletét: ");
            double hm = Convert.ToDouble(Console.Read());
            if (hm < 0)
            {
                System.Console.WriteLine("jég");
            }
            else if (hm > 0 || hm < 100)
            {
                System.Console.WriteLine("víz");
            }
            else if (hm > 100)
            {
                System.Console.WriteLine("gőz");
            }
            Console.ReadKey();
        }
    }
}
