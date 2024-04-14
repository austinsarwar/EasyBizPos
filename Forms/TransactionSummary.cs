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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
