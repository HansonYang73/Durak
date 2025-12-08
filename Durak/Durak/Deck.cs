using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Deck
    {
        public List<Card> deck;
        public int Size { get; set; }

        public Deck() 
        {
            deck = new List<Card>();
            Size = 0;

            int suit = -1;
            for (int i = 1; i <= 52; i++)
            {
                if (i % 13 == 1) suit++;
                if (i % 13 == 2) i += 4; // skips 2,3,4,5
                AddCard(new Card(i, (Suit)suit));


            }

            Shuffle();

            Card.EmpSuit = deck[0].Suit;
            EmpowerTheCards();

            AddCard(Draw()); // Put the First empowered card at the end of the deck
        }

        public Deck(Deck mainDeck) //Hand
        {
            deck = new List<Card>();
            Size = 0;

            for (int i = 0; i < 6; i++)
            {
                AddCard(mainDeck.Draw());
            }
        }

        private void Shuffle()
        {
            Random rnd = new Random();
            for (int i = Size - 1; i > 0; i--) {
                int rand = rnd.Next(i + 1);
                Card tmp = deck[i];
                deck[i] = deck[rand];
                deck[rand] = tmp;
            }
        }

        private void EmpowerTheCards()
        {
            deck.ForEach(card =>
            {
                if (card.Suit == Card.EmpSuit)
                {
                    card.Power += 13;
                }
            });
        }

        public void AddCard(Card card)
        {
            deck.Add(card);
            Size++;
        }

        public Card Draw()
        {
            Size--;
            Card removedCard = deck[0];
            deck.RemoveAt(0);
            return removedCard;
        }

        public Card Play(Card card)
        {
            Size--;
            deck.Remove(card);
            return card;
        }

        public void PrintDeck()
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card);
            }
        }

        public bool ContainsNumber(int n)
        {
            deck.ForEach((card) =>
            {
                if (card.Number == n)
                {
                    return true;
                }
            });
            return false;
        }
    }
}
