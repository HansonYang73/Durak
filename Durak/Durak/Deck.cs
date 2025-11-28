using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Deck
    {
        private List<Card> deck;
        private int size;

        public Deck() // need to make another constructor for the player hand
        {
            deck = new List<Card>();
            size = 0;


            switch (new Random().Next(4)) // need to actually chose a card
            {
                case 0:
                    Card.EmpSuit = Suit.Heart; 
                    break;
                case 1:
                    Card.EmpSuit = Suit.Diamond;
                    break;
                case 2:
                    Card.EmpSuit = Suit.Club;
                    break;
                case 3:
                    Card.EmpSuit = Suit.Spade;
                    break;
            }

            int suit = -1;
            for (int i = 1; i <= 52; i++)
            {
                if (i % 13 == 1)
                {
                    suit++;
                }
                deck.Add(new Card(i, (Suit)suit));
                size++;
            }

            shuffle();
        }

        private void shuffle()
        {
            for (int i = size - 1; i > 0; i--) {
                int rand = new Random().Next(i + 1);
                Card tmp = deck[i];
                deck[i] = deck[rand];
                deck[rand] = tmp;
            }
        }
    }
}
