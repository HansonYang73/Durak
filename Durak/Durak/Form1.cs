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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
