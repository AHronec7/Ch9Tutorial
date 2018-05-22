namespace AccessingControls
{
    partial class Mainform
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
            this.label1 = new System.Windows.Forms.Label();
            this.BananaRadioButton = new System.Windows.Forms.RadioButton();
            this.PopcornRadioButton = new System.Windows.Forms.RadioButton();
            this.MuffinRadioButton = new System.Windows.Forms.RadioButton();
            this.FoodFactsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Food ";
            // 
            // BananaRadioButton
            // 
            this.BananaRadioButton.AutoSize = true;
            this.BananaRadioButton.Location = new System.Drawing.Point(44, 76);
            this.BananaRadioButton.Name = "BananaRadioButton";
            this.BananaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.BananaRadioButton.TabIndex = 1;
            this.BananaRadioButton.TabStop = true;
            this.BananaRadioButton.Text = "1 Banana";
            this.BananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // PopcornRadioButton
            // 
            this.PopcornRadioButton.AutoSize = true;
            this.PopcornRadioButton.Location = new System.Drawing.Point(44, 120);
            this.PopcornRadioButton.Name = "PopcornRadioButton";
            this.PopcornRadioButton.Size = new System.Drawing.Size(161, 17);
            this.PopcornRadioButton.TabIndex = 2;
            this.PopcornRadioButton.TabStop = true;
            this.PopcornRadioButton.Text = "1 Cup of Air-popped popcorn";
            this.PopcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // MuffinRadioButton
            // 
            this.MuffinRadioButton.AutoSize = true;
            this.MuffinRadioButton.Location = new System.Drawing.Point(44, 165);
            this.MuffinRadioButton.Name = "MuffinRadioButton";
            this.MuffinRadioButton.Size = new System.Drawing.Size(140, 17);
            this.MuffinRadioButton.TabIndex = 3;
            this.MuffinRadioButton.TabStop = true;
            this.MuffinRadioButton.Text = "1 Large Blueberry Muffin";
            this.MuffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // FoodFactsButton
            // 
            this.FoodFactsButton.Location = new System.Drawing.Point(59, 216);
            this.FoodFactsButton.Name = "FoodFactsButton";
            this.FoodFactsButton.Size = new System.Drawing.Size(75, 23);
            this.FoodFactsButton.TabIndex = 4;
            this.FoodFactsButton.Text = "Food Facts";
            this.FoodFactsButton.UseVisualStyleBackColor = true;
            this.FoodFactsButton.Click += new System.EventHandler(this.FoodFactsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(210, 216);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FoodFactsButton);
            this.Controls.Add(this.MuffinRadioButton);
            this.Controls.Add(this.PopcornRadioButton);
            this.Controls.Add(this.BananaRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton BananaRadioButton;
        private System.Windows.Forms.RadioButton PopcornRadioButton;
        private System.Windows.Forms.RadioButton MuffinRadioButton;
        private System.Windows.Forms.Button FoodFactsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

