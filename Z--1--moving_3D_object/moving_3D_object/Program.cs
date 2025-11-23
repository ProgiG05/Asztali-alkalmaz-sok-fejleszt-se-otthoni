using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moving_3D_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            List<string> simpleObject = new List<string>{};
            Console.Write("Give a character to make a line: ");
            string lineChar = Console.ReadLine();
            Console.Write("How long: ");
            int lineLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < lineLength; i++)
            {
                simpleObject.Add(lineChar);
            }
            Console.Write("Give a character to move: ");
            string movingChar = Console.ReadLine();
            int position = 0;
            for (int i = 0; i < simpleObject.Count; i++)
            {
                Console.Clear();
                simpleObject[position] = movingChar;
                Console.WriteLine(string.Join("", simpleObject));
                simpleObject[position] = lineChar;
                position++;
                System.Threading.Thread.Sleep(300);
            }
            Console.ReadKey();
        }
    }
}
