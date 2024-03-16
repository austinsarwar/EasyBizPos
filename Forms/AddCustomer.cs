using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBizPos.DAOS;


namespace EasyBizPos.Forms
{
    public partial class AddCustomer : Form
    {
        BindingSource customerInfoBindingSource = new BindingSource();

        public AddCustomer()
        {
            InitializeComponent();
        }

        
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            // set the customer name, phone number, and email to the textboxes
            string name = nameTxt.Text;
            string phoneNumber = phoneNumberTxt.Text;
            string email = emailTxt.Text;
            // Create a new instance of the CustomerInformationDAO Database Access Object
            CustomerInformationDAO customerInformationDAO = new CustomerInformationDAO();
            // Add the customer info to the database
            customerInformationDAO.AddCustomer(name, phoneNumber, email);
            // Close the form
            this.Close();

        }
    }
}
