using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetPractice.DAL
{
    internal class ProductsRepository : DbConnection, IRepository<Product>
    {
        public List<Product> List()
        {
            var products = new List<Product>();

            const string sqlExpression = "SELECT...";//Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                var reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        products.Add(new Product
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"],
                            Price = (decimal)reader["price"]
                        });
                    }
                }
                reader.Close();
            }*/
            return products;
        }

        public void Insert(Product product)
        {
            const string sqlExpression = "INSERT...; SELECT SCOPE_IDENTITY()"; //Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                // определяем параметры и их значение
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = product.Name;
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;

                //получаем Id новой строки, если необходимо
                var identity = command.ExecuteScalar();
            }*/
        }

        public void Update(Product product)
        {
            const string sqlExpression = "UPDATE..."; //Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                // определяем параметры и их значение
                command.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = product.Name;
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;

                int affectedRowsCount = command.ExecuteNonQuery();
            }*/
        }

        public void Delete(int productId)
        {
            const string sqlExpression = "DELETE..."; //Дописать SQL запрос и раскомментировать метод

            /*using (var command = new SqlCommand(sqlExpression, this.Connection))
            {
                command.Parameters.Add("@Id", SqlDbType.Int).Value = productId;

                int affectedRowsCount = command.ExecuteNonQuery();
            }*/
        }
    }
}