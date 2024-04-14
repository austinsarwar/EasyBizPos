using EasyBizPos.Models;
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
    public partial class CheckoutForm : Form
    {
        private Cart cart;
        BindingSource cartBindingSource = new BindingSource();
        private CartForm _cartForm;
        public CheckoutForm(CartForm cartForm)
        {
            InitializeComponent();
            cart = Cart.Instance;
            txtEnterCash.Hide();
            btnCompleteTransaction.Hide();
            _cartForm = cartForm;
            UpdateTotal();
            _cartForm = cartForm;
        }

        private void UpdateTotal()
        {
            decimal subtotal = cart.GetCartSubtotal();
            decimal taxRate = Convert.ToDecimal(ConfigManager.Instance.GetSalesTaxRate());
            decimal tax = Math.Round(subtotal * taxRate, 2);
            decimal totalPrice = subtotal + tax;

            totalPriceLabel.Text = totalPrice.ToString();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            txtEnterCash.Show();
            btnCompleteTransaction.Show();
        }

        private void btnCompleteTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amountEntered = Convert.ToDecimal(txtEnterCash.Text);
                if(amountEntered >= cart.GetCartTotalPrice()) {
                    TransactionDAO transaction = new TransactionDAO();
                    transaction.CreateTransaction();
                    transaction.CreateTransactionDetails();
                    decimal changeDue = amountEntered - cart.GetCartTotalPrice();
                    cart.SetChange(changeDue);
                    this.Close();
                    TransactionSummary summary = new TransactionSummary(_cartForm);  
                    summary.Show();


                }else
                {
                    MessageBox.Show("Insufficient amount");
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show("Incorrect input", ex.Message.ToString());

            }
           


        }

        private void txtEnterCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
