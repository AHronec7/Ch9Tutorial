namespace CellPhone
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
            this.CellPhoneData = new System.Windows.Forms.GroupBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.GroupBox();
            this.OutputPriceBox = new System.Windows.Forms.TextBox();
            this.OutputModelBox = new System.Windows.Forms.TextBox();
            this.OutputBrandBox = new System.Windows.Forms.TextBox();
            this.OutputPrice = new System.Windows.Forms.Label();
            this.OutputModel = new System.Windows.Forms.Label();
            this.OutputBrand = new System.Windows.Forms.Label();
            this.CreateDataButton = new System.Windows.Forms.Button();
            this.CellPhoneData.SuspendLayout();
            this.OutputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CellPhoneData
            // 
            this.CellPhoneData.Controls.Add(this.PriceTextBox);
            this.CellPhoneData.Controls.Add(this.ModelTextBox);
            this.CellPhoneData.Controls.Add(this.BrandTextBox);
            this.CellPhoneData.Controls.Add(this.label3);
            this.CellPhoneData.Controls.Add(this.label2);
            this.CellPhoneData.Controls.Add(this.label1);
            this.CellPhoneData.Location = new System.Drawing.Point(34, 12);
            this.CellPhoneData.Name = "CellPhoneData";
            this.CellPhoneData.Size = new System.Drawing.Size(328, 145);
            this.CellPhoneData.TabIndex = 0;
            this.CellPhoneData.TabStop = false;
            this.CellPhoneData.Text = "CellPhoneData";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(177, 113);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(120, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(177, 65);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(120, 20);
            this.ModelTextBox.TabIndex = 4;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(177, 24);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(120, 20);
            this.BrandTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // OutputBox
            // 
            this.OutputBox.Controls.Add(this.OutputPriceBox);
            this.OutputBox.Controls.Add(this.OutputModelBox);
            this.OutputBox.Controls.Add(this.OutputBrandBox);
            this.OutputBox.Controls.Add(this.OutputPrice);
            this.OutputBox.Controls.Add(this.OutputModel);
            this.OutputBox.Controls.Add(this.OutputBrand);
            this.OutputBox.Location = new System.Drawing.Point(34, 231);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(328, 149);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.TabStop = false;
            this.OutputBox.Text = "Output";
            // 
            // OutputPriceBox
            // 
            this.OutputPriceBox.Location = new System.Drawing.Point(177, 116);
            this.OutputPriceBox.Name = "OutputPriceBox";
            this.OutputPriceBox.ReadOnly = true;
            this.OutputPriceBox.Size = new System.Drawing.Size(120, 20);
            this.OutputPriceBox.TabIndex = 5;
            // 
            // OutputModelBox
            // 
            this.OutputModelBox.Location = new System.Drawing.Point(177, 72);
            this.OutputModelBox.Name = "OutputModelBox";
            this.OutputModelBox.ReadOnly = true;
            this.OutputModelBox.Size = new System.Drawing.Size(120, 20);
            this.OutputModelBox.TabIndex = 4;
            // 
            // OutputBrandBox
            // 
            this.OutputBrandBox.Location = new System.Drawing.Point(177, 23);
            this.OutputBrandBox.Name = "OutputBrandBox";
            this.OutputBrandBox.ReadOnly = true;
            this.OutputBrandBox.Size = new System.Drawing.Size(120, 20);
            this.OutputBrandBox.TabIndex = 3;
            // 
            // OutputPrice
            // 
            this.OutputPrice.AutoSize = true;
            this.OutputPrice.Location = new System.Drawing.Point(16, 123);
            this.OutputPrice.Name = "OutputPrice";
            this.OutputPrice.Size = new System.Drawing.Size(31, 13);
            this.OutputPrice.TabIndex = 2;
            this.OutputPrice.Text = "Price";
            // 
            // OutputModel
            // 
            this.OutputModel.AutoSize = true;
            this.OutputModel.Location = new System.Drawing.Point(16, 79);
            this.OutputModel.Name = "OutputModel";
            this.OutputModel.Size = new System.Drawing.Size(36, 13);
            this.OutputModel.TabIndex = 1;
            this.OutputModel.Text = "Model";
            // 
            // OutputBrand
            // 
            this.OutputBrand.AutoSize = true;
            this.OutputBrand.Location = new System.Drawing.Point(16, 30);
            this.OutputBrand.Name = "OutputBrand";
            this.OutputBrand.Size = new System.Drawing.Size(35, 13);
            this.OutputBrand.TabIndex = 0;
            this.OutputBrand.Text = "Brand";
            // 
            // CreateDataButton
            // 
            this.CreateDataButton.Location = new System.Drawing.Point(155, 186);
            this.CreateDataButton.Name = "CreateDataButton";
            this.CreateDataButton.Size = new System.Drawing.Size(75, 23);
            this.CreateDataButton.TabIndex = 2;
            this.CreateDataButton.Text = "CreateData";
            this.CreateDataButton.UseVisualStyleBackColor = true;
            this.CreateDataButton.Click += new System.EventHandler(this.CreateDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 432);
            this.Controls.Add(this.CreateDataButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.CellPhoneData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CellPhoneData.ResumeLayout(false);
            this.CellPhoneData.PerformLayout();
            this.OutputBox.ResumeLayout(false);
            this.OutputBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CellPhoneData;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox OutputBox;
        private System.Windows.Forms.TextBox OutputPriceBox;
        private System.Windows.Forms.TextBox OutputModelBox;
        private System.Windows.Forms.TextBox OutputBrandBox;
        private System.Windows.Forms.Label OutputPrice;
        private System.Windows.Forms.Label OutputModel;
        private System.Windows.Forms.Label OutputBrand;
        private System.Windows.Forms.Button CreateDataButton;
    }
}