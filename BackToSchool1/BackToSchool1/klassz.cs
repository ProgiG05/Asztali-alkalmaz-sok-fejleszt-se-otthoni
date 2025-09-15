using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToSchool1
{
    class klassz
    {
        public string word1,word2;
        public int num1,num2;

        public klassz(string word1, string word2, int num1,int num2)
        {
            this.word1 = word1;
            this.word2 = word2;
            this.num1 = num1;
            this.num2 = num2;
        }

        public klassz(string sor)
        {
            string[] egysor = sor.Split(';');
            word1 = egysor[0];
            word2 = egysor[0];
            num1 = Convert.ToInt32(egysor[1]);
            num2 = Convert.ToInt32(egysor[2]);
        }

    }
}
