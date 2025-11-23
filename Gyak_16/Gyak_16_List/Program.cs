using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_16_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listák
            Console.WriteLine("Listák");
            List<int> lista = new List<int>(5);

            //elem hozzáadása a listához - Add()
            lista.Add(12);
            Console.Write("Mi legyen a következő elem: ");
            int kovelem = Convert.ToInt32(Console.ReadLine());
            lista.Add(kovelem);

            //lista elemeinek kiíratása foreach ciklussal
            foreach (var x in lista)
            {
                Console.Write($"{x} ");
            }

            //lista létrehozása - gyűjtemény inicializáló szintaxis
            var gyümik = new List<string>()
            {
                "alma",
                "barack",
                "körte",
                "eper"
            };
            Console.WriteLine();
            foreach (var y in gyümik)
            {
                Console.Write($"{y} ");
            }

            //lista létrrehozása - kezdőértékekkel rendelkező lista
            List<int> szamok = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //lista elemszáma - Count
            Console.WriteLine($"A szamok lista {szamok.Count} db elemből áll");
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write($"{szamok[i]} ");
            }

            int[] tömb = new int[] { 7, 8, 9, 10 };
            //tömb eleminek hozzáadása a listához - AddRange(gyűjtemény)
            szamok.AddRange(tömb);
            Console.WriteLine($"\nLista és a tömb együtt");
            foreach (var sz in szamok)
            {
                Console.Write($"{sz} ");
            }
            Console.WriteLine();
            //elem beszúrása a listába - Insert(hova,mit)
            szamok.Insert(0, 15);

            //elem eltávolítása a listából - Remove(elem), RemoveAt(index)
            szamok.Remove(15);
            szamok.RemoveAt(2);
            foreach (var item in szamok)
            {
                Console.Write($"{item} ");
            }

            //Tartalomvizsgálat - Contains
            Console.WriteLine(szamok.Contains(99) ? "Benne van" : "Nincs benne");

            //Lista sorba rendezése - Sort()
            szamok.Sort();
            foreach (var sz in szamok)
            {
                Console.Write($"{sz} ");
            }

            //sorrend megfordítása - reverse
            szamok.Reverse();
            foreach (var sz in szamok)
            {
                Console.Write($"{sz} ");
            }

            Console.WriteLine(szamok.Capacity);
            Console.WriteLine();

            Console.WriteLine("Programozási tételek");
            Console.WriteLine($"A lista eleminek összege: {szamok.Sum()}");
            Console.WriteLine($"A lista elemeinek átlaga: {Math.Round(szamok.Average(),2)}");
            Console.WriteLine($"A lista legkisebb eleme: {szamok.Min()}, ennek indexe {szamok.IndexOf(szamok.Min())}");
            Console.WriteLine($"A lista legnagyobb eleme: {szamok.Max()}, ennek indexe {szamok.IndexOf(szamok.Min())}");

            //lista tömbbé alakítása
            int[] listatömb = new int[szamok.Count];
            listatömb = szamok.ToArray();
            Console.WriteLine($"A listatömb elemei: ");
            for (int i = 0; i < listatömb.Length; i++)
            {
                Console.Write($"{listatömb[i]} ");
            }
            //teljes lista törlése
            szamok.Clear();



            Console.ReadLine();
        }
    }
}
