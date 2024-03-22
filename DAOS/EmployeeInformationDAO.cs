using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using EasyBizPos.Models;
using EasyBizPos.DAOS;
using System.Windows;


namespace EasyBizPos.DAOS
{
    internal class EmployeeInformationDAO
    {

        string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");



        public List<Employee> getAllEmployeeInfo()
        {
            // start with empty list
            List<Employee> returnThese = new List<Employee>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT employee_ID, username, name, role, phone_number, email, IF(admin = 1, 'yes', 'no') as admin FROM employeeinfo", connection);
            // Get All data from database and store it in a list
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // Read the data from the database and store it in a list
                while (reader.Read())
                {
                    Employee e = new Employee
                    {
                        Employee_ID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Name = reader.GetString(2),
                        Role = reader.GetString(3),
                        PhoneNumber = reader.GetString(4),
                        Email = reader.GetString(5),
                        Admin = reader.GetString(6), // Admin is read as string ('yes' or 'no')
                    };

                    returnThese.Add(e);
                }
            }

            connection.Close();
            // return the list of employee
            return returnThese;
        }

        // Search database for data "like" the search string" 
        public List<Employee> searchEmployeeName(string searchTerm)
        {
            // start with empty list
            List<Employee> returnThese = new List<Employee>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Add wildcards to the search term
            String searchWildPhrase = "%" + searchTerm + "%";
           
            MySqlCommand command = new MySqlCommand();
            // Prepare a SELECT command to get all the data from the 'employeeinfo' table where the name is like the search term.
            command.CommandText = "SELECT employee_ID, name, role, phone_number, email FROM employeeinfo WHERE NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            // Get All data from database and store it in a list
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // Read the data from the database and store it in a list
                while (reader.Read())
                {
                    // Create a new employee object and store the data from the database in it
                    Employee e = new Employee
                    {
                        Employee_ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Role = reader.GetString(2),
                        PhoneNumber = reader.GetString(3),
                        Email = reader.GetString(4),
                    };

                    returnThese.Add(e);

                }
            }
            connection.Close();
            return returnThese;


        }
        public void AddEmployee(string name, string role, string phone_number, string email, string password, string username, int admin)
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            // Connect to the database using the provided connection string.
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Prepare an INSERT command to add a new employee to the 'employeeinfo' table.
            MySqlCommand command = new MySqlCommand("INSERT INTO employeeinfo (name, role, phone_number, email, Password, username, admin) " +
                                            "VALUES (@name, @role, @phone_number, @email, @password, @username, @admin)", connection);

            // Add parameters to the command prevents SQL injection by ensuring that the value of id is treated as data,
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@role", role);
            command.Parameters.AddWithValue("@phone_number", phone_number);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@admin", admin);

            // Execute the command
            command.ExecuteNonQuery();
        }


        public void DeleteEmployee(int employee_id)
        {
            // Connect to the database using the provided connection string.
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Prepare a DELETE command to remove a employee from the 'employeeinfo' table based on their ID.
            MySqlCommand command = new MySqlCommand();
            // Prepare a DELETE command to remove a employee from the 'employeeinfo' table based on their ID.
            command.CommandText = "DELETE FROM employeeinfo WHERE employee_ID = @employee_id";
            // Add the connection to the command
            command.Connection = connection;
            // Add parameters to the command prevents SQL injection by ensuring that the value of id is treated as data
            command.Parameters.AddWithValue("@employee_id", employee_id);
            // Execute the command, which deletes the specified employee from the database.
            command.ExecuteNonQuery();
            // Close the database connection to release database resources.
            connection.Close();

        }
    }
    }
