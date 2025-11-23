using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_AbstraktOsztály
{
    internal class Cica : Allat
    {
        public Cica(string nev, int kor) : base(nev,kor)
        {

        }
        public override string Beszel()
        {
            return "mjáu";
        }
        public override void Eszik()
        {
            Console.WriteLine("hamhamhamham");
        }
    }
}
