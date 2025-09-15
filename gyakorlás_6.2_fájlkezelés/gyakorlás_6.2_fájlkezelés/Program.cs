using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyakorlás_6._2_fájlkezelés
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("jatekok.txt");   
            string[] játékNeve = new string[30];
            int[] mennyiség = new int[30];
            int[] ár = new int[30];
            string[] egysor = new string[3];
            int index = 0;
            while (!sr.EndOfStream)
            {
                egysor = sr.ReadLine().Split(' ');
                játékNeve[index] = egysor[0];
                mennyiség[index] = Convert.ToInt32(egysor[1]);
                ár[index] = Convert.ToInt32(egysor[2]);
                index++;
            }
            sr.Close();
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"A játékboltban {index} féle játék található");
            Console.WriteLine();
            int legtöbb = mennyiség.Max();
            for (int i = 0; i < index; i++)
            {
                if (legtöbb == mennyiség[i])
                {
                    Console.WriteLine("4. feladat:");
                    Console.WriteLine($"A {játékNeve[i]} nevű játékból {legtöbb} db található a raktárban.");
                }
            }
            Console.WriteLine();
            int józsi = 2500000;
            int össz = ár.Sum();
            if (össz>józsi)
            {
                Console.WriteLine($"5. feladat \nA teljes árukészlet {össz} Ft - ba kerül, \nígy Jószi bácsinak nincs elegendő pénze a játékok megvásárlásához.");
            }
            else
            {
                Console.WriteLine($"5.feladat \nA teljes árukészlet {össz} Ft-ba kerül, \nígy Jószi bácsinak {józsi-össz} Ft - ja marad a nyereményéből.");
            }
            Console.WriteLine();
            Console.WriteLine("6.feladat:");
            for (int i = 0; i < index; i++)
            {
                int képlet = mennyiség[i] * ár[i];
                Console.WriteLine($"{játékNeve[i]} {képlet}Ft");
            }
            StreamWriter sw = new StreamWriter("bevetel.txt");
            sw.WriteLine("6.feladat:");
            for (int i = 0; i < index; i++)
            {
                int képlet = mennyiség[i] * ár[i];
                sw.WriteLine($"{játékNeve[i]} {képlet}Ft");
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
