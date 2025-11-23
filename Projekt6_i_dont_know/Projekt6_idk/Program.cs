using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt6_idk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Console.WriteLine("Halo");
            Random rnd = new Random();
            List<int> randomszamok = new List<int>();
            for (int i = 0; i < randomszamok.Count; i++)
            {
                randomszamok[i] = rnd.Next(1,20);
            }
            foreach (var item in randomszamok)
            {
                Console.WriteLine(item);
            }
            Dictionary<int, int> stat = new Dictionary<int, int>();
            for (int i = 0; i < randomszamok.Count; i++)
            {
                if (stat.ContainsKey(randomszamok[i]))
                {
                    randomszamok[stat[i]]++;
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
