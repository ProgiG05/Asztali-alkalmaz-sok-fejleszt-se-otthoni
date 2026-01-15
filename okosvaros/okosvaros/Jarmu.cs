using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okosvaros
{
    abstract class Jarmu
    {
        private string azonosito;
        private string tipus;
        private int ferohely;
        private int sebesseg;

        public string Azonosito
        {
            get => azonosito;
            set => azonosito = value != "" || value != null ? value : throw new Exception("Az azonosító nem lehet üres!");
        }
        public string Tipus
        {
            get => tipus;
            set => tipus = value != "" || value != null ? value : throw new Exception("Az típus nem lehet üres!");
        }
        public int Ferohely
        {
            get => ferohely;
            set => ferohely = value > 0 ? value : throw new Exception("A férőhely csak pozitív szám lehet! ");
        }
        public int Sebesseg
        {
            get => sebesseg;
            set => sebesseg = value > 0 ? value : throw new Exception("A sebesség csak pozitív szám lehet! ");
        }
        public abstract string Kategoria{ get; set; }
        public Jarmu(string azonosito, string tipus, int ferohely, int sebesseg)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Ferohely = ferohely;
            Sebesseg = sebesseg;
        }
        public Jarmu(string azonosito)
        {
            Azonosito = azonosito;
            Tipus = "ismeretlen";
            Ferohely = 0;
            Sebesseg = 0;
        }
        public abstract string Leiras();
        public abstract string Indul();
        public abstract string Megall();
        public abstract string MozogCelhoz(string cel);
    }
}
