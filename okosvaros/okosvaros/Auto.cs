using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okosvaros
{
    class Auto : Jarmu, IKornyezetBarat
    {
        private string uzemanyagTipus;
        private int kibocsatas;
        private int energiaSzint;
        public override string Kategoria{get ;set ;}
        public string UzemanyagTipus { get => uzemanyagTipus; set => uzemanyagTipus = value == "benzin" || value == "dízel" || value == "elektromos" ? value : throw new Exception("Helytelen üzemanyagtípús! "); }
        public int Kibocsatas { get => kibocsatas; set => kibocsatas = value; }
        public int EnergiaSzint { get => energiaSzint; set => energiaSzint = value; }
        public Auto(string azonosito, string tipus, int ferohely, int sebesseg, string uzemanyagTipus, int kibocsatas, int energiaSzint) : base (azonosito,tipus,ferohely,sebesseg)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Ferohely = ferohely;
            Sebesseg = sebesseg;
            UzemanyagTipus = uzemanyagTipus;
            Kibocsatas = kibocsatas;
            EnergiaSzint = energiaSzint;
            Kategoria = "Személyszállító";
        }
        public Auto(string azonosito, string uzemanyagTipus, int kibocsatas) : base(azonosito)
        {
            Azonosito = azonosito;
            Tipus = "ismeretlen autótípús";
            Ferohely = 0;
            Sebesseg = 0;
            UzemanyagTipus = uzemanyagTipus;
            Kibocsatas = kibocsatas;
            EnergiaSzint = 0;
        }
        public override string Leiras()
        {
            string jel = UzemanyagTipus == "benzin" || UzemanyagTipus == "dízel" ? "l" : "%";
            return $"{Azonosito} azonosítójú {Ferohely} férőhelyes {Kategoria} {Tipus} sebessége {Sebesseg} km/h. {UzemanyagTipus}, károsanyag-kibocsátása {KibocsatasSzintje()} g/km, aktuális üzemanyagszintje {EnergiaSzint} {jel}.";
        }
        public override string Indul()
        {
            if (UzemanyagTipus == "benzin" || UzemanyagTipus == "dízel")
            {
                if (EnergiaSzint > 5)
                {
                    return "Az autó elindult.";
                }
                else
                {
                    return "Az autó nem tud elindulni.";
                }
            }
            else if (UzemanyagTipus == "elektromos")
            {
                if (EnergiaSzint > 20)
                {
                    return "Az autó elindult.";
                }
                else
                {
                    return "Az autó nem tud elindulni.";
                }
            }
            else
            {
                return "Helytelen üzemanyag típus.";
            }
        }
        public override string Megall()
        {
            return $"Az {Azonosito} azonosítójú autó megállt! ";
        }
        public override string MozogCelhoz(string cel)
        {
            if (Megall() != $"Az {Azonosito} azonosítójú autó megállt! " || Indul() == "Az autó elindult.")
            {
                return $"Az {Azonosito} azonosoítójú autó a {cel} felé halad.";
            }
            else
            {
                return $"Az {Azonosito} azonosoítójú autó a {cel} felé nem tud haladni.";
            }
        }
        public int KibocsatasSzintje()
        {
            return Kibocsatas;
        }
        public bool ElektromosE()
        {
            if (UzemanyagTipus == "benzin" || UzemanyagTipus == "dízel")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
