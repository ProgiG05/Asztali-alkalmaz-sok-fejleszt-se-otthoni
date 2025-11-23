using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250929_Öröklödés_8_JátékosKarakter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Karakter k1 = new Karakter("Arthas", 3, 100, 80, new DateTime(2023, 10, 1));
                k1.Kiir();

                k1.SebzestKap(30);
                k1.KombatKiir();

                k1.Gyogyul(20);
                k1.KombatKiir();

                k1.SzintetLep();

                Karakter k2 = new Karakter("Luna", 1);
                k2.Kiir();


                Varazslo v1 = new Varazslo("Merlin", 5, 120, 120, new DateTime(2024, 5, 1), 80);
                Varazslo v2 = new Varazslo("Morgana", 3, 100, 90, DateTime.Now, 100);

                v1.Varazsol(v2, 40);
                v2.KombatKiir();

                Harcos h1 = new Harcos("Thorin", 4, 150, 150, new DateTime(2023, 12, 1), 20);
                h1.SebzestKap(50);
                h1.KombatKiir();

                Harcos h2 = new Harcos("Brienne", 2,100,100,DateTime.Now,50);
                h2.SebzestKap(30);
                h2.KombatKiir();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
