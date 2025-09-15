using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt4_Akasztófa_ft.csabesz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a szót / mondatot: ");
            string szo = Convert.ToString(Console.ReadLine());
            int lehetoseg = 10;
            char[] talalat = new char[szo.Length];
            char[] betuk = new char[lehetoseg + szo.Length];
            int betutipp = 0;
            bool igaz = false;
            char[] realszo = new char[szo.Length];
            string[] szokitalal = new string[lehetoseg + szo.Length];
            int szohely = 0;
            for (int i = 0; i < betuk.Length; i++)
            {
                betuk[i] = ' ';
            }
            for (int i = 0; i < szokitalal.Length; i++)
            {
                szokitalal[i] = " ";
            }
            for (int i = 0; i < talalat.Length; i++)
            {
                talalat[i] = '_';
                if (szo[i] == ' ')
                {
                    talalat[i] = ' ';
                }
                if (szo[i] == '!')
                {
                    talalat[i] = '!';
                }
                if (szo[i] == '?')
                {
                    talalat[i] = '?';
                }
                if (szo[i] == ',')
                {
                    talalat[i] = ',';
                }
                if (szo[i] == '"')
                {
                    talalat[i] = '"';
                }
            }
            int szotalal = 0;
            int j = 0;
            foreach (var item in szo)
            {
                realszo[j] = item; j++;
            }
            Console.Clear();
            while (igaz != true)
            {
                Console.WriteLine($"Lehetőségeid száma: {lehetoseg}");
                int nemjo = 0;
                char tipp = ' ';
                szotalal = 0;
                int bing = 0;
                string kitalalszo = "";
                Console.Write("Betűtipp vagy '!' után szótipp (kilépés: $):  ");
                tipp = Convert.ToChar(Console.ReadLine());
                if (tipp == '!')
                {
                    Console.Write("Szó: ");
                    kitalalszo = Console.ReadLine();
                    szokitalal[szohely] = kitalalszo;
                    szohely++;
                    if (kitalalszo.Length == szo.Length)
                    {
                        for (int k = 0; k < kitalalszo.Length; k++)
                        {
                            if (kitalalszo[k] == szo[k])
                            {
                                talalat[k] = kitalalszo[k];
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem talált!");
                        lehetoseg--;
                        break;
                    }
                }
                else if (tipp == '$')
                {
                    lehetoseg = lehetoseg - 10;
                    Console.WriteLine($"Ezt kellett volna kitalálnod: {szo}");
                    Console.WriteLine("Vége a játéknak!");
                    igaz = true;
                    break;
                }
                else
                {
                    for (int i = 0; i < szo.Length; i++)
                    {
                        if ((tipp == 'e' || tipp == 'é') && (szo[i] == 'e' || szo[i] == 'é'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if ((tipp == 'a' || tipp == 'á') && (szo[i] == 'a' || szo[i] == 'á'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if ((tipp == 'i' || tipp == 'í') && (szo[i] == 'i' || szo[i] == 'í'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if ((tipp == 'o' || tipp == 'ó') && (szo[i] == 'o' || szo[i] == 'ó'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if ((tipp == 'ö' || tipp == 'ő') && (szo[i] == 'ö' || szo[i] == 'ő'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if ((tipp == 'u' || tipp == 'ú') && (szo[i] == 'u' || szo[i] == 'ú'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if ((tipp == 'ü' || tipp == 'ű') && (szo[i] == 'ü' || szo[i] == 'ű'))
                        {
                            talalat[i] = szo[i];
                            bing++;
                            continue;
                        }
                        if (tipp == realszo[i])
                        {
                            bing++;
                            talalat[i] = tipp;
                        }
                        else
                        {
                            foreach (var item in realszo)
                            {
                                if (item != tipp)
                                {
                                    nemjo++;
                                }
                            }
                            if (nemjo == szo.Length)
                            {
                                Console.WriteLine("Nem Talált!");
                                lehetoseg--;
                                break;
                            }
                        }

                    }
                }
                if (tipp == '$')
                {
                    break;
                }
                Console.WriteLine();
                if (bing > 0)
                {
                    if (bing > 1)
                    {
                        Console.WriteLine($"Talált! ({bing}x)");
                    }
                    else
                    {
                        Console.WriteLine("Talált!");
                    }
                }
                Console.WriteLine();
                betuk[betutipp] = tipp;
                betutipp++;
                foreach (var item in talalat)
                {
                    Console.Write($"{item}");
                }

                Console.WriteLine();
                for (int l = 0; l < szo.Length; l++)
                {
                    if (talalat[l] == szo[l])
                    {
                        szotalal++;
                    }
                    else
                    {
                        szotalal--;
                    }
                }
                Console.WriteLine();
                if (szotalal == szo.Length)
                {
                    Console.WriteLine("Kitaláltad!");
                    Console.Write("A szó/mondat: ");
                    foreach (var item in talalat)
                    {
                        Console.Write($"{item}");
                    }
                    Console.WriteLine();
                    Console.Write("Tippelt betűk/szavak: ");
                    for (int i = 0; i < betuk.Length; i++)
                    {
                        if (betuk[i] != ' ' && betuk[i] != '!')
                        {
                            Console.Write($"'{betuk[i]}' ");
                        }
                    }
                    for (int i = 0; i < szokitalal.Length; i++)
                    {
                        if (szokitalal[i] != " ")
                        {
                            Console.Write($"'{szokitalal[i]}' ");
                        }
                    }
                    igaz = true;
                    break;
                }
                Console.Write("Tippelt betűk/szavak: ");
                for (int i = 0; i < betuk.Length; i++)
                {
                    if (szotalal == szo.Length)
                    {
                        break;
                    }
                    if (betuk[i] != ' ' && betuk[i] != '!')
                    {
                        Console.Write($"'{betuk[i]}' ");
                    }
                    if (szokitalal[i] != " ")
                    {
                        Console.Write($"'{szokitalal[i]}' ");
                    }
                }
                Console.WriteLine();
                if (lehetoseg <= 0)
                {
                    Console.WriteLine($"Ezt kellett volna kitalálnod: {szo}");
                    Console.WriteLine("Vége a játéknak!");
                    igaz = true;
                }
            }
            Console.ReadKey();
        }
    }
}
