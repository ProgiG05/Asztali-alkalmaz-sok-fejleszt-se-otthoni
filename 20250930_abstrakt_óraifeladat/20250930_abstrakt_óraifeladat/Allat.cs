using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_abstrakt_óraifeladat
{
    abstract class Allat
    {
        private string nev;
        private int kor;
        private int suly;

        public string Nev
        {
            get => nev;
            set => nev = value != "" && value != "ismeretlen" ? value : throw new Exception("A név üres vagy ismeretlen érték!");
        }
        public int Kor
        {
            get => kor;
            set => kor = value > 0 ? value : throw new Exception("Rossz ám");
        }
        public int Suly
        {
            get => suly;
            set => suly = value > 0 ? value : throw new Exception("Rossz ám");
        }

        public Allat(string nev, int kor, int suly)
        {
            Nev = nev;
            Kor = kor;
            Suly = suly;
        }
        public abstract void Etkezik()
        {
            Console.WriteLine("Mindenevő");
        }
        public abstract void Mozog()
        {
            Console.WriteLine($"{Nev}");
        }
        public abstract void HangotAd()
        {
            Console.WriteLine();
        }
    }
}
