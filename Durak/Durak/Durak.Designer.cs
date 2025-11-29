namespace Durak
{
    partial class Durak
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.Label();
            this.op3 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.op1ComboBox = new System.Windows.Forms.ComboBox();
            this.op2ComboBox = new System.Windows.Forms.ComboBox();
            this.op3ComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "TESTING ONLY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "DURAK";
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(36, 100);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(76, 13);
            this.op1.TabIndex = 2;
            this.op1.Text = "OPPONENT 1";
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(642, 100);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(76, 13);
            this.op3.TabIndex = 3;
            this.op3.Text = "OPPONENT 3";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(349, 100);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(76, 13);
            this.op2.TabIndex = 4;
            this.op2.Text = "OPPONENT 2";
            // 
            // op1ComboBox
            // 
            this.op1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op1ComboBox.FormattingEnabled = true;
            this.op1ComboBox.Items.AddRange(new object[] {
            "AI",
            "Hanson",
            "Shon",
            "Oliver"});
            this.op1ComboBox.Location = new System.Drawing.Point(12, 128);
            this.op1ComboBox.Name = "op1ComboBox";
            this.op1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.op1ComboBox.TabIndex = 5;
            // 
            // op2ComboBox
            // 
            this.op2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op2ComboBox.FormattingEnabled = true;
            this.op2ComboBox.Items.AddRange(new object[] {
            "None",
            "AI",
            "Hanson",
            "Shon",
            "Oliver"});
            this.op2ComboBox.Location = new System.Drawing.Point(329, 128);
            this.op2ComboBox.Name = "op2ComboBox";
            this.op2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.op2ComboBox.TabIndex = 6;
            // 
            // op3ComboBox
            // 
            this.op3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op3ComboBox.FormattingEnabled = true;
            this.op3ComboBox.Items.AddRange(new object[] {
            "None",
            "AI",
            "Hanson",
            "Shon",
            "Oliver"});
            this.op3ComboBox.Location = new System.Drawing.Point(615, 128);
            this.op3ComboBox.Name = "op3ComboBox";
            this.op3ComboBox.Size = new System.Drawing.Size(121, 21);
            this.op3ComboBox.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(329, 258);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start Game!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Durak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.op3ComboBox);
            this.Controls.Add(this.op2ComboBox);
            this.Controls.Add(this.op1ComboBox);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Durak";
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.durakForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label op3;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.ComboBox op1ComboBox;
        private System.Windows.Forms.ComboBox op2ComboBox;
        private System.Windows.Forms.ComboBox op3ComboBox;
        private System.Windows.Forms.Button startButton;
    }
}

