using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Bot // Add sorting to Deck.cs
    {
        private Deck MainDeck { get; set; }
        private Deck BoardDeck { get; set; }

        private Deck attackingDeck;
        public Bot(Deck deck, Deck boardDeck)
        {
            MainDeck = deck;
            BoardDeck = boardDeck;
        }

        public Card Attack(bool firstAttack) // return null for end turn
        {
            if (firstAttack || CanAttack())
            {

            }
            return null;
        }

        private bool CanAttack()
        {
            bool canAttack = false;
            foreach (Card card in MainDeck.GetDeck())
            {
                //if ()
            }

            return canAttack;
        }
    }
}
