using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Durak
{
    public partial class Durak : Form
    {
        private int playerCount;
        private static String culture;
        private bool isChangingLanguage = false;

        public Durak()
        {
            InitializeComponent();
            languageComboBox.SelectedIndex = 0;
            playerCount = 2;
        }

        private void ChangeLanguage(string culture)
        {
            isChangingLanguage = true;
            var selectedText = languageComboBox.Text;
            var selectedIndex = languageComboBox.SelectedIndex;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            Controls.Clear();
            InitializeComponent();

            if (selectedIndex >= 0 && selectedIndex < languageComboBox.Items.Count)
                languageComboBox.SelectedIndex = selectedIndex;
            else
                languageComboBox.Text = selectedText; // fallback if items changed
            isChangingLanguage = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            Hide();
            new GameBoard(playerCount).Show();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isChangingLanguage == true)
                return;
            if(languageComboBox.Text == "English")
            {
                culture = "en-US";
                ChangeLanguage(culture);

            }
            if(languageComboBox.Text == "Français")
            {
                culture = "fr-FR";
                ChangeLanguage(culture);
            }
            if (languageComboBox.Text == "Español")
            {
                culture = "es-ES";
                ChangeLanguage(culture);
                label9.Font = new Font(label9.Font.FontFamily, 24, FontStyle.Bold);
            }
        }
        public static String getCulture()
        {
            return culture;
        }
    }
}