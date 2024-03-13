using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace EasyBizPos
{
    internal class CustomerInformationDAO
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=easybizpos;";
        public List<Customer> getAllCustomerInfo()
        {
            // start with empty list
            List<Customer> returnThese = new List<Customer>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM customerinfo", connection);
            // Get All data from database and store it in a list
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // Read the data from the database and store it in a list
                while (reader.Read())
                {
                    Customer c = new Customer
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
            // return the list of customers
            return returnThese;


        }
        // Search database for data "like" the search string" 
        public List<Customer> searchCustomerName(string searchTerm)
        {
            // start with empty list
            List<Customer> returnThese = new List<Customer>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Add wildcards to the search term
            String searchWildPhrase = "%" + searchTerm + "%";
           
            MySqlCommand command = new MySqlCommand();
            // Prepare a SELECT command to get all the data from the 'customerinfo' table where the name is like the search term.
            command.CommandText = "SELECT ID, NAME, PHONE_NUMBER, EMAIL, DATE FROM customerinfo WHERE NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            // Get All data from database and store it in a list
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // Read the data from the database and store it in a list
                while (reader.Read())
                {
                    // Create a new customer object and store the data from the database in it
                    Customer c = new Customer
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
        public void AddCustomer(string name, string phone_number, string email)

        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            // Connect to the database using the provided connection string.
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Prepare an INSERT command to add a new customer to the 'customerinfo' table.
            MySqlCommand command = new MySqlCommand("INSERT INTO customerInfo (NAME, PHONE_NUMBER, EMAIL, DATE) " +
                                        "VALUES (@name, @phone_number, @email, @currentDate)", connection);

            // Add parameters to the command prevents SQL injection by ensuring that the value of id is treated as data,


            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@phone_number", phone_number);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@currentDate", currentDate);

            // Execute the command
            command.ExecuteNonQuery();


        }
        public void DeleteCustomer(int id)
        {
            // Connect to the database using the provided connection string.
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Prepare a DELETE command to remove a customer from the 'customerinfo' table based on their ID.
            MySqlCommand command = new MySqlCommand();
            // Prepare a DELETE command to remove a customer from the 'customerinfo' table based on their ID.
            command.CommandText = "DELETE FROM customerinfo WHERE ID = @id";
            // Add the connection to the command
            command.Connection = connection;
            // Add parameters to the command prevents SQL injection by ensuring that the value of id is treated as data
            command.Parameters.AddWithValue("@id", id);
            // Execute the command, which deletes the specified customer from the database.
            command.ExecuteNonQuery();
            // Close the database connection to release database resources.
            connection.Close();

        }
    }
    }
