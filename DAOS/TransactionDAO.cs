using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBizPos.Models;
using EasyBizPos.DAOS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            using (MySqlCommand command = new MySqlCommand("SELECT transaction.transaction_id, customerinfo.NAME, transaction.total, transaction.date  FROM transaction INNER JOIN customerinfo ON transaction.customer_id=customerinfo.ID", connection))
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

    }
}