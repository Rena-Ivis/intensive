using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using AdoNetPractice.DAL;
using AdoNetPractice.Models;

namespace AdoNetPractice
{
    public partial class MainForm : Form
    {
        private readonly ClientsRepository _clientsRepository;
        private readonly ProductsRepository _productsRepository;
        private readonly OrdersRepository _ordersRepository;

        public MainForm()
        {
            InitializeComponent();
            _clientsRepository = new ClientsRepository();
            _productsRepository = new ProductsRepository();
            _ordersRepository = new OrdersRepository();
            FillGrids();
        }

        private void FillGrids()
        {
            ReadClients();
            ReadProducts();
            ReadOrders();
            ReadReport();
        }

        private void ReadReport()
        {
            List<Report> reports = _ordersRepository.GetReport();
            var bindingList = new BindingList<Report>(reports);
            this.ReportDataGrid.DataSource = new BindingSource(bindingList, null);
        }

        #region Client CRUD

        private void ReadClients()
        {
            List<Client> clients = _clientsRepository.List();

            var bindingList = new BindingList<Client>(clients);
            this.ClientsDataGrid.DataSource = new BindingSource(bindingList, null);
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            ClientEditForm form = new ClientEditForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _clientsRepository.Insert(form.Client);
                FillGrids();
            }
        }

        private void UpdateClientBtn_Click(object sender, EventArgs e)
        {
            Client client = (Client)ClientsDataGrid.CurrentRow.DataBoundItem;

            ClientEditForm form = new ClientEditForm(client);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _clientsRepository.Update(form.Client);
                FillGrids();
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            Client client = (Client)ClientsDataGrid.CurrentRow.DataBoundItem;
            if (!client.Id.HasValue)
                throw new ApplicationException("Delete event: Client id not defined!");

            var confirmResult = MessageBox.Show($"Are you sure to delete client {client.Name}?",
                                     "Delete confirm",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _clientsRepository.Delete(client.Id.Value);
                FillGrids();
            }
        }

        #endregion
       
        #region Product CRUD

        private void ReadProducts()
        {
            List<Product> products = _productsRepository.List();
            var bindingList = new BindingList<Product>(products);
            this.ProductsDataGrid.DataSource = new BindingSource(bindingList, null);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductEditForm form = new ProductEditForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _productsRepository.Insert(form.Product);
                FillGrids();
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)ProductsDataGrid.CurrentRow.DataBoundItem;

            ProductEditForm form = new ProductEditForm(product);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _productsRepository.Update(form.Product);
                FillGrids();
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)ProductsDataGrid.CurrentRow.DataBoundItem;
            if (!product.Id.HasValue)
                throw new ApplicationException("Delete event: Product id not defined!");

            var confirmResult = MessageBox.Show($"Are you sure to delete product {product.Name}?",
                                     "Delete confirm",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _productsRepository.Delete(product.Id.Value);
                FillGrids();
            }
        }

        #endregion

        #region Order CRUD
        private void ReadOrders()
        {
            List<Order> orders = _ordersRepository.List();
            var bindingList = new BindingList<Order>(orders);
            this.OrdersDataGrid.DataSource = new BindingSource(bindingList, null);
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            List<Product> products = _productsRepository.List();
            List<Client> clients = _clientsRepository.List();

            OrderEditForm form = new OrderEditForm(products, clients);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _ordersRepository.Insert(form.Order);
                FillGrids();
            }
        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            List<Product> products = _productsRepository.List();
            List<Client> clients = _clientsRepository.List();

            Order order = (Order)OrdersDataGrid.CurrentRow.DataBoundItem;

            OrderEditForm form = new OrderEditForm(products, clients, order);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _ordersRepository.Update(form.Order);
                FillGrids();
            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            Order order = (Order)OrdersDataGrid.CurrentRow.DataBoundItem;
            if (!order.Id.HasValue)
                throw new ApplicationException("Delete event: Order id not defined!");

            var confirmResult = MessageBox.Show($"Are you sure to delete product {order}?",
                                     "Delete confirm",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _ordersRepository.Delete(order.Id.Value);
                FillGrids();
            }
        }
        #endregion
    }
}
