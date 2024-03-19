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

namespace EasyBizPos.Forms
{
    public partial class UserLogin : Form
    {
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

            // Hash the password
            string hashedPassword = HashPassword(password);
      
            // Check if the username and hashed password exist in the database
            bool isAuthenticated = CheckCredentials(username, hashedPassword);

            if (isAuthenticated)
            {
                // Allow access to the main form
                OpenMainForm();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private string HashPassword(string password)
        {
            // Use a secure hashing algorithm like SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

            // Query to check if the username exists in the database
            string userQuery = "SELECT COUNT(*) FROM employeeinfo WHERE employee_ID = @username";

            // Query to get the hashed password for the username
            string passwordQuery = "SELECT Password FROM employeeinfo WHERE employee_ID = @username";

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

                // Get the hashed password for the username
                using (MySqlCommand passwordCommand = new MySqlCommand(passwordQuery, connection))
                {
                    passwordCommand.Parameters.AddWithValue("@username", username);

                    string hashedPassword = passwordCommand.ExecuteScalar()?.ToString();

                    if (hashedPassword == null)
                    {
                        // Unable to retrieve hashed password
                        return false;
                    }

                    // Compare the hashed password with the input password
                    return VerifyHashedPassword(password, hashedPassword);
                }
            }
        }

        private bool VerifyHashedPassword(string password, string hashedPassword)
        {
            // Compare the hashed input password with the stored hashed password
            return password == hashedPassword;
        }

        
        private void OpenMainForm()
        {
            this.Hide(); // Hide the login form
            HomeFormMain mainForm = new HomeFormMain();
            mainForm.ShowDialog(); // Show the main form as a dialog
            this.Close(); // Close the login form after the main form is closed
        }
        private void AddName_Click(object sender, EventArgs e)
        {

        }
    }
}
