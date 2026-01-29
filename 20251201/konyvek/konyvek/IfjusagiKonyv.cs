using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    class IfjusagiKonyv: Konyv
    {
        private string celcsoport;
        public string Celcsoport
        {
            get => celcsoport;
            set => celcsoport = value == "gyerekek" || value == "tinédzserek" || value == "fiatal felnőttek" ? value : throw new Exception("Helytelen célcsoport! ");
        }
        public IfjusagiKonyv(int azonosito, string cim, string szerzo, int oldalszam, string kategoria, string celcsoport) : base(azonosito, cim, szerzo, oldalszam, kategoria)
        {
            Azonosito = azonosito;
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Kategoria = kategoria;
            Celcsoport = celcsoport;
        }
        public override string OlvasasElkezdes()
        {
            return $"Az ifjúsági könyv olvasása elkezdődött.";
        }
        public override string ToString()
        {
            return $"{base.ToString()} {OlvasasElkezdes()}";
        }
    }
}
