using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AdoNetPractice.Models;

namespace AdoNetPractice.DAL
{
    public class ClientsRepository: DbConnection, IRepository<Client>
    {
        /// <summary>
        /// Получить все записи из таблицы dbo.Clients
        /// </summary>
        /// <returns></returns>
        public List<Client> List()
        {
            var clients = new List<Client>();
            
            const string sqlExpression = "SELECT * FROM dbo.Clients"; //Дописать SQL запрос и раскомментировать метод

            using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                var reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        clients.Add(new Client
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"],
                            Email = (string)reader["email"],
                            Phone = (string)reader["phone"]
                        });
                    }
                }
                reader.Close();
            }
            return clients;
        }

        /// <summary>
        /// Добавить нового клиента
        /// </summary>
        /// <param name="client"></param>
        public void Insert(Client client)
        {
            const string sqlExpression = "INSERT INTO dbo.Clients (Name, Email, Phone) VALUES (@Name, @Email, @Phone);SELECT SCOPE_IDENTITY()";//Дописать SQL запрос и раскомментировать метод

            using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                //определяем параметры и их значение
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = client.Name;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = client.Email;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = client.Phone;

                //получаем Id новой строки, если необходимо
                var identity = command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Обновить клиента
        /// </summary>
        /// <param name="client"></param>
        public void Update(Client client)
        {
            const string sqlExpression = "UPDATE dbo.Clients SET Name = @Name, Email = @Email, Phone = @Phone WHERE Id = @Id"; //Дописать SQL запрос и раскомментировать метод

            using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                //определяем параметры и их значение
                command.Parameters.Add("@Id", SqlDbType.Int).Value = client.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = client.Name;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = client.Email;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = client.Phone;

                int affectedRowsCount = command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Удалить клиента
        /// </summary>
        /// <param name="clientId"></param>
        public void Delete(int clientId)
        {
            const string sqlExpression = "DELETE FROM dbo.Clients WHERE Id = @Id";//Дописать SQL запрос и раскомментировать метод

            using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                command.Parameters.Add("@Id", SqlDbType.Int).Value = clientId;

                int affectedRowsCount = command.ExecuteNonQuery();
            }
        }

    }
}
