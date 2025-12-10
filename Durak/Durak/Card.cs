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
                if (Durak.getCulture() == "en-US")
                {
                    numStr = "Jack";
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    numStr = "Valet";
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    numStr = "Jota";
                }

            }
            else if (Number == 12)
            {
                if (Durak.getCulture() == "en-US")
                {
                    numStr = "Queen";
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    numStr = "Dame";
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    numStr = "Reina";
                }
            }
            else if (Number == 13)
            {
                if (Durak.getCulture() == "en-US")
                {
                    numStr = "King";
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    numStr = "Roi";
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    numStr = "Rey";
                }
            }
            else if (Number == 1)
            {
                if (Durak.getCulture() == "en-US")
                {
                    numStr = "Ace";
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    numStr = "As";
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    numStr = "As";
                }
            }




            string suitStr = Suit.ToString();
            string culture = Durak.getCulture();

            if (suitStr.Equals("Heart"))
            {
                if (culture == "en-US")
                    suitStr = "Heart";
                else if (culture == "fr-FR")
                    suitStr = "Coeurs";
                else if (culture == "es-ES")
                    suitStr = "Corazones";
            }

            else if (suitStr == "Clubs")
            {
                if (culture == "en-US")
                    suitStr = "Clubs";
                else if (culture == "fr-FR")
                    suitStr = "Trèfles";
                else if (culture == "es-ES")
                    suitStr = "Tréboles";
            }

            else if (suitStr == "Spades")
            {
                if (culture == "en-US")
                    suitStr = "Spades";
                else if (culture == "fr-FR")
                    suitStr = "Piques";
                else if (culture == "es-ES")
                    suitStr = "Espadas";
            }

            else if (suitStr == "Diamonds")
            {
                if (culture == "en-US")
                    suitStr = "Diamonds";
                else if (culture == "fr-FR")
                    suitStr = "Carreaux";
                else if (culture == "es-ES")
                    suitStr = "Diamantes";
            }

            if (Durak.getCulture() == "en-US")
            {
                return numStr + " of " + suitStr + "s";
            }
            else if (Durak.getCulture() == "fr-FR")
            {
                return numStr + " des " + suitStr;
            }
            else
            {
                return numStr + " de " + suitStr;
            }

            
        }
    }
}
