using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(+)(-)(*)(/)");
            Console.WriteLine("kilépés = 'k'");
            Console.Write("Melyik műveletet akarod elvégezni? ");
            char müv = Convert.ToChar(Console.ReadLine());
            do
            {
                Console.WriteLine("(+)(-)(*)(/)");
                Console.WriteLine("kilépés = 'k'");
                Console.Write("Melyik műveletet akarod elvégezni? ");
                müv = Convert.ToChar(Console.ReadLine());
                switch (müv)
                {
                    case '+':
                        Console.Clear();
                        Console.Write("Adj meg egy számot: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Adj meg még egy számot: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        double egyenlet = Összeadás(x, y);
                        Console.WriteLine($"Az eredmény: {egyenlet}");
                        break;
                    case '-':
                        Console.Clear();
                        Console.Write("Adj meg egy számot: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Adj meg még egy számot: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        egyenlet = Kivonás(x, y);
                        Console.WriteLine($"Az eredmény: {egyenlet}");
                        break;
                    case '*':
                        Console.Clear();
                        Console.Write("Adj meg egy számot: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Adj meg még egy számot: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        egyenlet = Szorzás(x, y);
                        Console.WriteLine($"Az eredmény: {egyenlet}");
                        break;
                    case '/':
                        Console.Clear();
                        Console.Write("Adj meg egy számot: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Adj meg még egy számot: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        egyenlet = Osztás(x, y);
                        Console.WriteLine($"Az eredmény: {egyenlet}");
                        break;
                    default:
                        break;
                }

            } while (müv != 'k');


        }
        static int Összeadás(int x, int y)
        {
            return x + y;
        }
        static int Kivonás(int x, int y)
        {
            if (x > y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }
        static int Szorzás(int x, int y)
        {
            return x * y;
        }
        static int Osztás(int x, int y)
        {
            if (x>y)
            {
                return x / y;
            }
            else
            {
                return y / x;
            }
            
        }
    }
}
