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
            this.historyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTextBox.Location = new System.Drawing.Point(12, 12);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(351, 718);
            this.historyTextBox.TabIndex = 15;
            // 
            // endTurnButton
            // 
            this.endTurnButton.Location = new System.Drawing.Point(1290, 570);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(89, 38);
            this.endTurnButton.TabIndex = 30;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // sortingComboBox
            // 
            this.sortingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingComboBox.FormattingEnabled = true;
            this.sortingComboBox.Items.AddRange(new object[] {
            "Power",
            "Suit",
            "Number"});
            this.sortingComboBox.Location = new System.Drawing.Point(1123, 580);
            this.sortingComboBox.Name = "sortingComboBox";
            this.sortingComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortingComboBox.TabIndex = 31;
            this.sortingComboBox.SelectedIndexChanged += new System.EventHandler(this.sortingComboBox_SelectedIndexChanged);
            // 
            // extraBotCards
            // 
            this.extraBotCards.BackColor = System.Drawing.Color.Transparent;
            this.extraBotCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraBotCards.ForeColor = System.Drawing.Color.White;
            this.extraBotCards.Location = new System.Drawing.Point(1104, 16);
            this.extraBotCards.Name = "extraBotCards";
            this.extraBotCards.Size = new System.Drawing.Size(108, 58);
            this.extraBotCards.TabIndex = 39;
            // 
            // nextCard
            // 
            this.nextCard.Enabled = false;
            this.nextCard.Location = new System.Drawing.Point(1104, 708);
            this.nextCard.Name = "nextCard";
            this.nextCard.Size = new System.Drawing.Size(75, 23);
            this.nextCard.TabIndex = 40;
            this.nextCard.Text = "Next";
            this.nextCard.UseVisualStyleBackColor = true;
            this.nextCard.Click += new System.EventHandler(this.nextCard_Click);
            // 
            // goBack
            // 
            this.goBack.Enabled = false;
            this.goBack.Location = new System.Drawing.Point(369, 708);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 41;
            this.goBack.Text = "Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1123, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sort Deck By:";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainMenuButton.Enabled = false;
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(668, 415);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(257, 96);
            this.mainMenuButton.TabIndex = 43;
            this.mainMenuButton.Text = "Return to main menu";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Visible = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // botCard6
            // 
            this.botCard6.BackColor = System.Drawing.Color.Transparent;
            this.botCard6.Location = new System.Drawing.Point(995, 13);
            this.botCard6.Name = "botCard6";
            this.botCard6.Size = new System.Drawing.Size(103, 163);
            this.botCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard6.TabIndex = 38;
            this.botCard6.TabStop = false;
            // 
            // botCard5
            // 
            this.botCard5.BackColor = System.Drawing.Color.Transparent;
            this.botCard5.Location = new System.Drawing.Point(886, 13);
            this.botCard5.Name = "botCard5";
            this.botCard5.Size = new System.Drawing.Size(103, 163);
            this.botCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard5.TabIndex = 37;
            this.botCard5.TabStop = false;
            // 
            // botCard4
            // 
            this.botCard4.BackColor = System.Drawing.Color.Transparent;
            this.botCard4.Location = new System.Drawing.Point(777, 13);
            this.botCard4.Name = "botCard4";
            this.botCard4.Size = new System.Drawing.Size(103, 163);
            this.botCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard4.TabIndex = 36;
            this.botCard4.TabStop = false;
            // 
            // botCard3
            // 
            this.botCard3.BackColor = System.Drawing.Color.Transparent;
            this.botCard3.Location = new System.Drawing.Point(668, 13);
            this.botCard3.Name = "botCard3";
            this.botCard3.Size = new System.Drawing.Size(103, 163);
            this.botCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard3.TabIndex = 35;
            this.botCard3.TabStop = false;
            // 
            // botCard2
            // 
            this.botCard2.BackColor = System.Drawing.Color.Transparent;
            this.botCard2.Location = new System.Drawing.Point(559, 13);
            this.botCard2.Name = "botCard2";
            this.botCard2.Size = new System.Drawing.Size(103, 163);
            this.botCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard2.TabIndex = 34;
            this.botCard2.TabStop = false;
            // 
            // botCard1
            // 
            this.botCard1.BackColor = System.Drawing.Color.Transparent;
            this.botCard1.Location = new System.Drawing.Point(450, 13);
            this.botCard1.Name = "botCard1";
            this.botCard1.Size = new System.Drawing.Size(103, 163);
            this.botCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard1.TabIndex = 33;
            this.botCard1.TabStop = false;
            // 
            // cardDefend6
            // 
            this.cardDefend6.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend6.Location = new System.Drawing.Point(995, 334);
            this.cardDefend6.Name = "cardDefend6";
            this.cardDefend6.Size = new System.Drawing.Size(103, 163);
            this.cardDefend6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend6.TabIndex = 27;
            this.cardDefend6.TabStop = false;
            this.cardDefend6.Visible = false;
            // 
            // cardDefend5
            // 
            this.cardDefend5.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend5.Location = new System.Drawing.Point(886, 334);
            this.cardDefend5.Name = "cardDefend5";
            this.cardDefend5.Size = new System.Drawing.Size(103, 163);
            this.cardDefend5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend5.TabIndex = 26;
            this.cardDefend5.TabStop = false;
            this.cardDefend5.Visible = false;
            // 
            // cardDefend4
            // 
            this.cardDefend4.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend4.Location = new System.Drawing.Point(777, 334);
            this.cardDefend4.Name = "cardDefend4";
            this.cardDefend4.Size = new System.Drawing.Size(103, 163);
            this.cardDefend4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend4.TabIndex = 25;
            this.cardDefend4.TabStop = false;
            this.cardDefend4.Visible = false;
            // 
            // cardDefend3
            // 
            this.cardDefend3.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend3.Location = new System.Drawing.Point(668, 334);
            this.cardDefend3.Name = "cardDefend3";
            this.cardDefend3.Size = new System.Drawing.Size(103, 163);
            this.cardDefend3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend3.TabIndex = 24;
            this.cardDefend3.TabStop = false;
            this.cardDefend3.Visible = false;
            // 
            // cardDefend2
            // 
            this.cardDefend2.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend2.Location = new System.Drawing.Point(559, 334);
            this.cardDefend2.Name = "cardDefend2";
            this.cardDefend2.Size = new System.Drawing.Size(103, 163);
            this.cardDefend2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend2.TabIndex = 23;
            this.cardDefend2.TabStop = false;
            this.cardDefend2.Visible = false;
            // 
            // cardDefend1
            // 
            this.cardDefend1.BackColor = System.Drawing.SystemColors.Control;
            this.cardDefend1.Location = new System.Drawing.Point(450, 334);
            this.cardDefend1.Margin = new System.Windows.Forms.Padding(0);
            this.cardDefend1.Name = "cardDefend1";
            this.cardDefend1.Padding = new System.Windows.Forms.Padding(3);
            this.cardDefend1.Size = new System.Drawing.Size(103, 163);
            this.cardDefend1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend1.TabIndex = 22;
            this.cardDefend1.TabStop = false;
            this.cardDefend1.Visible = false;
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.Transparent;
            this.card6.Location = new System.Drawing.Point(995, 568);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(103, 163);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card6.TabIndex = 13;
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.card_Click);
            this.card6.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.card6.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.Color.Transparent;
            this.card5.Location = new System.Drawing.Point(886, 568);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(103, 163);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card5.TabIndex = 12;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card_Click);
            this.card5.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.card5.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.Transparent;
            this.card4.Location = new System.Drawing.Point(777, 568);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(103, 163);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card4.TabIndex = 11;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card_Click);
            this.card4.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.card4.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Location = new System.Drawing.Point(668, 568);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(103, 163);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card3.TabIndex = 10;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card_Click);
            this.card3.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.card3.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Location = new System.Drawing.Point(559, 568);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(103, 163);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card2.TabIndex = 9;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card_Click);
            this.card2.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.card2.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(450, 568);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(103, 163);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card1.TabIndex = 7;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card_Click);
            this.card1.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.card1.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // mainDeck
            // 
            this.mainDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainDeck.Image = global::Durak.Properties.Resources.back;
            this.mainDeck.Location = new System.Drawing.Point(1263, 230);
            this.mainDeck.Name = "mainDeck";
            this.mainDeck.Size = new System.Drawing.Size(116, 162);
            this.mainDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainDeck.TabIndex = 6;
            this.mainDeck.TabStop = false;
            this.mainDeck.Click += new System.EventHandler(this.mainDeck_Click);
            this.mainDeck.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.mainDeck.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // empowerCard
            // 
            this.empowerCard.BackColor = System.Drawing.Color.Transparent;
            this.empowerCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.empowerCard.Location = new System.Drawing.Point(1178, 252);
            this.empowerCard.Name = "empowerCard";
            this.empowerCard.Size = new System.Drawing.Size(149, 123);
            this.empowerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empowerCard.TabIndex = 14;
            this.empowerCard.TabStop = false;
            this.empowerCard.Click += new System.EventHandler(this.mainDeck_Click);
            this.empowerCard.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.empowerCard.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // cardAttack1
            // 
            this.cardAttack1.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack1.Location = new System.Drawing.Point(450, 277);
            this.cardAttack1.Name = "cardAttack1";
            this.cardAttack1.Size = new System.Drawing.Size(103, 163);
            this.cardAttack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack1.TabIndex = 16;
            this.cardAttack1.TabStop = false;
            // 
            // cardAttack2
            // 
            this.cardAttack2.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack2.Location = new System.Drawing.Point(559, 277);
            this.cardAttack2.Name = "cardAttack2";
            this.cardAttack2.Size = new System.Drawing.Size(103, 163);
            this.cardAttack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack2.TabIndex = 17;
            this.cardAttack2.TabStop = false;
            // 
            // cardAttack3
            // 
            this.cardAttack3.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack3.Location = new System.Drawing.Point(668, 277);
            this.cardAttack3.Name = "cardAttack3";
            this.cardAttack3.Size = new System.Drawing.Size(103, 163);
            this.cardAttack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack3.TabIndex = 18;
            this.cardAttack3.TabStop = false;
            // 
            // cardAttack4
            // 
            this.cardAttack4.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack4.Location = new System.Drawing.Point(777, 277);
            this.cardAttack4.Name = "cardAttack4";
            this.cardAttack4.Size = new System.Drawing.Size(103, 163);
            this.cardAttack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack4.TabIndex = 19;
            this.cardAttack4.TabStop = false;
            // 
            // cardAttack5
            // 
            this.cardAttack5.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack5.Location = new System.Drawing.Point(886, 277);
            this.cardAttack5.Name = "cardAttack5";
            this.cardAttack5.Size = new System.Drawing.Size(103, 163);
            this.cardAttack5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack5.TabIndex = 20;
            this.cardAttack5.TabStop = false;
            // 
            // cardAttack6
            // 
            this.cardAttack6.BackColor = System.Drawing.Color.Transparent;
            this.cardAttack6.Location = new System.Drawing.Point(995, 277);
            this.cardAttack6.Name = "cardAttack6";
            this.cardAttack6.Size = new System.Drawing.Size(103, 163);
            this.cardAttack6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack6.TabIndex = 21;
            this.cardAttack6.TabStop = false;
            // 
            // numberOfCardsLabel
            // 
            this.numberOfCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOfCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfCardsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfCardsLabel.Location = new System.Drawing.Point(1271, 205);
            this.numberOfCardsLabel.Name = "numberOfCardsLabel";
            this.numberOfCardsLabel.Size = new System.Drawing.Size(108, 22);
            this.numberOfCardsLabel.TabIndex = 44;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Enabled = false;
            this.winLabel.Font = new System.Drawing.Font("Mongolian Baiti", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Red;
            this.winLabel.Location = new System.Drawing.Point(432, 283);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(740, 109);
            this.winLabel.TabIndex = 45;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Durak.Properties.Resources.CardTableBackground;
            this.ClientSize = new System.Drawing.Size(1414, 742);
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
            this.Name = "GameBoard";
            this.Text = "GameBoard";
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
        private System.Windows.Forms.Button endTurnButton;
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
    }
}