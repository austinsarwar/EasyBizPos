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
    public partial class TransactionForm : Form
    {
        BindingSource transactionBindingSource = new BindingSource();
        TransactionDAO transactionInfoDAO = new TransactionDAO();
        public TransactionForm()
        {
            InitializeComponent();
            
            transactionBindingSource.DataSource = transactionInfoDAO.GetAllTransaction();
            dataGridTransaction.DataSource = transactionBindingSource;

            dataGridTransaction.Columns["transaction_id"].Visible = false;
            dataGridTransaction.Columns["customer_id"].Visible = false;

        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {

            // Ensure a row is selected
            if (dataGridTransaction.CurrentRow == null || dataGridTransaction.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a transaction from the grid.");
                return; // Exit the method if no row is selected
            }

            int rowIndex = dataGridTransaction.CurrentCell.RowIndex;
            int transactionId = (int)dataGridTransaction.Rows[rowIndex].Cells[0].Value;

            // Assuming transactionInfoDAO is correctly instantiated somewhere as an instance of TransactionInfoDAO
            transactionBindingSource.DataSource = transactionInfoDAO.GetTransactionDetailsByTransactionId(transactionId);
            dataGridTransaction.DataSource = transactionBindingSource;

            // Hiding specific columns
            dataGridTransaction.Columns["transactionDetailId"].Visible = false;
            dataGridTransaction.Columns["transactionId"].Visible = false;
            dataGridTransaction.Columns["productId"].Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            transactionBindingSource.DataSource = transactionInfoDAO.GetAllTransaction();
            dataGridTransaction.DataSource = transactionBindingSource;
            dataGridTransaction.Columns["customer_id"].Visible = false;

            dataGridTransaction.Columns["transaction_id"].Visible = false;
        }
    }
}
