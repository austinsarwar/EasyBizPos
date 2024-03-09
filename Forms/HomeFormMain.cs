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

namespace EasyBizPos
{
    public partial class HomeFormMain : Form
    {
        BindingSource customerInfoBindingSource = new BindingSource();
        
        
        public HomeFormMain()
        {
            InitializeComponent();
           

        }


        private void Refresh(object sender, EventArgs e)
        {
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.getAllCustomerInfo();
            customerView.DataSource = customerInfoBindingSource;
           

            


        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            var cat = new CatalogForm();
            cat.Show();
            


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.searchCustomerName(SearchText.Text);
            customerView.DataSource = customerInfoBindingSource;



        }

        private void customerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerInfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var cat = new CatalogForm();
            cat.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.searchCustomerName(SearchText.Text);
            customerView.DataSource = customerInfoBindingSource;

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            CustomerInformationDAO customerInfoDAO = new CustomerInformationDAO();
            customerInfoBindingSource.DataSource = customerInfoDAO.searchCustomerName(SearchText.Text);
            customerView.DataSource = customerInfoBindingSource;


        }

        private void CustomerInfoView_Load(object sender, EventArgs e)
        {

        }
    }
}
