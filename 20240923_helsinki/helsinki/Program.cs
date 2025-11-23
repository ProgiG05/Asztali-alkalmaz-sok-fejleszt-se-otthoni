using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki
{
    class Program
    {
        static List<helsinki> data = new List<helsinki>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("helsinki.txt").ToList().ForEach(x => data.Add(new helsinki(x)));
            Console.WriteLine($"3. feladat: Pontszerző versenyzők száma: {data.Count}");

            Console.WriteLine($"Arany: {data.Where(x => x.helyezes == 1).Count()}");
            Console.WriteLine($"Ezüst: {data.Where(x => x.helyezes == 2).Count()}");
            Console.WriteLine($"Bronz: {data.Where(x => x.helyezes == 3).Count()}");
            Console.WriteLine($"Olimpiai pontok száma: {data.Sum(x => x.pontozas)}");

            int uszas = data.Where(x => x.ágnev == "uszas" && x.helyezes < 4).Count();
            int torna = data.Where(x => x.ágnev == "torna" && x.helyezes < 4).Count();

            if (uszas > torna)
            {
                Console.WriteLine("Több az uszas");
            }
            else if (uszas < torna)
            {
                Console.WriteLine("Több a torna");
            }
            else if (uszas == torna)
            {
                Console.WriteLine("Egyenlő");
            }

            System.IO.StreamWriter sw = new System.IO.StreamWriter("helsinki2.txt");
            data.ForEach(x => sw.WriteLine($"{x.helyezes} {x.ágnev} {x.versenynev} {x.sportoloszam}"));
            sw.Close();

            var legtöbb = data.Where(x => x.helyezes < 4).OrderBy(x => x.sportoloszam).Last();
            Console.WriteLine($"Helyezés: {legtöbb.helyezes}\nSportág: {legtöbb.ágnev}\nVersenyszám: {legtöbb.versenynev}\nSportolók Száma: {legtöbb.sportoloszam}");

            Console.ReadKey();
        }
    }
}
