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

        private Deck DrawDeck { get; set; }

        private Deck attackingDeck;
        private Deck defendingDeck;
        public Bot(Deck deck, Deck boardDeck, Deck drawDeck)
        {
            MainDeck = deck;
            BoardDeck = boardDeck;
            DrawDeck = drawDeck;

            attackingDeck = new Deck(false);
            defendingDeck = new Deck(false);
        }

        public Card Attack(bool firstAttack) // return null for end turn
        {
            if (firstAttack)
            {
                MainDeck.SortByPower();
                if (DrawDeck.Size == 0)
                {
                    return MainDeck.GetDeck()[MainDeck.Size];
                }
                return MainDeck.Get(0);

            }
            else if (CanAttack())
            {
                attackingDeck.SortByPower();
                if (DrawDeck.Size > 0 && MainDeck.GetDeck()[0].Power + 9 > attackingDeck.GetDeck()[0].Power)
                { //If draw deck is greater than 0 and the power of the lowest card in your attacking hand is less than 9 power levels greater. play card
                    return attackingDeck.Get(0);
                }//end game, guarantee extra attack if possible
                else if (DrawDeck.Size == 0)
                {
                    return attackingDeck.Get(0);
                }
            }

            return null;
        }

        public Card Defend()
        {
            if (CanDefend())
            {
                defendingDeck.SortByPower();
                return defendingDeck.Get(0);
            }
            return null;
        }


        private bool CanAttack()
        {
            bool canAttack = false;
            foreach (Card card in MainDeck.GetDeck())
            {
                if (BoardDeck.ContainsNumber(card.Number))
                {
                    attackingDeck.AddCard(card);
                    canAttack = true;
                }
            }

            return canAttack;
        }

        private bool CanDefend()
        {
            bool canDefend = false;
            Card attackingCard = BoardDeck.Get(BoardDeck.Size-1);

            foreach (Card card in MainDeck.GetDeck())
            {
                if ((card.Suit == attackingCard.Suit || card.Suit == Card.EmpSuit) && card.Power > attackingCard.Power)
                {
                    defendingDeck.AddCard(card);
                    canDefend = true;
                }
            }

            return canDefend;
        }
    }
}