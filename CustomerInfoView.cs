using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBizPos
{
    public partial class CustomerInfoView : Form
    {
        BindingSource customerInfoBindingSource = new BindingSource();
        
        public CustomerInfoView()
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
            var cat = new CatalogView();
            cat.Show();
            


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
