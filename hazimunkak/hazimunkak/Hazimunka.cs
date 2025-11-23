using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazimunkak
{
    abstract class Hazimunka
    {
        private int azonosito, vegreHajtasIdeje;
        private string tevekenyseg, fontossag, kategoria;
        public string Kategoria { get; set; }
        public int Azonosito
        {
            get => azonosito;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Az azonosító nem lehet negatív! ");
                }
                else if (value == 0)
                {
                    throw new Exception("Az azonosító nem lehet nulla! ");
                }
                else if (value >= 25)
                {
                    throw new Exception("Az azonosító nem lehet nagyobb mint 25! ");
                }
                else
                {
                    value = azonosito;
                }
            }
        }
        public string Tevekenyseg
        {
            get => tevekenyseg;
            set => tevekenyseg = value == "" || value == null ? throw new Exception("A tevékenység nem lehet üres vagy null!") : value;
        }
        public string Fontossag
        {
            get => fontossag;
            set => fontossag = value == "Magas" || value == "Közepes" || value == "Alacsony" ? value : throw new Exception("Helytelen fontossági fokozat! ");
        }
        public int VegreHajtasIdeje
        {
            get => VegreHajtasIdeje;
            set
            {
                if (value < 0)
                {
                    throw new Exception("A végrehajtás ideje nem lehet negatív! ");
                }
                else if (value % 1 == 0)
                {
                    throw new Exception("A végrehajtás ideje csak egész szám lehet");
                }
                else
                {
                    value = VegreHajtasIdeje;
                }
            }
        }

        public Hazimunka(int azonosito, int vegreHajtasIdeje, string tevekenyseg, string fontossag)
        {
            Azonosito = azonosito;
            VegreHajtasIdeje = vegreHajtasIdeje;
            Tevekenyseg = tevekenyseg;
            Fontossag = fontossag;
        }
        
        public abstract string MunkaElvegzese();
        public override string ToString()
        {
            return $"{Azonosito}. munka: {Tevekenyseg} ({Fontossag}) - {VegreHajtasIdeje} perc";
        }
    }
}
