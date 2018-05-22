namespace TwoForms
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
            this.DisplayFormButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayFormButton
            // 
            this.DisplayFormButton.Location = new System.Drawing.Point(99, 64);
            this.DisplayFormButton.Name = "DisplayFormButton";
            this.DisplayFormButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayFormButton.TabIndex = 0;
            this.DisplayFormButton.Text = "Display Form";
            this.DisplayFormButton.UseVisualStyleBackColor = true;
            this.DisplayFormButton.Click += new System.EventHandler(this.DisplayFormButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(278, 64);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 173);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayFormButton);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayFormButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

