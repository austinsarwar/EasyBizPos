using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace EasyBizPos.Models
{
    internal class DatabaseManager
    {
        private static readonly string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

        public static CartItem GetCartItemByUPC(string upc)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Products WHERE UPC = @upc";
                    command.Parameters.AddWithValue("@upc", upc);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string name = reader.GetString("Name");
                            decimal price = reader.GetDecimal("Price");

                            return new CartItem(id, name, price);
                        }
                    }
                }
            }

            throw new Exception("Product not found in database.");
        }

    }
}
