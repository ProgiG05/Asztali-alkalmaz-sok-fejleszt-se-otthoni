using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250905_konyvek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Olvasmany olv1 = new Olvasmany("Minta olvasmány", "Minta Kálmán", 2025);
                olv1.Kiir();
                Olvasmany olv2 = new Olvasmany("Minta 1", "Minta János");
                olv2.Kiir();

                Konyv konyv1 = new Konyv("Légikisasszonyok", "Baurer Barbara", 2025, 268);
                konyv1.Kiir();
                Konyv konyv2 = new Konyv("A könyv címe", "Farkas György", 0, 300);
                konyv2.Kiir();

                Magazin magazin1 = new Magazin("Gramofon magazin", "Bencsik Gyula", 2020, 40, 5, "történelmi");
                magazin1.Kiir();
                Magazin magazin2 = new Magazin("Figyelő magazin", "Mong Attila", 2020, 20, 5, "történelmi");
                magazin2.Kiir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
