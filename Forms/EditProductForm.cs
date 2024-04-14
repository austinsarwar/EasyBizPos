using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyBizPos.Forms
{
    public partial class EditProductForm : Form
    {
        private int productId;
        private CatalogForm catalogForm;

        public EditProductForm(int id, CatalogForm catalogForm)
        {
            InitializeComponent();
            productId = id;
            this.catalogForm = catalogForm;

            // Populate the form with the product details
            PopulateForm();
        }
        private void PopulateForm()
        {
            // Connection string for MySQL database
            string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

            // Query to fetch product details by ID
            string selectQuery = "SELECT product_name, upc, price, stock FROM products WHERE product_id = @id";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a MySqlCommand object with the select query and connection
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    // Set the parameter in the query
                    command.Parameters.AddWithValue("@id", productId);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the product details
                            productNameTxt.Text = reader.GetString(0);
                            upcText.Text = reader.GetString(1);
                            priceText.Text = reader.GetDecimal(2).ToString();
                            stockText.Text = reader.GetInt32(3).ToString();
                        }
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Connection string for MySQL database
            string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
            // Update query to update product details
            string updateQuery = "UPDATE products SET product_name = @name, upc = @upc, price = @price, stock = @stock WHERE product_id = @id";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a MySqlCommand object with the update query and connection
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    // Set the parameters in the query
                    command.Parameters.AddWithValue("@name", productNameTxt.Text);
                    command.Parameters.AddWithValue("@upc", upcText.Text);
                    command.Parameters.AddWithValue("@price", decimal.Parse(priceText.Text));
                    command.Parameters.AddWithValue("@stock", int.Parse(stockText.Text));
                    command.Parameters.AddWithValue("@id", productId);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the update was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product details updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product details");
                    }
                }
            }

            // Close the form
            this.Close();
        }

        private void EditProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Refresh the CatalogForm after closing the EditProductForm
            catalogForm.RefreshDataGrid();
        }
    }
}
