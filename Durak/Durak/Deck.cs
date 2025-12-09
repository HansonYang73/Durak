using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Deck
    {
        private List<Card> deck;
        public int Size { get; set; }
        public bool isBot;
        public Bot bot;

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

        public Card Get(int index)
        {
            return deck[index];
        }

        public List<Card> GetDeck()
        {
            return deck;
        }

        public Deck(bool isBot) //Hand
        {
            deck = new List<Card>();
            Size = 0;

            this.isBot = isBot;
            
            //for (int i = 0; i < 6; i++)
            //{
            //    AddCard(mainDeck.Draw());
            //}
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

        public void AddDeck(Deck addingDeck)
        {
            while (addingDeck.Size > 0) 
            {
                AddCard(addingDeck.Draw());
            }
        }

        public Card Draw()
        {
            Size--;
            Card removedCard = deck[0];
            deck.RemoveAt(0);
            return removedCard;
        }

        public Card Play(int index)
        {
            Size--;
            Card removedCard = deck[index];
            deck.RemoveAt(index);
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
            bool contains = false;
            deck.ForEach((card) =>
            {
                if (card.Number == n)
                {
                    contains = true;
                }
            });
            return contains;
        }

        public void SortByPower()
        {
            deck = deck.OrderBy(card => card.Power)
                       .ThenBy(card => (int)card.Suit)
                       .ToList();
        }

        public void SortBySuit()
        {
            deck = deck.OrderBy(card => (int)card.Suit)
                       .ThenBy(card => card.Power)
                       .ToList();
        }

        public void SortByNumber()
        {
            deck = deck.OrderBy(card => card.Number)
                       .ThenBy(card => (int)card.Suit)
                       .ToList();
        }
    }
}
