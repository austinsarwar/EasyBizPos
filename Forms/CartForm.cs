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
using MySql.Data.MySqlClient;


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
            if(cart.GetCustomerName() != null)
            {
                labelCustomerName.Text = cart.GetCustomerName();
            }
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
            taxRateLabel.Text = taxRate.ToString();
            labelCustomerName.Text = "No Customer Selected";
            cart.updateCartListQuantity();

            cartBindingSource.DataSource = cart.getCart();

            // Reset the DataSource of the DataGridView
            dataGridCart.DataSource = null;
            dataGridCart.DataSource = cartBindingSource;
        }




        public void btnClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            cartBindingSource.Clear();
            UpdateCartDetails();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CustomerPhoneLookUpForm customerLookUp = new CustomerPhoneLookUpForm(this);
            if(cart.GetCustomerId() < 0 ) {
                
               
                customerLookUp.Show();
            }
            else
            {
                
                CheckoutForm form = new CheckoutForm(this);
                form.Show();
            }
        }
        public void UpdateCustomerNameLabel()
        {
            if (cart.GetCustomerName() != null)
            {
                labelCustomerName.Text = cart.GetCustomerName();
            }
           
        }

        private void upcEnterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string upc = upcEnterBox.Text;
                if (string.IsNullOrWhiteSpace(upc))
                {
                    MessageBox.Show("Please enter a UPC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Establish a new MySqlConnection
                string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        // Search for the product in the database
                        string query = "SELECT * FROM products WHERE UPC = @upc";
                        using (var cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@upc", upc);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Product found, add it to the cart
                                    int id = reader.GetInt32("product_id");
                                    string name = reader.GetString("product_name");
                                    decimal price = reader.GetDecimal("price");
                                    int stock = reader.GetInt32("stock");

                                    CartItem cartItem = new CartItem(id, name, price);
                                    cart.Add(cartItem);
                                    UpdateCartDetails();
                                    // Refresh DataGridView
                                    dataGridCart.Refresh();
                                }
                                else
                                {
                                    // Product not found
                                    MessageBox.Show("UPC not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Reset the UPC text box and set focus to it
                upcEnterBox.Text = "";
                upcEnterBox.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
