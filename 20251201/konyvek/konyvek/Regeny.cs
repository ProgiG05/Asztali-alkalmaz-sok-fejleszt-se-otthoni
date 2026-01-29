using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    class Regeny : Konyv
    {
        
        private string tortenelmiIdoszak;
        public string TortenelmiIdoszak
        {
            get => tortenelmiIdoszak;
            set => tortenelmiIdoszak = value != "" ? value : throw new Exception("Az érték nem lehet üres! ");
        }
        public Regeny(int azonosito, string cim, string szerzo, int oldalszam, string kategoria, string tortenelmiIdoszak) : base(azonosito, cim, szerzo, oldalszam, kategoria)
        {
            Azonosito = azonosito;
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Kategoria = kategoria;
            TortenelmiIdoszak = tortenelmiIdoszak;
        }
        public override string OlvasasElkezdes()
        {
            return $"A történelmi regény olvasása elkezdődött.";
        }
        public override string ToString()
        {
            return $"{base.ToString()} {OlvasasElkezdes()}";
        }
    }
}
