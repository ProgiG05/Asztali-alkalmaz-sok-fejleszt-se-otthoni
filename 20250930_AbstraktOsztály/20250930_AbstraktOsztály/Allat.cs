using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_AbstraktOsztály
{
    abstract class Allat
    {
        string nev;
        int kor;
        
        public string Nev
        {
            get => nev;
            set => nev = string.IsNullOrWhiteSpace(value) ? throw new Exception("Név megadása kötelező!") : value;
        }
        public int Kor
        {
            get => kor;
            set => kor = value < 0 ? throw new Exception("A kor nem kehet negatív!") : value;
        }

        public Allat(string nev, int kor)
        {
            Kor = kor;
            Nev = nev;
        }
        public abstract void Eszik();

        public abstract string Beszel();
    }
}
