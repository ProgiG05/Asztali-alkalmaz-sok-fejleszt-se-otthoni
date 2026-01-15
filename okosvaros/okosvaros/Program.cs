using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okosvaros
{
    class Program
    {
        static List<Jarmu> adatok = new List<Jarmu>();
        static void Main(string[] args)
        {
            try
            {
                System.IO.File.ReadAllLines("jarmuvek.txt").Skip(1).ToList().ForEach(x => 
                {
                    string[] egysor = x.Split(';');
                    if (egysor[1] == "autó")
                    {
                        adatok.Add(new Auto(egysor[0],egysor[1],Convert.ToInt32(egysor[2]), Convert.ToInt32(egysor[3]),egysor[4],Convert.ToInt32(egysor[5]), Convert.ToInt32(egysor[6])));
                    }
                    else if (egysor[1] == "busz")
                    {
                        adatok.Add(new Busz(egysor[0], egysor[1], Convert.ToInt32(egysor[2]), Convert.ToInt32(egysor[3]), Convert.ToInt32(egysor[4]), Convert.ToInt32(egysor[5])));
                    }
                    else if (egysor[1] == "kerékpár")
                    {
                        adatok.Add(new Kerekpar(egysor[0], egysor[1], Convert.ToInt32(egysor[2]), Convert.ToInt32(egysor[3]), egysor[4], Convert.ToInt32(egysor[5])));
                    }
                    else
                    {
                        throw new Exception("Nem sikerült bolvasni! ");
                    }
                });

                foreach (var item in adatok)
                {
                    Console.WriteLine(item.Leiras());
                }

                Console.WriteLine($"Összesen {adatok.Count()} jármű");
                Console.WriteLine($"Autók száma: {adatok.Where(x => x.Tipus == "autó").Count()}");
                Console.WriteLine($"Buszok száma: {adatok.Where(x => x.Tipus == "busz").Count()}");
                Console.WriteLine($"Kerékpárok száma: {adatok.Where(x => x.Tipus == "kerékpár").Count()}");
                Console.WriteLine($"Az összes jármű átlagsebessége: {adatok.Average(x => x.Sebesseg)}");
                Console.WriteLine($"Ennyi jármű rendelkezik legalább 4 férőhellyel: {adatok.Where(x => x.Ferohely >= 0).Count()}");
                List<Jarmu> elektronyosautok = new List<Jarmu>();;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
