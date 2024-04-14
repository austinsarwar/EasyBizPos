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
using MySql.Data.MySqlClient;




namespace EasyBizPos
{
    public partial class CatalogForm : Form
    {
        // creates a connection between the database and the Catalog datagrid
        BindingSource catalogBindingSource = new BindingSource();
        // instance of the cart class;
        private Cart cart;
        private MySqlConnection connection;

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

        private void CartIcon_Click(object sender, EventArgs e)
        {

        }

        private void labelCartCounter_Click(object sender, EventArgs e)
        {

        }

        private void AddToCatalogue_click(object sender, EventArgs e)
        {
            AddNewProduct addNewProductForm = new AddNewProduct();
            addNewProductForm.ShowDialog();
        }

        private void editEntry_Click(object sender, EventArgs e)
        {
            // Get the ID of the highlighted item
            int highlightedItemId = GetHighlightedItemId();

            // Create an instance of the edit form, passing a reference to this CatalogForm instance
            EditProductForm editProductForm = new EditProductForm(highlightedItemId, this);

            // Display the edit form as a dialog
            if (editProductForm.ShowDialog() == DialogResult.OK)
            {
                // The data grid should already be updated by the FormClosed event handler
            }
        }

        public void RefreshDataGrid()
        {
            // Refresh the data grid to reflect the latest changes
            CatalogDAO catalogDAO = new CatalogDAO();
            catalogBindingSource.DataSource = catalogDAO.getAllCatalog();
            dataGridCart.DataSource = catalogBindingSource;

            // Refresh the DataGridView
            dataGridCart.Refresh();
        }








        private int GetHighlightedItemId()
        {
            // Get the index of the current cell
            int rowIndex = dataGridCart.CurrentCell.RowIndex;

            // Get the value of the ID cell in the current row
            int itemId = (int)dataGridCart.Rows[rowIndex].Cells[0].Value;

            return itemId;
        }





    }
}
