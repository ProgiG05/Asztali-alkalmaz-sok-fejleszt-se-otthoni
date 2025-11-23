using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250929_Öröklödés_8_JátékosKarakter
{
    internal class Karakter
    {
        private string nev;
        private int szint;
        private int eletero;
        private int maxeletero;
        private DateTime letrehozasIdeje;

        public string Nev
        {
            get => nev;
            set => nev = value != "" ? value : throw new Exception("A karakter neve nem lehet üres!");
        }
        public int Szint
        {
            get => szint;
            set => szint = value >= 1 ? value : throw new Exception("A szint legalább 1 kell, hogy legyen!");
        }
        public int Maxeletero
        {
            get => maxeletero;
            set => maxeletero = value > 10 ? value : throw new Exception("A maximális életerő legalább 10 kell, hogy legyen!");
        }
        public int Eletero
        {
            get => eletero;
            set
            {
                if (value > 0)
                {
                    if (value <= Maxeletero)
                    {
                        eletero = value;
                    }
                    else
                    {
                        throw new Exception("Az életerő nem lehet negatív vagy nagyobb, mint a maximális életerő! ");
                    }
                }
                else
                {
                    throw new Exception("Az életerő nem lehet negatív vagy nagyobb, mint a maximális életerő! ");
                }
            }
        }
        public DateTime LetrehozasIdeje
        {
            get => letrehozasIdeje;
            set => letrehozasIdeje = value <= DateTime.Now && value > new DateTime(2020,11,1) ? value : throw new Exception("A létrehozás ideje nem lehet a jövőben!");
        }

        public Karakter(string nev, int szint, int maxeletero, int eletero, DateTime letrehozasIdeje)
        {
            Nev = nev;
            Szint = szint;
            Maxeletero = maxeletero;
            Eletero = eletero;
            LetrehozasIdeje = letrehozasIdeje;
        }
        public Karakter(string nev,int szint)
        {
            Nev = nev;
            Szint = szint;
            Maxeletero = 100;
            Eletero = 100;
            LetrehozasIdeje = DateTime.Now;
        }

        public virtual int SebzestKap(int sebzes)
        {
            if (Eletero - sebzes > 0)
            {
                if (sebzes < Eletero)
                {
                    int eredmeny = Eletero - sebzes;
                    Eletero = eredmeny;
                    return eredmeny;
                }
                else
                {
                    int eredmeny = 0;
                    return eredmeny;
                }
            }
            else
            {
                throw new Exception("A karakter már halott!");
            }
        }
        public virtual int Gyogyul(int gyogy)
        {
            if ((Eletero + gyogy) <= Maxeletero)
            {
                int eredmeny = Eletero + gyogy;
                Eletero = eredmeny;
                return eredmeny;
            }
            else
            {
                throw new Exception("A karakter életereje nem lehet nagyobb, mint a maximális életereje!");
            }
        }
        public virtual void SzintetLep()
        {
            int ujMaxeletero = Convert.ToInt32(Math.Floor(Maxeletero * 1.1));
            int ujEletero = ujMaxeletero;
            int ujSzint = Szint + 1;
            Szint = Szint + 1;

            Console.WriteLine($"Név: {Nev}\nSzint: {ujSzint}\nÉleterő: {ujEletero}/{ujMaxeletero}");
        }

        public virtual void Kiir()
        {
            Console.WriteLine($"Név: {Nev}\nSzint: {Szint}\nÉleterő: {Eletero}/{Maxeletero}\nLétrehozás ideje: {LetrehozasIdeje}\n");
        }
        public virtual void KombatKiir()
        {
            Console.WriteLine($"Név: {Nev}\nSzint: {Szint}\nÉleterő: {Eletero}/{Maxeletero}");
        }
    }
    class Varazslo : Karakter
    {
        private int manna;

        public int Manna
        {
            get => manna;
            set => manna = value > 0 ? value : throw new Exception("A manna nem lehet negatív!");
        }

        public Varazslo(string nev, int szint, int maxeletero, int eletero, DateTime letrehozasIdeje, int manna) : base(nev,szint,maxeletero,eletero,letrehozasIdeje)
        {
            Nev = nev;
            Szint = szint;
            Maxeletero = maxeletero;
            Eletero = eletero;
            LetrehozasIdeje = letrehozasIdeje;
            Manna = manna;
        }

        public virtual void Varazsol(Karakter celkarakter, int manasebzes)
        {
            int celEletero = celkarakter.Eletero;
            celkarakter.Eletero = celEletero - manasebzes;
            Manna = Manna - manasebzes;
        }
    }
    class Harcos : Karakter
    {
        private int pancel;
        public int Pancel
        {
            get => pancel;
            set => pancel = value >= 0 ? value : throw new Exception("Az pancél nem lehet negatív!");
        }
        public Harcos(string nev, int szint, int maxeletero, int eletero, DateTime letrehozasIdeje, int arany) : base(nev, szint, maxeletero, eletero, letrehozasIdeje)
        {
            Nev = nev;
            Szint = szint;
            Maxeletero = maxeletero;
            Eletero = eletero;
            LetrehozasIdeje = letrehozasIdeje;
            Pancel = pancel;
        }
        public override int SebzestKap(int sebzes)
        {
            // Sebzés csökkentése a páncél értékével, de a páncél nem lehet negatív
            int eff = Math.Max(0, sebzes - pancel);
            // A páncél csökken a sebzés erejével, de nem mehet negatívba
            pancel = Math.Max(0, pancel - sebzes);
            // Életerő csökken az effektív sebzéssel, de nem mehet negatívba
            Eletero = Math.Max(0, Eletero - eff);
            return Eletero;
        }
    }
}
