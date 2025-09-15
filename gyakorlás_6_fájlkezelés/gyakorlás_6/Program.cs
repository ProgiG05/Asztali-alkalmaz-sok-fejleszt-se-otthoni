using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace gyakorlás_6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("ital.txt",Encoding.Default);
            string[] italnév = new string[10];
            int[] egységár = new int[10];
            int[] eladás = new int[10];
            string[] egysor = new string[3];
            int tombindex = 0;
            while (!sr.EndOfStream)
            {
                egysor = sr.ReadLine().Split(';');
                italnév[tombindex] = egysor[0];
                egységár[tombindex] = Convert.ToInt32(egysor[1]);
                eladás[tombindex] = Convert.ToInt32(egysor[2]);
                tombindex++;
            }
            sr.Close();
            Console.WriteLine("A Betérő kocsma italválasztéka: ");
            for (int i = 0; i < tombindex; i++)
            {
                Console.WriteLine($"{i+1}. {italnév[i]}");
            }
            Console.WriteLine($"A Betérő kocsma italválasztékának száma: {tombindex}");
            Console.WriteLine($"A Betérő kocsma italonkénti bevételei: ");
            int összbevétel = 0;
            for (int i = 0; i < eladás.Length-3; i++)
            {
                int keplet = egységár[i] * eladás[i] * 100;
                Console.WriteLine($"{italnév[i]} - {keplet} Ft");
                összbevétel += keplet;
            }
            Console.WriteLine($"A Betérő kocsma összbevétele: {összbevétel}");
            int drágaIndex = egységár.Max();
            for (int i = 0; i < egységár.Length; i++)
            {
                if (drágaIndex == egységár[i])
                {
                    Console.WriteLine($"A Betérő kocsma legdrágább itala: {italnév[i]}");
                }
            }
            int legjobbItókaIndex = eladás.Max();
            for (int i = 0; i < eladás.Length; i++)
            {
                if (legjobbItókaIndex == eladás[i])
                {
                    Console.WriteLine($"A Betérő kocsma legkedveltebb itala: {italnév[i]}");
                }
            }
            Console.WriteLine($"A Betérő kocsma italjainak összes literje: {eladás.Sum()}l");
            //--------------------------------------------------------------------------------------------------
            StreamWriter sw = new StreamWriter("megoldas.txt");
            sw.WriteLine("A Betérő kocsma italválasztéka: ");
            for (int i = 0; i < tombindex; i++)
            {
                sw.WriteLine($"{i + 1}. {italnév[i]}");
            }
            sw.WriteLine($"A Betérő kocsma italválasztékának száma: {tombindex}");
            sw.WriteLine($"A Betérő kocsma italonkénti bevételei: ");
            int osszbevétel = 0;
            for (int i = 0; i < eladás.Length-3; i++)
            {
                int keplet = egységár[i] * eladás[i] * 100;
                sw.WriteLine($"{italnév[i]} - {keplet} Ft");
                osszbevétel += keplet;
            }
            sw.WriteLine($"A Betérő kocsma összbevétele: {összbevétel}");
            int dragaIndex = egységár.Max();
            for (int i = 0; i < egységár.Length; i++)
            {
                if (dragaIndex == egységár[i])
                {
                    sw.WriteLine($"A Betérő kocsma legdrágább itala: {italnév[i]}");
                }
            }
            int legjobbItokaIndex = eladás.Max();
            for (int i = 0; i < eladás.Length; i++)
            {
                if (legjobbItokaIndex == eladás[i])
                {
                    sw.WriteLine($"A Betérő kocsma legkedveltebb itala: {italnév[i]}");
                }
            }
            sw.WriteLine($"A Betérő kocsma italjainak összes literje: {eladás.Sum()}");
            sw.Close();
            Console.ReadKey();
        }
        static void Beolvasás2()
        {
            StreamReader sr2 = new StreamReader("italok.txt");
            string[] egysor = new string[3];
            List<string> név = new List<string>();
            List<int> ár = new List<int>();
            List<int> adás = new List<int>();
            while (!sr2.EndOfStream)
            {
                egysor = sr2.ReadLine().Split(';');
                név.Add(egysor[0]);
                ár.Add(Convert.ToInt32(egysor[1]));
                adás.Add(Convert.ToInt32(egysor[2]));
            }
            sr2.Close();
        }
        struct Ital
        {
            public string név;
            public int ár, adás;
        }
        static Ital[] itókák = new Ital[100];
        static void Beolvasás3()
        {
            StreamReader sr3 = new StreamReader("italok.txt");
            string[] egysor = new string[3];
            int index = 0;
            while (!sr3.EndOfStream)
            {
                itókák[index].név = egysor[0];
                itókák[index].ár = Convert.ToInt32(egysor[1]);
                itókák[index].adás = Convert.ToInt32(egysor[2]);
                index++;
            }
            sr3.Close();
        }
        static List<Ital> italkák = new List<Ital>();
        static void Beolvasás4()
        {
            StreamReader sr4 = new StreamReader("italok.txt");
            string[] egysor = new string[3];
            while (!sr4.EndOfStream)
            {
                egysor = sr4.ReadLine().Split(';');
                Ital segédital = new Ital();
                segédital.név = egysor[0];
                segédital.ár = Convert.ToInt32(egysor[1]);
                segédital.adás = Convert.ToInt32(egysor[2]);
                italkák.Add(segédital);
            }
            sr4.Close();
        }
    }
}
