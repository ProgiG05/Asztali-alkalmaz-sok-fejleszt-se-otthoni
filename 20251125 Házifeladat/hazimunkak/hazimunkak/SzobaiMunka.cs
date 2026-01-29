using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazimunkak
{
    internal class SzobaiMunka : Hazimunka
    {
        private string helysegTipusa;
        public string Helysegtipusa
        {
            get => helysegTipusa;
            set => helysegTipusa = value == "szoba" || value == "konyha" || value == "mellékhelység" ? value : throw new Exception("Helytelen helység típús! ");
        }
        public SzobaiMunka(int azonosito, int vegreHajtasIdeje, string tevekenyseg, string fontossag, string helysegTipusa) : base(azonosito,vegreHajtasIdeje,tevekenyseg,fontossag)
        {
            Azonosito = azonosito;
            VegreHajtasIdeje = vegreHajtasIdeje;
            Tevekenyseg = tevekenyseg;
            Fontossag = fontossag;
            Helysegtipusa = helysegTipusa;
        }
        public override string MunkaElvegzese()
        {
            return $"A {Helysegtipusa} helységben a házimunka el lett végezve.";
        }
        public override string ToString()
        {
            return $"{base.ToString()}. {MunkaElvegzese()}";
        }
    }
}
