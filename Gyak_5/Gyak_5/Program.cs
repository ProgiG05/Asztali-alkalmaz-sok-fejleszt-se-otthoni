using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = {"egy","kettő"};
            int[] nums = { 1, 2 };
            double[] szamok = {3,4};
            foreach (var szo in szavak)
            {
                Console.Write($"{szo} ");
            }
            Console.WriteLine("");

            int száz = 0;
            int szamlalo = 0;
            int paros = 0;
            int paratlan = 0;
            do
            {
                Console.Write("Adj meg egy számot: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x % 3 == 0)
                {
                    Console.WriteLine($"Négyzet: {Math.Pow(x, 2)}");
                    száz = száz + x;
                }
                else
                {
                    continue;
                }
                if (x % 2 == 0)
                {
                    paros = paros + x;
                    száz = száz + x;
                }
                else
                {
                    paratlan = paratlan + x;
                    száz = száz + x;
                }
                száz = száz + x;
                szamlalo = szamlalo + 1;

            } while (száz < 100);
            Console.WriteLine($"{szamlalo}db számot olvastunk be");
            Console.WriteLine($"A beolvasott számok átlaga: {száz / szamlalo}");
            Console.WriteLine($"A párosak öszege: {paros} és a páratlanok öszege: {paratlan}");
            Console.WriteLine($"A párosak és páratlanok összege: {paros + paratlan}");


            Console.Write("What day is today: ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday" :
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
            }

            Console.Write("Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{ch} ");
                }
                Console.WriteLine("");
            }
           



            Console.ReadKey();
        }
    }
}
