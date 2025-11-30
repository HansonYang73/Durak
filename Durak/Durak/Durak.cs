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
        private List<String> players;
        public Durak()
        {
            InitializeComponent();
            playerCount = 1;
            players = new List<String>();
            players.Add("Player");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            Deck p1 = new Deck(deck);
            Deck p2 = new Deck(deck);

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
            op2ComboBox.SelectedIndex = 0;
            op3ComboBox.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            players.Add(op1ComboBox.Text);
            playerCount++;

            if (!op2ComboBox.Text.Equals("None"))
            {
                players.Add(op2ComboBox.Text);
                playerCount++;
            }
            if (!op3ComboBox.Text.Equals("None"))
            {
                players.Add(op3ComboBox.Text);
                playerCount++;
            }

            Hide();
            new GameBoard().Show();
            // need to add more code
            // not sure about the variable players and playercount being in this form
        }
    }
}
