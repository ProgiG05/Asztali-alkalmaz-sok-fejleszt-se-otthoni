using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double a = 2.2;
            double b = 3.5;
            double c = 5.7;
            double avg = (a + b + c) / 3;
            Console.Write("Give me a number: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a: {a}\nb: {b}\nc: {c}");
            Console.WriteLine($"The average of the 3 numbers: {avg}\nAnd rounded to 2 decimals: {Math.Round(avg, 2)}");
            Console.WriteLine($"Value of pi,but with only 2 decimals: {Math.Round(Math.PI, 2)}");
            int r = 2;
            double area = 2 * r * Math.PI;
            Console.WriteLine($"Area of a circle:\nRadius: r = 2cm\nEquation: 2*r*pi\nResult: {Math.Round(area)}");
            Console.ReadKey();
        }
    }
}


