using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBizPos.Models;
using EasyBizPos.DAOS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows;

namespace EasyBizPos.DAOS
{
    internal class TransactionDAO
    {
        private Cart cart;
        string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
        public List<Transaction> GetAllTransaction()
        {
            // start with empty list
            List<Transaction> returnThese = new List<Transaction>();
            // connect to mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            cart = Cart.Instance;
            //MySqlCommand command = new MySqlCommand("SELECT transaction.transaction_id, customerinfo.NAME, transaction.total, transaction.date FROM transaction INNER JOIN customerinfo ON transaction.customer_id = customerinfo.ID"
            using (MySqlCommand command = new MySqlCommand("SELECT transaction.transaction_id, customerinfo.NAME, transaction.total, transaction.date FROM transaction LEFT JOIN customerinfo ON transaction.customer_id=customerinfo.ID", connection))
            {

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Read the data from the database and store it in a list
                    while (reader.Read())
                    {
                        Transaction c = new Transaction
                        {
                            transaction_id = reader.GetInt32(0),
                            customer_name = reader.IsDBNull(1) ? null : reader.GetString(1),  // Check for null before reading customer name
                            total = reader.GetDecimal(2),

                            date = reader.GetDateTime(3),
                        };

                        returnThese.Add(c);

                    }
                }

            }



            connection.Close();
            // return the list of customers
            return returnThese;


        }
        public List<TransactionDetail> GetTransactionDetailsByTransactionId(int transactionId)
        {
            // Start with an empty list to store the transaction details
            List<TransactionDetail> details = new List<TransactionDetail>();

            // Check for valid customer ID
            if (transactionId < 0)
            {
                throw new ArgumentException("Invalid Transaction ID.");
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query
                string query = @"
                SELECT p.product_name, td.quantity, td.price
                FROM transaction_detail td
                INNER JOIN products p ON td.product_id = p.product_id
                WHERE td.transaction_id = @transactionId"; 

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Set the parameter value
                    command.Parameters.AddWithValue("@transactionId", transactionId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Read the data from the database and store it in the list
                        while (reader.Read())
                        {
                            TransactionDetail transactionDetail = new TransactionDetail
                            {
                          
      
                                productName = reader.GetString(0),
                                quantity = reader.GetInt32(1),
                                price = reader.GetDecimal(2)
                            };

                            details.Add(transactionDetail);
                        }
                    }
                }
            }

            // Return the list of transaction details
            return details;
        }

        public void CreateTransaction()
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            cart = Cart.Instance;
            // Assume connectionString is a class-level variable that has been initialized
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                int? customerId = cart.GetCustomerId();
                decimal totalPrice = cart.GetCartTotalPrice();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    if (customerId >= 0) // Assuming 0 is the minimum valid ID.
                    {
                        command.CommandText = "INSERT INTO transaction (customer_id, total, date) VALUES (@customer_id, @total, @currentDate)";
                        command.Parameters.AddWithValue("@customer_id", customerId);
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO transaction (total, date) VALUES (@total, @currentDate)";
                    }

                    command.Parameters.AddWithValue("@total", totalPrice);
                    command.Parameters.AddWithValue("@currentDate", currentDate);

                    // Use a transaction to ensure the operation is atomic.
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        command.Transaction = transaction;
                        try
                        {
                            command.ExecuteNonQuery();

                            // Retrieve the last inserted id (transaction id) and set it in the cart
                            long lastInsertedId = command.LastInsertedId;
                            cart.SetTransactionId(Convert.ToInt32(lastInsertedId));

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            
                            MessageBox.Show("An error occurred: " + ex.Message);
                            transaction.Rollback();
                            // Handle the exception (log it, inform the user, etc.)
                            throw; // Rethrow the exception if you need to propagate it further.
                        }
                    }
                }
                // No need to explicitly call Close when using is present, as it calls Dispose which takes care of closing the connection.
            }
        }
        public void CreateTransactionDetails()
        {
            cart = Cart.Instance;
            int transactionId = cart.GetTransactionId();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            foreach (var item in cart.getCart())
                            {
                                int productId = item.ProductId;
                                int quantity = item.Quantity;
                                decimal price = item.Price;

                                // Insert the transaction detail
                                command.CommandText = "INSERT INTO transaction_detail (transaction_id, product_id, quantity, price) VALUES (@transactionId, @productId, @quantity, @price)";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@transactionId", transactionId);
                                command.Parameters.AddWithValue("@productId", productId);
                                command.Parameters.AddWithValue("@quantity", quantity);
                                command.Parameters.AddWithValue("@price", price);
                                command.ExecuteNonQuery();

                                // Update the stock count
                                command.CommandText = "UPDATE products SET stock = stock - @quantity WHERE product_id = @productId";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@quantity", quantity);
                                command.Parameters.AddWithValue("@productId", productId);
                                command.ExecuteNonQuery();
                            }

                            // Commit transaction after all items are inserted and stock is updated
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // If an error occurs, roll back the transaction
                            transaction.Rollback();
                            MessageBox.Show("An error occurred while creating transaction details: " + ex.Message);
                            throw;
                        }
                    }
                }
            }
        }

        public List<Transaction> GetAllTransactionsByCustomerId(int customerId)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT t.transaction_id, t.total, t.date, c.ID as customer_id, c.NAME as customer_name
                    FROM transaction t
                    LEFT JOIN customerinfo c ON t.customer_id = c.ID
                    WHERE t.customer_id = @customerId";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction
                            {
                                transaction_id = reader.GetInt32(0),
                                total = reader.GetDecimal(1),
                                date = reader.GetDateTime(2),
                                customer_id = reader.IsDBNull(3) ? 0 : reader.GetInt32(3), // Assuming customer_id is an int
                                customer_name = reader.IsDBNull(4) ? null : reader.GetString(4) // Assuming customer_name is a string
                            };

                            transactions.Add(transaction);
                        }

                    }
                }
            }

            return transactions;
        }



    }
}