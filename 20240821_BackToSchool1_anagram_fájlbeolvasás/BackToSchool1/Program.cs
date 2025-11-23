using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackToSchool1
{
    class Program
    {
        static List<klassz> data = new List<klassz>();
        static void reading1()
        {
            StreamReader sr = new StreamReader("valami.txt");
            string elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                klassz seged = new klassz(egysor[0],egysor[1],Convert.ToInt32(egysor[2]),Convert.ToInt32(egysor[3]));
                data.Add(seged);
            }
        }
        static void reading2()
        {
            foreach (var item in File.ReadAllLines("valami.txt").Skip(1))
            {
                klassz seged = new klassz(item);
                data.Add(seged);
            }
        }
        static void anagram_solver(string word1,string word2)
        {
            List<char> wl1 = new List<char>();
            List<char> wl2 = new List<char>();
            while (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    wl1.Add(word1[i]);
                    wl2.Add(word2[i]);
                }
            }
            foreach (var item in wl1)
            {
                Console.WriteLine($"{item}");
            }
            foreach (var item in wl2)
            {
                Console.WriteLine($"{item}");
            }

            //bool d = false;
            //return d;
        }
        static void Main(string[] args)
        {
            Console.Write("Give me the first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Give me the second word: ");
            string word2 = Console.ReadLine();

            anagram_solver(word1,word2);
            Console.ReadKey();
        }
    }
}
