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
    public partial class AddEmployee : Form
    {
        BindingSource employeeInfoBindingSource = new BindingSource();

        public AddEmployee()
        {
            InitializeComponent();
        }

        
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            // set the employee name, role, phone number, and email to the textboxes
            string name = nameTxt.Text;
            string role = roleTxt.Text;
            string phoneNumber = phoneNumberTxt.Text;
            string email = emailTxt.Text;
            // Create a new instance of the EmployeeInformationDAO Database Access Object
            EmployeeInformationDAO employeeInformationDAO = new EmployeeInformationDAO();
            // Add the employee info to the database
            employeeInformationDAO.AddEmployee(name, role, phoneNumber, email);
            // Close the form
            this.Close();

        }
    }
}
