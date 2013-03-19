namespace Inl_uppg_3
{
    partial class Hangman
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.lblGuessedChars = new System.Windows.Forms.Label();
            this.lblHiddenWord = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblNumberGuess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Image = global::Inl_uppg_3.Properties.Resources.hangman0;
            this.pb.Location = new System.Drawing.Point(12, 37);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(577, 302);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // lblGuessedChars
            // 
            this.lblGuessedChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuessedChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuessedChars.Location = new System.Drawing.Point(595, 37);
            this.lblGuessedChars.Name = "lblGuessedChars";
            this.lblGuessedChars.Size = new System.Drawing.Size(101, 299);
            this.lblGuessedChars.TabIndex = 1;
            // 
            // lblHiddenWord
            // 
            this.lblHiddenWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHiddenWord.AutoSize = true;
            this.lblHiddenWord.Location = new System.Drawing.Point(11, 342);
            this.lblHiddenWord.Name = "lblHiddenWord";
            this.lblHiddenWord.Size = new System.Drawing.Size(0, 13);
            this.lblHiddenWord.TabIndex = 2;
            // 
            // tbGuess
            // 
            this.tbGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGuess.Enabled = false;
            this.tbGuess.Location = new System.Drawing.Point(598, 339);
            this.tbGuess.MaxLength = 1;
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 20);
            this.tbGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(598, 365);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Gissa";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Nytt spel";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblNumberGuess
            // 
            this.lblNumberGuess.AutoSize = true;
            this.lblNumberGuess.Location = new System.Drawing.Point(94, 17);
            this.lblNumberGuess.Name = "lblNumberGuess";
            this.lblNumberGuess.Size = new System.Drawing.Size(0, 13);
            this.lblNumberGuess.TabIndex = 6;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 392);
            this.Controls.Add(this.lblNumberGuess);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lblHiddenWord);
            this.Controls.Add(this.lblGuessedChars);
            this.Controls.Add(this.pb);
            this.Name = "Hangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lblGuessedChars;
        private System.Windows.Forms.Label lblHiddenWord;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblNumberGuess;
    }
}

