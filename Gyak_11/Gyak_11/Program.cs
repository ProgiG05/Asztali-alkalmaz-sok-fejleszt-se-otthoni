using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MÁTRIXOK");
            int[,] majdnemlotto = new int[9, 10];
            Random rnd = new Random();
            for (int i = 0; i < majdnemlotto.GetLength(0); i++)
            {
                for (int j = 0; j < majdnemlotto.GetLength(1); j++)
                {
                    majdnemlotto[i, j] = rnd.Next(1, 91);
                    Console.Write($"{majdnemlotto[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Programozási tételek:");
            Console.WriteLine("Sorozatszámítás, eldöntés, lineáris keresés, megszámlálás, min/max");
            int valasztas;
            do
            {
                Console.WriteLine("Programozási tételek ");
                Console.WriteLine("1: mátrix eleminek összege,átlaga");
                Console.WriteLine("2: páros számok darabszáma");
                Console.WriteLine("3: legkisebb elem és indexe");
                Console.WriteLine("4: legnagyobb elem és indexe");
                Console.WriteLine("5: kilépés");
                valasztas = Convert.ToInt32(Console.ReadLine());
                switch (valasztas)
                {
                    case 1:
                        Console.Clear();
                        double osszeg = 0;
                        int elemszam = majdnemlotto.GetLength(0) * majdnemlotto.GetLength(1);
                        for (int i = 0; i < majdnemlotto.GetLength(0); i++)
                        {
                            for (int j = 0; j < majdnemlotto.GetLength(1); j++)
                            {
                                osszeg =+majdnemlotto[i, j];
                            }
                        }
                        Console.WriteLine($"Összeg: {osszeg}, átlag:{osszeg / elemszam}");
                        break;
                    case 2:
                        Console.Clear();
                        int db = 0;
                        for (int i = 0; i < majdnemlotto.GetLength(0); i++)
                        {
                            for (int j = 0; j < majdnemlotto.GetLength(1); j++)
                            {
                                if (majdnemlotto[i, j] % 2 == 0)
                                {
                                    db++;
                                }
                            }
                        }
                        Console.WriteLine($"A páros számok darabszáma: {db}");
                        break;
                    case 3:
                        Console.Clear();
                        //tegyük fel hogy a mátrix első eleme a legkisebb
                        int min = majdnemlotto[0, 0];
                        //int min = int.MinValue;
                        int mini = 0;
                        int minj = 0;
                        for (int i = 0; i < majdnemlotto.GetLength(0); i++)
                        {
                            for (int j = 0; j < majdnemlotto.GetLength(1); j++)
                            {
                                //elemek hasonlítgatása - ha kisebbet tálálunk
                                if (majdnemlotto[i, j] < min)
                                {
                                    //akkor kisebb elem tárolása
                                    min = majdnemlotto[i, j];
                                    //jegyezzük meg ennek az indexeit
                                    mini = i;
                                    minj = j;
                                }
                            }
                        }
                        Console.WriteLine($"A legkisebb elem: {min}");
                        Console.WriteLine($"Ez a mártrix[{mini + 1},{minj + 1}]. eleme");
                        break;
                    case 4:
                        Console.Clear();
                        //tegyük fel hogy a mátrix első eleme a legnagyobb
                        int max = majdnemlotto[0, 0];
                        //int max = int.MaxValue;
                        int maxi = 0;
                        int maxj = 0;
                        for (int i = 0; i < majdnemlotto.GetLength(0); i++)
                        {
                            for (int j = 0; j < majdnemlotto.GetLength(1); j++)
                            {
                                //elemek hasonlítgatása - ha kisebbet tálálunk
                                if (majdnemlotto[i, j] > max)
                                {
                                    //akkor kisebb elem tárolása
                                    max = majdnemlotto[i, j];
                                    //jegyezzük meg ennek az indexeit
                                    maxi = i;
                                    maxj = j;
                                }
                            }
                        }
                        Console.WriteLine($"A legnagyobb elem: {max}");
                        Console.WriteLine($"Ez a mártrix[{maxi + 1},{maxj + 1}]. eleme");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Nem jó számot adtál meg");
                        break;
                }
            } while (valasztas != 5);


            Console.WriteLine("2*2 Mátrix");
            int[,] tömb = new int[2, 2];
            tömb[0, 0] = 25;
            Console.Write("Mi legyen a következő elem? ");
            int kövi = Convert.ToInt32(Console.ReadLine());
            tömb[0, 1] = kövi;
            Console.Write("Mi legyen a következő elem? ");
            kövi = Convert.ToInt32(Console.ReadLine());
            tömb[1, 0] = kövi;
            tömb[1, 1] = 99;
            for (int i = 0; i < 2; i++)//sorok száma
            {
                for (int j = 0; j < 2; j++)//oszlopok száma
                {
                    Console.Write($"{tömb[i, j]} ");
                }
                Console.WriteLine();
            }


            // kezdőértékkel rendelkező mátrix
            int[,] szamok = new int[3, 3] { { 1, 2,3 } , { 4,5,6 } , {7,8,9} };
            int ossz = 0;
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    Console.Write($"{szamok[i, j]} ");
                    //főátló eleminek összege (i=j)
                    if (i == j)
                    {
                        ossz += szamok[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(ossz);
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    Console.Write($"{szamok[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
