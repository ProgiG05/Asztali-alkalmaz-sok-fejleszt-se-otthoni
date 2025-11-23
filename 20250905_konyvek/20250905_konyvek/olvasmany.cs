using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250905_konyvek
{
    class Olvasmany
    {
        private string cim;
        private string szerzo;
        private int kiadasEve;
        public Olvasmany(string cim, string szerzo, int kiadasEve)
        {
            Cim = cim;
            Szerzo = szerzo;
            KiadasEve = kiadasEve;
        }
        public Olvasmany(string cim, string szerzo)
        {
            Cim = cim;
            Szerzo = szerzo;
            KiadasEve = 1500;
        }
        public string Cim
        {
            get => cim;
            set => cim = value != "" ? value.ToString().ToUpper() : throw new Exception("Hibás adat!");
        }
        public string Szerzo
        {
            get => szerzo;
            set => szerzo = value != "" ? value : throw new Exception("Hibás adat!");
        }
        public int KiadasEve
        {
            get => kiadasEve;
            set
            {
                if (value < 1500 && value > Convert.ToInt32(DateTime.Now.Year))
                {
                    throw new Exception("Hibás adat!");
                }
                else
                {
                    kiadasEve = value;
                }
            }
        }

        public virtual void Kiir()
        {
            Console.WriteLine($"\nAz olvasmány címe: {Cim}");
            Console.WriteLine($"Az olvasmány szerzője: {Szerzo}");
            Console.Write($"A kiadás éve: {KiadasEve} ");
            Kora();
        }
        public virtual void Kora()
        {
            Console.Write($"- {DateTime.Now.Year - KiadasEve} éves\n");
        }
    }
        class Konyv : Olvasmany
        {
            private int oldalakSzama;

            public Konyv(string cim, string szerzo, int kiadasEve, int oldalakSzama): base(cim, szerzo, kiadasEve)
            {
                OldalakSzama = oldalakSzama;
            }
            public int OldalakSzama
            {
                get => oldalakSzama;
                set => oldalakSzama = value > 0 && value != 0 ? value : 1;
            }

            public override void Kiir()
            {
                base.Kiir();
                Console.WriteLine($"Oldalak száma: {OldalakSzama}\n");
            }
        }
        class Magazin : Konyv
        {
            private int szam;
            private string temakor;

            public int Szam
            {
                get => szam;
                set => szam = value > 0 ? value : throw new Exception("Hibás adat!");
            }
            public string Temakor
            {
                get => temakor;
                set => temakor = value != "" ? value : throw new Exception("Hibás adat!");
            }
            
            public Magazin(string cim, string szerzo, int kiadasEve,int doldalakSzama, int szam, string temakor) : base(cim, szerzo, kiadasEve, doldalakSzama)
            {
                Szam = szam;
                Temakor = temakor;
            }

            public override void Kiir()
            {
                base.Kiir();
                Console.WriteLine($"{Szam}. kiadás {Temakor} témában");
            }
        }
    
}
