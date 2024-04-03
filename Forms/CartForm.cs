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
using EasyBizPos.DAOS;


namespace EasyBizPos.Forms
{
    public partial class CartForm : Form
    {
        private Cart cart;
        BindingSource cartBindingSource = new BindingSource();
        public CartForm()
        {
            InitializeComponent();
            cart = Cart.Instance;

            UpdateCartDetails();
        }

        private void UpdateCartDetails()
        {
            decimal subtotal = cart.GetCartSubtotal();
            decimal taxRate = Convert.ToDecimal(ConfigManager.Instance.GetSalesTaxRate());
            decimal tax = Math.Round(subtotal * taxRate, 2); 
            decimal totalPrice = subtotal + tax;

            subtotalPrice.Text = subtotal.ToString();
            taxPrice.Text = tax.ToString();
            totalPriceLabel.Text = totalPrice.ToString();

            cart.updateCartListQuantity();

            cartBindingSource.DataSource = cart.getCart();
            dataGridCart.DataSource = cartBindingSource;
        }


        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            cartBindingSource.Clear();
            UpdateCartDetails();
        }
    }
}
