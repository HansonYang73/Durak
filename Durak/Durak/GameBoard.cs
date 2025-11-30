using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class GameBoard : Form
    {
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
        //      - Can only attack if the defender has more than 0 cards (if cards on board < defender hand)
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
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
