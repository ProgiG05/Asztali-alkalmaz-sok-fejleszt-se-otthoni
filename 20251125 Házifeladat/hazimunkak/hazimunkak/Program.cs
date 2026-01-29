using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazimunkak
{
    internal class Program
    {
        static List<Hazimunka> adatok = new List<Hazimunka>();
        public void Beolvasas()
        {
            System.IO.File.ReadAllLines("hazimunkak.txt").Skip(1).ToList().ForEach(x => adatok.Add(new HazimunkaKezelo(x)));
        }
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
