using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AdoNetPractice.DAL;
using AdoNetPractice.Models;

namespace AdoNetPractice
{
    public class OrdersRepository : DbConnection, IRepository<Order>
    {
        public List<Order> List()
        {
            var orders = new List<Order>();

            const string sqlExpression = "SELECT...";//Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                var reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        orders.Add(new Order
                        {
                            Id = (int)reader["id"],
                            ProductId = (int)reader["productId"],
                            ClientId = (int)reader["clientId"],
                            Count = (int)reader["count"]
                        });
                    }
                }
                reader.Close();
            }*/
            return orders;
        }

        public List<Report> GetReport()
        {
            var reports = new List<Report>();
            //Дописать SQL запрос и раскомментировать метод
            const string sqlExpression = @"
SELECT 
o.Id AS OrderId, 
c.Name AS ClientName, 
p.Name AS ProductName, 
p.Price, 
o.Count, 
(SELECT o.Count*p.Price) AS Sum 
FROM dbo.Orders o
INNER JOIN dbo.Clients c ...
INNER JOIN dbo.Products p ...
";
            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                var reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        reports.Add(new Report
                        {
                            OrderId = (int)reader["OrderId"],
                            ClientName = (string)reader["ClientName"],
                            ProductName = (string)reader["ProductName"],
                            Price = (decimal)reader["Price"],
                            Count = (int)reader["Count"],
                            Sum = (decimal)reader["Sum"]
                        });
                    }
                }
                reader.Close();
            }*/
            return reports;
        }

        public void Insert(Order order)
        {
            const string sqlExpression = "INSERT...; SELECT SCOPE_IDENTITY()"; //Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                // определяем параметры и их значение
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = order.ProductId;
                command.Parameters.Add("@ClientId", SqlDbType.Int).Value = order.ClientId;
                command.Parameters.Add("@Count", SqlDbType.Int).Value = order.Count;

                //получаем Id новой строки, если необходимо
                var identity = command.ExecuteScalar();
            }*/
        }

        public void Update(Order order)
        {
            const string sqlExpression = "UPDATE..."; //Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                // определяем параметры и их значение
                command.Parameters.Add("@Id", SqlDbType.Int).Value = order.Id;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = order.ProductId;
                command.Parameters.Add("@ClientId", SqlDbType.Int).Value = order.ClientId;
                command.Parameters.Add("@Count", SqlDbType.Int).Value = order.Count;

                int affectedRowsCount = command.ExecuteNonQuery();
            }*/
        }

        public void Delete(int orderId)
        {
            const string sqlExpression = "DELETE..."; //Дописать SQL запрос и раскомментировать метод
            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                command.Parameters.Add("@Id", SqlDbType.Int).Value = orderId;

                int affectedRowsCount = command.ExecuteNonQuery();
            }*/
        }
    }
}