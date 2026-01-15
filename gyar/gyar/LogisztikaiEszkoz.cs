using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyar
{
    abstract class LogisztikaiEszkoz
    {
        private string azonosito;
        private string tipus;
        private int terhelhetoseg;
        private double sebesseg;

        public string Azonosito { get => azonosito; set => azonosito = value != null || value != "" ? value : throw new Exception("Az azonosító nem lehet null vagy üres érték! "); }
        public string Tipus { get => tipus; set => tipus = value != null || value != "" ? value : throw new Exception("Az típús nem lehet null vagy üres érték! "); }
        public int Terhelhetoseg { get => terhelhetoseg; set => terhelhetoseg = value < 0 ? value : throw new Exception("A terhelhetőség nem lehet kisebb mint nulla! "); }
        public double Sebesseg { get => sebesseg; set => sebesseg = value < 0 ? value : throw new Exception("A sebesség nem lehet kisebb mint nulla !"); }
        public abstract string Besorolas { get; }
        public LogisztikaiEszkoz(string azonosito, string tipus, int terhelhetoseg, double sebesseg)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Terhelhetoseg = terhelhetoseg;
            Sebesseg = sebesseg;
        }
        public LogisztikaiEszkoz(string azonosito)
        {
            Azonosito = azonosito;
            Tipus = "ismeretlen";
            Terhelhetoseg = 0;
            Sebesseg = 0;
        }
        public virtual string Megjelenites()
        {
            return $"{Azonosito} azonosítójú {terhelhetoseg} kg terhelhetőségű {Besorolas} {Tipus} sebessége {Sebesseg} m/s";
        }
        public abstract string MunkatIndit();
        public abstract string MunkatLezar();
        public abstract string SzalagFellettHalad(string pozicio);

    }
}
