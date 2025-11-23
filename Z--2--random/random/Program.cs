using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace random
{
    class Program
    {
        static List<random> adatok = new List<random>();
        static void beolvasas()
        {
            StreamReader sr = new StreamReader("kolcsonzesek.txt");
            string firstline = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                random seged = new random(egysor[0], egysor[1], Convert.ToInt32(egysor[2]), Convert.ToInt32(egysor[3]), Convert.ToInt32(egysor[4]),Convert.ToInt32(egysor[5]));
                adatok.Add(seged);
            }
            sr.Close();
            Console.WriteLine("A beolvasás megtörtént!");
        }
        static void kiíras()
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                Console.WriteLine($"{adatok[i].nev}: {adatok[i].jarmuAz} - {adatok[i].elvora}:{adatok[i].elvperc} - {adatok[i].vora}:{adatok[i].vperc}");
            }
        }
        static void Main(string[] args)
        {
            beolvasas();
            kiíras();
            Console.ReadKey();
        }
    }
}
