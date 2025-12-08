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
        public Bot(Deck deck, Deck boardDeck)
        {
            MainDeck = deck;
            BoardDeck = boardDeck;
        }

        //public Card Attack()
        //{
        //    if (CanAttack())
        //    {

        //    }
        //}

        //private bool CanAttack()
        //{

        //}
    }
}
