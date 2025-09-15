using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_9
{
    class Program
    {
        //-----------------------------------------------------------------------------------------------------------
        //struktura
        struct koordináta
        {
            public int x;
            public int y;
            //metódus készítése - eljárás
            public void pontBeallitas()
            {
                x = 99;
                y = 100;
            }
            //metódus készítése - függvény
            public string pontErtek()
            {
                return $"X = {x} , Y = {y} - függvény készítője: Gipsz Jakab";
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        //struktura konstrukttal
        struct allat
        {
            public string nev;
            public int kor;
            //paraméteres konstruktor
            public allat(string nev, int kor)
            {
                this.nev = nev;
                this.kor = kor;
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        struct cars
        {
            public string name;
            public string model;
            public int year;
            public int horsepower;
            public int milage;
            public cars(string name, string model, int year, int horsepower, int milage)
            {
                this.name = name;
                this.model = model;
                this.year = year;
                this.horsepower = horsepower;
                this.milage = milage; //kms
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        //strutura létrehozása statikus konstruktorral
        struct ingatlan
        {
            public static string telepules;     //private
            public static int meret;            //private

            static ingatlan()
            {
                telepules = "Székesfehérvár";
                meret = 100;
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Struktúrák");
            //1.használat --- new  alkalmazása,használása
            koordináta pontok = new koordináta();
            Console.WriteLine($"Az x értéke: {pontok.x}");
            Console.WriteLine($"Az y értéke: {pontok.y}");

            pontok.x = 12;
            pontok.y = 8;

            Console.WriteLine($"Az x értéke: {pontok.x}");
            Console.WriteLine($"Az y értéke: {pontok.y}");

            //2. használat --- new nélkül
            koordináta pontok2;
            pontok2.x = 23;
            Console.WriteLine($"Az x értéke: {pontok2.x}");

            //állat típúsú változó
            allat allatka = new allat("Buksi",2);       //aktuális paraméter
            Console.WriteLine($"{allatka.nev} {allatka.kor} éves");

            //ingatlan típúsú változó
            ingatlan ing = new ingatlan();
            Console.WriteLine($"Település: {ingatlan.telepules}");
            Console.WriteLine($"Méret: {ingatlan.meret}");

            //metódus alkalmazása eljárás
            pontok.pontBeallitas();
            Console.WriteLine($"Az x értéke: {pontok.x}, az y értéke: {pontok.y}");

            //metódus alkalmazása függvény
            Console.WriteLine(pontok.pontErtek());

            //autó típúsú változó
            cars car1 = new cars("Nissan","Skyline GTR R34",1999,276,4500); //from 1998 to 2002
            cars car2 = new cars("Honda", "NSX", 1997, 270, 3100); //from 1990 to 2005
            cars car3 = new cars("Mazda", "RX7", 1995, 255, 4400); //from 1978 to 2002
            Console.WriteLine("Welcome to my JDM carshop!");
            Console.WriteLine("The list:");
            for (int i = 1; i < 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(car1.name);
                }
                else if (i == 2)
                {
                    Console.WriteLine(car2.name);
                }
                else if (i == 3)
                {
                    Console.WriteLine(car3.name);
                }
            }
            Console.Write("What car would you like to see? ");
            string car = Convert.ToString(Console.ReadLine());
            if (car ==  car1.name)
            {
                Console.WriteLine($"Model: {car1.model}\nProduduction year: {car1.year}\nHorsepower: {car1.horsepower}\nMilage(in kilometres): {car1.milage}");
            }
            else if (car == car2.name)
            {
                Console.WriteLine($"Model: {car2.model}\nProduduction year: {car2.year}\nHorsepower: {car2.horsepower}\nMilage(in kilometres): {car2.milage}");
            }
            else if (car == car3.name)
            {
                Console.WriteLine($"Model: {car3.model}\nProduduction year: {car3.year}\nHorsepower: {car3.horsepower}\nMilage(in kilometres): {car3.milage}");
            }
            Console.ReadKey();
        }
    }
}
