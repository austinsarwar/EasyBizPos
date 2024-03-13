using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBizPos
{
    public partial class CatalogForm : Form
    {
        // creates a connection between the database and the Catalog datagrid
        BindingSource catalogBindingSource = new BindingSource();

        // Counter for the cart
        int cartCounter = 0;
        public CatalogForm()
        {
            // starts the form
            InitializeComponent();
            // Loads database into the datagrid
            CatalogDAO catalogDAO = new CatalogDAO();
            // Retrieves the data from the catalog table
            catalogBindingSource.DataSource = catalogDAO.getAllCatalog();
            //  Sets the datagrid to the database
            dataGridCatalog.DataSource = catalogBindingSource;
        }

       

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
           // Updates the cart counter
            cartCounter++;
           // Updates the cart counter label
            labelCartCounter.Text = cartCounter.ToString();
        }
    }
}
