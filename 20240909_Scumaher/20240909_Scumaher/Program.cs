using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;

namespace _20240909_Scumaher
{
    class Program
    {
        static List<Schum> data = new List<Schum>();
        //static void beolvas1()
        //{
        //    StreamReader sr = new StreamReader("schumacher.csv");
        //    string[] elso = sr.ReadLine().Split(';');
        //    while (!sr.EndOfStream)
        //    {
        //        data.Add(new Schum(sr.ReadLine()));
        //    }
        //    sr.Close();
        //}
        //static void beolvas2()
        //{
        //    foreach (var item in File.ReadAllLines("schumacher.csv").Skip(1))
        //    {
        //        data.Add(new Schum(item));
        //    }
        //}
        
        static void Main(string[] args)
        {
            //beolvas1();
            //beolvas2();

            System.IO.File.ReadAllLines("schumacher.csv").Skip(1).ToList().ForEach(x => data.Add(new Schum(x)));

            Console.WriteLine($"3.feladat: {data.Count}");
            Console.WriteLine($"4. feladat: Schumacher {data.Where(x => x.grandprix == "Hungarian Grand Prix" && x.position > 0).Count()} alkalommal szerepelt.");
            Console.WriteLine($"4. feladat: Schumacher {data.Count(x => x.grandprix == "Hungarian Grand Prix" && x.position > 0)} alkalommal szerepelt.");
            Console.WriteLine("Sikires szereplései:");
            data.Where(x => x.grandprix == "Hungarian Grand Prix" && x.position > 0).ToList().ForEach(x => Console.WriteLine($"\t{x.date.Year}. {x.date.Month:00}. {x.date.Day:00}: {x.position}.hely"));
            Console.WriteLine("5. feladat: Hibastatisztika:");
            data.Where(x => x.status != "Finished" && !x.status.Contains("lap")).GroupBy(x => x.status).Where(y => y.Count() > 2).ToList().ForEach(y => Console.WriteLine($"\t{y.Key} - {y.Count()}"));
            Console.ReadKey();
        }
    }
}
