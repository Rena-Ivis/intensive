namespace AdoNetPractice
{
    partial class ProductEditForm
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
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.CloseProductEditForm = new System.Windows.Forms.Button();
            this.SaveProductBtn = new System.Windows.Forms.Button();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProducNameLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(118, 21);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(223, 20);
            this.ProductIdTextBox.TabIndex = 17;
            this.ProductIdTextBox.Visible = false;
            // 
            // CloseProductEditForm
            // 
            this.CloseProductEditForm.Location = new System.Drawing.Point(233, 145);
            this.CloseProductEditForm.Name = "CloseProductEditForm";
            this.CloseProductEditForm.Size = new System.Drawing.Size(75, 23);
            this.CloseProductEditForm.TabIndex = 16;
            this.CloseProductEditForm.Text = "Cancel";
            this.CloseProductEditForm.UseVisualStyleBackColor = true;
            this.CloseProductEditForm.Click += new System.EventHandler(this.CloseProductEditForm_Click);
            // 
            // SaveProductBtn
            // 
            this.SaveProductBtn.Location = new System.Drawing.Point(140, 145);
            this.SaveProductBtn.Name = "SaveProductBtn";
            this.SaveProductBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveProductBtn.TabIndex = 15;
            this.SaveProductBtn.Text = "Save";
            this.SaveProductBtn.UseVisualStyleBackColor = true;
            this.SaveProductBtn.Click += new System.EventHandler(this.SaveProductBtn_Click);
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(23, 92);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.ProductPriceLabel.TabIndex = 12;
            this.ProductPriceLabel.Text = "Price";
            // 
            // ProducNameLabel
            // 
            this.ProducNameLabel.AutoSize = true;
            this.ProducNameLabel.Location = new System.Drawing.Point(23, 50);
            this.ProducNameLabel.Name = "ProducNameLabel";
            this.ProducNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ProducNameLabel.TabIndex = 10;
            this.ProducNameLabel.Text = "Name";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(118, 47);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.ProductNameTextBox.TabIndex = 9;
            // 
            // ProductPriceNumericUpDown
            // 
            this.ProductPriceNumericUpDown.DecimalPlaces = 2;
            this.ProductPriceNumericUpDown.Location = new System.Drawing.Point(118, 92);
            this.ProductPriceNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.ProductPriceNumericUpDown.Name = "ProductPriceNumericUpDown";
            this.ProductPriceNumericUpDown.Size = new System.Drawing.Size(223, 20);
            this.ProductPriceNumericUpDown.TabIndex = 18;
            this.ProductPriceNumericUpDown.ThousandsSeparator = true;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 189);
            this.Controls.Add(this.ProductPriceNumericUpDown);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.CloseProductEditForm);
            this.Controls.Add(this.SaveProductBtn);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProducNameLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Name = "ProductEditForm";
            this.Text = "ProductEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.Button CloseProductEditForm;
        private System.Windows.Forms.Button SaveProductBtn;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProducNameLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.NumericUpDown ProductPriceNumericUpDown;
    }
}