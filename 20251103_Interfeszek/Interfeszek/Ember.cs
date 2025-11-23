using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Ember:IBeszelo
    {
        public string Nev { get; set; } //tul
        public void Beszel() //me
        {
            Console.WriteLine($"Helló, ember vagyok. Nevem: {Nev}");
        }
    }
}
