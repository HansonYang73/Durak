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
        private int turn;

        private List<PictureBox> playersCards;
        private List<PictureBox> attackingSlots;
        private List<PictureBox> defendingSlots;

        private int playerCount;

        private Deck deck;

        private string fightMode;

        private Deck boardDeck;
        private Deck mainPlayer;
        private Deck currentAttacker;
        private Deck currentDefender;

        private int attacksThisRound;
        private const int maxAttacksPerTurn = 6;
        //private bool allowCardPlay;
        private bool turnEnded;

        public GameBoard(int playerCount)
        {
            InitializeComponent();
            turn = 1;

            turnEnded = false;


            this.playerCount = playerCount;

            this.deck = new Deck();
            boardDeck = new Deck(false);

            
            this.fightMode = "Attack";
            mainPlayer = new Deck(false);
            currentAttacker = mainPlayer;
            currentDefender = new Deck(true);

            empowerCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(deck.Get(deck.Size - 1).CardImg);
            Console.WriteLine(deck.Get(deck.Size - 1).CardImg);
            empowerCard.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            playersCards = new List<PictureBox> { card1, card2, card3, card4, card5, card6 };
            attackingSlots = new List<PictureBox> { cardAttack1, cardAttack2, cardAttack3, cardAttack4, cardAttack5, cardAttack6 };
            defendingSlots = new List<PictureBox> { cardDefend1, cardDefend2, cardDefend3, cardDefend4, cardDefend5, cardDefend6 };
            Console.WriteLine(deck.Size);

            drawDecks();
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
            if (turnEnded)
            {
                drawDecks();
                fillDeck();
            }
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
            sortingComboBox.SelectedIndex = 0;
        }

        private void drawDecks()
        {
            foreach (Deck deck in new List<Deck> { })
            {
                while (deck.Size < 6 && this.deck.Size > 0)
                {
                    Card drawnCard = this.deck.Draw();
                    deck.AddCard(drawnCard);
                }
            }

            Sort();

            turnEnded = false;
        }

        private void fillDeck()//add paramater later
        {
            int size = 0;

            foreach (PictureBox pictureBox in playersCards)
            {
                //if (pictureBox.Image == null)
                //{
                    //if (deck.Size == 0)
                    //{
                    //    mainDeck.Visible = false;
                    //    mainDeck.Enabled = false;
                    //    empowerCard.Visible = false;
                    //    empowerCard.Enabled = false;
                    //    break;
                    //}
                    if (size < mainPlayer.Size)
                    {
                        pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(mainPlayer.Get(size++).CardImg);
                    }
                    else 
                    {
                        pictureBox.Image = null;
                    }
                //}
                //else
                //{
                //    continue;
                //}
            }
            if (deck.Size == 0)
            {
                mainDeck.Visible = false;
                mainDeck.Enabled = false;
                empowerCard.Visible = false;
                empowerCard.Enabled = false;
            }
            else if (deck.Size == 1)
            {
                mainDeck.Visible = false;
                mainDeck.Enabled = false;
                empowerCard.Enabled = true;
            }

            Console.WriteLine(deck.Size);
        }

        private void card_Click(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            int cardInd = playersCards.IndexOf(card);
            if (cardInd < mainPlayer.Size)
            {
                attackOrDefend(card, cardInd);
            }

            Console.WriteLine(mainPlayer.Size);
            fillDeck();
        }
        private void attackOrDefend(PictureBox card, int i)
        {
            
            Card playCard = mainPlayer.Get(i);
            if (fightMode == "Attack")
            {
                if (CanAttack(playCard)) 
                { 
                    attack(card);
                    // adds the card to the decks
                    boardDeck.AddCard(mainPlayer.Play(i));
                }
            }
            else
            {
                if (CanDefend(playCard))
                {
                    defend(card);

                    boardDeck.AddCard(mainPlayer.Play(i));
                }
            }
            card.Image = null;
        }
        private void attack(PictureBox card)
        {
            // adds the image
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
            card.Image = null;

            
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
            card.Image = null;
        }

        private bool CanAttack(Card attackCard)
        {
            return (boardDeck.Size == 0 || boardDeck.ContainsNumber(attackCard.Number)) && true; // change true to canAttack bool variable
        }

        private bool CanDefend(Card card)
        {
            bool canDefend = false;
            Card attackingCard = boardDeck.Get(boardDeck.Size - 1);

            if ((card.Suit == attackingCard.Suit || card.Suit == Card.EmpSuit) && card.Power > attackingCard.Power)
            {
                canDefend = true; 
            }

            return canDefend && true; // change true to canDefend2 bool variable
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
            ClearBoard();
        }

        private void ClearBoard()
        {
            attackingSlots.ForEach((picturebox) => picturebox.Image = null);
            defendingSlots.ForEach((picturebox) =>
            {
                picturebox.Image = null;
                picturebox.Visible = false;
            });

            boardDeck = new Deck(false);
        }


        private void empowerCard_Click(object sender, EventArgs e)
        {

            //pickUpLastEmpoweredCard();
            if (turnEnded)
            {
                drawDecks();
                fillDeck();
            }

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
            //currentDefender = allDecks[(currentAttackerIndex + 1) % playerCount];
        }

        //private void currentAttackerRule()
        //{
        //    if (fightMode == "Attack" && cardAttack1 == null)
        //    {
        //        allowCardPlay = true;
        //    }
        //}

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            // deal with bots attack and user defend and user attack


            // everyone played and ended their turn

            if (boardDeck.Size % 2 == 1)
            {
                currentDefender.AddDeck(boardDeck);
            }
            else
            {
                Deck temp = currentAttacker;
                currentAttacker = currentDefender;
                currentDefender = temp;
            }

            ClearBoard();
            turn++;
            turnEnded = true;
        }

        private void sortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
            fillDeck();
        }

        private void Sort()
        {
            switch (sortingComboBox.SelectedIndex)
            {
                case 0:
                    mainPlayer.SortByPower();
                    break;
                case 1:
                    mainPlayer.SortBySuit();
                    break;
                case 2:
                    mainPlayer.SortByNumber();
                    break;
            }
        }

        private void waitngLabelTimer_Tick(object sender, EventArgs e)
        {
            String waitingText = waitingLabel.Text;
            int dots = waitingText.Count(dot => dot == '.');
            String str = waitingText.Substring(0, waitingText.Length-dots);

            dots = (dots + 1) % 4;
            for (int i = 0; i < dots; i++)
            {
                str += ".";
            }
            
            waitingLabel.Text = str;
        }

        private async void StartTurn()
        {

        }
    }
}