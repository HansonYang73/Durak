using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    internal class Card
    {
        private int power;
        public int Power { 
            get
            {
                return power;
            } 
            set
            {
                power = value % 13;
                switch (power)
                {
                    case 0:
                        power = 13;
                        break;
                    case 1:
                        power = 14;
                        break;
                }

                if (Suit == EmpSuit)
                {
                    power += 13;
                }
            } 
        }
        public Suit Suit { get; set; }
        public static Suit EmpSuit { get; set; } // Empowered Suit
        public string CardImg {  get; set; }

        public Card(int num, Suit suit)
        {
            Suit = suit;
            Power = num;
            CardImg = num + ".png";
        }
    }
}
