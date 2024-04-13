using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;

namespace EasyBizPos.Forms
{
    public partial class UserLogin : Form
    {
        public HomeFormMain MainForm { get; set; }
        public static string ActiveUsername { get; private set; }
        public static bool IsAdmin { get; private set; }


        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if the username and hashed password exist in the database
            bool isAuthenticated = CheckCredentials(username, password);

            if (isAuthenticated)
            {
                string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
                string nameQuery = "SELECT name, admin FROM employeeinfo WHERE username = @username";
                string name;
                int admin;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand(nameQuery, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    name = reader.GetString(0);
                                    ActiveUsername = name;
                                    admin = reader.GetInt32(1);
                                    IsAdmin = admin == 1;
                                }
                            }
                        }
                        OpenMainForm();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}");
                }
            }
            else
            {
                string errorMessage = "Invalid username or password. Please try again.";

                // Check if the username exists in the database
                string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
                string userQuery = "SELECT COUNT(*) FROM employeeinfo WHERE username = @username";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand userCommand = new MySqlCommand(userQuery, connection))
                        {
                            userCommand.Parameters.AddWithValue("@username", username);
                            connection.Open();
                            int userCount = Convert.ToInt32(userCommand.ExecuteScalar());

                            if (userCount == 0)
                            {
                                errorMessage = "User does not exist.";
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    errorMessage = $"Error connecting to the database: {ex.Message}";
                }

                MessageBox.Show(errorMessage);
            }
        }

        public static bool IsUserAdmin()
        {
            return IsAdmin;
        }



        private string HashPassword(string password, string salt)
        {
            // Hash the password with the stored salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hashedPassword;
        }


        private bool CheckCredentials(string username, string password)
        {
            string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

            // Query to check if the username exists in the database
            string userQuery = "SELECT COUNT(*) FROM employeeinfo WHERE username = @username";

            // Query to get the hashed password and salt for the username
            string passwordQuery = "SELECT Password, salt FROM employeeinfo WHERE username = @username";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Check if the username exists
                    using (MySqlCommand userCommand = new MySqlCommand(userQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@username", username);
                        connection.Open();
                        int userCount = Convert.ToInt32(userCommand.ExecuteScalar());

                        if (userCount == 0)
                        {
                            // Username doesn't exist
                            return false;
                        }
                    }

                    // Get the hashed password and salt for the username
                    using (MySqlCommand passwordCommand = new MySqlCommand(passwordQuery, connection))
                    {
                        passwordCommand.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = passwordCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader.GetString(0);
                                string salt = reader.GetString(1);

                                // Hash the user-supplied password with the retrieved salt
                                string hashedInputPassword = HashPassword(password, salt);

                                // Compare the hashed password with the input password
                                return hashedInputPassword == hashedPassword;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}");
                return false;
            }

            return false;
        }



        private bool VerifyHashedPassword(string password, string hashedPassword)
        {
            // Compare the hashed input password with the stored hashed password
            return password == hashedPassword;
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login form when the main form is closed
        }

        private void OpenMainForm()
        {
            MainForm = new HomeFormMain(); 
            MainForm.ActiveUsername = ActiveUsername; // Set the active username
            this.Hide(); // Hide the login form
            MainForm.FormClosed += MainForm_FormClosed; // Subscribe to the FormClosed event
            MainForm.Show(); // Show the main form
        }

        private void AddName_Click(object sender, EventArgs e)
        {

        }
    }
}
