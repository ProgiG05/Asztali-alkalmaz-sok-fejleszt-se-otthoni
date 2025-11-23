using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Helikopter : MozgoJarmu
    {
        private float sebesség = 1;

        public Helikopter(string azonosito, float x, float y, Terkep terkep) : base("H", x, y, terkep)
        {

        }

        public void Gyorsit()
        {
            sebesség += 0.1f;
        }
        public void Lassit()
        {
            float lassitas = 0.1f;
            if (sebesség - lassitas < 0)
            {
                throw new Exception("!");
            }
            else
            {
                sebesség = sebesség - lassitas;
            }
        }
        public override void Mozog()
        {
            float ujX = X + iranyX * sebesség;
            float ujY = Y + iranyY * sebesség;

            if (IdeLephet(ujX,ujY))
            {
            
            }
        }
    }
}
