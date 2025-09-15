using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.)

            System.Console.WriteLine("Adj meg egy számot: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                System.Console.WriteLine("pozitív");
            }
            else if (x == 0)
            {
                System.Console.WriteLine("nulla");
            }
            else
            {
                System.Console.WriteLine("negatív");
            }

            //2.)

            System.Console.WriteLine("Haromszog kiszamitasa");
            System.Console.WriteLine("Add meg az a oldalt: ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Add meg a b oldalt: ");
            double b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Add meg a c oldalt: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                System.Console.WriteLine("Derékszögű");
            }
            else
            {
                System.Console.WriteLine("Nem derékszögű");
            }
            //nem bizti hogy jo xd

            //3.)

            System.Console.WriteLine("Adj meg egy számot: ");
            double y = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Adj meg egy számot: ");
            double z = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine($"A két szám összege: {y + z}");
            System.Console.WriteLine($"A két szám átlaga: {(y + z) / 2}");
            //System.Console.WriteLine($"A két szám különbsége: {y-z}");
            if (y < z)
            {
                System.Console.WriteLine($"A két szám különbsége: {z - y}");
            }
            else
            {
                System.Console.WriteLine($"A két szám különbsége: {y - z}");
            }
            System.Console.WriteLine($"A két szám szorzata: {(y + z) / 2}");
            //System.Console.WriteLine($"A két szám hányadosa: {y/z}");
            if (y < z)
            {
                System.Console.WriteLine($"A két szám hányadosa: {z / y}");
            }
            else
            {
                System.Console.WriteLine($"A két szám hányadosa: {y / z}");
            }

            //5.)

            System.Console.WriteLine("Adj meg egy számot: ");
            double tk = Convert.ToDouble(Console.ReadLine());
            if (tk > -20 && tk < 40)
            {
                System.Console.WriteLine("Téglalap kerülete\n(2*a)+(2*b)");
                System.Console.WriteLine("Mennyi legyen az a oldal: ");
                double aa = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Mennyi legyen a b oldal: ");
                double bb = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"Kerület: {(2 * aa) + (2 * bb)}");
            }
            else
            {
                System.Console.WriteLine("Téglalap területe\n2*(a+b)");
                System.Console.WriteLine("Mennyi legyen az a oldal: ");
                double aa = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Mennyi legyen a b oldal: ");
                double bb = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"Terület: {2 * (a + b)}");
            }

            //6.)

            System.Console.WriteLine("Adj meg egy számot: ");
            double xx = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Adj meg egy számot: ");
            double yy = Convert.ToDouble(Console.ReadLine());
            if (xx == yy)
            {
                System.Console.WriteLine("A számok egyenlőek");
            }
            else
            {
                if (xx > yy)
                {
                    System.Console.WriteLine($"A nagyobb szám 2-vel osztva: {xx / 2}");
                    System.Console.WriteLine($"A kisebbik szám 3-mal osztva: {yy / 3}");
                }
                else
                {
                    System.Console.WriteLine($"A nagyobb szám 2-vel osztva: {yy / 2}");
                    System.Console.WriteLine($"A kisebbik szám 3-mal osztva: {xx / 3}");
                }
            }

            //7.)

            System.Console.WriteLine("Mondj egy számot aztán eldöntöm hogy páros vagy páratlan! ");
            double pp = Convert.ToDouble(Console.ReadLine());
            if (pp / 2 == 0)
            {
                System.Console.WriteLine("Páros");
            }
            else
            {
                System.Console.WriteLine("Páratlan");
            }
            Console.ReadLine();
        }
    }
}
