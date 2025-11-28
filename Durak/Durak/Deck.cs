using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Deck
    {
        List<Card> deck;

        public Deck()
        {
            deck = new List<Card>();
            switch (new Random().Next(4))
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

            for (int i = 1; i <= 52; i++)
            {
                
            }
        }
    }
}
