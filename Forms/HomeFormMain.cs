﻿using System;
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
            this.panelMdiParent.Visible=false;
            CartForm cartForm = new CartForm();
            cartForm.MdiParent = this;
            cartForm.Show();

        }
    }
}
