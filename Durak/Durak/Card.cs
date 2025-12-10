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
            string numStr = Number.ToString();
            if (Number == 11)
            {
                numStr = "Jack";

            }
            else if (Number == 12)
            {
                numStr = "Queen";
            }
            else if (Number == 13)
            {
                numStr = "King";
            }
            else if (Number == 1)
            {
                numStr = "Ace";
            }

            return numStr + " of " + Suit + "s";

            
        }
    }
}
