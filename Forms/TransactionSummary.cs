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
    public partial class TransactionSummary : Form
    {
        private Cart cart;
        private CartForm _cartForm;
        public TransactionSummary(CartForm cartForm)
        {
            InitializeComponent();
            cart = Cart.Instance;
            _cartForm = cartForm;

            labelChange.Text = cart.GetChange().ToString();
            if(cart.GetCustomerName() != null)
            {
                labelCustomerName.Text = cart.GetCustomerName().ToString();
            }
            else
            {
                labelCustomerName.Text = "No Customer Selected";
            }
            
            labelTotal.Text = cart.GetCartTotalPrice().ToString();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _cartForm.btnClearCart_Click(sender, e);

            MessageBox.Show("Cart has been cleared.");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
