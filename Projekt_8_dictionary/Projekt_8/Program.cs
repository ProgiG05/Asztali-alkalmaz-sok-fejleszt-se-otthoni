using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_8
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Szótár");
            //létrehozása
            Dictionary<string, string> szótár = new Dictionary<string, string>();

            //kezdőrtékkel
            Dictionary<string, string> színek = new Dictionary<string, string>() { {"piros","red" },{"zöld","green" },{"fekete","black" },{"kék","blue" } };

            //új elem felvétele
            szótár.Add("alma", "apple");

            //kulcs szerinti kiíratás
            Console.WriteLine(szótár["alma"]);

            //szótár tartalmának kiírása
            foreach (KeyValuePair<string,string> item in színek)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //érték változtatás - adás
            színek["zöld"] = "grín";
            Console.WriteLine(színek["zöld"]);

            //kulcs-értékpár eltávolítás
            színek.Remove("zöld");
            foreach (KeyValuePair<string, string> item in színek)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //szótár elemszámának lekérése
            Console.WriteLine($"A színek szótár {színek.Count} elemű");

            //tartalmazás vizsgálat - ContainsKey(kulcs)
            Console.WriteLine(színek.ContainsKey("zöld")?"Van zöld (kulcs)":"Nincs zöld (kulcs)");

            //tartalmazás vizsgálat - ContainsValue(érték)
            Console.WriteLine(színek.ContainsValue("red")?"Van piros":"Nincs piros");






            //Statisztika
            //Töltsünk fel egy 20 elemű tömböt véletlen számokkal.
            //Szótár segítségével írjuk képernyőre,hogy egy számból hány darab van a tömbben!
            //----------------------------------------------------------------------------------------------------------
            Console.WriteLine("Szamok");
            int[] nums = new int[30];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(15);
            }
            Array.Sort(nums);
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.ContainsKey(nums[i]))
                {
                    numbers[nums[i]]++;
                }
                else
                {
                    numbers.Add(nums[i], 1);
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}db");
            }
            
            //----------------------------------------------------------------------------------------------------------

            Console.WriteLine(" \n ");

            //----------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Félévi");
            //int[] félévi = new int[14];
            //for (int i = 0; i < félévi.Length; i++)
            //{
            //    Console.Write("Adott tantárgy kerekített átlaga: ");
            //    int kisátlag = Convert.ToInt32(Console.ReadLine());
            //    félévi[i] = kisátlag;
            //}
            //Array.Sort(félévi);
            //Dictionary<int, int> stat = new Dictionary<int, int>();
            //for (int i = 0; i < félévi.Length; i++)
            //{
            //    if (stat.ContainsKey(félévi[i]))
            //    {
            //        stat[félévi[i]]++;
            //    }
            //    else
            //    {
            //        stat.Add(félévi[i], 1);
            //    }
            //}
            //foreach (KeyValuePair<int, int> item in stat)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}db");
            //}
            //double nagyátlag = félévi.Sum() / félévi.Length;
            //Console.WriteLine($"Az összátlag: {Math.Round(nagyátlag, 2)}");
            //----------------------------------------------------------------------------------------------------------

            Console.WriteLine(" \n ");

            //----------------------------------------------------------------------------------------------------------
            //kérjunk be 5 kutya nevét, életkorát, tároljuk egy szótárba,majd az átlagéletkorukat számítsuk ki!
            Console.WriteLine("Kutyalista");
            Dictionary<string, int> kutya = new Dictionary<string, int>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{i+1}. kutya neve:");
                string nev = Console.ReadLine();
                Console.Write($"{i+1}. kutya kora: ");
                int kor = Convert.ToInt32(Console.ReadLine());
                if (kutya.ContainsKey(nev))
                {
                    Console.WriteLine("Ez a kutyus már szerepel a listában");
                    i--;
                }
                else
                {
                    kutya.Add(nev, kor);
                }
            }
            foreach (var item in kutya)
            {
                Console.WriteLine($"A kutyák adatai: {item.Key} - {item.Value} éves");
            }
            Console.WriteLine($"A kutyák átlagéletkora: {kutya.Values.Average()}");
            //----------------------------------------------------------------------------------------------------------

            Console.WriteLine(" \n ");

            //----------------------------------------------------------------------------------------------------------
            Feltölt();
            foreach (var item in statisztika())
            {
                Console.WriteLine($"{item.Key} - {item.Value}db");
            }

            Console.ReadKey();
        }



        static List<int> szamok = new List<int>();

        //eljárás a számok lista feltöltésére
        static void Feltölt()
        {
            for (int i = 0; i < 30; i++)
            {
                szamok.Add(rnd.Next(10, 21));
            }
        }
        //elemek gyakorisága szamok listában
        static Dictionary<int, int> statisztika()
        {
            Dictionary<int, int> statisztikaEredmény = new Dictionary<int, int>();
            for (int i = 0; i < szamok.Count; i++)
            {
                if (statisztikaEredmény.ContainsKey(szamok[i]))
                {
                    statisztikaEredmény[szamok[i]]++;
                }
                else
                {
                    statisztikaEredmény.Add(szamok[i],1);
                }
            }
            return statisztikaEredmény;
        }
    }
}
