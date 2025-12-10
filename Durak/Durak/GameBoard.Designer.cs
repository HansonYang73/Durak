namespace Durak
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.sortingComboBox = new System.Windows.Forms.ComboBox();
            this.extraBotCards = new System.Windows.Forms.Label();
            this.nextCard = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.botCard6 = new System.Windows.Forms.PictureBox();
            this.botCard5 = new System.Windows.Forms.PictureBox();
            this.botCard4 = new System.Windows.Forms.PictureBox();
            this.botCard3 = new System.Windows.Forms.PictureBox();
            this.botCard2 = new System.Windows.Forms.PictureBox();
            this.botCard1 = new System.Windows.Forms.PictureBox();
            this.cardDefend6 = new System.Windows.Forms.PictureBox();
            this.cardDefend5 = new System.Windows.Forms.PictureBox();
            this.cardDefend4 = new System.Windows.Forms.PictureBox();
            this.cardDefend3 = new System.Windows.Forms.PictureBox();
            this.cardDefend2 = new System.Windows.Forms.PictureBox();
            this.cardDefend1 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.mainDeck = new System.Windows.Forms.PictureBox();
            this.empowerCard = new System.Windows.Forms.PictureBox();
            this.cardAttack1 = new System.Windows.Forms.PictureBox();
            this.cardAttack2 = new System.Windows.Forms.PictureBox();
            this.cardAttack3 = new System.Windows.Forms.PictureBox();
            this.cardAttack4 = new System.Windows.Forms.PictureBox();
            this.cardAttack5 = new System.Windows.Forms.PictureBox();
            this.cardAttack6 = new System.Windows.Forms.PictureBox();
            this.numberOfCardsLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.botCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empowerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack6)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTextBox
            // 
            resources.ApplyResources(this.historyTextBox, "historyTextBox");
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            // 
            // endTurnButton
            // 
            resources.ApplyResources(this.endTurnButton, "endTurnButton");
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // sortingComboBox
            // 
            resources.ApplyResources(this.sortingComboBox, "sortingComboBox");
            this.sortingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingComboBox.FormattingEnabled = true;
            this.sortingComboBox.Items.AddRange(new object[] {
            resources.GetString("sortingComboBox.Items"),
            resources.GetString("sortingComboBox.Items1"),
            resources.GetString("sortingComboBox.Items2")});
            this.sortingComboBox.Name = "sortingComboBox";
            this.sortingComboBox.SelectedIndexChanged += new System.EventHandler(this.sortingComboBox_SelectedIndexChanged);
            // 
            // extraBotCards
            // 
            resources.ApplyResources(this.extraBotCards, "extraBotCards");
            this.extraBotCards.BackColor = System.Drawing.Color.Transparent;
            this.extraBotCards.ForeColor = System.Drawing.Color.White;
            this.extraBotCards.Name = "extraBotCards";
            // 
            // nextCard
            // 
            resources.ApplyResources(this.nextCard, "nextCard");
            this.nextCard.Name = "nextCard";
            this.nextCard.UseVisualStyleBackColor = true;
            this.nextCard.Click += new System.EventHandler(this.nextCard_Click);
            // 
            // goBack
            // 
            resources.ApplyResources(this.goBack, "goBack");
            this.goBack.Name = "goBack";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // mainMenuButton
            // 
            resources.ApplyResources(this.mainMenuButton, "mainMenuButton");
            this.mainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // botCard6
            // 
            resources.ApplyResources(this.botCard6, "botCard6");
            this.botCard6.BackColor = System.Drawing.Color.Transparent;
            this.botCard6.Name = "botCard6";
            this.botCard6.TabStop = false;
            // 
            // botCard5
            // 
            resources.ApplyResources(this.botCard5, "botCard5");
            this.botCard5.BackColor = System.Drawing.Color.Transparent;
            this.botCard5.Name = "botCard5";
            this.botCard5.TabStop = false;
            // 
            // botCard4
            // 
            resources.ApplyResources(this.botCard4, "botCard4");
            this.botCard4.BackColor = System.Drawing.Color.Transparent;
            this.botCard4.Name = "botCard4";
            this.botCard4.TabStop = false;
            // 
            // botCard3
            // 
            resources.ApplyResources(this.botCard3, "botCard3");
            this.botCard3.BackColor = System.Drawing.Color.Transparent;
            this.botCard3.Name = "botCard3";
            this.botCard3.TabStop = false;
            // 
            // botCard2
            // 
            resources.ApplyResources(this.botCard2, "botCard2");
            this.botCard2.BackColor = System.Drawing.Color.Transparent;
            this.botCard2.Name = "botCard2";
            this.botCard2.TabStop = false;
            // 
            // botCard1
            // 
            resources.ApplyResources(this.botCard1, "botCard1");
            this.botCard1.BackColor = System.Drawing.Color.Transparent;
            this.botCard1.Name = "botCard1";
            this.botCard1.TabStop = false;
            // 
            // cardDefend6
            // 
            resources.ApplyResources(this.cardDefend6, "cardDefend6");
            this.cardDefend6.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend6.Name = "cardDefend6";
            this.cardDefend6.TabStop = false;
            // 
            // cardDefend5
            // 
            resources.ApplyResources(this.cardDefend5, "cardDefend5");
            this.cardDefend5.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend5.Name = "cardDefend5";
            this.cardDefend5.TabStop = false;
            // 
            // cardDefend4
            // 
            resources.ApplyResources(this.cardDefend4, "cardDefend4");
            this.cardDefend4.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend4.Name = "cardDefend4";
            this.cardDefend4.TabStop = false;
            // 
            // cardDefend3
            // 
            resources.ApplyResources(this.cardDefend3, "cardDefend3");
            this.cardDefend3.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend3.Name = "cardDefend3";
            this.cardDefend3.TabStop = false;
            // 
            // cardDefend2
            // 
            resources.ApplyResources(this.cardDefend2, "cardDefend2");
            this.cardDefend2.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend2.Name = "cardDefend2";
            this.cardDefend2.TabStop = false;
            // 
            // cardDefend1
            // 
            resources.ApplyResources(this.cardDefend1, "cardDefend1");
            this.cardDefend1.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend1.Name = "cardDefend1";
            this.cardDefend1.TabStop = false;
            // 
            // card6
            // 
            resources.ApplyResources(this.card6, "card6");
            this.card6.BackColor = System.Drawing.Color.Transparent;
            this.card6.Name = "card6";
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.card_Click);
            // 
            // card5
            // 
            resources.ApplyResources(this.card5, "card5");
            this.card5.BackColor = System.Drawing.Color.Transparent;
            this.card5.Name = "card5";
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card_Click);
            // 
            // card4
            // 
            resources.ApplyResources(this.card4, "card4");
            this.card4.BackColor = System.Drawing.Color.Transparent;
            this.card4.Name = "card4";
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card_Click);
            // 
            // card3
            // 
            resources.ApplyResources(this.card3, "card3");
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Name = "card3";
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card_Click);
            // 
            // card2
            // 
            resources.ApplyResources(this.card2, "card2");
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Name = "card2";
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card_Click);
            // 
            // card1
            // 
            resources.ApplyResources(this.card1, "card1");
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Name = "card1";
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card_Click);
            // 
            // mainDeck
            // 
            resources.ApplyResources(this.mainDeck, "mainDeck");
            this.mainDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainDeck.Image = global::Durak.Properties.Resources.back;
            this.mainDeck.Name = "mainDeck";
            this.mainDeck.TabStop = false;
            this.mainDeck.Click += new System.EventHandler(this.mainDeck_Click);
            this.mainDeck.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.mainDeck.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // empowerCard
            // 
            resources.ApplyResources(this.empowerCard, "empowerCard");
            this.empowerCard.BackColor = System.Drawing.Color.Transparent;
            this.empowerCard.Name = "empowerCard";
            this.empowerCard.TabStop = false;
            this.empowerCard.Click += new System.EventHandler(this.mainDeck_Click);
            // 
            // cardAttack1
            // 
            resources.ApplyResources(this.cardAttack1, "cardAttack1");
            this.cardAttack1.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack1.Name = "cardAttack1";
            this.cardAttack1.TabStop = false;
            // 
            // cardAttack2
            // 
            resources.ApplyResources(this.cardAttack2, "cardAttack2");
            this.cardAttack2.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack2.Name = "cardAttack2";
            this.cardAttack2.TabStop = false;
            // 
            // cardAttack3
            // 
            resources.ApplyResources(this.cardAttack3, "cardAttack3");
            this.cardAttack3.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack3.Name = "cardAttack3";
            this.cardAttack3.TabStop = false;
            // 
            // cardAttack4
            // 
            resources.ApplyResources(this.cardAttack4, "cardAttack4");
            this.cardAttack4.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack4.Name = "cardAttack4";
            this.cardAttack4.TabStop = false;
            // 
            // cardAttack5
            // 
            resources.ApplyResources(this.cardAttack5, "cardAttack5");
            this.cardAttack5.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack5.Name = "cardAttack5";
            this.cardAttack5.TabStop = false;
            // 
            // cardAttack6
            // 
            resources.ApplyResources(this.cardAttack6, "cardAttack6");
            this.cardAttack6.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack6.Name = "cardAttack6";
            this.cardAttack6.TabStop = false;
            // 
            // numberOfCardsLabel
            // 
            resources.ApplyResources(this.numberOfCardsLabel, "numberOfCardsLabel");
            this.numberOfCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOfCardsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfCardsLabel.Name = "numberOfCardsLabel";
            // 
            // winLabel
            // 
            resources.ApplyResources(this.winLabel, "winLabel");
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.ForeColor = System.Drawing.Color.Red;
            this.winLabel.Name = "winLabel";
            // 
            // GameBoard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Durak.Properties.Resources.CardTableBackground;
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.numberOfCardsLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.nextCard);
            this.Controls.Add(this.extraBotCards);
            this.Controls.Add(this.botCard6);
            this.Controls.Add(this.botCard5);
            this.Controls.Add(this.botCard4);
            this.Controls.Add(this.botCard3);
            this.Controls.Add(this.botCard2);
            this.Controls.Add(this.botCard1);
            this.Controls.Add(this.sortingComboBox);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.cardDefend6);
            this.Controls.Add(this.cardDefend5);
            this.Controls.Add(this.cardDefend4);
            this.Controls.Add(this.cardDefend3);
            this.Controls.Add(this.cardDefend2);
            this.Controls.Add(this.cardDefend1);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.mainDeck);
            this.Controls.Add(this.empowerCard);
            this.Controls.Add(this.cardAttack1);
            this.Controls.Add(this.cardAttack2);
            this.Controls.Add(this.cardAttack3);
            this.Controls.Add(this.cardAttack4);
            this.Controls.Add(this.cardAttack5);
            this.Controls.Add(this.cardAttack6);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameBoard_FormClosed);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empowerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainDeck;
        private System.Windows.Forms.PictureBox empowerCard;
        private System.Windows.Forms.TextBox historyTextBox;
        public System.Windows.Forms.PictureBox card1;
        public System.Windows.Forms.PictureBox card2;
        public System.Windows.Forms.PictureBox card3;
        public System.Windows.Forms.PictureBox card4;
        public System.Windows.Forms.PictureBox card5;
        public System.Windows.Forms.PictureBox card6;
        public System.Windows.Forms.PictureBox cardAttack1;
        public System.Windows.Forms.PictureBox cardAttack2;
        public System.Windows.Forms.PictureBox cardAttack3;
        public System.Windows.Forms.PictureBox cardAttack4;
        public System.Windows.Forms.PictureBox cardAttack5;
        public System.Windows.Forms.PictureBox cardAttack6;
        public System.Windows.Forms.PictureBox cardDefend1;
        public System.Windows.Forms.PictureBox cardDefend2;
        public System.Windows.Forms.PictureBox cardDefend3;
        public System.Windows.Forms.PictureBox cardDefend4;
        public System.Windows.Forms.PictureBox cardDefend5;
        public System.Windows.Forms.PictureBox cardDefend6;
        private System.Windows.Forms.ComboBox sortingComboBox;
        public System.Windows.Forms.PictureBox botCard1;
        public System.Windows.Forms.PictureBox botCard2;
        public System.Windows.Forms.PictureBox botCard3;
        public System.Windows.Forms.PictureBox botCard4;
        public System.Windows.Forms.PictureBox botCard5;
        public System.Windows.Forms.PictureBox botCard6;
        private System.Windows.Forms.Label extraBotCards;
        private System.Windows.Forms.Button nextCard;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label numberOfCardsLabel;
        private System.Windows.Forms.Label winLabel;
        internal System.Windows.Forms.Button endTurnButton;
    }
}