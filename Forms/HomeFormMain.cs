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

namespace EasyBizPos
{
    public partial class HomeFormMain : Form
    {
        BindingSource customerInfoBindingSource = new BindingSource();
        
        
        public HomeFormMain()
        {
            // starts the form
            InitializeComponent();
           

        }


        

        

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            // Opens the catalog form
            var cat = new CatalogForm();
            cat.MdiParent = this;
            cat.Show();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            // Opens the customer form 
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();

           
        }
    }
}
