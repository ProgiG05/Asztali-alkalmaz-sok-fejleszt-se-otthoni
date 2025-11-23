using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    abstract class MozgoJarmu : Jarmu
    {
        protected float iranyX, iranyY;

        public MozgoJarmu(string azonosito, float x, float y, Terkep terkep) : base(azonosito, x, y, terkep)
        {
            
        }

        public void UjIranyVektor(float iranyX, float iranyY)
        {
            this.iranyX = iranyX;
            this.iranyY = iranyY;
        }
        public abstract void Mozog();
        
    }
}
