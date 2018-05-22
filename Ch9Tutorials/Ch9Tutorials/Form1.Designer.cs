namespace Ch9Tutorials
{
    partial class Form1
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
            this.CoinListBox = new System.Windows.Forms.ListBox();
            this.TossCoinButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoinListBox
            // 
            this.CoinListBox.FormattingEnabled = true;
            this.CoinListBox.Location = new System.Drawing.Point(53, 12);
            this.CoinListBox.Name = "CoinListBox";
            this.CoinListBox.Size = new System.Drawing.Size(239, 186);
            this.CoinListBox.TabIndex = 0;
            // 
            // TossCoinButton
            // 
            this.TossCoinButton.Location = new System.Drawing.Point(53, 251);
            this.TossCoinButton.Name = "TossCoinButton";
            this.TossCoinButton.Size = new System.Drawing.Size(75, 23);
            this.TossCoinButton.TabIndex = 1;
            this.TossCoinButton.Text = "Toss Coin";
            this.TossCoinButton.UseVisualStyleBackColor = true;
            this.TossCoinButton.Click += new System.EventHandler(this.TossCoinButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(217, 251);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 343);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TossCoinButton);
            this.Controls.Add(this.CoinListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CoinListBox;
        private System.Windows.Forms.Button TossCoinButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

