namespace AdoNetPractice
{
    partial class ClientEditForm
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
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ClientEmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.ClientPhoneTextBox = new System.Windows.Forms.TextBox();
            this.SaveClientBtn = new System.Windows.Forms.Button();
            this.CloseClientEditForm = new System.Windows.Forms.Button();
            this.ClientIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(177, 34);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.ClientNameTextBox.TabIndex = 0;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(82, 37);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(61, 13);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "ClientName";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(82, 79);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(177, 76);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(223, 20);
            this.ClientEmailTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(82, 126);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone";
            // 
            // ClientPhoneTextBox
            // 
            this.ClientPhoneTextBox.Location = new System.Drawing.Point(177, 123);
            this.ClientPhoneTextBox.Name = "ClientPhoneTextBox";
            this.ClientPhoneTextBox.Size = new System.Drawing.Size(223, 20);
            this.ClientPhoneTextBox.TabIndex = 4;
            // 
            // SaveClientBtn
            // 
            this.SaveClientBtn.Location = new System.Drawing.Point(177, 193);
            this.SaveClientBtn.Name = "SaveClientBtn";
            this.SaveClientBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveClientBtn.TabIndex = 6;
            this.SaveClientBtn.Text = "Save";
            this.SaveClientBtn.UseVisualStyleBackColor = true;
            this.SaveClientBtn.Click += new System.EventHandler(this.SaveClientBtn_Click);
            // 
            // CloseClientEditForm
            // 
            this.CloseClientEditForm.Location = new System.Drawing.Point(270, 193);
            this.CloseClientEditForm.Name = "CloseClientEditForm";
            this.CloseClientEditForm.Size = new System.Drawing.Size(75, 23);
            this.CloseClientEditForm.TabIndex = 7;
            this.CloseClientEditForm.Text = "Cancel";
            this.CloseClientEditForm.UseVisualStyleBackColor = true;
            this.CloseClientEditForm.Click += new System.EventHandler(this.CloseClientEditForm_Click);
            // 
            // ClientIdTextBox
            // 
            this.ClientIdTextBox.Location = new System.Drawing.Point(177, 8);
            this.ClientIdTextBox.Name = "ClientIdTextBox";
            this.ClientIdTextBox.Size = new System.Drawing.Size(223, 20);
            this.ClientIdTextBox.TabIndex = 8;
            this.ClientIdTextBox.Visible = false;
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 251);
            this.Controls.Add(this.ClientIdTextBox);
            this.Controls.Add(this.CloseClientEditForm);
            this.Controls.Add(this.SaveClientBtn);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.ClientPhoneTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ClientEmailTextBox);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.ClientNameTextBox);
            this.Name = "ClientEditForm";
            this.Text = "ClientEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox ClientEmailTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox ClientPhoneTextBox;
        private System.Windows.Forms.Button SaveClientBtn;
        private System.Windows.Forms.Button CloseClientEditForm;
        private System.Windows.Forms.TextBox ClientIdTextBox;
    }
}