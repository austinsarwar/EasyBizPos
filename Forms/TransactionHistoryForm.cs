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
using EasyBizPos.Models;

namespace EasyBizPos.Forms
{
    public partial class TransactionHistoryForm : Form
    {
        private int customerId;
        TransactionDAO transactionInfoDAO = new TransactionDAO();
        BindingSource transacationBindingSource = new BindingSource();
        public TransactionHistoryForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            TransactionDAO transactionDAO = new TransactionDAO();
            var transactions = transactionDAO.GetAllTransactionsByCustomerId(customerId);

            transacationBindingSource.DataSource = transactions;

            dataGridTransaction.DataSource = transacationBindingSource;
            dataGridTransaction.Columns["customer_id"].Visible = false;

            dataGridTransaction.Columns["transaction_id"].Visible = false;
        }


        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            // You can customize the appearance or behavior of the form when it loads
            // For example, you can set the form title to include the customer's name
            string customerName = GetCustomerNameById(customerId);
            this.Text = $"Transaction History for {customerName}";
        }

        private string GetCustomerNameById(int customerId)
        {
            // You can implement a method to fetch the customer's name from the database
            // For now, we'll just return a placeholder string
            return "Customer Name";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close the current form
            LoadTransactionHistory();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            TransactionDAO transactionDAO = new TransactionDAO();
            int rowIndex = dataGridTransaction.CurrentCell.RowIndex;
            int transactionId = (int)dataGridTransaction.Rows[rowIndex].Cells[0].Value;

            transacationBindingSource.DataSource = transactionInfoDAO.GetTransactionDetailsByTransactionId(transactionId);
            dataGridTransaction.DataSource = transacationBindingSource;
            dataGridTransaction.Columns["transactionDetailId"].Visible = false;
            dataGridTransaction.Columns["transactionId"].Visible = false;

            dataGridTransaction.Columns["productId"].Visible = false;
           
        }

    }
}
