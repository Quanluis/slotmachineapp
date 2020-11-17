namespace slotmachineapp
{
    partial class currencyLabel
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.rollThree = new System.Windows.Forms.PictureBox();
            this.rollTwo = new System.Windows.Forms.PictureBox();
            this.rollOne = new System.Windows.Forms.PictureBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.gamePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rollThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(373, 33);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(68, 13);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Slot machine";
            // 
            // rollThree
            // 
            this.rollThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollThree.Location = new System.Drawing.Point(522, 151);
            this.rollThree.Name = "rollThree";
            this.rollThree.Size = new System.Drawing.Size(95, 84);
            this.rollThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollThree.TabIndex = 1;
            this.rollThree.TabStop = false;
            // 
            // rollTwo
            // 
            this.rollTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollTwo.Location = new System.Drawing.Point(356, 150);
            this.rollTwo.Name = "rollTwo";
            this.rollTwo.Size = new System.Drawing.Size(95, 85);
            this.rollTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollTwo.TabIndex = 2;
            this.rollTwo.TabStop = false;
            // 
            // rollOne
            // 
            this.rollOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollOne.Location = new System.Drawing.Point(199, 151);
            this.rollOne.Name = "rollOne";
            this.rollOne.Size = new System.Drawing.Size(95, 84);
            this.rollOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollOne.TabIndex = 3;
            this.rollOne.TabStop = false;
            // 
            // spinButton
            // 
            this.spinButton.Enabled = false;
            this.spinButton.Location = new System.Drawing.Point(366, 297);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 23);
            this.spinButton.TabIndex = 4;
            this.spinButton.Text = "SPIN!";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.Location = new System.Drawing.Point(232, 87);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(100, 20);
            this.countLabel.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(366, 88);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(53, 90);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(137, 13);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Insert funds then click Play!";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(213, 90);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(13, 13);
            this.currency.TabIndex = 8;
            this.currency.Text = "$";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(633, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(522, 386);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 10;
            this.reset.Text = "Cash out!";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // gamePic
            // 
            this.gamePic.Image = global::slotmachineapp.Properties.Resources.fruit_logo;
            this.gamePic.Location = new System.Drawing.Point(12, 12);
            this.gamePic.Name = "gamePic";
            this.gamePic.Size = new System.Drawing.Size(64, 54);
            this.gamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePic.TabIndex = 11;
            this.gamePic.TabStop = false;
            // 
            // currencyLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePic);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.rollOne);
            this.Controls.Add(this.rollTwo);
            this.Controls.Add(this.rollThree);
            this.Controls.Add(this.mainLabel);
            this.Name = "currencyLabel";
            this.Text = "Slot machine";
            ((System.ComponentModel.ISupportInitialize)(this.rollThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.PictureBox rollThree;
        private System.Windows.Forms.PictureBox rollTwo;
        private System.Windows.Forms.PictureBox rollOne;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.TextBox countLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label currency;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox gamePic;
    }
}

