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
        // Binding source connects the database to the datagrid
        BindingSource customerInfoBindingSource = new BindingSource();
        
        
        public HomeFormMain()
        {
            // starts the form
            InitializeComponent();

            // Loads database into the datagrid
            foreach (Control ctrl in this.Controls)
            {
                // Set the background color of the mdi parent form
                Color mdiParentColor = Color.FromArgb(34, 34, 74);
                // If the control is a MdiClient
                if (ctrl is MdiClient)
                {
                    // Set the background color of the mdi parent form  
                    ctrl.BackColor = mdiParentColor; // Or any other color

                    break;
                }
            }


        }


        

        

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
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
            // Opens the customer form 
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
                // Closes all the child forms
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            // Set the main logo to Home
            labelMainLogo.Text = "Home";
        }
    }
}
