using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251020_Abstract_Szallitas
{
    abstract class Szallitoeszkoz
    {
        private string nev;
        private int maxSebesseg;
        private int kapacitas;
        private int uzemanyagFogyasztas;

        public string Nev
        {
            get => nev;
            set => nev = value != "" ? value : throw new Exception("Nem lehet üres");
        }
        public virtual int MaxSebesseg
        {
            get => maxSebesseg;
            set => maxSebesseg = value < 150 ? value: throw new Exception("A szállító eszköz nem mehet 100km/h sebességnél többel!");
        }
        public virtual int Kapacitas
        {
            get => kapacitas;
            set => kapacitas = value < 20000 ? value : throw new Exception("A szállító eszköz nem vihet 2t-nál több tömeget!");
        }
        public virtual int UzemanyagFogyasztas
        {
            get => uzemanyagFogyasztas;
            set => uzemanyagFogyasztas = value < 20 ? value : throw new Exception("A szállító eszköznek nem lehet 20L/100km-nél több a fogyasztása!");
        }

        public Szallitoeszkoz(string nev, int maxSebesseg, int kapacitas, int uzemanyagFogyasztas)
        {
            Nev = nev;
            MaxSebesseg = maxSebesseg;
            Kapacitas = kapacitas;
            UzemanyagFogyasztas = uzemanyagFogyasztas;

        }
        public Szallitoeszkoz(string nev, int maxSebesseg)
        {
            Nev = nev;
            MaxSebesseg = maxSebesseg;
        }
        public Szallitoeszkoz(string nev)
        {
            Nev = nev;
        }
        public abstract void Szallitas();

        public override string ToString()
        {
            return $"{Nev} {MaxSebesseg} km/h maximális sebességgel ({Kapacitas}kg szállítási kapacitással) {UzemanyagFogyasztas} litert fogyaszt 100 km-en.";
        }
    }
}
