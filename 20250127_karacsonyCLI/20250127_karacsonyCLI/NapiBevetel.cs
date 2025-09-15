using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250127_karacsonyCLI
{
    class NapiBevetel
    {
        private int nap;

        public int getNap()
        {
            return nap;
        }

        private int harangKesz;

        public int getHarangKesz()
        {
            return harangKesz;
        }

        private int harangEladott;

        public int getHarangEladott()
        {
            return harangEladott;
        }

        private int angyalkaKesz;

        public int getAngyalkaKesz()
        {
            return angyalkaKesz;
        }

        private int angyalkaEladott;

        public int getAngyalkaEladott()
        {
            return angyalkaEladott;
        }

        private int fenyofaKesz;

        public int getFenyofaKesz()
        {
            return fenyofaKesz;
        }

        private int fenyofaEladott;

        public int getFenyofaEladott()
        {
            return fenyofaEladott;
        }

        public NapiBevetel(string sor)
        {
            string[] s = sor.Split(';');
            nap = Convert.ToInt32(s[0]);
            harangKesz = Convert.ToInt32(s[1]);
            harangEladott = Convert.ToInt32(s[2]);
            angyalkaKesz = Convert.ToInt32(s[3]);
            angyalkaEladott = Convert.ToInt32(s[4]);
            fenyofaKesz = Convert.ToInt32(s[5]);
            fenyofaEladott = Convert.ToInt32(s[6]);
        }

        public int napiBevetel()
        {
            return -(harangEladott * 1000 + angyalkaEladott * 1350 + fenyofaEladott * 1500);
        }
    }

}
