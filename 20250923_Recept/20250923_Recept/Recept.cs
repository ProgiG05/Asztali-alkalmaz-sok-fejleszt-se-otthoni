using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250923_Recept
{
    internal class Recept
    {
        private string nev;
        private List<string> osszetevok;
        private int elkeszitesiIdo; 
        private DateTime letrehozasIdeje;

        public string Nev
        {
            get => nev;
            set => nev = value != "" ? value : throw new Exception("A recept neve nem lehet üres");
        }
        public List<string> Osszetevok
        {
            get => osszetevok;
            set => osszetevok = value.Count > 0 ? value : throw new Exception("A receptnek legalább egy összetevője kell, hogy legyen");
        }
        public int ElkeszitesiIdo
        {
            get => elkeszitesiIdo;
            set => elkeszitesiIdo = value >= 0 ? value : throw new Exception("Az elkészítési idő nem lehet negatív");
        }
        public DateTime LetrehozasIdeje
        {
            get => letrehozasIdeje;
            set => letrehozasIdeje = value <= DateTime.Now ? value : throw new Exception("A létrehozás ideje nem lehet a jövőben");
        }
        public Recept(string nev, List<string> osszetevok, int elkeszitesiIdo, DateTime letrehozasIdeje)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = elkeszitesiIdo;
            LetrehozasIdeje = letrehozasIdeje;
        }
        public Recept(string nev, List<string> osszetevok)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = 30;
            LetrehozasIdeje = DateTime.Now;
        }
        public Recept(string nev)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = 0;
            LetrehozasIdeje = new DateTime(2000,1,1);
        }
        
        public virtual void AllergenekEllenorzes() 
        {
            foreach (var item in Osszetevok)
            {
                if (item == "glutén" || item == "liszt" || item == "tojás" || item == "tej" || item == "dió")
                {
                    Console.WriteLine("Figyelem! A recept allergéneket tartalmaz: glutén, tej, tojás, dió");
                    break;
                }
                else
                {
                    Console.WriteLine("A recept nem tartalmaz allergéneket.");
                }
            }        
        }
        public virtual void HozzavalokListazasa()
        {
            AllergenekEllenorzes();
            Console.Write($"A(z) {Nev} recept hozzávalói: ");
            foreach (var item in Osszetevok)
            {
                Console.Write($"{item}, ");
            }
        }

    }
    class VegetarianusRecept : Recept
    {
        private int kaloria;

        public int Kaloria
        {
            get => kaloria;
            set => kaloria = value > 0 ? value : throw new Exception("A kalória nem lehet negatív! ");
        }

        public VegetarianusRecept(string nev, List<string> osszetevok, int elkeszitesiIdo, DateTime letrehozasIdeje) : base(nev, osszetevok, elkeszitesiIdo, letrehozasIdeje)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = elkeszitesiIdo;
            LetrehozasIdeje = letrehozasIdeje;
            Kaloria = kaloria;

        }
        public VegetarianusRecept(string nev, List<string> osszetevok, int kaloria) : base(nev, osszetevok)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            Kaloria = kaloria;
        }
        public VegetarianusRecept(string nev, int kaloria) : base(nev)
        {
            Nev = nev;
            Kaloria = kaloria;
        }
        public virtual void VegetarianusEllenorzes()
        {
            foreach (var item in Osszetevok)
            {
                if (item == "hús" || item == "hal" || item == "csirke" || item == "pulyka" || item == "szalonna")
                {
                    throw new Exception("A vegetáriánus recept nem tartalmazhat húst, halat vagy szalonnát.");
                }
            }
        }
        public override void AllergenekEllenorzes()
        {
            if (Osszetevok.Contains("glutén") || Osszetevok.Contains("liszt") || Osszetevok.Contains("tojás") || Osszetevok.Contains("tej") || Osszetevok.Contains("dió"))
            {
                Console.Write("Figyelem! A recept allergéneket tartalmaz: ");
                Console.WriteLine(string.Join(", ",Osszetevok));
            }
            else
            {
                Console.WriteLine("A recept nem tartalmaz allergéneket.");
            }
        }
        public double TapErtekSzamitas()
        {
            return (Kaloria / 2000) * 100;
        }
        public override void HozzavalokListazasa()
        {
            VegetarianusEllenorzes();
            AllergenekEllenorzes();
            base.HozzavalokListazasa();
            Console.WriteLine($"Kalórai tartalom: {Kaloria} kcal");
        }
    }
    class HusosReceptek : Recept
    {
        private string husTipus;
        private int sutesHomerseklet;

        public string HusTipus
        {
            get => husTipus;
            set
            {
                if (value == "csirke" || value == "marha" || value == "sertés" || value == "hal")
                {
                    husTipus = value;
                }
                else
                {
                    throw new Exception("A hús típusa csak csirke, marha, sertés vagy hal lehet.");
                }
            }
        }

        public int SutesHomerseklet
        {
            get => sutesHomerseklet;
            set => sutesHomerseklet = value >= 0 ? value : throw new Exception("A sütés hőmérséklete nem lehet negatív, sem nulla!");
        }
        public HusosReceptek(string nev, List<string> osszetevok, int elkeszitesiIdo, DateTime letrehozasIdeje, string husTipus, int sutesHomerseklet) : base(nev, osszetevok, elkeszitesiIdo, letrehozasIdeje)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = elkeszitesiIdo;
            LetrehozasIdeje = letrehozasIdeje;
            HusTipus = husTipus;
            SutesHomerseklet = sutesHomerseklet;
        }

        public override void HozzavalokListazasa()
        {
            base.HozzavalokListazasa();
            Console.WriteLine($"Hús típusa: {HusTipus}, ");
            Console.WriteLine($"Sütés hőmérséklete: {SutesHomerseklet} °C");
        }
    }
}
