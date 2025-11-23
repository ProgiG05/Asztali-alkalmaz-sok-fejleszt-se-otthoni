using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_AbstraktOsztály
{
    internal class Kutya : Allat
    {
        string gazda;
        public string Gazda
        {
            get => gazda;
            set => gazda = value.Length < 1 ? throw new Exception("Legalább egy betűs elgyen a gazda!") : value;
        }
        public Kutya(string nev, int kor, string gazda) : base(nev, kor)
        {
            Gazda = gazda;
        }
        public override void Eszik()
        {
            Console.WriteLine("Nyam - nyam");
        }
        public override string Beszel()
        {
            return "vauvauvauvauvauvauvau";
        }
    }
}
