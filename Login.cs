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
    public partial class Login : Form
    {
        public Login()
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

        private bool CheckCredentials(string username, string hashedPassword)
        {
            // Query the database to check if the username and hashed password exist
            // Return true if the credentials are valid, false otherwise
            // Example: SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @hashedPassword

            // Placeholder return statement
            return true;
        }

        private void OpenMainForm()
        {
            this.Hide(); // Hide the login form
            HomeFormMain mainForm = new HomeFormMain();
            mainForm.ShowDialog(); // Show the main form as a dialog
            this.Close(); // Close the login form after the main form is closed
        }

        private void labelMainLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelMdiParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsBtn_Click(object sender, EventArgs e)
        {

        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {

        }

        private void CartBtn_Click(object sender, EventArgs e)
        {

        }

        private void CatalogBtn_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
