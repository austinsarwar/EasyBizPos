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
        public CheckoutForm()
        {
            InitializeComponent();
            cart = Cart.Instance;
            txtEnterCash.Hide();

            UpdateTotal();
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
                    TransactionSummary summary = new TransactionSummary();  
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
