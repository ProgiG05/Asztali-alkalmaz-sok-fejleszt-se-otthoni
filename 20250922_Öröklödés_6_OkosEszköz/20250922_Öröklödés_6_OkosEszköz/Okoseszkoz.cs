using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250922_Öröklödés_6_OkosEszköz
{
    class Okoseszkoz
    {
        private string nev;
        private string allapot;
        private int fogyasztas;
        private DateTime letrehozasIdeje;

        public string Nev
        {
            get => nev;
            set => nev = value != "" ? value : throw new Exception("A név nem lehetüres!");
        }
        
        public string Allapot
        {
            get => allapot;
            set
            {
                if (value == "bekapcsolva" || value == "kikapcsolva")
                {
                    if (value == "kikapcsolva" && Fogyasztas < 0 || Fogyasztas > 0)
                    {
                        throw new Exception("Kikapcsolt állapotban a fogyasztásnak nullának kell lennie! ");
                    }
                    else
                    {
                        allapot = value;
                    }
                }
                else
                {
                    throw new Exception("Az állapot értékei: bekapcsolva/kikapcsolva lehet !");
                }
            }

        }
        public int Fogyasztas
        {
            get => fogyasztas;
            set
            {
                if (value < 0)
                {
                    throw new Exception("A fogyasztás nem lehet negatív!");
                }
                if (Allapot == "kikapcsolva" && value != 0)
                {
                    throw new Exception("Kikapcsolt állapotban a fogyasztásnak nullának kell lennie!");
                }
                fogyasztas = value;
            }
        }
        
        public DateTime LetrehozasIdeje
        {

            get => letrehozasIdeje;
            set
            {
                DateTime minIdo = new DateTime(1990, 01, 01);
                if (value < minIdo && value > DateTime.Now)
                {
                    throw new Exception("Hibás dátum");
                }
                else
                {
                    letrehozasIdeje = value;
                }
            }
        }

        public Okoseszkoz(string nev, string allapot, int fogyasztas, DateTime letrehozasIdeje)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = letrehozasIdeje;
        }
        public Okoseszkoz(string nev, string allapot, int fogyasztas)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = DateTime.Now;
        }
        public Okoseszkoz(string nev, string allapot)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = 0;
            LetrehozasIdeje = DateTime.Now;
        }
        public Okoseszkoz(string nev)
        {
            Nev = nev;
            Allapot = "kikapcsolva";
            Fogyasztas = 0;
            LetrehozasIdeje = DateTime.Now;
        }

        public virtual void AllapotValto()
        {
            if (Allapot == "bekapcsolva")
            {
                Fogyasztas = 50;
            }
            else if (Allapot == "kikapcsolva")
            {
                Allapot = "bekapcsolva";
                Fogyasztas = 50;
            }
        }
        public virtual void AllapotJelentes()
        {
            
            Console.WriteLine($"\nA(z) {Nev} okos eszköz {DateTime.Now.Day - LetrehozasIdeje.Day} napja lett létrehozva fogyasztása {Fogyasztas}W.");
            Console.WriteLine($"Jelenleg {Allapot} van.");
            AllapotValto();

        }
  
    }
    class Lampa : Okoseszkoz
    {
        private string szinhomerseklet;
        private int fenyErosseg;

        public string Szinhomerseklet
        {
            get => szinhomerseklet;
            set
            {
                if (value != "")
                {
                    if (value == "meleg" || value == "hideg" || value == "semleges")
                    {
                        szinhomerseklet = value;
                    }
                    else
                    {
                        throw new Exception("Hiba!");
                    }
                }
                else
                {
                    throw new Exception("Hiba!");
                }
            }
        }
        public int FenyErosseg
        {
            get => fenyErosseg;
            set => fenyErosseg = value;
        }

        public Lampa(string nev, string allapot, int fogyasztas, DateTime letrehozasIdeje, string szinhomerseklet, int fenyErosseg) : base(nev, allapot, fogyasztas, letrehozasIdeje)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = letrehozasIdeje;
            Szinhomerseklet = szinhomerseklet;
            FenyErosseg = fenyErosseg;
        }
        public Lampa(string nev, string allapot, int fogyasztas, DateTime letrehozasIdeje, string szinhomerseklet) : base(nev, allapot, fogyasztas, letrehozasIdeje)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = letrehozasIdeje;
            Szinhomerseklet = "semleges";
            FenyErosseg = 0;
        }
        public Lampa(string nev, string allapot, int fogyasztas) : base(nev, allapot, fogyasztas)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = DateTime.Now;
            Szinhomerseklet = "semleges";
            FenyErosseg = 0;
        }
        public override void AllapotValto()
        {
            //base.AllapotValto();
            if (Allapot == "bekapcsolva")
            {
                if (FenyErosseg == 100)
                {
                    Fogyasztas = 50;
                }
                else if (FenyErosseg == 50)
                {
                    Fogyasztas = 25;
                }
            }
        }
        public override void AllapotJelentes()
        {
            //base.AllapotJelentes();
            Console.WriteLine($"\nA(z) {Nev} okos eszköz {DateTime.Now - LetrehozasIdeje} napja lett létrehozva fogyasztása {Fogyasztas}W.");
            Console.WriteLine($"Jelenleg {Allapot} van.");
            Console.WriteLine($"Fényerőssége {FenyErosseg}, színhőmérséklete: {Szinhomerseklet}");
            //AllapotValto();
        }
    }
    class Futes : Okoseszkoz
    {
        private double celHomerseklet;
        private double aktualisHomerseklet;

        public double CelHomerseklet
        {
            get => celHomerseklet;
            set => celHomerseklet = value > 5 && value < 30 ? value : throw new Exception("A célhőmérséklet csak 5 és 30 fok között lehet!");
        }
        public double AktualisHomerseklet
        {
            get => aktualisHomerseklet;
            set => aktualisHomerseklet = value;
        }
        public Futes(string nev, string allapot, int fogyasztas, DateTime letrehozasIdeje, double celHomerseklet, double aktualisHomerseklet) : base(nev, allapot, fogyasztas, letrehozasIdeje)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = letrehozasIdeje;
            CelHomerseklet = celHomerseklet;
            AktualisHomerseklet = aktualisHomerseklet;
        }
        public Futes(string nev, string allapot, int fogyasztas) : base(nev, allapot, fogyasztas)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = fogyasztas;
            LetrehozasIdeje = DateTime.Now;
            CelHomerseklet = 0;
            AktualisHomerseklet = 0;
        }
        public Futes(string nev, string allapot) : base(nev, allapot)
        {
            Nev = nev;
            Allapot = allapot;
            Fogyasztas = 0;
            LetrehozasIdeje = DateTime.Now;
            CelHomerseklet = 0;
            AktualisHomerseklet = 0;
        }
        public override void AllapotValto()
        {
            //base.AllapotValto();
            if (Allapot == "bekapcsolva")
            {
                Allapot = "kikapcsolva";
            }
            else if (Allapot == "kikapcsolva")
            {
                Allapot = "bekapcsolva";
                if (AktualisHomerseklet < CelHomerseklet)
                {
                    Fogyasztas = 100;
                }
                else if (AktualisHomerseklet >= CelHomerseklet)
                {
                    Fogyasztas = 20;
                }
            }
        }
        public override void AllapotJelentes()
        {
            //base.AllapotJelentes();
            Console.WriteLine($"A(z) {Nev} okos eszköz {DateTime.Now - LetrehozasIdeje} napja lett létrehozva fogyasztása {Fogyasztas}W.");
            Console.WriteLine($"Jelenleg {Allapot} van.");
            Console.WriteLine($"Célhőmérséklet: {CelHomerseklet}°C, aktuális hőmérséklet: {AktualisHomerseklet}°C");
            Console.WriteLine($"Havi fogyasztása: {HaviKoltseg()}");
            AllapotValto();
        }

        public double HaviKoltseg()
        {
            double eredmeny = (Fogyasztas * 20 * 30) / 1000;
            return eredmeny;
        }
    }
}
