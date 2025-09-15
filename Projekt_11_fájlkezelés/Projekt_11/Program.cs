using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //fájlkezelés
namespace Projekt_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fájlba írás
            //Console.Write("Mi legyen a fájl neve? ");
            //string fileNeve = Console.ReadLine();
            //StreamWriter sw = new StreamWriter(fileNeve + ".txt");
            //StreamWriter sw = new StreamWriter("meki.txt");
            //sw.WriteLine("Saját lista");
            //sw.WriteLine("hambi");
            //sw.WriteLine("kumpi");
            //Console.Write("Mit szeretnél még enni?");
            //string etel = Console.ReadLine();
            //sw.WriteLine(etel);
            //sw.Close();


            //Fájlból olvasás
            //StreamReader sr = new StreamReader(@"C:\Users\szabo.gergo.1005\source\repos\Projekt_11\Projekt_11\bin\Debug\meki.txt");
            //StreamReader sr = new StreamReader(fileNeve + ".txt");
            //etel = sr.ReadLine();
            //Console.WriteLine($"A fájl első sora: {etel}");
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());

            //while (!sr.EndOfStream)
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}
            //sr.Close();



            //tömb adatszerkezet használata
            //a fájl egy sora 4db adatot tartalmaz -> 4db tömb
            string[] allatNeve = new string[100];
            int[] allatKora = new int[100];
            string[] allatKaja = new string[100];
            int[] allatLaba = new int[100];
            //allatNeve[0] = "Cica";
            int index = 0; //tömb adatszerkezetek index


            //allatok fájl beolvasása
            StreamReader sr1 = new StreamReader("allatok.txt");
            string[] egysor = new string[4];
            while (!sr1.EndOfStream)
            {
                egysor = sr1.ReadLine().Split(' ');
                allatNeve[index] = egysor[0];
                allatKora[index] = Convert.ToInt32(egysor[1]);
                allatKaja[index] = egysor[2];
                allatLaba[index] = Convert.ToInt32(egysor[3]);
                index++;
                //Console.WriteLine(sr1.ReadLine());
            }
            sr1.Close();
            //allatok nevének kiíratása
            for (int i = 0; i < index; i++)
            {
                Console.Write(allatNeve[i] + " ");
            }





            //lista adatszerkezet használata
            List<string> aNev = new List<string>();
            List<int> aKora = new List<int>();
            List<string> aKaja = new List<string>();
            List<int> aLaba = new List<int>();

            StreamReader sr2 = new StreamReader("allatok.txt");
            while (!sr2.EndOfStream)
            {
                string[] egySor = sr2.ReadLine().Split(' ');
                aNev.Add(egySor[0]);
                aKora.Add(Convert.ToInt32(egySor[1]));
                aKaja.Add(egySor[2]);
                aLaba.Add(Convert.ToInt32(egySor[3]));

                //aNev.Add(sr2.ReadLine().Split(' ')[0]);
                //aKora.Add(Convert.ToInt32(sr2.ReadLine().Split(' ')[1]));
                //aKaja.Add(sr2.ReadLine().Split(' ')[2]);
                //aLaba.Add(Convert.ToInt32(sr2.ReadLine().Split(' ')[3]));
            }

            sr2.Close();
            Console.WriteLine();
            //állatok nevének kiíratása
            for (int i = 0; i < aNev.Count; i++)
            {
                Console.Write($"{aNev[i]} ");
            }
            Console.WriteLine($"Az állatkertben {aNev.Count} állat van");
            Console.WriteLine($"Az állatok átlagéletkora: {aKora.Average():0.00}");
            Console.WriteLine($"A legidősebb állat: {aKora.Max()} éves");
            Console.WriteLine($"Az állatok összesen {aLaba.Sum()} lábbal rendelkezik");
            Console.Write($"Melyik állat eszik Ronaldot? ");
            for (int i = 0; i < aNev.Count; i++)
            {
                if (aKaja[i] == "Ronaldo")
                {
                    Console.WriteLine($"{aNev[i]} ");
                }
            }
            Beolvasás1();
            Beolvasás2();

            Console.ReadKey();
        }//main

        struct allatTipus
        {
            public string nev, kaja;
            public int kor, lab;
        }

        //struktúra típúsú tömb
        static allatTipus[] allat = new allatTipus[100];
        static int tömbIndex = 0;
        static void Beolvasás1()
        {
            StreamReader sr = new StreamReader("allatok.txt");
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(' ');
                allat[tömbIndex].nev = egysor[0];
                allat[tömbIndex].kor = Convert.ToInt32(egysor[1]);
                allat[tömbIndex].kaja = egysor[2];
                allat[tömbIndex].lab = Convert.ToInt32(egysor[3]);
                tömbIndex++;
            }
            sr.Close();
            Console.WriteLine("A beolvasott állatok adatai: ");
            Console.WriteLine("\t Név\t Kor\t Étel\t Láb");
            Console.WriteLine("------------------------------------------");
            for (int i = 0; i < tömbIndex; i++)
            {
                Console.WriteLine($"\t{allat[i].nev}\t{allat[i].kor}\t{allat[i].kaja}\t{allat[i].lab}");
            }
        }
        //struktúra típúsú lista
        static List<allatTipus> allatka = new List<allatTipus>();
        static void Beolvasás2()
        {
            StreamReader sr = new StreamReader("allatok.txt");
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(' ');
                allatTipus segedAllat = new allatTipus();
                segedAllat.nev = egysor[0];
                segedAllat.kor = Convert.ToInt32(egysor[1]);
                segedAllat.kaja = egysor[2];
                segedAllat.lab = Convert.ToInt32(egysor[3]);
                allatka.Add(segedAllat);
            }
            sr.Close();

            foreach (var item in allatka)
            {
                Console.WriteLine($"{item.nev} - {item.kor} - {item.kaja} - {item.lab}");
            }
        }
    }
}
