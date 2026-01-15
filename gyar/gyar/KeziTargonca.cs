using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyar
{
    class KeziTargonca : LogisztikaiEszkoz, IVeszelyesAnyagkezelo,IKarbantartasiIgeny
    {
        private string munkavegzoTipus;
        private bool veszelyesAnyagE;
        private DateTime utolsoKarbantartas;
        public override string Besorolas => "Emberi irányítás";
        public string MunkavegzoTipus { get => munkavegzoTipus; set => munkavegzoTipus = value != "VILLA" || value != "KOSÁR" ? value : throw new Exception("Helytelen munkavégző típus! "); }
        public bool VeszelyesAnyagE() => veszelyesAnyagE;
        public DateTime UtolsoKarbantartas { get => utolsoKarbantartas; set => utolsoKarbantartas = value < DateTime.Today ? value : throw new Exception("Helytelen dátum! "); }

        public KeziTargonca(string azonosito, string tipus, int terhelhetoseg, double sebesseg, string munkavegzoTipus, string veszelyesAnyagE, DateTime utolsoKarbantartas) : base(azonosito, tipus, terhelhetoseg, sebesseg)
        {
            MunkavegzoTipus = munkavegzoTipus;
            this.veszelyesAnyagE = veszelyesAnyagE == "Igen" ? true : false;
            UtolsoKarbantartas = utolsoKarbantartas;
        }
        public override string Megjelenites()
        {
            string veszelyesAnyagStr = VeszelyesAnyagE() ? "Igen" : "Nem";
            return $"{base.Megjelenites()}\nMunkavégzési típús: {MunkavegzoTipus}.\nVeszélyes anyag: {veszelyesAnyagStr}.\nUtolsó Karbantartás dátuma: {utolsoKarbantartas}";
        }
        public override string MunkatIndit()
        {
            return $"{Azonosito} azonosítójú kézi targonca munkába lépett";
        }
        public override string MunkatLezar()
        {
            return $"{Azonosito} azonosítójú kézi targonca munkát lezárt";
        }   
        public override string SzalagFellettHalad(string pozicio)
        {
            return $"{Azonosito} azonosítójú kézi targonca a szalag felett halad. Pozíció: {pozicio}";
        }
        public string BiztonsagiEljaras()
        {
            if (VeszelyesAnyagE())
            {
                return "Viseljen megfelelő védőfelszerelést és tartsa be a biztonsági előírásokat!";
            }
            else
            {
                return "Nincs szükség külön biztonsági eljárásra.";
            }
        }
        public DateTime UtolsoKarbantartasDatuma()
        {
            if (UtolsoKarbantartas > DateTime.Today)
            {
                return UtolsoKarbantartas;
            }
            else
            {
                throw new Exception("Nincs érvényes karbantartási dátum!");
            }
        }
        public bool KarbantartasSzuksegesE()
        {
            if ((DateTime.Today - UtolsoKarbantartas).TotalDays > 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
