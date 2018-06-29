using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AdoNetPractice.Models;

namespace AdoNetPractice
{
    public partial class ClientEditForm : Form
    {
        public Client Client;
        public ClientEditForm(Client client = null)
        {
            InitializeComponent();
            if (client != null)
            {
                this.ClientIdTextBox.Text = client.Id != null ? client.Id.ToString() : null;
                this.ClientNameTextBox.Text = client.Name;
                this.ClientEmailTextBox.Text = client.Email;
                this.ClientPhoneTextBox.Text = client.Phone;
            }
        }

        private void SaveClientBtn_Click(object sender, EventArgs e)
        {
            var client = new Client
            {
                Name = this.ClientNameTextBox.Text,
                Email = this.ClientEmailTextBox.Text,
                Phone = this.ClientPhoneTextBox.Text
            };

            if (!string.IsNullOrEmpty(ClientIdTextBox.Text))
                client.Id = Convert.ToInt32(ClientIdTextBox.Text);

            this.Client = client;
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
