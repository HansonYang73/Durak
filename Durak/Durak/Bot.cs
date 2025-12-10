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

        private Deck attackingDeck;
        private Deck defendingDeck;
        public Bot(Deck deck)
        {
            MainDeck = deck;

            attackingDeck = new Deck(false);
            defendingDeck = new Deck(false);
        }

        public Card Attack(Deck boardDeck, Deck drawDeck) // return null for end turn
        {
            attackingDeck = new Deck(false);
            if (boardDeck.Size == 0)
            {
                MainDeck.SortByPower();
                if (drawDeck.Size == 0)
                {
                    return MainDeck.Play(MainDeck.Size-1);
                }
                return MainDeck.Play(0);

            }
            else if (CanAttack(boardDeck))
            {
                attackingDeck.SortByPower();
                return MainDeck.Play(attackingDeck.Get(0));
            }

            return null;
        }

        public Card Defend(Deck boardDeck, Deck drawDeck)
        {
            defendingDeck = new Deck(false);
            if (CanDefend(boardDeck))
            {
                defendingDeck.SortByPower();
                return MainDeck.Play(defendingDeck.Get(0));
            }
            return null;
        }


        private bool CanAttack(Deck boardDeck)
        {
            bool canAttack = false;
            foreach (Card card in MainDeck.GetDeck())
            {
                if (boardDeck.ContainsNumber(card.Number))
                {
                    attackingDeck.AddCard(card);
                    canAttack = true;
                }
            }

            return canAttack && boardDeck.Size < 12;
        }

        private bool CanDefend(Deck boardDeck)
        {
            bool canDefend = false;
            Card attackingCard = boardDeck.Get(boardDeck.Size-1);

            foreach (Card card in MainDeck.GetDeck())
            {
                if ((card.Suit == attackingCard.Suit || card.Suit == Card.EmpSuit) && card.Power > attackingCard.Power)
                {
                    defendingDeck.AddCard(card);
                    canDefend = true;
                }
            }

            return canDefend && boardDeck.Size % 2 == 1;
        }
    }
}