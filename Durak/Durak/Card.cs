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
                power = value;
                switch (power)
                {
                    case 0:
                        power = 13;
                        break;
                    case 1:
                        power = 14;
                        break;
                }
            } 
        }
        public int Number { get; set; }
        public Suit Suit { get; set; }
        public static Suit EmpSuit { get; set; } // Empowered Suit
        public string CardImg {  get; set; }

        public Card(int num, Suit suit)
        {
            Suit = suit;
            Power = num % 13;
            Number = num % 13 == 0 ? 13 : num % 13;
            CardImg = "_" + num;
        }

        public override String ToString()
        {
            if (Number == 11)
            {
                return "Jack" + " of " + Suit + "s";

            }
            else if (Number == 12)
            {
                return "Queen" + " of " + Suit + "s";

            }
            else if (Number == 13)
            {
                return "King" + " of " + Suit + "s";

            }
            else if (Number == 1)
            {
                return "Ace" + " of " + Suit + "s";

            }
            else
            {
                return Number + " of " + Suit + "s";

            }
        }
    }
}
