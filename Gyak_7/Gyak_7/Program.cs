using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Give me a number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give me a number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x % y;
                Console.Write(z);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers!");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            //catch(Exception e)
            //{
            //    Console.WriteLine("Something went wrong!");
            //}

            Console.ReadKey();
        }
    }
}
