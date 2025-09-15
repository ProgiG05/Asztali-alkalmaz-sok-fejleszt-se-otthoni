using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_14_20240412
{
    //osztály - class
    class Ember
    {
        //adattagok
        public string nev;
        public int eletkor;
        public string varos;
        //konstruktor paraméteres
        public Ember(string nev, int eletkor, string varos)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.varos = varos;
        }
        public Ember() { }
        //metódus
        public void kiírás()
        {
            Console.WriteLine($"{nev}\t{eletkor}\t{varos}\t");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Ember ember_tkp1 = new Ember("dezső", 55,"T.puszta");
            Ember ember = new Ember();
            ember.nev = "Józsi";
            ember.eletkor = 15;
            ember.varos = "Bp.";
            //adatok megjelenítése
            Console.WriteLine($"Név: {ember.nev}\nKor: {ember.eletkor}\nVáros: {ember.varos}");
            Console.WriteLine();
            //Ember ember_tkp2 = new Ember("krisi",49,"T.puszta");
            Ember ember2 = new Ember();
            ember2.nev = "Karcsi";
            ember2.eletkor = 20;
            ember2.varos = "Szfvár";
            Console.WriteLine($"Név: {ember2.nev}\nKor: {ember2.eletkor}\nVáros: {ember2.varos}");
            Console.WriteLine();
            //kiíras metódus
            ember.kiírás();
            ember2.kiírás();

            Ember ember3 = new Ember("Leonidász", 100, "Spárta");
            ember3.kiírás();

            //Class2 = kutyák
            Class2 kutya1 = new Class2("Foxi","Németjuhász",5);
            











            Console.WriteLine("MENTÉÉS");
            Console.ReadKey();
        }
    }
}
