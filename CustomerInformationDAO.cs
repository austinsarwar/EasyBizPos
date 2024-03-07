using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos
{
    internal class CustomerInformationDAO
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=easybizpos;";
        public List<CustomerInformation> getAllCustomerInfo()
        {
            // start with empty list
            List<CustomerInformation> returnThese = new List<CustomerInformation>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM customerinfo", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CustomerInformation c = new CustomerInformation
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PhoneNumber = reader.GetString(2),
                        Email = reader.GetString(3),
                        Date = reader.GetDateTime(4),
                    };
                    returnThese.Add(c);

                }
            }
            
            connection.Close();
           
            return returnThese;


        }
        public List<CustomerInformation> searchCustomerName(string searchTerm)
        {
            // start with empty list
            List<CustomerInformation> returnThese = new List<CustomerInformation>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            String searchWildPhrase = "%" + searchTerm + "%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, NAME, PHONE_NUMBER, EMAIL, DATE FROM customerinfo WHERE NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CustomerInformation c = new CustomerInformation
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PhoneNumber = reader.GetString(2),
                        Email = reader.GetString(3),
                        Date = reader.GetDateTime(4),
                    };
                    returnThese.Add(c);

                }
            }

            connection.Close();

            return returnThese;


        }

    }
}
