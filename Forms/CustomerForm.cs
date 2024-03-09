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
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

      
        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.getAllCustomerInfo();
            CustomerDataGrid.DataSource = customerInfoBindingSource;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchQuery.Text;
            CustomerInformationDAO customerFormInfo = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerFormInfo.searchCustomerName(searchTerm);
            CustomerDataGrid.DataSource = customerInfoBindingSource;

        }
    }
}
