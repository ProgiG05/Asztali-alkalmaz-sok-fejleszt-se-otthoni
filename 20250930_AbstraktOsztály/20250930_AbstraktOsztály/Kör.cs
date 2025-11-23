using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250930_AbstraktOsztály
{
    internal class Kör : Alakzat
    {
        public double r;
        public Kör(double r)
        {
            this.r = r;
        }
        public override double Terulet()
        {
            return Math.Round(Math.Pow(r, 2) * Math.PI, 2);
            //throw new NotImplementedException();
        }
    }
}
