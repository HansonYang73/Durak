using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// START OF GAME
//      - 1. everyone draw cards
//      - 2. main attacker is the player
//      - 3. defender is bot to the left

// draw cards until 6
//      - i can remove the drawing till 6 from the deck constructor since it will draw 6 cards anyways
//      - 1. Previous Defender
//      - 2. Main attacker
//      - 3. Other attacker clockwise
// attack
//      - Main attacker attacking the player to its left (the defender)
//      - First attack can be any card and is made by the main attacker
//      - Afterwards, anyone (maybe in order) can attack as long as the number is on the board
//      - Can only attack the attaacker 6 times 
// defend
//      - Can only defend with a card of (same suit AND higher power) OR (is empowered)
//      - If the attacking card is also empowered, need to defend with a higher empowered card
// everyone needs to end turn for turn to end
//      - You can end turn at any point (button)
//      - After someones make a play, if you previously click the 'end turn button' it doesn't matter
//        and you can still play but you need to click the 'end turn button' again.
//      - If the board is defended, defender becomes the next main attacker AND all cards in the board is discarded
//      - Else the player to the left of the defender becomes the next main attacker AND the defender picks up all cards on the board.

// Features to add
//      - Round table backround
//      - Hand of cards
//      - Show who ended their turn

// Additional Ideas
//      - Turn counter (ex: Turn 1)
//      - Main attacker and defender indicater

// Possible changes for balance
//      - Only allow 6 attacks so that you can't just keep attacking until they can't defend especially when you are 4 players
namespace Durak
{
    public partial class GameBoard : Form
    {


        private List<PictureBox> playersCards;
        private List<PictureBox> attackingSlots;
        private List<PictureBox> defendingSlots;
        private Deck deck;
        private Deck mainPlayer;
        private string fightMode;
        private List<Deck> allDecks;
        private Deck currentPlayer;
        private int playerCount;
        private Deck currentDefender;
        private int mainAttackerIndex;

        public GameBoard(int playerCount)
        {
            mainAttackerIndex = 0;
            this.playerCount = playerCount;
            InitializeComponent();
            this.allDecks = new List<Deck>();
            this.deck = new Deck();
            for (int i = 0; i < playerCount; i++)
            {
                this.allDecks.Add(new Deck(this.deck));
            }
            this.mainPlayer = allDecks[0];
            this.fightMode = "Attack";
            empowerCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(deck.Get(deck.Size - 1).CardImg);
            Console.WriteLine(deck.Get(deck.Size - 1).CardImg);
            empowerCard.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            playersCards = new List<PictureBox> { card1, card2, card3, card4, card5, card6 };
            attackingSlots = new List<PictureBox> { cardAttack1, cardAttack2, cardAttack3, cardAttack4, cardAttack5, cardAttack6 };
            defendingSlots = new List<PictureBox> { cardDefend1, cardDefend2, cardDefend3, cardDefend4, cardDefend5, cardDefend6 };
            fillDeck();





        }

        public string FightMode

        {
            set { fightMode = value; }

        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mainDeck_Click(object sender, EventArgs e)
        {
            fillDeck();

        }

        private void mainDeck_MouseEnter(object sender, EventArgs e)
        {
            mainDeck.BorderStyle = BorderStyle.FixedSingle;
        }

        private void mainDeck_MouseLeave(object sender, EventArgs e)
        {
            mainDeck.BorderStyle = BorderStyle.None;

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }

        private void fillDeck()
        {

            foreach (PictureBox pictureBox in playersCards)
            {
                if (pictureBox.Image == null)
                {

                    if (deck.Size == 0)
                    {
                        mainDeck.Visible = false;
                        mainDeck.Enabled = false;
                        empowerCard.Visible = false;
                        empowerCard.Enabled = false;
                        break;
                    }

                    else
                    {
                        pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(deck.Draw().CardImg);


                    }
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine(deck.Size);
        }

        private void card1_Click(object sender, EventArgs e)
        {
            attackOrDefend(card1);





        }

        private void card2_Click(object sender, EventArgs e)
        {
            attackOrDefend(card2);





        }

        private void card3_Click(object sender, EventArgs e)
        {

            attackOrDefend(card3);





        }

        private void card4_Click(object sender, EventArgs e)
        {

            attackOrDefend(card4);





        }

        private void card5_Click(object sender, EventArgs e)
        {
            attackOrDefend(card5);




        }

        private void card6_Click(object sender, EventArgs e)
        {
            attackOrDefend(card6);



        }

        private void attack(PictureBox card)
        {
            PictureBox pb = null;
            foreach (PictureBox pictureBox in attackingSlots)
            {
                if (pictureBox.Image == null)
                {
                    pb = pictureBox;
                    break;
                }
                else
                {
                    continue;

                }

            }
            pb.Image = card.Image;




        }
        private void defend(PictureBox card)
        {
            PictureBox pb = null;
            foreach (PictureBox pictureBox in defendingSlots)
            {
                if (pictureBox.Image == null)
                {
                    pb = pictureBox;
                    break;
                }
                else
                {
                    continue;

                }

            }
            pb.Visible = true;
            pb.Image = card.Image;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.fightMode == "Attack")
            {
                this.fightMode = "Defend";


            }
            else if (this.fightMode == "Defend")
            {
                this.fightMode = "Attack";


            }
            Console.WriteLine(fightMode);
        }

        private void attackOrDefend(PictureBox card)
        {
            if (fightMode == "Attack")
            {

                attack(card);


            }
            else
            {
                defend(card);


            }
            card.Image = null;

        }
        private void pickUpLastEmpoweredCard()
        {
            foreach (PictureBox pictureBox in playersCards)
            {
                if (pictureBox.Image == null)
                {
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(deck.Draw().CardImg);
                    empowerCard.Visible = false;
                    empowerCard.Enabled = false;
                    break;


                }
                else
                {
                    continue;

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            attackingSlots.ForEach((picturebox) => picturebox.Image = null);
            defendingSlots.ForEach((picturebox) => picturebox.Image = null);
        }


        private void empowerCard_Click(object sender, EventArgs e)
        {

            pickUpLastEmpoweredCard();

        }

        private void empowerCard_MouseEnter(object sender, EventArgs e)
        {
            empowerCard.BorderStyle = BorderStyle.FixedSingle;
        }

        private void empowerCard_MouseLeave(object sender, EventArgs e)
        {
            empowerCard.BorderStyle = BorderStyle.None;
        }

        private void setDefender()
        {
            currentDefender = allDecks[(mainAttackerIndex + 1) % playerCount];
        }

        private void firstAttack()
        {
            fightMode = "Attack";



        }
    }
}