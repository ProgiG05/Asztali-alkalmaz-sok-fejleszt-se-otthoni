using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1._0
{
    class Card
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public int rank;

        public Card(int rank) {this.rank = rank;}

        public Card()
        {
        }
    }
}
