using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250917_oktatasi_intezmeny
{
    internal class Szemely
    {
        private string nev;
        private int azonosito;
        private int szulEv;
        private string feladatEllatas;

        public string Nev
        {
            get => nev; 
            set
            {
                string[] egybe = value.Split(' ');
                if (Char.IsUpper(egybe[0][0]) && Char.IsUpper(egybe[1][0]))
                {
                    value = nev;
                }
                else
                {
                    throw new Exception("A név nem megfelelő formátumú!");
                }
            }
        }
        public int Azonosito
        {
            get => azonosito;
            set => azonosito = value != 0 && value > 0 && value.ToString().Length < 8 ? value : throw new Exception("Hibás! ");
        }
        public int SzulEv
        {
            get => szulEv;
            set => szulEv = value != 0 &&  value > 1900 && value <= DateTime.Now.Year ? value : throw new Exception("Hibás! ");
        }
        public string FeladatEllatas
        {
            get => feladatEllatas;
            set
            {
                if (value == "tanár" || value == "diák" || value == "adminisztrátor")
                {
                    feladatEllatas = value;
                }
                else
                {
                    throw new Exception("Hibás! ");
                }
            }
        }

        public Szemely(string nev, int azonosito, int szulEv, string feladatEllatas)
        {
            Nev = nev;
            Azonosito = azonosito;
            SzulEv = szulEv;
            FeladatEllatas = feladatEllatas;
        }


    }
}
