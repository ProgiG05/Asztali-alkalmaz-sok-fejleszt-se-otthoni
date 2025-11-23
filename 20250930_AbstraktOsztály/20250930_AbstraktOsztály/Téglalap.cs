using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_AbstraktOsztály
{
    internal class Téglalap : Alakzat
    {
        public int Aoldal {  get; set; }
        public int Boldal { get; set; }
        public Téglalap(int a, int b)
        {
            Aoldal = a;
            Boldal = b;
        }
        public override double Terulet()
        {
            return Aoldal * Boldal;
            //throw new NotImplementedException();
        }

    }
}
