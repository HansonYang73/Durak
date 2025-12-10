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
            this.components = new System.ComponentModel.Container();
            this.mainDeck = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.empowerCard = new System.Windows.Forms.PictureBox();
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.cardAttack1 = new System.Windows.Forms.PictureBox();
            this.cardAttack2 = new System.Windows.Forms.PictureBox();
            this.cardAttack3 = new System.Windows.Forms.PictureBox();
            this.cardAttack4 = new System.Windows.Forms.PictureBox();
            this.cardAttack5 = new System.Windows.Forms.PictureBox();
            this.cardAttack6 = new System.Windows.Forms.PictureBox();
            this.cardDefend1 = new System.Windows.Forms.PictureBox();
            this.cardDefend2 = new System.Windows.Forms.PictureBox();
            this.cardDefend3 = new System.Windows.Forms.PictureBox();
            this.cardDefend4 = new System.Windows.Forms.PictureBox();
            this.cardDefend5 = new System.Windows.Forms.PictureBox();
            this.cardDefend6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.sortingComboBox = new System.Windows.Forms.ComboBox();
            this.waitingLabel = new System.Windows.Forms.Label();
            this.waitngLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.botCard1 = new System.Windows.Forms.PictureBox();
            this.botCard2 = new System.Windows.Forms.PictureBox();
            this.botCard3 = new System.Windows.Forms.PictureBox();
            this.botCard4 = new System.Windows.Forms.PictureBox();
            this.botCard5 = new System.Windows.Forms.PictureBox();
            this.botCard6 = new System.Windows.Forms.PictureBox();
            this.extraBotCards = new System.Windows.Forms.Label();
            this.nextCard = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empowerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard6)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDeck
            // 
            this.mainDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainDeck.Image = global::Durak.Properties.Resources.back;
            this.mainDeck.Location = new System.Drawing.Point(1141, 229);
            this.mainDeck.Name = "mainDeck";
            this.mainDeck.Size = new System.Drawing.Size(116, 162);
            this.mainDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainDeck.TabIndex = 6;
            this.mainDeck.TabStop = false;
            this.mainDeck.Click += new System.EventHandler(this.mainDeck_Click);
            this.mainDeck.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.mainDeck.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(328, 567);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(103, 163);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card1.TabIndex = 7;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card_Click);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(437, 567);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(103, 163);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card2.TabIndex = 9;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card_Click);
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(546, 567);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(103, 163);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card3.TabIndex = 10;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card_Click);
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(655, 567);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(103, 163);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card4.TabIndex = 11;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card_Click);
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(764, 567);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(103, 163);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card5.TabIndex = 12;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card_Click);
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(873, 567);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(103, 163);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card6.TabIndex = 13;
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.card_Click);
            // 
            // empowerCard
            // 
            this.empowerCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.empowerCard.Location = new System.Drawing.Point(1056, 219);
            this.empowerCard.Name = "empowerCard";
            this.empowerCard.Size = new System.Drawing.Size(130, 182);
            this.empowerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empowerCard.TabIndex = 14;
            this.empowerCard.TabStop = false;
            this.empowerCard.Click += new System.EventHandler(this.empowerCard_Click);
            // 
            // historyTextBox
            // 
            this.historyTextBox.Location = new System.Drawing.Point(12, 12);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(216, 718);
            this.historyTextBox.TabIndex = 15;
            // 
            // cardAttack1
            // 
            this.cardAttack1.Location = new System.Drawing.Point(328, 276);
            this.cardAttack1.Name = "cardAttack1";
            this.cardAttack1.Size = new System.Drawing.Size(103, 163);
            this.cardAttack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack1.TabIndex = 16;
            this.cardAttack1.TabStop = false;
            // 
            // cardAttack2
            // 
            this.cardAttack2.Location = new System.Drawing.Point(437, 276);
            this.cardAttack2.Name = "cardAttack2";
            this.cardAttack2.Size = new System.Drawing.Size(103, 163);
            this.cardAttack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack2.TabIndex = 17;
            this.cardAttack2.TabStop = false;
            // 
            // cardAttack3
            // 
            this.cardAttack3.Location = new System.Drawing.Point(546, 276);
            this.cardAttack3.Name = "cardAttack3";
            this.cardAttack3.Size = new System.Drawing.Size(103, 163);
            this.cardAttack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack3.TabIndex = 18;
            this.cardAttack3.TabStop = false;
            // 
            // cardAttack4
            // 
            this.cardAttack4.Location = new System.Drawing.Point(655, 276);
            this.cardAttack4.Name = "cardAttack4";
            this.cardAttack4.Size = new System.Drawing.Size(103, 163);
            this.cardAttack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack4.TabIndex = 19;
            this.cardAttack4.TabStop = false;
            // 
            // cardAttack5
            // 
            this.cardAttack5.Location = new System.Drawing.Point(764, 276);
            this.cardAttack5.Name = "cardAttack5";
            this.cardAttack5.Size = new System.Drawing.Size(103, 163);
            this.cardAttack5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack5.TabIndex = 20;
            this.cardAttack5.TabStop = false;
            // 
            // cardAttack6
            // 
            this.cardAttack6.Location = new System.Drawing.Point(873, 276);
            this.cardAttack6.Name = "cardAttack6";
            this.cardAttack6.Size = new System.Drawing.Size(103, 163);
            this.cardAttack6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAttack6.TabIndex = 21;
            this.cardAttack6.TabStop = false;
            // 
            // cardDefend1
            // 
            this.cardDefend1.Location = new System.Drawing.Point(328, 333);
            this.cardDefend1.Margin = new System.Windows.Forms.Padding(0);
            this.cardDefend1.Name = "cardDefend1";
            this.cardDefend1.Padding = new System.Windows.Forms.Padding(3);
            this.cardDefend1.Size = new System.Drawing.Size(103, 163);
            this.cardDefend1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend1.TabIndex = 22;
            this.cardDefend1.TabStop = false;
            this.cardDefend1.Visible = false;
            // 
            // cardDefend2
            // 
            this.cardDefend2.Location = new System.Drawing.Point(437, 333);
            this.cardDefend2.Name = "cardDefend2";
            this.cardDefend2.Size = new System.Drawing.Size(103, 163);
            this.cardDefend2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend2.TabIndex = 23;
            this.cardDefend2.TabStop = false;
            this.cardDefend2.Visible = false;
            // 
            // cardDefend3
            // 
            this.cardDefend3.Location = new System.Drawing.Point(546, 333);
            this.cardDefend3.Name = "cardDefend3";
            this.cardDefend3.Size = new System.Drawing.Size(103, 163);
            this.cardDefend3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend3.TabIndex = 24;
            this.cardDefend3.TabStop = false;
            this.cardDefend3.Visible = false;
            // 
            // cardDefend4
            // 
            this.cardDefend4.Location = new System.Drawing.Point(655, 333);
            this.cardDefend4.Name = "cardDefend4";
            this.cardDefend4.Size = new System.Drawing.Size(103, 163);
            this.cardDefend4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend4.TabIndex = 25;
            this.cardDefend4.TabStop = false;
            this.cardDefend4.Visible = false;
            // 
            // cardDefend5
            // 
            this.cardDefend5.Location = new System.Drawing.Point(764, 333);
            this.cardDefend5.Name = "cardDefend5";
            this.cardDefend5.Size = new System.Drawing.Size(103, 163);
            this.cardDefend5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend5.TabIndex = 26;
            this.cardDefend5.TabStop = false;
            this.cardDefend5.Visible = false;
            // 
            // cardDefend6
            // 
            this.cardDefend6.Location = new System.Drawing.Point(873, 333);
            this.cardDefend6.Name = "cardDefend6";
            this.cardDefend6.Size = new System.Drawing.Size(103, 163);
            this.cardDefend6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDefend6.TabIndex = 27;
            this.cardDefend6.TabStop = false;
            this.cardDefend6.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1145, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 28;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1145, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Location = new System.Drawing.Point(1168, 567);
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
    "Sort By Power",
    "Sort By Suit",
    "Sort By Number"});
            this.sortingComboBox.Location = new System.Drawing.Point(1099, 486);
            this.sortingComboBox.Name = "sortingComboBox";
            this.sortingComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortingComboBox.TabIndex = 31;
            this.sortingComboBox.SelectedIndexChanged += new System.EventHandler(this.sortingComboBox_SelectedIndexChanged);
            // 
            // waitingLabel
            // 
            this.waitingLabel.AutoSize = true;
            this.waitingLabel.Location = new System.Drawing.Point(1074, 15);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(150, 13);
            this.waitingLabel.TabIndex = 32;
            this.waitingLabel.Text = "Waiting for [Player] to attack...";
            // 
            // waitngLabelTimer
            // 
            this.waitngLabelTimer.Enabled = true;
            this.waitngLabelTimer.Interval = 500;
            this.waitngLabelTimer.Tick += new System.EventHandler(this.waitngLabelTimer_Tick);
            // 
            // botCard1
            // 
            this.botCard1.Location = new System.Drawing.Point(328, 12);
            this.botCard1.Name = "botCard1";
            this.botCard1.Size = new System.Drawing.Size(103, 163);
            this.botCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard1.TabIndex = 33;
            this.botCard1.TabStop = false;
            // 
            // botCard2
            // 
            this.botCard2.Location = new System.Drawing.Point(437, 12);
            this.botCard2.Name = "botCard2";
            this.botCard2.Size = new System.Drawing.Size(103, 163);
            this.botCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard2.TabIndex = 34;
            this.botCard2.TabStop = false;
            // 
            // botCard3
            // 
            this.botCard3.Location = new System.Drawing.Point(546, 12);
            this.botCard3.Name = "botCard3";
            this.botCard3.Size = new System.Drawing.Size(103, 163);
            this.botCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard3.TabIndex = 35;
            this.botCard3.TabStop = false;
            // 
            // botCard4
            // 
            this.botCard4.Location = new System.Drawing.Point(655, 12);
            this.botCard4.Name = "botCard4";
            this.botCard4.Size = new System.Drawing.Size(103, 163);
            this.botCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard4.TabIndex = 36;
            this.botCard4.TabStop = false;
            // 
            // botCard5
            // 
            this.botCard5.Location = new System.Drawing.Point(764, 12);
            this.botCard5.Name = "botCard5";
            this.botCard5.Size = new System.Drawing.Size(103, 163);
            this.botCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard5.TabIndex = 37;
            this.botCard5.TabStop = false;
            // 
            // botCard6
            // 
            this.botCard6.Location = new System.Drawing.Point(873, 12);
            this.botCard6.Name = "botCard6";
            this.botCard6.Size = new System.Drawing.Size(103, 163);
            this.botCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botCard6.TabIndex = 38;
            this.botCard6.TabStop = false;
            // 
            // extraBotCards
            // 
            this.extraBotCards.Location = new System.Drawing.Point(982, 15);
            this.extraBotCards.Name = "extraBotCards";
            this.extraBotCards.Size = new System.Drawing.Size(86, 90);
            this.extraBotCards.TabIndex = 39;
            // 
            // nextCard
            // 
            this.nextCard.Enabled = false;
            this.nextCard.Location = new System.Drawing.Point(982, 707);
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
            this.goBack.Location = new System.Drawing.Point(247, 707);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 41;
            this.goBack.Text = "Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 742);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.nextCard);
            this.Controls.Add(this.extraBotCards);
            this.Controls.Add(this.botCard6);
            this.Controls.Add(this.botCard5);
            this.Controls.Add(this.botCard4);
            this.Controls.Add(this.botCard3);
            this.Controls.Add(this.botCard2);
            this.Controls.Add(this.botCard1);
            this.Controls.Add(this.waitingLabel);
            this.Controls.Add(this.sortingComboBox);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.mainDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empowerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAttack6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDefend6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botCard6)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.ComboBox sortingComboBox;
        private System.Windows.Forms.Label waitingLabel;
        private System.Windows.Forms.Timer waitngLabelTimer;
        public System.Windows.Forms.PictureBox botCard1;
        public System.Windows.Forms.PictureBox botCard2;
        public System.Windows.Forms.PictureBox botCard3;
        public System.Windows.Forms.PictureBox botCard4;
        public System.Windows.Forms.PictureBox botCard5;
        public System.Windows.Forms.PictureBox botCard6;
        private System.Windows.Forms.Label extraBotCards;
        private System.Windows.Forms.Button nextCard;
        private System.Windows.Forms.Button goBack;
    }
}