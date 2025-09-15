using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Console.WriteLine("Halo");
            Random rnd = new Random();
            int[] randomszamok = new int[20];
            for (int i = 0; i < randomszamok.Length; i++)
            {
                randomszamok[i] = rnd.Next(20);
            }
            Array.Sort(randomszamok);
            Dictionary<int, int> stat = new Dictionary<int, int>();
            for (int i = 0; i < randomszamok.Length; i++)
            {
                if (stat.ContainsKey(randomszamok[i]))
                {
                    stat[randomszamok[i]]++;
                }
                else
                {
                    stat.Add(randomszamok[i], 1);
                }
            }
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Key} - {item.Value}db");
            }
            Console.ReadKey();
        }
    }
}
