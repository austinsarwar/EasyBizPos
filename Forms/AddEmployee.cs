using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBizPos.DAOS;
using System.Security.Cryptography;
using BCrypt;


namespace EasyBizPos.Forms
{
    public partial class AddEmployee : Form
    {
        BindingSource employeeInfoBindingSource = new BindingSource();

        public AddEmployee()
        {
            InitializeComponent();
        }

        public (string hashedPassword, string salt) HashPassword(string password)
        {
            // Generate a salt
            string salt = BCrypt.Net.BCrypt.GenerateSalt(12);

            // Hash the password with the salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return (hashedPassword, salt);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            // Check if the passwords match
            if (passwordBox.Text != reenterBox.Text)
            {
                MessageBox.Show("Passwords must match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Set the employee name, role, phone number, and email to the textboxes
            string name = nameTxt.Text;
            string role = roleTxt.Text;
            string phoneNumber = phoneNumberTxt.Text;
            string email = emailTxt.Text;
            (string hashedPassword, string salt) = HashPassword(passwordBox.Text);
            string[] nameParts = name.Split(' ');
            string firstName = nameParts[0].ToLower();
            string lastName = nameParts.Length > 1 ? nameParts[1].ToLower() : "";
            string username = firstName + lastName; // Combine first and last name into one lowercase string
            int admin = adminCheckBox.Checked ? 1 : 0; // Set admin to 1 if checked, 0 otherwise

            // Create a new instance of the EmployeeInformationDAO Database Access Object
            EmployeeInformationDAO employeeInformationDAO = new EmployeeInformationDAO();

            // Add the employee info to the database
            employeeInformationDAO.AddEmployee(name, role, phoneNumber, email, hashedPassword, username, admin, salt);

            // Close the form
            this.Close();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
