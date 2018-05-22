namespace AccessingControls
{
    partial class NutritionFacts
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Labelone = new System.Windows.Forms.Label();
            this.labeltwo = new System.Windows.Forms.Label();
            this.labelthree = new System.Windows.Forms.Label();
            this.labelfour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fat Grams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carb Grams";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(60, 324);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Labelone
            // 
            this.Labelone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Labelone.Location = new System.Drawing.Point(196, 36);
            this.Labelone.Name = "Labelone";
            this.Labelone.Size = new System.Drawing.Size(100, 23);
            this.Labelone.TabIndex = 9;
            // 
            // labeltwo
            // 
            this.labeltwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltwo.Location = new System.Drawing.Point(196, 113);
            this.labeltwo.Name = "labeltwo";
            this.labeltwo.Size = new System.Drawing.Size(100, 25);
            this.labeltwo.TabIndex = 10;
            // 
            // labelthree
            // 
            this.labelthree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelthree.Location = new System.Drawing.Point(196, 185);
            this.labelthree.Name = "labelthree";
            this.labelthree.Size = new System.Drawing.Size(100, 23);
            this.labelthree.TabIndex = 11;
            // 
            // labelfour
            // 
            this.labelfour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelfour.Location = new System.Drawing.Point(196, 274);
            this.labelfour.Name = "labelfour";
            this.labelfour.Size = new System.Drawing.Size(100, 24);
            this.labelfour.TabIndex = 12;
            // 
            // NutritionFacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 350);
            this.Controls.Add(this.labelfour);
            this.Controls.Add(this.labelthree);
            this.Controls.Add(this.labeltwo);
            this.Controls.Add(this.Labelone);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NutritionFacts";
            this.Text = "NutritionFacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Label labelfour;
        public System.Windows.Forms.Label Labelone;
        public System.Windows.Forms.Label labeltwo;
        public System.Windows.Forms.Label labelthree;
    }
}