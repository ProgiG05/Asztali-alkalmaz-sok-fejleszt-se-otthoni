using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okosvaros
{
    class Busz : Jarmu, IKornyezetBarat
    {
        private int utasokSzama;
        private int kibocsatas;
        public override string Kategoria { get; set; }
        public int UtasokSzama { get => utasokSzama; set => utasokSzama = value; }
        public int Kibocsatas { get => kibocsatas; set => kibocsatas = value; }
        public Busz(string azonosito, string tipus, int ferohely, int sebesseg, int utasokSzama, int kibocsatas) : base(azonosito, tipus, ferohely, sebesseg)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Ferohely = ferohely;
            Sebesseg = sebesseg;
            UtasokSzama = utasokSzama;
            Kibocsatas = kibocsatas;
            Kategoria = "Tömegközlekedés";
        }
        public Busz(string azonosito, int utasokSzama) : base(azonosito)
        {
            Azonosito = azonosito;
            Tipus = "ismeretlen busztípús";
            Ferohely = 0;
            Sebesseg = 0;
            UtasokSzama = utasokSzama;
            Kibocsatas = 0;
            Kategoria = "Tömegközlekedés";
        }
        public override string Indul()
        {
            return $"Az {Azonosito} azonosítójú busz {UtasokSzama} utassal elindult.";
        }
        public override string Megall()
        {
            return $"Az {Azonosito} azonosítójú busz megállt";
        }
        public override string MozogCelhoz(string cel)
        {
            return $"Az {Azonosito} azonosítójú busz a {cel} felé halad";
        }
        public int KibocsatasSzintje()
        {
            return Kibocsatas;
        }
        public bool ElektromosE()
        {
            return false;
        }
        public override string Leiras()
        {
            return $"Az {Azonosito} azonosítójú 40 férőhelyes {Tipus} busz sebessége {Sebesseg} km/h. Utasok száma {UtasokSzama} fő, károsanyag-kibocsátása {KibocsatasSzintje()} g/km";
        }
    }
}
