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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainPlayerCardsImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empowerCard)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDeck
            // 
            this.mainDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainDeck.Image = global::Durak.Properties.Resources.back;
            this.mainDeck.Location = new System.Drawing.Point(923, 193);
            this.mainDeck.Name = "mainDeck";
            this.mainDeck.Size = new System.Drawing.Size(130, 182);
            this.mainDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainDeck.TabIndex = 6;
            this.mainDeck.TabStop = false;
            this.mainDeck.Click += new System.EventHandler(this.mainDeck_Click);
            this.mainDeck.MouseEnter += new System.EventHandler(this.mainDeck_MouseEnter);
            this.mainDeck.MouseLeave += new System.EventHandler(this.mainDeck_MouseLeave);
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(293, 442);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(103, 163);
            this.card1.TabIndex = 7;
            this.card1.TabStop = false;
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(402, 442);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(103, 163);
            this.card2.TabIndex = 9;
            this.card2.TabStop = false;
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(511, 442);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(103, 163);
            this.card3.TabIndex = 10;
            this.card3.TabStop = false;
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(620, 442);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(103, 163);
            this.card4.TabIndex = 11;
            this.card4.TabStop = false;
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(729, 442);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(103, 163);
            this.card5.TabIndex = 12;
            this.card5.TabStop = false;
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(838, 442);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(103, 163);
            this.card6.TabIndex = 13;
            this.card6.TabStop = false;
            // 
            // empowerCard
            // 
            this.empowerCard.Location = new System.Drawing.Point(820, 233);
            this.empowerCard.Name = "empowerCard";
            this.empowerCard.Size = new System.Drawing.Size(177, 96);
            this.empowerCard.TabIndex = 14;
            this.empowerCard.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 593);
            this.textBox1.TabIndex = 15;
            // 
            // mainPlayerCardsImages
            // 
            this.mainPlayerCardsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.mainPlayerCardsImages.ImageSize = new System.Drawing.Size(16, 16);
            this.mainPlayerCardsImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 627);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.mainDeck);
            this.Controls.Add(this.empowerCard);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainDeck;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox empowerCard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList mainPlayerCardsImages;
    }
}