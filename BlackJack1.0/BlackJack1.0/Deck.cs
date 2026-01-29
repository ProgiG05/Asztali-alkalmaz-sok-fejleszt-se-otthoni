using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1._0
{
    class Deck
    {
        Random random;
        public Deck()
        {
            random = new Random();
        }
        // returns a random card from the deck using its value
        public Card GetCard()
        {
            int rank = random.Next(1, 11);
            Card c = new Card(rank);
            return c;
        }
    }
}
