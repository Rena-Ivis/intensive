using AdoNetPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdoNetPractice
{
    public partial class OrderEditForm : Form
    {
        public Order Order;
        public OrderEditForm(List<Product> products, List<Client> clients, Order order = null)
        {
            InitializeComponent();

            this.ProductComboBox.DataSource = products;
            this.ClientComboBox.DataSource = clients;

            if (order != null)
            {
                this.OrderIdTextBox.Text = order.Id != null ? order.Id.ToString() : null;
                this.ProductComboBox.SelectedItem = products.FirstOrDefault(x => x.Id == order.ProductId);
                this.ClientComboBox.SelectedItem = clients.FirstOrDefault(x => x.Id == order.ClientId); 
                this.OrderCountNumericUpDown.Value = order.Count;
            }
        }

        private void SaveClientBtn_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                ProductId = ((Product)this.ProductComboBox.SelectedValue).Id.Value,
                ClientId = ((Client)this.ClientComboBox.SelectedValue).Id.Value,
                Count = (int)this.OrderCountNumericUpDown.Value
            };

            if (!string.IsNullOrEmpty(OrderIdTextBox.Text))
                order.Id = Convert.ToInt32(OrderIdTextBox.Text);

            this.Order = order;
            this.DialogResult = DialogResult.OK;
            this.Close();
            // this.Dispose();
        }

        private void CloseClientEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
