using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Kamatos_kamat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KAMATOS KAMAT");
            Console.Write("Add meg az alaptőkét: ");
            double alaptőke = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fixkamat(%): ");
            double fk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Futamidő: ");
            int év = Convert.ToInt32(Console.ReadLine());
            int ev = 0;
            for (int i = 0; i < év; i++)
            {
                ev++;
                var km = alaptőke * Math.Pow(1 + fk / 100, ev);
                Console.WriteLine($"A(z) {ev}. évben a pénzmennyiség: {Math.Round(km)}");
            }

            Console.WriteLine("KAMATOS KAMAT 2.0");
            Console.Write("Add meg az alaptőkét: ");
            double atk = Convert.ToDouble(Console.ReadLine());
            if (atk > 0)
            {
                Console.Write("Futamidő(max 10 év): ");
                int évv = Convert.ToInt32(Console.ReadLine());
                if (évv > 0 && évv < 10)
                {
                    int evv = 0;
                    int ew = 0;
                    double[] kamatok = new double[] { };
                    double[] tkk = new double[] { };
                    for (int i = 0; i < évv; i++)//kamtos for lopp
                    {
                        evv++;
                        Console.Write($"Változó kamat(%) {evv}. évre: ");
                        double fkk = Convert.ToDouble(Console.ReadLine());
                        if (fkk > 0)
                        {
                            kamatok = kamatok.Append(fkk).ToArray();
                        }
                        else
                        {
                            Console.WriteLine("Pénzt akarsz veszíteni?");
                        }
                    }
                    for (int i = 0; i < évv; i++)//pénzes for loop
                    {
                        ew++;
                        tkk = tkk.Append(atk * Math.Pow(1 + kamatok[i] / 100, evv)).ToArray();
                        Console.WriteLine($"A(z) {evv}. évben a pénzmennyiség: {Math.Round(tkk[i])}");
                    }
                }
                else
                {
                    Console.WriteLine("Egyenlőre 10 év a max.");
                }
            }
            else
            {
                Console.WriteLine("Valamivel csak el kell kezdeni.");
            }
            Console.ReadKey();
        }
    }
}
