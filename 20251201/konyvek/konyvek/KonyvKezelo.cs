using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    class KonyvKezelo : IKonyv
    {
        public static List<Konyv> konyvAdatok = new List<Konyv>();
        
        public void Kiiras()
        {
            System.IO.File.ReadAllLines("konyvek.txt", Encoding.UTF8).Skip(1).ToList().ForEach(x => 
            {
                string[] egysor = x.Split(';');
                if (egysor[-1].Contains("Regény"))
                {
                    konyvAdatok.Add(new Regeny(Convert.ToInt32(egysor[0]), egysor[1], egysor[2], Convert.ToInt32(egysor[3]), egysor[4], egysor[5]));
                }
                if (egysor[-1].Contains("Tudományos"))
                {
                    konyvAdatok.Add(new IfjusagiKonyv(Convert.ToInt32(egysor[0]), egysor[1], egysor[2], Convert.ToInt32(egysor[3]), egysor[4], egysor[5]));
                }
                else
                {
                    throw new Exception("Nem sikerült beolvasni! ");
                }
            });
            
            foreach (var item in konyvAdatok)
            {
                Console.WriteLine(item);
            }
        }
        public int OldalszamOsszesites(int osszOldalszam)
        {
            osszOldalszam = konyvAdatok.Sum(x => x.Oldalszam);
            return osszOldalszam;
        }
        public List<Konyv> LegrovidebbKonyv(List<Konyv> keresettKonyv)
        {
            keresettKonyv = konyvAdatok.Where(x => x.Oldalszam == konyvAdatok.Min().Oldalszam).ToList();
            return keresettKonyv;
        }
        public string AdatokMegjelenitese()
        {
            return ToString();
        }
    }
}
