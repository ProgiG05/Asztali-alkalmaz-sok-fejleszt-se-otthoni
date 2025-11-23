using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251020_Abstract_Szallitas
{
    class Szemelyauto : Szallitoeszkoz
    {
        private int ulesekSzama;
        public int szemelyMaxSebesseg;
        public int szemelyUzemanyagFogyasztas;
        public int szemelyKapacitas;
        public int UlesekSzama
        {
            get => ulesekSzama;
            set => ulesekSzama = value;
        }
        public override int Kapacitas
        {
            get => szemelyKapacitas;
            set => szemelyKapacitas = value < 1000 ? value : throw new Exception("A szállító eszköz nem vihet 1t-nál több tömeget!");
        }
        public override int UzemanyagFogyasztas
        {
            get => szemelyUzemanyagFogyasztas;
            set => szemelyUzemanyagFogyasztas = value < 10 ? value : throw new Exception("A szállító eszköznek nem lehet 10L/100km-nél több a fogyasztása!");
        }
        public override int MaxSebesseg
        {
            get => szemelyMaxSebesseg;
            set => szemelyMaxSebesseg = value <= 240 ? value: throw new Exception("A személyautó nem mehet 240km/h sebességnél többel!");
        }
        public Szemelyauto(string nev, int szemelyMaxSebesseg, int szemelyKapacitas, int szemelyUzemanyagFogyasztas, int ulesekSzama) : base(nev)
        {
            MaxSebesseg = szemelyMaxSebesseg;
            Kapacitas = szemelyKapacitas;
            UzemanyagFogyasztas = szemelyUzemanyagFogyasztas;
            UlesekSzama = ulesekSzama;
        }
        public override void Szallitas()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{base.ToString()} ülések száma: {UlesekSzama}";
        }
    }
}
