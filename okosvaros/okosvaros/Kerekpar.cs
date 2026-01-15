using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okosvaros
{
    class Kerekpar : Jarmu, IKornyezetBarat
    {
        
        public override string Kategoria { get; set; }
        private string fajta;
        private int kibocsatas;
        public string Fajta { get => fajta; set => fajta = value == "országúti" || value == "hegyi" || value == "városi" ? value : throw new Exception("Helytelen fajta! "); }
        public int Kibocsatas { get => kibocsatas; set => kibocsatas = 0; }
        public Kerekpar(string azonosito, string tipus, int ferohely, int sebesseg,string fajta, int kibocsatas) : base(azonosito, tipus, ferohely, sebesseg)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Ferohely = ferohely;
            Sebesseg = sebesseg;
            Fajta = fajta;
            Kibocsatas = kibocsatas;
            Kategoria = "Egyéni közlekedés";
        }
        public Kerekpar(string azonosito, string fajta, int kibocsatas) : base(azonosito)
        {
            Azonosito = azonosito;
            Tipus = "ismeretlen kerékpártípús";
            Ferohely = 1;
            Sebesseg = 0;
            Fajta = fajta;
            Kibocsatas = kibocsatas;
            Kategoria = "Egyéni közlekedés";
        }
        public override string Indul()
        {
            return $"Az {Azonosito} azonosítójú kerékpár elindult.";
        }
        public override string Megall()
        {
            return $"Az {Azonosito} azonosítójú kerékpár megállt.";
        }
        public override string MozogCelhoz(string cel)
        {
            return $"Az {Azonosito} azonosítójú kerékpár a {cel} felé halad";
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
            return $"Az {Azonosito} azonosítójú 1 férőhelyes {Tipus} kerékpár sebessége {Sebesseg} km/h. Típusa {fajta}, károsanyag-kibocsátása {KibocsatasSzintje()} g/km";
        }
    }
}
