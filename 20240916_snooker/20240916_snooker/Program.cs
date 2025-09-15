using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240916_snooker
{
    class Program
    {
        static List<snooker> data = new List<snooker>();
        static void Main(string[] args)
        {
            Console.WriteLine("Feladat 2:");
            System.IO.File.ReadAllLines("snooker.txt", Encoding.Default).Skip(1).ToList().ForEach(x => data.Add(new snooker(x)));
            Console.WriteLine($"Feladat 3: {data.Count}");
            Console.WriteLine($"Feladat 4: {data.Average(x => x.nyeremeny)}");
            Console.WriteLine($"Feladat 5: {Math.Round(data.Where(x => x.orszag == "Anglia").Average(x => x.nyeremeny), 2)}");
            var nagy = data.Where(x => x.orszag == "Kína").OrderBy(x => x.nyeremeny).Last();
            Console.WriteLine($"Feladat 6: {nagy.helyezes} - {nagy.nev} - {nagy.orszag} - {nagy.nyeremeny * 380}");
            var norveg = data.Any(x => x.orszag == "Norvég") ? "Van" : "Nincs";
            Console.WriteLine($"Feladat 7: {norveg}");
            System.IO.StreamWriter sw = new System.IO.StreamWriter("anglia.txt");
            sw.WriteLine("Az angliai versenyzők adatai: \n");
            sw.WriteLine("Név     Helyezés      Eredmény");
            sw.WriteLine("------------------------------");
            data.Where(x => x.orszag == "Anglia").ToList().ForEach(y => sw.WriteLine($"{y.nev}\t{y.helyezes}\t{y.nyeremeny}"));
            sw.Close();
            Console.ReadKey();
        }
    }
}
