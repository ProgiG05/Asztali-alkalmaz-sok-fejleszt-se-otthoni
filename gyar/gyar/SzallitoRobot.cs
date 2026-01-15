using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyar
{
    class SzallitoRobot : LogisztikaiEszkoz, IKarbantartasiIgeny
    {
        private string energiaForras;
        private DateTime utolsoKarbantartas;
        public override string Besorolas => "autonóm";

        public string EnergiaForras { get => energiaForras; set => energiaForras = value == "akkumulátor" || value == "hibrid" ? value : throw new Exception("Helytelen energiaforrás! "); }
        public DateTime UtolsoKarbantartas { get => utolsoKarbantartas; set => utolsoKarbantartas = value < DateTime.Today ? value : throw new Exception("Helytelen dátum! "); }

        public SzallitoRobot(string azonosito, string tipus, int terhelhetoseg, double sebesseg, string energiaForras, DateTime utolsoKarbantartas) : base(azonosito, tipus, terhelhetoseg, sebesseg)
        {
            EnergiaForras = energiaForras;
            UtolsoKarbantartas = utolsoKarbantartas;
        }
        public override string Megjelenites()
        {
            return base.Megjelenites();
        }
        public override string MunkatIndit()
        {
            return $"{Azonosito} azonosítójú jármű munkába lépett";
        }
        public override string MunkatLezar()
        {
            throw new NotImplementedException();
        }
        public override string SzalagFellettHalad(string pozicio)
        {
            return $"{Azonosito} azonosítójú a szalag felett halad. ";
        }
        public DateTime UtolsoKarbantartasDatuma()
        {
            return new DateTime(2025, 9, 11);
        }
        public bool KarbantartasSzuksegesE()
        {
            return false;
        }
    }
}
