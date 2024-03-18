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
    public partial class PreviewCartForm : Form
    {
        private Cart cart;
        BindingSource cartBindingSource = new BindingSource();
        public PreviewCartForm()
        {

            InitializeComponent();
            cart = Cart.Instance;
            cart.updateCartListQuantity();

            cartBindingSource.DataSource = cart.getCart();
            dataGridCartPreview.DataSource = cartBindingSource;
            

        }
    }
}
