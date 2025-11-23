using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton_0517
{
    class ultraB
    {
        //adattag - fájl adatai
        public string nev,kategoria,vido;
        public int rajtszam,ora,perc,mp,tavszazalek;

        //konstruktor 
        public ultraB(string nev, string kategoria, int rajtszam, string vido, int tavszazalek)
        {
            this.nev = nev;
            this.kategoria = kategoria;
            this.rajtszam = rajtszam;
            this.vido = vido;
            this.tavszazalek = tavszazalek;
        }

        //konstruktor 2.0
        
        public ultraB(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            rajtszam = Convert.ToInt32(egysor[1]);
            kategoria = egysor[2];
            vido = egysor[3];
            tavszazalek = Convert.ToInt32(egysor[4]);
        }

    }
}
