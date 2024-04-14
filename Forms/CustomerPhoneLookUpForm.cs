using EasyBizPos.DAOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBizPos.Models;

namespace EasyBizPos.Forms
{
    public partial class CustomerPhoneLookUpForm : Form
    {
        private Cart cart;
        private CartForm _cartForm;
        public CustomerPhoneLookUpForm(CartForm cartForm)
        {
            InitializeComponent();
            cart = Cart.Instance;
            _cartForm = cartForm;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            CustomerInformationDAO customerInformationDAO = new CustomerInformationDAO();
            int? customerId = customerInformationDAO.GetCustomerIdByPhoneNumber(phoneNumber);
            string customerName = customerInformationDAO.GetCustomerNameById(customerId);
            if(customerName != null && customerId != null) {
                cart.SetCustomerId(customerId);
                cart.SetCustomerName(customerName);
                _cartForm.UpdateCustomerNameLabel();
                MessageBox.Show("Customer Selected");
                this.Close();
                CheckoutForm checkoutForm = new CheckoutForm(_cartForm);
                checkoutForm.Show();
            }
            else
            {
                MessageBox.Show("Phone Number not found");
            }
           



            

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Customer Selected");
            this.Close();
            CheckoutForm checkoutForm = new CheckoutForm(_cartForm);
            checkoutForm.Show();

        }
    }
}
