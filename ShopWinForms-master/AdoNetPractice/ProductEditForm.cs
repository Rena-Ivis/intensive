using System;
using System.Windows.Forms;

namespace AdoNetPractice
{
    public partial class ProductEditForm : Form
    {
        public Product Product;
        public ProductEditForm(Product product = null)
        {
            InitializeComponent();
            if (product != null)
            {
                this.ProductIdTextBox.Text = product.Id != null ? product.Id.ToString() : null;
                this.ProductNameTextBox.Text = product.Name;
                this.ProductPriceNumericUpDown.Value = product.Price;
            }
        }

        private void SaveProductBtn_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = this.ProductNameTextBox.Text,
                Price = (decimal)this.ProductPriceNumericUpDown.Value
            };

            if (!string.IsNullOrEmpty(ProductIdTextBox.Text))
                product.Id = Convert.ToInt32(ProductIdTextBox.Text);

            this.Product = product;
            this.DialogResult = DialogResult.OK;
            this.Close();
            // this.Dispose();
        }

        private void CloseProductEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
