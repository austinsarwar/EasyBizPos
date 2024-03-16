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
using EasyBizPos.Forms;




namespace EasyBizPos
{
    public partial class CatalogForm : Form
    {
        // creates a connection between the database and the Catalog datagrid
        BindingSource catalogBindingSource = new BindingSource();
        // instance of the cart class;
        private Cart cart;
        // Counter for the cart
        
    

        public CatalogForm()
        {
            // starts the form
            InitializeComponent();
            // access Singleton instance
            cart = Cart.Instance;
            // Loads database into the datagrid
            CatalogDAO catalogDAO = new CatalogDAO();
            // Retrieves the data from the catalog table
            catalogBindingSource.DataSource = catalogDAO.getAllCatalog();
            //  Sets the datagrid to the database
            dataGridCart.DataSource = catalogBindingSource;
            labelCartCounter.Text = cart.getCartItemCount().ToString();

        }

       

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
           
            int rowIndex = dataGridCart.CurrentCell.RowIndex;
            int id = (int)dataGridCart.Rows[rowIndex].Cells[0].Value;
            string name = (string)dataGridCart.Rows[rowIndex].Cells[1].Value;
            decimal price = (decimal)dataGridCart.Rows[rowIndex].Cells[2].Value;
           
            CartItem cartItem = new CartItem(id, name, price);
            cart.Add(cartItem);
            ToastSuccessForm toastSuccess  = new ToastSuccessForm();    
            toastSuccess.Show();
            
            
            






            // Updates the cart counter
            cart.incrementCartItemCount();
           // Updates the cart counter label
            labelCartCounter.Text = cart.getCartItemCount().ToString();
           
        }

        private void btnCartPreview_Click(object sender, EventArgs e)
        {

            // Try to find an open instance of the CartPreview form
            Form cartPreview = Application.OpenForms["CartPreview"];

            if (cartPreview != null)
            {
                // If found, bring it to the front
                cartPreview.BringToFront();
            }
            else
            {
                // If not found, create and show a new instance
                cartPreview = new PreviewCartForm();
                cartPreview.Name = "CartPreview"; // Make sure to set the Name property of the CartPreview form in its constructor or designer
                cartPreview.Show();
            }






        }
    }
}
