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
    public partial class Durak : Form
    {
        private int playerCount;
        public Durak()
        {
            InitializeComponent();
            playerCount = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            Deck p1 = new Deck(false);
            Deck p2 = new Deck(false);

            Console.WriteLine("Deck:");
            deck.PrintDeck();
            Console.WriteLine("p1:");
            p1.PrintDeck();
            Console.WriteLine("p2:");
            p2.PrintDeck();

            Console.WriteLine(Card.EmpSuit);
        }

        private void durakForm_Load(object sender, EventArgs e)
        {
            op1ComboBox.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            Hide();
            new GameBoard(playerCount).Show();
            // need to add more code
            // not sure about the variable players and playercount being in this form
        }
    }
}
