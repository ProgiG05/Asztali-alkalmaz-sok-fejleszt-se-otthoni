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
                olv1.Kora();
                Olvasmany olv2 = new Olvasmany("Minta 1", "Minta János");
                olv2.Kiir();
                olv2.Kora();

                Konyv konyv1 = new Konyv("Légikisasszonyok", "Baurer Barbara", 2025, 268);
                konyv1.Kiir();
                konyv1.Kora();
                Konyv konyv2 = new Konyv("A könyv címe", "Farkas György", 0, 300);
                konyv2.Kiir();
                konyv2.Kora();

                Magazin magazin1 = new Magazin("Gramofon magazin", "Bencsik Gyula", 2020, 40, 5, "történelmi");
                magazin1.Kiir();
                magazin1.Kora();
                Magazin magazin2 = new Magazin("Figyelő magazin", "Mong Attila", 2020, 20, 5, "történelmi");
                magazin2.Kiir();
                magazin2.Kora();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
