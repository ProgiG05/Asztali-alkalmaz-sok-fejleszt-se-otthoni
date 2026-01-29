using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1._0
{
    class Hand
    {
        ArrayList cards;
        //constructor
        public Hand()
        {
            cards = new ArrayList();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        //returns true if the hand is busted (over 21)
        public bool IsBusted()
        {
            return this.Total() > 21;
        }
        //returns the total value of the current hand
        public int Total()
        {
            int total = 0;
            foreach (Card card in cards)
            {
                total += card.Value;
            }
            return total;
        }
        //override ToString to display the hand and its total value
        public override string ToString()
        {
            string s = "Hand: ";
            foreach (Card card in cards)
            {
                s += card + " ";
            }
            s += "\nTotal: ";
            s += Total();
            return s;
        }
    }
}
