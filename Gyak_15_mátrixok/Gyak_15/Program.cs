using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A mátrix kiíratása: ");
            int[,] matrix = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("A mátrix átlaga,számjai összege,darabszáma");
            int sum = 0;
            int darab = matrix.GetLength(0) * matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    sum += num;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"A mátrix számainak összege: {sum}");
            Console.WriteLine($"A mátrix számainak darabszáma: {darab}");
            Console.WriteLine($"A mátrix átlaga: {sum / darab}");

            Console.WriteLine("A mátrix páros,páratlan számai,darabja,összege");
            int[] paros = new int[] { };
            int[] paratlan = new int[] { };
            int ps = 0;
            int psdb = 0;
            int prtln = 0;
            int prtlndb = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    if (num % 2 == 0)
                    {
                        paros = paros.Append(num).ToArray();
                        ps += num;
                        psdb++;
                    }
                    else
                    {
                        paratlan = paratlan.Append(num).ToArray();
                        prtln += num;
                        prtlndb++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"A mátrix páros számai: ");
            foreach (var item in paros)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix páratlan számai: ");
            foreach (var item in paratlan)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix páros számainak darabja: {psdb}");
            Console.WriteLine($"A mátrix páros számainak összege: {ps}");
            Console.WriteLine($"A mátrix páratlan számainak darabja: {prtlndb}");
            Console.WriteLine($"A mátrix páratlan számainak összege: {prtln}");
            int min = matrix[0, 0];
            int mini = 0;
            int minj = 0;
            int max = matrix[0, 0];
            int maxi = 0;
            int maxj = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    if (num < min)
                    {
                        min = num;
                        mini = i;
                        minj = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix legkisebb eleme: {min}\tindexe: {mini + 1},{minj + 1}");
            Console.WriteLine($"A mátrix legnagyobb eleme: {max}\tindexe: {maxi + 1},{maxj + 1}");
            Console.Write("Melyik számot keressem a mátrixban? ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int igenn = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    if (szam == num)
                    {
                        igenn = 1;
                    }
                }
                Console.WriteLine();
            }
            if (igenn == 1)
            {
                Console.WriteLine("Megvan a szám amit kerestél");
            }
            else
            {
                Console.WriteLine("Nincs meg a szám amit kerestél");
            }




            Console.Write("Adj meg egy mondatot: ");
            string szoveg = Console.ReadLine();
            if (szoveg.Contains("alma"))
            {
                Console.WriteLine("Van alma a szövegben");
            }
            else
            {
                Console.WriteLine("Nincs alma a szöbegben");
            }
            szoveg.ToLower();
            szoveg.Split();
            Console.Write("Adj meg egy betűt(melyik betűt keressem a mondatban): ");
            char betu = Convert.ToChar(Console.ReadLine());
            int b = 0;
            bool igen = true;
            foreach (var item in szoveg)
            {
                if (item == betu)
                {
                    b++;
                }
                else
                {
                    igen = false;
                }
            }
            if (igen == false)
            {
                Console.WriteLine($"A keresett betű {b} darabszámban található meg a mondatban");
            }
            else
            {
                Console.WriteLine(szoveg.ToUpper());
            }


           
            Console.WriteLine(szoveg.Replace(" ", ""));
            string sz = szoveg.ToUpper();
            Console.WriteLine(sz);
            sz.Split();
            Console.Write("Adj meg egy tetszőleges szót: ");
            string sz2 = Convert.ToString(Console.ReadLine());
            //sz2.Split();
            foreach (var item in sz)
            {
                Console.Write(item);
                if (item == sz[2])
                {
                    Console.Write($" {sz2} ");
                }
            }



















            Console.ReadKey();
        }
    }
}
