using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1._0
{
    class Player
    {
        // the player's hand
        protected Hand hand;
        //constructor
        public Player()
        {
            hand = new Hand();
        }

        public virtual Hand Deal(Deck deck)
        {
            DealCards(2, deck);
            Console.WriteLine();

            bool playing = true;
            while (playing)
            {
                Console.Write("Would you like to Hit (H) or Stay (S)?: ");
                string response = Console.ReadLine();
                switch (response.ToUpper())
                {
                    case "H":
                        DealCards(1, deck);
                        playing = !hand.IsBusted();
                        break;
                    case "S":
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }

            return hand;
        }

        public void DealCards(int num, Deck deck)
        {
            string cardString = (num == 1) ? "card" : "cards";
            Console.WriteLine("Dealing new " + cardString);
            for (int i = 0; i < num; i++)
            {
                hand.AddCard(deck.GetCard());
            }
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return hand.ToString();
        }
    }
}
