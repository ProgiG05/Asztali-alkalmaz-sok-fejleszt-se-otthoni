using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    interface IInterfacePelda
    {
        void PeldaEljaras();
        string PeldaFuggveny();
    }

    class Osztaly : IInterfacePelda
    {
        public void PeldaEljaras()
        {
            Console.WriteLine("Példa eljárás implementációja");
        }

        public string PeldaFuggveny()
        {
            return "Példa függvény implementációja";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pelda = new Osztaly();
            pelda.PeldaEljaras();
            Console.WriteLine(pelda.PeldaFuggveny());


            var implem = new Osztaly2();
            Console.WriteLine(implem.Nevem()) ;
          
            //explicit konverzió Nevem() metódusra
            IEgyik implem2 = implem;
            Console.WriteLine(implem2.Nevem());
            implem2.Varos();
            Osztaly2 varosom = new Osztaly2();
            ((IEgyik)varosom).Varos();
            ((IMasik)varosom).Varos();

            IAllat kutya = new Kutya();
            kutya.Eszik();
            Console.WriteLine(kutya.HangotAd());


            IKutya kutyus = new Kutya2();
            kutyus.Iszik();
            kutyus.Eszik();
            Console.WriteLine(kutyus.HangotAd());

            //is operátor - egy adott osztály megvalósít-e egy interfészt
            Kutya saját = new Kutya();
            Console.WriteLine(saját is IKutya?"Megvalósítja az IKutya if-t":"Nem valósítja meg az IKutya if-t");

            //as null értéket ad vissza, ha a konverzió sikertelen volt

            IKutya teszt = saját as IKutya;
            Console.WriteLine(teszt!=null?"az osztály megvalósítja az if-t":"az osztály nem valósítja meg az if-t");

            Ember ember = new Ember { Nev = "Karcsi" };
            ember.Beszel();

            List<ISportolo> sportolok = new List<ISportolo>
            {
                new Futo(),
                new Uszo()
            };

            foreach (var item in sportolok)
            {
                item.Sportol();
            }
            Console.ReadKey();
        }
    }
}
