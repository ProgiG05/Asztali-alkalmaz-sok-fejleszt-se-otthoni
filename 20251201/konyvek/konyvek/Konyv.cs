using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    abstract class Konyv
    {
        private int azonosito;
        private string cim;
        private string szerzo;
        private int oldalszam;
        private string kategoria;

        public int Azonosito
        {
            get => azonosito;
            set => azonosito = value > 0 || value < 50 ? value : throw new Exception("Az azonosito nem lehet nagyobb mint 50 és nem lehet kisebb mint nulla!"); 
        }
        public string Cim
        {
            get => cim;
            set => cim = value != "" || value != null ? value : throw new Exception("A cím nem lehet üres vagy null értékű! ");
        }
        public string Szerzo
        {
            get => szerzo;
            set => szerzo = value != "" || value != null ? value : throw new Exception("A szerző nem lehet üres vagy null értékű! ");
        }
        public int Oldalszam
        {
            get => oldalszam;
            set => oldalszam = value > 0 ? value : throw new Exception("Az oldalszam nem lehet negatív értékű! ");
        }
        public string Kategoria
        {
            get => kategoria;
            set => kategoria = value == "Regény" || value == "Ifjúsági" || value == "Tudományos" ? value : throw new Exception("Helytelen kategória! ");
        }

        public Konyv(int azonosito, string cim, string szerzo, int oldalszam, string kategoria)
        {
            Azonosito = azonosito;
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Kategoria = kategoria;
        }

        public abstract string OlvasasElkezdes();

        public override string ToString()
        {
            return $"{azonosito}. könyv: {Cim} - {Szerzo} ({Kategoria}) - {Oldalszam} oldal";
        }

    }
}
