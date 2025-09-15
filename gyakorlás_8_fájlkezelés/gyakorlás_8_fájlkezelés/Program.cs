using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyakorlás_8_fájlkezelés
{
    class Program
    {
        struct adatok
        {
            public int km;
            public string nev;
        }
        static List<adatok> adatlista = new List<adatok>();
        static void beolvasas_es_kiiras()
        {
            StreamReader sr = new StreamReader("autok.txt");
            string[] kocsik = new string[100];
            string[] auto = new string[100];
            int[] km = new int[100];
            int tömbindex = 0;
            while (!sr.EndOfStream)
            {
                kocsik[tömbindex] = sr.ReadLine();
                tömbindex++;
            }
            sr.Close();
            for (int i = 0; i < tömbindex; i++)
            {
                adatok seged = new adatok();
                if (tömbindex % 2 == 0)
                {
                    //seged.km = Convert.ToInt32(kocsik[i]);
                    km[i] = Convert.ToInt32(kocsik[i]);
                    adatlista.Add(seged);
                }
                else
                {
                    //seged.nev = kocsik[i];
                    auto[i] = kocsik[i];
                    adatlista.Add(seged);
                }
            }
            Console.WriteLine("Autók - kilométer: ");
            for (int i = 0; i < tömbindex; i++)
            {
                Console.WriteLine($"{auto[i]} - {km[i]}km");
            }
        }
        static void Main(string[] args)
        {
            beolvasas_es_kiiras();
            Console.ReadKey();
        }
    }
}
