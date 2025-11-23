using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251014_DKÉ_craters
{
    class craters
    {
        public double x;
        public double y;
        public double radius;
        public string name;

        public craters(string one)
        {
            string[] oneline = one.Split('\t');
            x = double.Parse(oneline[0]);
            y = double.Parse(oneline[1]);
            radius = double.Parse(oneline[2]);
            name = oneline[3];
        }
    }
}
