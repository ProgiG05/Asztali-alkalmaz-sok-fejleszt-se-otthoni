using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251020_Abstract_Szallitas
{
    internal class Teherauto : Szallitoeszkoz
    {
        private bool hűtés;
        private int teherKapacitas;
        private int teherUzemanyagFogyasztas;
        public bool Hűtés
        {
            get => hűtés;
            set => hűtés = value;
        }
        public override int Kapacitas
        {
            get => teherKapacitas;
            set => teherKapacitas = value < 20000 ? value : throw new Exception("A szállító eszköz nem vihet 5t-nál több tömeget!");
        }
        public override int UzemanyagFogyasztas
        {
            get => teherUzemanyagFogyasztas;
            set => teherUzemanyagFogyasztas = value < 30 ? value : throw new Exception("A szállító eszköznek nem lehet 20L/100km-nél több a fogyasztása!");
        }

        public Teherauto(string nev, int maxSebesseg, int teherKapacitas, int teherUzemanyagFogyasztas, bool hűtés) : base( nev, maxSebesseg)
        {
            Nev = nev;
            MaxSebesseg = maxSebesseg;
            Kapacitas = teherKapacitas;
            UzemanyagFogyasztas = teherUzemanyagFogyasztas;
            Hűtés = hűtés;
        }
        public override void Szallitas()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            if (Hűtés)
            {
                return $"{Nev} {MaxSebesseg} km/h maximális sebességgel ({Kapacitas}kg szállítási kapacitással) {UzemanyagFogyasztas} litert fogyaszt 100 km-en. Hűtésre alkalmas";
            }
            else
            {
                return $"{Nev} {MaxSebesseg} km/h maximális sebességgel ({Kapacitas}kg szállítási kapacitással) {UzemanyagFogyasztas} litert fogyaszt 100 km-en. Hűtésre nem alkalmas";
            }
            
        }
    }
}
