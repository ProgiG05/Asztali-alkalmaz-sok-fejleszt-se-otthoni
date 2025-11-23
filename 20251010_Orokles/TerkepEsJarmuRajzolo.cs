using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class TerkepEsJarmuRajzolo : TerkepRajzolo
    {
        private string[] jarmuvek;
        private int jarmuvekN;
        private static readonly Terkep terkep;

        public string[] Jarmuvek
        {
            get => jarmuvek;
            set => jarmuvek = value;
        }
        public int JarmuvekN
        {
            get => jarmuvekN;
            set => jarmuvekN = value > 0 ? value : throw new Exception("nem jo");
        }
        public TerkepEsJarmuRajzolo(string[] jarmuvek, int jarmuvekN) : base(terkep)
        {
            Jarmuvek = jarmuvek;
            JarmuvekN = jarmuvek.Length;
        }

        public virtual void JarmuFelvetel()
        {
            Console.WriteLine("Milyen járművet szeretnél látni a térképen: ");
            string jarmu = Console.ReadLine();
            
        }
        public override char MiVanItt(int x, int y)
        {
            return base.MiVanItt(x, y);

            
        }
    }
}
