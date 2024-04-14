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
        BindingSource transacationBindingSource = new BindingSource();
        TransactionDAO transactionInfoDAO = new TransactionDAO();
        public TransactionForm()
        {
            InitializeComponent();
            
            transacationBindingSource.DataSource = transactionInfoDAO.GetAllTransaction();
            dataGridTransaction.DataSource = transacationBindingSource;

            dataGridTransaction.Columns["transaction_id"].Visible = false;
            dataGridTransaction.Columns["customer_id"].Visible = false;

        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridTransaction.CurrentCell.RowIndex;
            int transactionId = (int)dataGridTransaction.Rows[rowIndex].Cells[0].Value;
            transacationBindingSource.DataSource = transactionInfoDAO.GetTransactionDetailsByTransactionId(transactionId);
            dataGridTransaction.DataSource = transacationBindingSource;
           
            dataGridTransaction.Columns["transactionDetailId"].Visible = false;
            dataGridTransaction.Columns["transactionId"].Visible = false;

            dataGridTransaction.Columns["productId"].Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            transacationBindingSource.DataSource = transactionInfoDAO.GetAllTransaction();
            dataGridTransaction.DataSource = transacationBindingSource;
            dataGridTransaction.Columns["customer_id"].Visible = false;

            dataGridTransaction.Columns["transaction_id"].Visible = false;
        }
    }
}
