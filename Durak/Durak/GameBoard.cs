using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private int page;

        private List<PictureBox> enemyCards;
        private List<PictureBox> playersCards;
        private List<PictureBox> attackingSlots;
        private List<PictureBox> defendingSlots;

        private int playerCount;

        private Deck deck;

        private string fightMode;

        private Deck boardDeck;
        private Deck mainPlayer;
        private Deck botPlayer;
        private Deck currentAttacker;
        private Deck currentDefender;

        private bool played;

        private bool endedTurn;
        private bool botEndedTurn;

        public GameBoard(int playerCount)
        {
            InitializeComponent();
            turn = 1;

            page = 1;

            endedTurn = false;
            botEndedTurn = false;


            this.playerCount = playerCount;

            this.deck = new Deck();
            boardDeck = new Deck(false);

            
            this.fightMode = "Attack";
            mainPlayer = new Deck(false);
            currentAttacker = mainPlayer;
            botPlayer = new Deck(true);
            currentDefender = botPlayer;

            played = false;

            empowerCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(deck.Get(deck.Size - 1).CardImg);
            empowerCard.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            playersCards = new List<PictureBox> { card1, card2, card3, card4, card5, card6 };
            enemyCards = new List<PictureBox> { botCard1, botCard2, botCard3, botCard4, botCard5, botCard6 };
            attackingSlots = new List<PictureBox> { cardAttack1, cardAttack2, cardAttack3, cardAttack4, cardAttack5, cardAttack6 };
            defendingSlots = new List<PictureBox> { cardDefend1, cardDefend2, cardDefend3, cardDefend4, cardDefend5, cardDefend6 };

            drawDecks();
            fillBotDeck();
            fillDeck();

            if (Durak.getCulture() == "en-US")
            {
                historyTextBox.AppendText("Turn " + turn + " (Attacker: You, Defender: Bot)" + Environment.NewLine);
            }
            else if (Durak.getCulture() == "fr-FR")
            {
                historyTextBox.AppendText("Tour " + turn + " (Attaquant : Vous, Défenseur : Robot)" + Environment.NewLine);
            }
            else if (Durak.getCulture() == "es-ES")
            {
                historyTextBox.AppendText("Turno " + turn + " (Atacante: Tu, Defensor: Bot)" + Environment.NewLine);
            }


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
            if (boardDeck.Size == 0 && (mainPlayer.Size < 6 || botPlayer.Size < 0))
            {
                drawDecks();
                fillBotDeck();
                fillDeck();

                if(Durak.getCulture() == "en-US")
                {
                string extraInfo = !currentAttacker.isBot ? " (Attacker: You, Defender: Bot)" : " (Attacker: Bot, Defender: You)";
                    historyTextBox.AppendText("Turn " + turn + extraInfo + Environment.NewLine);
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                string extraInfo = !currentAttacker.isBot ? " (Attaquant : Vous, Défenseur : Robot)" : " (Attaquant : Robot, Défenseur : Vous)";
                    historyTextBox.AppendText("Tour " + turn + extraInfo + Environment.NewLine);
                }
                else if (Durak.getCulture() == "es-ES")
                {
                string extraInfo = !currentAttacker.isBot ? " (Atacante: Tu, Defensor: Bot)" : " (Atacante: Bot, Defensor: Tu)";
                    historyTextBox.AppendText("Turno " + turn + extraInfo + Environment.NewLine);
                }
            }
        }

        private void mainDeck_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        private void mainDeck_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            sortingComboBox.SelectedIndex = 0;
        }

        private void drawDecks()
        {
            foreach (Deck deck in new List<Deck> {currentAttacker, currentDefender})
            {
                while (deck.Size < 6 && this.deck.Size > 0)
                {
                    Card drawnCard = this.deck.Draw();
                    deck.AddCard(drawnCard);
                }
            }

            Sort();

            endedTurn = false;
            botEndedTurn = false;

            if (Durak.getCulture() == "en-US")
            {
                numberOfCardsLabel.Text = "Cards: " + deck.Size.ToString();
            }
            else if (Durak.getCulture() == "fr-FR")
            {
                numberOfCardsLabel.Text = "Cartes: " + deck.Size.ToString();
            }
            else if (Durak.getCulture() == "es-ES")
            {
                numberOfCardsLabel.Text = "Cardes: " + deck.Size.ToString();
            }

            if (deck.Size == 0)
            {
                string suitStr = Card.EmpSuit.ToString();
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

                else if (suitStr.Equals("Club"))
                {
                    if (culture == "en-US")
                        suitStr = "Club";
                    else if (culture == "fr-FR")
                        suitStr = "Trèfles";
                    else if (culture == "es-ES")
                        suitStr = "Tréboles";
                }

                else if (suitStr.Equals("Spade"))
                {
                    if (culture == "en-US")
                        suitStr = "Spade";
                    else if (culture == "fr-FR")
                        suitStr = "Piques";
                    else if (culture == "es-ES")
                        suitStr = "Espadas";
                }

                else if (suitStr.Equals("Diamond"))
                {
                    if (culture == "en-US")
                        suitStr = "Diamond";
                    else if (culture == "fr-FR")
                        suitStr = "Carreaux";
                    else if (culture == "es-ES")
                        suitStr = "Diamantes";
                }


                if (Durak.getCulture() == "en-US")
                {
                    numberOfCardsLabel.Text = "Empowered Suit: " + suitStr;
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    numberOfCardsLabel.Text = "Couleur Puissant: " + suitStr;
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    numberOfCardsLabel.Text = "Traje Potenciado: " + suitStr;
                }
            }

            StartTurn();
        }

        private void fillBotDeck()
        {
            int size = 0;
            foreach (PictureBox pictureBox in enemyCards)
            {

                if (size < botPlayer.Size)
                {
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("back");
                    size++;

                }
                else
                {
                    pictureBox.Image = null;
                }

            }
            if (botPlayer.Size > 6)
            {
                int extraCards = botPlayer.Size - 6;
                if (Durak.getCulture() == "en-US")
                {
                    extraBotCards.Text = $"+{extraCards} Cards";
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    extraBotCards.Text = $"+{extraCards} Cartes";
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    extraBotCards.Text = $"+{extraCards} Cardes";
                }
            }
            else
            {
                extraBotCards.Text = "";
            }


        }

        private void fillDeck()
        {
            int size = 0;

            foreach (PictureBox pictureBox in playersCards)
            {

                if (size + 6 * (page - 1) < mainPlayer.Size)
                {
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(mainPlayer.Get(size + 6 * (page - 1)).CardImg);
                    size++;
                }
                else
                {
                    pictureBox.Image = null;
                }

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

            if (mainPlayer.Size > 6 * (page))
            {
                nextCard.Enabled = true;
            }
            else
            {
                nextCard.Enabled = false;
            }

            if (page > 1)
            {
                goBack.Enabled = true;

            }
            else
            {
                goBack.Enabled = false;
            }

        }

        private void card_Click(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            int cardInd = playersCards.IndexOf(card) + 6 * (page-1);
            if (cardInd < mainPlayer.Size)
            {
                attackOrDefend(card, cardInd);
            }
            fillDeck();

            if (deck.Size == 0 && (mainPlayer.Size == 0 || botPlayer.Size == 0))
            {
                endGame();
            }
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
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText($"You have attacked with: {playCard.ToString()}" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText($"Vous avez attaqué avec: {playCard.ToString()}" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText($"Has atacado con: {playCard.ToString()}" + Environment.NewLine);
                    }

                    played = true;
                }
            }
            else
            {
                if (CanDefend(playCard))
                {
                    defend(card);

                    boardDeck.AddCard(mainPlayer.Play(i));
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText($"You have defended with: {playCard.ToString()}" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText($"Vous avez défendu avec: {playCard.ToString()}" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText($"Has defendido con: {playCard.ToString()}" + Environment.NewLine);
                    }

                    played = true;
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
            return (boardDeck.Size == 0 || boardDeck.ContainsNumber(attackCard.Number)) && !played && boardDeck.Size % 2 == 0 && boardDeck.Size < 12;
        }

        private bool CanDefend(Card card)
        {
            if (boardDeck.Size % 2 == 0)
            {
                return false;
            }

            bool canDefend = false;
            Card attackingCard = boardDeck.Get(boardDeck.Size - 1);

            if ((card.Suit == attackingCard.Suit || card.Suit == Card.EmpSuit) && card.Power > attackingCard.Power)
            {
                canDefend = true; 
            }

            return canDefend && !played && boardDeck.Size % 2 == 1; 
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


        private void endGame()
        {
            winLabel.Visible = true;
            winLabel.Enabled = true;
            if (mainPlayer.Size == 0)
            {
                winLabel.ForeColor = Color.LimeGreen;
                if (Durak.getCulture() == "en-US")
                {
                    winLabel.Text = "You Have Won!";
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    winLabel.Text = "Vous Avez Gagné!";
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    winLabel.Text = "Has Ganado!";
                }
            }
            else if (botPlayer.Size == 0)
            {
                winLabel.ForeColor = Color.Red;
                winLabel.Text = "Durak!";
            }

            foreach (PictureBox picturebox in playersCards)
            {
                picturebox.Enabled = false;

            }

            mainMenuButton.Enabled = true;
            mainMenuButton.Visible = true;

        }

        private void empowerCard_MouseEnter(object sender, EventArgs e)
        {
            empowerCard.BorderStyle = BorderStyle.FixedSingle;
        }

        private void empowerCard_MouseLeave(object sender, EventArgs e)
        {
            empowerCard.BorderStyle = BorderStyle.None;
        }

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            if (!endedTurn && boardDeck.Size > 0)
            {
                if (Durak.getCulture() == "en-US")
                {
                    historyTextBox.AppendText("You have ended your turn" + Environment.NewLine);
                }
                else if (Durak.getCulture() == "fr-FR")
                {
                    historyTextBox.AppendText("Vous avez terminé votre tour" + Environment.NewLine);
                }
                else if (Durak.getCulture() == "es-ES")
                {
                    historyTextBox.AppendText("Has terminado tu turno." + Environment.NewLine);
                }
                endedTurn = true;
            }
        }

        private void EndTurn()
        {
            Console.WriteLine("End turn got called");
            if (endedTurn && botEndedTurn)
            {
                if (boardDeck.Size % 2 == 1)
                {
                    currentDefender.AddDeck(boardDeck);
                    fillBotDeck();
                    fillDeck();
                }
                else
                {
                    Deck temp = currentAttacker;
                    currentAttacker = currentDefender;
                    currentDefender = temp;

                    fightMode = fightMode == "Attack" ? "Defend" : "Attack";

                }

                if (currentAttacker == mainPlayer)
                {
                    played = false;
                }
                else
                {
                    played = true;
                }

                
                turn++;


                //if (boardDeck.Size == 0)
                //{
                //    drawDecks();
                //    if (Durak.getCulture() == "en-US")
                //    {
                //        string extraInfo = !currentAttacker.isBot ? " (Attacker: You, Defender: Bot)" : " (Attacker: Bot, Defender: You)";
                //        historyTextBox.AppendText(Environment.NewLine + "Turn " + turn + extraInfo + Environment.NewLine);
                //    }
                //    else if (Durak.getCulture() == "fr-FR")
                //    {
                //        string extraInfo = !currentAttacker.isBot ? " (Attaquant : Vous, Défenseur : Robot)" : " (Attaquant : Robot, Défenseur : Vous)";
                //        historyTextBox.AppendText(Environment.NewLine + "Tour " + turn + extraInfo + Environment.NewLine);
                //    }
                //    else if (Durak.getCulture() == "es-ES")
                //    {
                //        string extraInfo = !currentAttacker.isBot ? " (Atacante: Tu, Defensor: Bot)" : " (Atacante: Bot, Defensor: Tu)";
                //        historyTextBox.AppendText(Environment.NewLine + "Turno " + turn + extraInfo + Environment.NewLine);
                //    }
                //}
                if (mainPlayer.Size >= 6)
                {
                    drawDecks();
                    if (Durak.getCulture() == "en-US")
                    {
                        string extraInfo = !currentAttacker.isBot ? " (Attacker: You, Defender: Bot)" : " (Attacker: Bot, Defender: You)";
                        historyTextBox.AppendText(Environment.NewLine + "Turn " + turn + extraInfo + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        string extraInfo = !currentAttacker.isBot ? " (Attaquant : Vous, Défenseur : Robot)" : " (Attaquant : Robot, Défenseur : Vous)";
                        historyTextBox.AppendText(Environment.NewLine + "Tour " + turn + extraInfo + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        string extraInfo = !currentAttacker.isBot ? " (Atacante: Tu, Defensor: Bot)" : " (Atacante: Bot, Defensor: Tu)";
                        historyTextBox.AppendText(Environment.NewLine + "Turno " + turn + extraInfo + Environment.NewLine);
                    }
                }
                else if (deck.Size == 0)
                {
                    drawDecks();
                    if (Durak.getCulture() == "en-US")
                    {
                        string extraInfo = !currentAttacker.isBot ? " (Attacker: You, Defender: Bot)" : " (Attacker: Bot, Defender: You)";
                        historyTextBox.AppendText(Environment.NewLine + "Turn " + turn + extraInfo + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        string extraInfo = !currentAttacker.isBot ? " (Attaquant : Vous, Défenseur : Robot)" : " (Attaquant : Robot, Défenseur : Vous)";
                        historyTextBox.AppendText(Environment.NewLine + "Tour " + turn + extraInfo + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        string extraInfo = !currentAttacker.isBot ? " (Atacante: Tu, Defensor: Bot)" : " (Atacante: Bot, Defensor: Tu)";
                        historyTextBox.AppendText(Environment.NewLine + "Turno " + turn + extraInfo + Environment.NewLine);
                    }
                }

                ClearBoard();


                fillBotDeck();
                fillDeck();

                if (deck.Size > 0 && mainPlayer.Size < 6) 
                {
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText(Environment.NewLine + "Click the deck to draw the cards!" + Environment.NewLine + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText(Environment.NewLine + "Cliquez sur le paquet pour tirer les cartes!" + Environment.NewLine + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText(Environment.NewLine + "¡Haz clic en la baraja para robar las cartas!" + Environment.NewLine + Environment.NewLine);
                    }
                }
            }
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

        private async Task StartTurn()
        {
            Console.WriteLine("STARTED STARTTURN METHOD");
            if (mainPlayer == currentAttacker)
            {
                while (!endedTurn || !botEndedTurn)
                {
                    if (!botEndedTurn || !endedTurn)
                    {
                        await WaitForAttacker();
                        Console.WriteLine($"\nAFTER ATTACK: has played:{played} and player has ended:{endedTurn} and bot has ended:{botEndedTurn}\n");
                    }
                    if (!botEndedTurn || !endedTurn)
                    {
                        await WaitForDefender();
                        Console.WriteLine($"\nAFTER DEFEND: has played:{played} and player has ended:{endedTurn} and bot has ended:{botEndedTurn}\n");
                    }
                    if (boardDeck.Size == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                while (!endedTurn || !botEndedTurn)
                {
                    Console.WriteLine("Played: " + played);
                    if (!botEndedTurn || !endedTurn)
                    {
                        await WaitForDefender();
                    }
                    if (!botEndedTurn || !endedTurn)
                    {
                        await WaitForAttacker();
                    }
                    if (boardDeck.Size == 0)
                    {
                        break;
                    }
                }
            }

            if (boardDeck.Size > 0)
            {
                EndTurn();
                Console.WriteLine("Start Turn called end turn");
            }
            Console.WriteLine("ENDED STARTTURN METHOD");
        }

        private async Task WaitForAttacker()
        {
            if (!currentAttacker.isBot) 
            { 
                while (!played && !endedTurn)
                {
                    await Task.Delay(100);
                }
            }
            else
            {
                played = false;
                await Task.Delay(1000);
                Card attackCard = currentAttacker.bot.Attack(boardDeck, deck);
                if (attackCard != null && boardDeck.Size % 2 == 0)
                {
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText("Bot has attacked with: " + attackCard.ToString() + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText("Le robot a attaqué avec: " + attackCard.ToString() + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText("El bot ha atacado con: " + attackCard.ToString() + Environment.NewLine);
                    }

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(attackCard.CardImg);

                    attack(pictureBox);

                    boardDeck.AddCard(attackCard);
                    
                    // refresh bot deck
                    fillBotDeck();
                }
                else
                {
                    botEndedTurn = true;
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText("Bot has ended their turn" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText("Le robot a terminé son tour" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText("El bot ha terminado su turno" + Environment.NewLine);
                    }

                }

                if (deck.Size == 0 && (mainPlayer.Size == 0 || botPlayer.Size == 0))
                {
                    endGame();

                }
            }
        }

        private async Task WaitForDefender()
        {
            if (!currentDefender.isBot)
            {
                while (!played && !endedTurn)
                {
                    await Task.Delay(100);
                }
            }
            else
            {
                await Task.Delay(1000);
                Card defendCard = currentDefender.bot.Defend(boardDeck, deck);

                if (defendCard != null)
                {
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText("Bot has defended with: " + defendCard.ToString() + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText("Le robot a défendu avec: " + defendCard.ToString() + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText("Bot ha defendido con: " + defendCard.ToString() + Environment.NewLine);
                    }

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(defendCard.CardImg);

                    defend(pictureBox);

                    boardDeck.AddCard(defendCard);

                    // refresh bot deck
                    fillBotDeck();

                    endedTurn = false;
                }
                else
                {
                    botEndedTurn = true;
                    if (boardDeck.Size % 2 == 1)
                    {
                        endedTurn = true;
                    }
                    if (Durak.getCulture() == "en-US")
                    {
                        historyTextBox.AppendText("Bot has ended their turn" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "fr-FR")
                    {
                        historyTextBox.AppendText("Le robot a terminé son tour" + Environment.NewLine);
                    }
                    else if (Durak.getCulture() == "es-ES")
                    {
                        historyTextBox.AppendText("El bot ha terminado su turno" + Environment.NewLine);
                    }
                }

                played = false;

                if (deck.Size == 0 && (mainPlayer.Size == 0 || botPlayer.Size == 0))
                {
                    endGame();

                }
            }
        }

        private void nextCard_Click(object sender, EventArgs e)
        {
            page++;
            fillDeck();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            page--;
            fillDeck();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Durak().Show();
        }
    }
}