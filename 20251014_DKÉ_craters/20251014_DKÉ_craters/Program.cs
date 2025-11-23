using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251014_DKÉ_craters
{
    internal class Program
    {
        public static List<craters> craterData = new List<craters>();

        static public void Exercise1()
        {
            System.IO.File.ReadAllLines("surface_dcomma.txt", Encoding.UTF8).ToList().ForEach(x => craterData.Add(new craters(x)));
        }
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise6();
            Exercise7();
            Exercise8();
            Console.ReadKey();
            
        }
        static public void Exercise2()
        {
            Console.WriteLine("Exercise 2.");
            Console.WriteLine($"The number of craters: {craterData.Count()}");
        }
        static public void Exercise3()
        {
            Console.WriteLine("Exercise 3.");
            Console.Write("Enter the name of a crater: ");
            string craterName = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < craterData.Count; i++)
            {
                if (craterData[i].name == craterName)
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"The centre of {craterName} is X={craterData.Where(x => x.name == craterName).First().x} Y={craterData.Where(x => x.name == craterName).First().y} and its radius is R={craterData.Where(x => x.name == craterName).First().radius}. ");
            }
            else
            {
                Console.WriteLine("No crater with such name.");
            }
        }
        static public void Exercise4()
        {
            Console.WriteLine("Exercise 4.");
            double maxRadius = craterData.Max(x => x.radius);
            for (int i = 0; i < craterData.Count; i++)
            {
                if (craterData[i].radius == maxRadius)
                {
                    Console.WriteLine($"The name and the radius of the biggest crater: {craterData[i].name} {maxRadius}");
                }
            }

        }
        //Exercise 5
        static public double Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        static public void Exercise6()
        {
            Console.WriteLine("Exercise 6.");
            Console.Write("Enter the name of a crater: ");
            string givenName = Console.ReadLine();
            double givenX = craterData.Where(x => x.name == givenName).First().x;
            double givenY = craterData.Where(x => x.name == givenName).First().y;
            double givenR = craterData.Where(x => x.name == givenName).First().radius; 
            
            List<string> result = new List<string>();

            for (int i = 0; i < craterData.Count; i++)
            {
                if (Distance(givenX, craterData[i].x, givenY, craterData[i].y) > givenR + craterData[i].radius)
                {
                    result.Add(craterData[i].name);
                }
            }

            if (result.Count > 0)
            {
                Console.Write("No common part with: ");
                result.ForEach(x => Console.Write($"{x}, "));
            }

        }
        static public void Exercise7()
        {
            Console.WriteLine("Exercise 7.");

            for (int i = 0; i < craterData.Count; i++)
            {
                for (int j = i + 1; j < craterData.Count; j++)
                {
                    if (Distance(craterData[i].x, craterData[j].x, craterData[i].y, craterData[j].y) < craterData[i].radius - craterData[j].radius)
                    {
                        Console.WriteLine($"{craterData[i].name} contains crater {craterData[j].name}");
                    }
                }
            }
        }
        static public void Exercise8()
        {
            Console.WriteLine("Exercise 8.");
            System.IO.StreamWriter sw = new System.IO.StreamWriter("area.txt");
            craterData.ToList().ForEach(x => sw.WriteLine($"{Math.Round(Math.Pow(x.radius,2) * Math.PI,2)} {x.name}"));
            sw.Close();
        }
    }
}
