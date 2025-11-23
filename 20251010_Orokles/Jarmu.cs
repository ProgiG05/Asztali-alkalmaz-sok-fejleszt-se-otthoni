using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Jarmu 
    {
        public string azonosito;
        public float x, y;
        public Terkep terkep;

        public string Azonosito
        {
            get => azonosito;
            set => azonosito = value;
        }
        public float X
        {
            get { return X; }
            //set => x = value;
        }
        public float Y
        {
            get { return Y; }
            //set => y = value;
        }
        public Terkep Terkep
        {
            get => terkep;
            set => terkep = value;
        }

        public Jarmu(string azonosito, float x, float y, Terkep terkep)
        {
            Azonosito = azonosito;
            this.x = x;
            this.y = y;
            Terkep = terkep;
        }

        public virtual bool IdeLephet(float x, float y)
        {
            //float celMeretX = Terkep.MeretX;
            //float celMeretY = Terkep.MeretY;
            //if (x < celMeretX && y < celMeretY)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;   
            //}

            return Terkep.TerkepenBeluliPozicio(x,y);
        }
    }
}
