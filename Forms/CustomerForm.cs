using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using EasyBizPos.DAOS;
using EasyBizPos.Models;
namespace EasyBizPos.Forms

{
    public partial class CustomerForm : Form
    {
        BindingSource customerInfoBindingSource = new BindingSource();
        private Cart cart;

        public CustomerForm()
        {
            // starts the form
            InitializeComponent();
            // Loads database into the datagrid
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.getAllCustomerInfo();
            dataGridCustomer.DataSource = customerInfoBindingSource;
            cart = Cart.Instance;
        }

     
        public void refreshDataGrid()
        {
            // Refreshes the datagrid
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.getAllCustomerInfo();
            dataGridCustomer.DataSource = customerInfoBindingSource;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Searches the database for the customer name
            string searchTerm = searchQuery.Text;
            CustomerInformationDAO customerFormInfo = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerFormInfo.searchCustomerName(searchTerm);
            dataGridCustomer.DataSource = customerInfoBindingSource;

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            refreshDataGrid();



        }

     

     

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridCustomer.CurrentCell.RowIndex;
            int columnIndex = 1;
            string name = (string)dataGridCustomer.Rows[rowIndex].Cells[columnIndex].Value;
            int id = (int)dataGridCustomer.Rows[rowIndex].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer " + name + "?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
                customerInfoDAO.DeleteCustomer(id);
                customerInfoBindingSource.DataSource = customerInfoDAO.getAllCustomerInfo();
                dataGridCustomer.DataSource = customerInfoBindingSource;



            }

        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridCustomer.CurrentCell.RowIndex;
            int customerId = (int)dataGridCustomer.Rows[rowIndex].Cells[0].Value;
            string name = (string)dataGridCustomer.Rows[rowIndex].Cells[1].Value;

            cart.SetCustomerId(customerId);
            cart.SetCustomerName(name);
            MessageBox.Show($"{name} Selected for transaction");
        }
    }
}
