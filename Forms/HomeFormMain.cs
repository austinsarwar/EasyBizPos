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
            InitializeComponent();
           

        }


        

        private void CatalogClick(object sender, EventArgs e)
        {
            var cat = new CatalogForm();
            cat.MdiParent = this;
            cat.Show();
        }

      
        

        private void CatalogBtn_Click(object sender, EventArgs e)
        {

        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();
        }
    }
}
