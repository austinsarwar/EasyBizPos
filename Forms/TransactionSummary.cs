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
namespace EasyBizPos.Forms
{
    public partial class TransactionSummary : Form
    {
        private Cart cart;
        public TransactionSummary()
        {
            InitializeComponent();
            cart = Cart.Instance;
            labelChange.Text = cart.GetChange().ToString();
            labelCustomerName.Text = cart.GetCustomerName().ToString(); 
            labelTotal.Text = cart.GetCartTotalPrice().ToString();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cart.Clear();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
