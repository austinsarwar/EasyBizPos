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
        BindingSource catalogBindingSource = new BindingSource();
        public CatalogForm()
        {
            // starts the form
            InitializeComponent();
            // Loads database into the datagrid
            CatalogDAO catalogDAO = new CatalogDAO();
            catalogBindingSource.DataSource = catalogDAO.getAllCatalog();
            catalogView.DataSource = catalogBindingSource;
        }

    
    }
}
