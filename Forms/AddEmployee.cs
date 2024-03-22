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


namespace EasyBizPos.Forms
{
    public partial class AddEmployee : Form
    {
        BindingSource employeeInfoBindingSource = new BindingSource();

        public AddEmployee()
        {
            InitializeComponent();
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
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
            string password = HashPassword(passwordBox.Text);
            string[] nameParts = name.Split(' ');
            string firstName = nameParts[0].ToLower();
            string lastName = nameParts.Length > 1 ? nameParts[1].ToLower() : "";
            string username = firstName + lastName; // Combine first and last name into one lowercase string
            int admin = adminCheckBox.Checked ? 1 : 0; // Set admin to 1 if checked, 0 otherwise

            // Create a new instance of the EmployeeInformationDAO Database Access Object
            EmployeeInformationDAO employeeInformationDAO = new EmployeeInformationDAO();

            // Add the employee info to the database
            employeeInformationDAO.AddEmployee(name, role, phoneNumber, email, password, username, admin);

            // Close the form
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
