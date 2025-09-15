using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name1 = Convert.ToString(Console.ReadLine());
            Console.Write("How old are you: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Hello(name1, age1);

            string[] names = { "Jake", "Finn", "BMO", "Marceline", "Flame Princess", "Bubblegum Princess", "Ice King" };
            foreach (var nm in names)
            {
                Greeting(nm);
            }

            Feladat2();
            Feladat3();

            Console.ReadKey();
        }
        static void Hello(string név, int kor)
        {
            Console.WriteLine($"Hello {név}");
            Console.WriteLine($"You are {kor} years old");
        }
        static void Greeting(string character)
        {
            Console.WriteLine($"Hello {character} from Advanture time");
        }
        static void Feladat2()
        {
            for (int i = 100; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Feladat3()
        {
            Console.Write("Meddig: ");
            int ig = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            for (int i = 0; i < ig+1; i++)
            {
                osszeg = osszeg + i;
            }
            Console.WriteLine($"N számig a számok összege: {osszeg}");
        }


    }
}
