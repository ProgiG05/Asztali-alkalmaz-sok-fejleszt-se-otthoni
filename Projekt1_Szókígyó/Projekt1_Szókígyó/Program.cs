using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Szókígyó
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SZÓKÍGYÓ");
            Console.WriteLine("5 SZÓ-HOSSZÚSÁGÚ A KÍGYÓ");
            string[] kigyo = new string[5];
            Console.Write("ADD MEG A KEZDŐ SZÓT: ");
            string ksz = Console.ReadLine();
            kigyo[0] = ksz;
            int sorszam = 1;
            int betuszam = 1;
            for (int i = 0; i < kigyo.Length; i++)
            {
                sorszam++;
                betuszam++;
                Console.Write("ADJ MEG EGY SZÓT: ");
                string sz = Console.ReadLine();
                string[] sztömb = sz.Split();
                string szuccso = sz.Split().Last();
                foreach (var item in kigyo)//tömbön megy keresztül az item
                {
                    foreach (var it in sztömb)//a megadott szón megy keresztül
                    {
                        if (i == betuszam && sztömb[0] == szuccso)//megnézi hogy az előző szó utolsó betűje egyezik-e a beírt szó első betűjével,és az iteráció egyenlő-e a betuszammal ami jelzi kigyo adott indexét
                        {
                            kigyo[sorszam] = sz;
                        }
                        else
                        {
                            Console.WriteLine("SAJNOS EM JÓ");
                            continue;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
