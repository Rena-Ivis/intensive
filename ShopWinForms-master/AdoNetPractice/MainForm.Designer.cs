namespace AdoNetPractice
{
    partial class MainForm
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ClientsTab = new System.Windows.Forms.TabPage();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.UpdateClientBtn = new System.Windows.Forms.Button();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.ClientsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.UpdateOrder = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.Tabs.SuspendLayout();
            this.ClientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.ReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ClientsTab);
            this.Tabs.Controls.Add(this.ProductsTab);
            this.Tabs.Controls.Add(this.OrdersTab);
            this.Tabs.Controls.Add(this.ReportTab);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(776, 426);
            this.Tabs.TabIndex = 0;
            // 
            // ClientsTab
            // 
            this.ClientsTab.Controls.Add(this.DeleteClient);
            this.ClientsTab.Controls.Add(this.UpdateClientBtn);
            this.ClientsTab.Controls.Add(this.AddClientBtn);
            this.ClientsTab.Controls.Add(this.ClientsDataGrid);
            this.ClientsTab.Location = new System.Drawing.Point(4, 22);
            this.ClientsTab.Name = "ClientsTab";
            this.ClientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsTab.Size = new System.Drawing.Size(768, 400);
            this.ClientsTab.TabIndex = 0;
            this.ClientsTab.Text = "Clients";
            this.ClientsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(654, 137);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(75, 23);
            this.DeleteClient.TabIndex = 3;
            this.DeleteClient.Text = "DeleteClient";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // UpdateClientBtn
            // 
            this.UpdateClientBtn.Location = new System.Drawing.Point(654, 80);
            this.UpdateClientBtn.Name = "UpdateClientBtn";
            this.UpdateClientBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateClientBtn.TabIndex = 2;
            this.UpdateClientBtn.Text = "UpdateClient";
            this.UpdateClientBtn.UseVisualStyleBackColor = true;
            this.UpdateClientBtn.Click += new System.EventHandler(this.UpdateClientBtn_Click);
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Location = new System.Drawing.Point(654, 26);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(75, 23);
            this.AddClientBtn.TabIndex = 1;
            this.AddClientBtn.Text = "AddClient";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // ClientsDataGrid
            // 
            this.ClientsDataGrid.AllowUserToAddRows = false;
            this.ClientsDataGrid.AllowUserToDeleteRows = false;
            this.ClientsDataGrid.AllowUserToResizeRows = false;
            this.ClientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGrid.Location = new System.Drawing.Point(6, 6);
            this.ClientsDataGrid.Name = "ClientsDataGrid";
            this.ClientsDataGrid.Size = new System.Drawing.Size(617, 388);
            this.ClientsDataGrid.TabIndex = 0;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.DeleteProduct);
            this.ProductsTab.Controls.Add(this.UpdateProduct);
            this.ProductsTab.Controls.Add(this.AddProduct);
            this.ProductsTab.Controls.Add(this.ProductsDataGrid);
            this.ProductsTab.Location = new System.Drawing.Point(4, 22);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(768, 400);
            this.ProductsTab.TabIndex = 3;
            this.ProductsTab.Text = "Products";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(655, 137);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(91, 23);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.Text = "DeleteProduct";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Location = new System.Drawing.Point(655, 80);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(91, 23);
            this.UpdateProduct.TabIndex = 6;
            this.UpdateProduct.Text = "UpdateProduct";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(655, 26);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(91, 23);
            this.AddProduct.TabIndex = 5;
            this.AddProduct.Text = "AddProduct";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.AllowUserToResizeRows = false;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Location = new System.Drawing.Point(23, 6);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.Size = new System.Drawing.Size(617, 388);
            this.ProductsDataGrid.TabIndex = 4;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.DeleteOrder);
            this.OrdersTab.Controls.Add(this.UpdateOrder);
            this.OrdersTab.Controls.Add(this.AddOrder);
            this.OrdersTab.Controls.Add(this.OrdersDataGrid);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(768, 400);
            this.OrdersTab.TabIndex = 2;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(671, 137);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrder.TabIndex = 7;
            this.DeleteOrder.Text = "DeleteOrder";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // UpdateOrder
            // 
            this.UpdateOrder.Location = new System.Drawing.Point(671, 80);
            this.UpdateOrder.Name = "UpdateOrder";
            this.UpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.UpdateOrder.TabIndex = 6;
            this.UpdateOrder.Text = "UpdateOrder";
            this.UpdateOrder.UseVisualStyleBackColor = true;
            this.UpdateOrder.Click += new System.EventHandler(this.UpdateOrder_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(671, 26);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(75, 23);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "AddOrder";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.AllowUserToAddRows = false;
            this.OrdersDataGrid.AllowUserToDeleteRows = false;
            this.OrdersDataGrid.AllowUserToResizeRows = false;
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.Location = new System.Drawing.Point(23, 6);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.Size = new System.Drawing.Size(617, 388);
            this.OrdersDataGrid.TabIndex = 4;
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.ReportDataGrid);
            this.ReportTab.Location = new System.Drawing.Point(4, 22);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTab.Size = new System.Drawing.Size(768, 400);
            this.ReportTab.TabIndex = 4;
            this.ReportTab.Text = "Report";
            this.ReportTab.UseVisualStyleBackColor = true;
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.AllowUserToAddRows = false;
            this.ReportDataGrid.AllowUserToDeleteRows = false;
            this.ReportDataGrid.AllowUserToResizeColumns = false;
            this.ReportDataGrid.AllowUserToResizeRows = false;
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(6, 6);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.Size = new System.Drawing.Size(756, 388);
            this.ReportDataGrid.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabs);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Tabs.ResumeLayout(false);
            this.ClientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.OrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            this.ReportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ClientsTab;
        private System.Windows.Forms.DataGridView ClientsDataGrid;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button UpdateClientBtn;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button UpdateOrder;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.TabPage ReportTab;
        private System.Windows.Forms.DataGridView ReportDataGrid;
    }
}

