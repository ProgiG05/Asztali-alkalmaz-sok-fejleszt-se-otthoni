using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Válassz melyik műveletet akarad megcsinálni:(1-4): ");
            int szam = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (szam == 1)
                {
                    Console.WriteLine("A négyzet kerülete: 4 * a");
                    Console.Write("Szertnél példát?(Y/N): ");
                    char choice = Convert.ToChar(Console.ReadLine());
                    switch (choice)
                    {
                        case 'Y':
                            Console.Write("Add meg a négyzet oldalát: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            NégyzetKer(a);
                            break;
                        case 'y':
                            Console.Write("Add meg a négyzet oldalát: ");
                            int aa = Convert.ToInt32(Console.ReadLine());
                            NégyzetKer(aa);
                            break;
                        case 'N':
                            break;
                        case 'n':
                            break;
                    }
                }
                else if (szam == 2)
                {
                    Console.WriteLine("A téglalap kerölete: 2 * a + 2 * b");
                    Console.Write("Szertnél példát?(Y/N): ");
                    char choice = Convert.ToChar(Console.ReadLine());
                    switch (choice)
                    {
                        case 'Y':
                            Console.Write("Add meg a téglalap egyik oldalát: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Add meg a téglalap másik oldalát: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            TéglalapKer(a,b);
                            break;
                        case 'y':
                            Console.Write("Add meg a téglalap egyik oldalát: ");
                            int aa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Add meg a téglalap másik oldalát: ");
                            int bb = Convert.ToInt32(Console.ReadLine());
                            TéglalapKer(aa,bb);
                            break;
                        case 'N':
                            break;
                        case 'n':
                            break;
                    }
                }
                else if (szam == 3)
                {
                    Console.WriteLine("A kör kerülete: 2 * r * pi");
                    Console.Write("Szertnél példát?(Y/N): ");
                    char choice = Convert.ToChar(Console.ReadLine());
                    switch (choice)
                    {
                        case 'Y':
                            Console.Write("Add meg a kör sugarát: ");
                            int r = Convert.ToInt32(Console.ReadLine());
                            KörKer(r);
                            break;
                        case 'y':
                            Console.Write("Add meg a kör sugarát: ");
                            int rr = Convert.ToInt32(Console.ReadLine());
                            KörKer(rr);
                            break;
                        case 'N':
                            break;
                        case 'n':
                            break;
                    }
                }
            } while (szam == 4);
            Console.WriteLine("Viszlát!");
            Random rnd = new Random();
            int titok = rnd.Next(1, 100);
            int tippszam = 0;
            Console.WriteLine("Gondoltam egy számra!");
            Console.Write("Találd ki! ");
            int tipp = Convert.ToInt32(Console.ReadLine());
            while (tipp != titok)
            {
                Console.Write("Találd ki! ");
                tipp = Convert.ToInt32(Console.ReadLine());
                if (tipp > titok)
                {
                    if (tipp - titok == 3)
                    {
                        Console.WriteLine($"A gondolt szám kisebb mint {tipp}\nDe már nagyon közel jársz!");
                        tippszam = tippszam + 1;
                    }
                    else
                    {
                        Console.WriteLine($"A gondolt szám kisebb mint {tipp}");
                        tippszam = tippszam + 1;
                    }

                }
                else
                {
                    if (titok - tipp == 3)
                    {
                        Console.WriteLine($"A gondolt szám nagyobb mint {tipp}\nDe már nagyon közel jársz!");
                        tippszam = tippszam + 1;
                    }
                    else
                    {
                        Console.WriteLine($"A gondolt szám nagyobb mint {tipp}");
                        tippszam = tippszam + 1;
                    }
                }
            }
            string[] csillagok1 = { };
            string[] csillagok12 = { };
            for (int i = 0; i < tippszam; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
            Console.WriteLine("Sikeresen eltaláltad!");
            for (int i = 0; i < tippszam; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Tippek száma: {tippszam}");

            int[] tömb = new int[] { };
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Adj meg egy számot: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    tömb = tömb.Append(num).ToArray();
                }
                else
                {
                    Console.WriteLine("Csak pozitív számokat adj meg!");
                }
            }
            foreach (var item in tömb)
            {
                Console.Write($"{item} ");
            }

            Console.Write("Írj egy mondatot: ");
            string mondat = Convert.ToString(Console.ReadLine());
            foreach (var x in mondat)
            {
                Console.WriteLine(x.ToString());
            }

            string[] mdt = new string[] { };
            foreach (var i in mondat)
            {
                if (i != ' ')
                {
                    mdt = mdt.Append(i.ToString()).ToArray();
                }
                else
                {
                    continue;
                }
            }
            foreach (var item in mdt)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            Console.WriteLine($"A mondat hossza: {mdt.Length}");

            Console.ReadKey();
        }
        static void NégyzetKer(int a)
        {
            Console.WriteLine($"A négyzet kerülete: {4*a}");
        }
        static void TéglalapKer(int a,int b)
        {
            Console.WriteLine($"A téglalap kerülete: {2*a+2*b}");
        }
        static void KörKer(int r)
        {
            Console.WriteLine($"A kör kerülete: {Math.Round(2 * r * Math.PI, 2)}");
        }
    }
}
