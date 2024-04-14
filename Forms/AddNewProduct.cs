using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyBizPos.Forms
{
    public partial class AddNewProduct : Form
    {
        private readonly MySqlConnection connection;
        string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

        public AddNewProduct()
        {
            InitializeComponent();

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(productNameTxt.Text) ||
                string.IsNullOrWhiteSpace(upcText.Text) ||
                !decimal.TryParse(priceText.Text, out decimal price) ||
                !decimal.TryParse(stockText.Text, out decimal stock))
            {
                MessageBox.Show("Please enter valid inputs for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check if item already exists
            string query = "SELECT COUNT(*) FROM products WHERE upc = @upc";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@upc", upcText.Text); // Convert upc to string
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Item already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Insert new item
            query = "INSERT INTO products (product_name, upc, price, stock) VALUES (@name, @upc, @price, @stock)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", productNameTxt.Text);
                cmd.Parameters.AddWithValue("@upc", upcText.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void AddNewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
