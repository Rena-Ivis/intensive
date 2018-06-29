namespace AdoNetPractice
{
    partial class OrderEditForm
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
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.CloseClientEditForm = new System.Windows.Forms.Button();
            this.SaveClientBtn = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ClientIdLabel = new System.Windows.Forms.Label();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.OrderCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.OrderCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(123, 29);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(223, 20);
            this.OrderIdTextBox.TabIndex = 17;
            this.OrderIdTextBox.Visible = false;
            // 
            // CloseClientEditForm
            // 
            this.CloseClientEditForm.Location = new System.Drawing.Point(216, 214);
            this.CloseClientEditForm.Name = "CloseClientEditForm";
            this.CloseClientEditForm.Size = new System.Drawing.Size(75, 23);
            this.CloseClientEditForm.TabIndex = 16;
            this.CloseClientEditForm.Text = "Cancel";
            this.CloseClientEditForm.UseVisualStyleBackColor = true;
            this.CloseClientEditForm.Click += new System.EventHandler(this.CloseClientEditForm_Click);
            // 
            // SaveClientBtn
            // 
            this.SaveClientBtn.Location = new System.Drawing.Point(123, 214);
            this.SaveClientBtn.Name = "SaveClientBtn";
            this.SaveClientBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveClientBtn.TabIndex = 15;
            this.SaveClientBtn.Text = "Save";
            this.SaveClientBtn.UseVisualStyleBackColor = true;
            this.SaveClientBtn.Click += new System.EventHandler(this.SaveClientBtn_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(28, 147);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 13);
            this.CountLabel.TabIndex = 14;
            this.CountLabel.Text = "Count";
            // 
            // ClientIdLabel
            // 
            this.ClientIdLabel.AutoSize = true;
            this.ClientIdLabel.Location = new System.Drawing.Point(28, 100);
            this.ClientIdLabel.Name = "ClientIdLabel";
            this.ClientIdLabel.Size = new System.Drawing.Size(42, 13);
            this.ClientIdLabel.TabIndex = 12;
            this.ClientIdLabel.Text = "ClientId";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(28, 58);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(53, 13);
            this.ProductIdLabel.TabIndex = 10;
            this.ProductIdLabel.Text = "ProductId";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(123, 58);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(223, 21);
            this.ProductComboBox.TabIndex = 18;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(123, 100);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(223, 21);
            this.ClientComboBox.TabIndex = 19;
            // 
            // OrderCountNumericUpDown
            // 
            this.OrderCountNumericUpDown.Location = new System.Drawing.Point(123, 145);
            this.OrderCountNumericUpDown.Name = "OrderCountNumericUpDown";
            this.OrderCountNumericUpDown.Size = new System.Drawing.Size(223, 20);
            this.OrderCountNumericUpDown.TabIndex = 20;
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 263);
            this.Controls.Add(this.OrderCountNumericUpDown);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.CloseClientEditForm);
            this.Controls.Add(this.SaveClientBtn);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ClientIdLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Name = "OrderEditForm";
            this.Text = "OrderEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.OrderCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.Button CloseClientEditForm;
        private System.Windows.Forms.Button SaveClientBtn;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label ClientIdLabel;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.NumericUpDown OrderCountNumericUpDown;
    }
}