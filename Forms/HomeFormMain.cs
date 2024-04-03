using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBizPos.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;


namespace EasyBizPos
{
    public partial class HomeFormMain : Form
    {
        // Binding source connects the database to the datagrid
        BindingSource customerInfoBindingSource = new BindingSource();
        BindingSource employeeInfoBindingSource = new BindingSource();
        private MySqlConnection connection;

        public string ActiveUsername { get; set; }


        public HomeFormMain()
        {
            // starts the form
            InitializeComponent();

            activeUsernameLabel.Text = UserLogin.ActiveUsername;
            // Wire up the logout button click event
            logoutBtn.Click += LogoutBtn_Click;
            adminBtn.Click += AdminBtn_Click;
            

        }

        private void InitializeDatabaseConnection()
        {
            // Connection string for your MySQL database
            string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

            // Create MySqlConnection instance with connection string
            connection = new MySqlConnection(connectionString);
        }

        

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            // Hides the panel
            this.panelMdiParent.Visible = false;
            // Create a new instance of the catalog form
            var catalog = new CatalogForm();
            // Sets the parent form to the main form
            catalog.MdiParent = this;
            // Shows the catalog form 
            catalog.Show();
            // Set the main logo to Catalog
            labelMainLogo.Text = "Catalog";
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            // Hides the panel
            this.panelMdiParent.Visible = false;
            // Creates a new instance of the customer form
            CustomerForm customerForm = new CustomerForm();
            // Sets the parent form to the main form
            customerForm.MdiParent = this;
            // Shows the customer form
            customerForm.Show();
            // Set the main logo to Customer
            labelMainLogo.Text = "Customer";


        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.panelMdiParent.Visible = true;
            // Closes all the child forms
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            // Set the main logo to Home
            labelMainLogo.Text = "Home";
        }

        private void HomeFormMain_Load(object sender, EventArgs e)
        {

        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            this.panelMdiParent.Visible = false;
            CartForm cartForm = new CartForm();
            cartForm.MdiParent = this;
            cartForm.Show();

        }
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            // Hides the panel
            this.panelMdiParent.Visible = false;
            // Creates a new instance of the employee form
            EmployeeForm employeeForm = new EmployeeForm();
            // Sets the parent form to the main form
            employeeForm.MdiParent = this;
            // Shows the employee form
            employeeForm.Show();
            // Set the main logo to Employee
            labelMainLogo.Text = "Login";
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // Reset the active username
            ActiveUsername = string.Empty;

            // Show the login form
            UserLogin loginForm = new UserLogin();
            loginForm.Show();

            // Hide the current form (main form)
            this.Hide();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            // Hides the panel
            this.panelMdiParent.Visible = false;

            // Create a new instance of the Admin form
            AdminForm adminForm = new AdminForm();

            // Sets the parent form to the main form
            adminForm.MdiParent = this;

            // Shows the Admin form
            adminForm.Show();

            // Set the main logo to Admin
            labelMainLogo.Text = "Admin";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
