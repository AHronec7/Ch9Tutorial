namespace CellPhoneInventory
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
            this.CellPhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.AddPhoneButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectPhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneListBox = new System.Windows.Forms.ListBox();
            this.CellPhoneGroupBox.SuspendLayout();
            this.SelectPhoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CellPhoneGroupBox
            // 
            this.CellPhoneGroupBox.Controls.Add(this.AddPhoneButton);
            this.CellPhoneGroupBox.Controls.Add(this.PriceTextBox);
            this.CellPhoneGroupBox.Controls.Add(this.ModelTextBox);
            this.CellPhoneGroupBox.Controls.Add(this.BrandTextBox);
            this.CellPhoneGroupBox.Controls.Add(this.label3);
            this.CellPhoneGroupBox.Controls.Add(this.label2);
            this.CellPhoneGroupBox.Controls.Add(this.label1);
            this.CellPhoneGroupBox.Location = new System.Drawing.Point(12, 44);
            this.CellPhoneGroupBox.Name = "CellPhoneGroupBox";
            this.CellPhoneGroupBox.Size = new System.Drawing.Size(252, 225);
            this.CellPhoneGroupBox.TabIndex = 0;
            this.CellPhoneGroupBox.TabStop = false;
            this.CellPhoneGroupBox.Text = "Enter Cell Phone Data";
            // 
            // AddPhoneButton
            // 
            this.AddPhoneButton.Location = new System.Drawing.Point(57, 196);
            this.AddPhoneButton.Name = "AddPhoneButton";
            this.AddPhoneButton.Size = new System.Drawing.Size(75, 23);
            this.AddPhoneButton.TabIndex = 6;
            this.AddPhoneButton.Text = "Add Phone";
            this.AddPhoneButton.UseVisualStyleBackColor = true;
            this.AddPhoneButton.Click += new System.EventHandler(this.AddPhoneButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(130, 155);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(130, 91);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelTextBox.TabIndex = 4;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(130, 29);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrandTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // SelectPhoneGroupBox
            // 
            this.SelectPhoneGroupBox.Controls.Add(this.PhoneListBox);
            this.SelectPhoneGroupBox.Location = new System.Drawing.Point(333, 44);
            this.SelectPhoneGroupBox.Name = "SelectPhoneGroupBox";
            this.SelectPhoneGroupBox.Size = new System.Drawing.Size(261, 225);
            this.SelectPhoneGroupBox.TabIndex = 1;
            this.SelectPhoneGroupBox.TabStop = false;
            this.SelectPhoneGroupBox.Text = "Select A Phone";
            // 
            // PhoneListBox
            // 
            this.PhoneListBox.FormattingEnabled = true;
            this.PhoneListBox.Location = new System.Drawing.Point(20, 22);
            this.PhoneListBox.Name = "PhoneListBox";
            this.PhoneListBox.Size = new System.Drawing.Size(218, 186);
            this.PhoneListBox.TabIndex = 0;
            this.PhoneListBox.SelectedIndexChanged += new System.EventHandler(this.PhoneListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 321);
            this.Controls.Add(this.SelectPhoneGroupBox);
            this.Controls.Add(this.CellPhoneGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CellPhoneGroupBox.ResumeLayout(false);
            this.CellPhoneGroupBox.PerformLayout();
            this.SelectPhoneGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CellPhoneGroupBox;
        private System.Windows.Forms.GroupBox SelectPhoneGroupBox;
        private System.Windows.Forms.Button AddPhoneButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PhoneListBox;
    }
}

