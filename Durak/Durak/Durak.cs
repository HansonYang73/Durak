using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
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
            languageComboBox.SelectedIndex = 0;
            playerCount = 2;
        }

        private void durakForm_Load(object sender, EventArgs e)
        {
            //op1ComboBox.SelectedIndex = 0;
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