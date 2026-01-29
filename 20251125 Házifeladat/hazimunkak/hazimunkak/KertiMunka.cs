using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazimunkak
{
    class KertiMunka : Hazimunka
    {
        private string eszkoz;
        public string Eszkoz
        {
            get => eszkoz;
            set => eszkoz = value == "" || value == null ? throw new Exception("Az eszköz értéke nem lehet üres") : value;
        }

        public KertiMunka(int azonosito, int vegreHajtasIdeje, string tevekenyseg, string fontossag, string eszkoz) : base(azonosito,vegreHajtasIdeje,tevekenyseg,fontossag)
        {
            Azonosito = azonosito;
            VegreHajtasIdeje = vegreHajtasIdeje;
            Tevekenyseg = tevekenyseg;
            Fontossag = fontossag;
            Eszkoz = eszkoz;
        }
        public override string MunkaElvegzese()
        {
            return $"A {eszkoz} használtával a kerti munka elkészült. ";
        }
        public override string ToString()
        {
            return $"{base.ToString()}. {MunkaElvegzese()}";
        }
    }
}
