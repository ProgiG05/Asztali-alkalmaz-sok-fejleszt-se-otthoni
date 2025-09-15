using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_10
{
    class Program
    {
        //felsorolás enum
        enum viragok { tulipán,rózsa,szegfű,liliom}
        //felsorolás - első elem értékadás
        enum hetnapjai { hetfő = 1,kedd,szerda,csüti,péntek,szombat,vasárnap}
        //felsorolás - type shii
        enum jegyek { elégtelen,elégséges,közepes,jó,jeles}
        static void Main(string[] args)
        {
            Console.WriteLine("Felsorolás");

            Console.WriteLine((viragok)0);
            Console.WriteLine($"A felsorolás 2. eleme: { (viragok)1}");

            //érték átalakítása felsorolás elemére
            Console.WriteLine($"A {viragok.liliom}hoz tartozó érték: {(int)viragok.liliom}");

            viragok v = viragok.rózsa;
            Console.WriteLine(v);

            Console.WriteLine((hetnapjai)5);
            Console.WriteLine();

            //Enum.GetVAlues - egy tömböt add vissza,amelyben a felsorolás elemei vannak - tömbbé alakítás
            jegyek[] jegyekTömb = (jegyek[])Enum.GetValues(typeof(jegyek));
            foreach (var item in jegyekTömb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Enum.GetNames - karakterláncot add vissza
            string[] jegystrTömb = Enum.GetNames(typeof(jegyek));
            foreach (var item in jegystrTömb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Enum.GetName - egy elem lekérdezése
            Console.WriteLine(Enum.GetName(typeof(jegyek),1));

            ConsoleColor[] szinek = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Console.WriteLine("A szinek tömb tartalma");
            foreach (var item in szinek)
            {
                Console.WriteLine(item);//tab+space addolja item
            }

            int index = 0;
            while (index != szinek.Length - 1)
            {
                Console.BackgroundColor = szinek[index];
                Console.Clear();
                //if (index++ == szinek.Length-1)
                //{
                //    index = 0;
                //}
                index++;
            }

            jegyek jegy = jegyek.elégtelen;
            switch (jegy)
            {
                case jegyek.elégtelen:
                    Console.WriteLine("Egyes");
                    break;
                case jegyek.elégséges:
                    Console.WriteLine("Kettes");
                    break;
                case jegyek.közepes:
                    Console.WriteLine("Hármas");
                    break;
                case jegyek.jó:
                    Console.WriteLine("Négyes");
                    break;
                case jegyek.jeles:
                    Console.WriteLine("ötös");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
