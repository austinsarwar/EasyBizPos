using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBizPos.Models;
using EasyBizPos.DAOS;


namespace EasyBizPos.DAOS
{
    internal class CatalogDAO
    {
        string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

        List<Catalog> returnThese = new List<Catalog>();


        public List<Catalog> getAllCatalog()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM products", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read()){
                    Catalog c = new Catalog
                    {
                        ProductId = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Price = reader.GetDecimal(2),
                        Stock = reader.GetInt32(3),


                    };
                    returnThese.Add(c);
                }
            }
            connection.Close();
            return returnThese;

        }
       

    }
}
