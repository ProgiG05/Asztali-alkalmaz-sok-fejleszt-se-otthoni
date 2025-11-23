using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_AbstraktOsztály
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alakzat a = new Alakzat();
            Kör k = new Kör(3);
            Console.WriteLine(k.Terulet());

            Téglalap t = new Téglalap(4,5);
            Console.WriteLine(t.Terulet());

            Console.WriteLine("#######################################################################");

            List<Allat> allatok = new List<Allat>
            {
                new Kutya("Ela",2,"Guszti"),
                new Cica("Stu",3)
            };
            foreach (var item in allatok)
            {
                Console.WriteLine($"{item.GetType().Name} {item.Nev} {item.Kor}");
                item.Eszik();
            }
            Console.WriteLine("#######################################################################");

            Console.ReadKey();
        }
    }
}
