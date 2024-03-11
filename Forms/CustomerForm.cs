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
namespace EasyBizPos.Forms
{
    public partial class CustomerForm : Form
    {
        BindingSource customerInfoBindingSource = new BindingSource();

        public CustomerForm()
        {
            // starts the form
            InitializeComponent();
            // Loads database into the datagrid
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.getAllCustomerInfo();
            CustomerDataGrid.DataSource = customerInfoBindingSource;
        }

     
     

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Searches the database for the customer name
            string searchTerm = searchQuery.Text;
            CustomerInformationDAO customerFormInfo = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerFormInfo.searchCustomerName(searchTerm);
            CustomerDataGrid.DataSource = customerInfoBindingSource;

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();

        }
    }
}
