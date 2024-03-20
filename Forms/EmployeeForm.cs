using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using EasyBizPos.DAOS;
using EasyBizPos.Models;


namespace EasyBizPos.Forms

{
    public partial class EmployeeForm : Form
    {
        BindingSource employeeInfoBindingSource = new BindingSource();

        public EmployeeForm()
        {
            // starts the form
            InitializeComponent();
            // Loads database into the datagrid
            EmployeeInformationDAO employeeInfoDAO = new EmployeeInformationDAO();
            employeeInfoBindingSource.DataSource = employeeInfoDAO.getAllEmployeeInfo();
            dataGridEmployee.DataSource = employeeInfoBindingSource;
        }

        public void refreshDataGrid()
        {
            // Refreshes the datagrid
            EmployeeInformationDAO employeeInfoDAO = new EmployeeInformationDAO();
            employeeInfoBindingSource.DataSource = employeeInfoDAO.getAllEmployeeInfo();
            dataGridEmployee.DataSource = employeeInfoBindingSource;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Searches the database for the employee name
            string searchTerm = searchQuery.Text;
            EmployeeInformationDAO employeeFormInfo = new EmployeeInformationDAO();
            employeeInfoBindingSource.DataSource = employeeFormInfo.searchEmployeeName(searchTerm);
            dataGridEmployee.DataSource = employeeInfoBindingSource;

        }
        private int GetSelectedEmployeeId()
        {
            if (dataGridEmployee.CurrentRow != null)
            {
                return Convert.ToInt32(dataGridEmployee.CurrentRow.Cells[0].Value);
            }
            return -1;
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridEmployee.CurrentCell.RowIndex;
            int columnIndex = 1;
            string name = (string)dataGridEmployee.Rows[rowIndex].Cells[columnIndex].Value;
            int id = (int)dataGridEmployee.Rows[rowIndex].Cells[0].Value;
            try
            {
                int employeeId = GetSelectedEmployeeId();
                if (employeeId != -1)
                {
                    TimeTrackingDAO timeTrackingDao = new TimeTrackingDAO();
                    timeTrackingDao.Clockin(employeeId);
                    MessageBox.Show("Employee clocked in successfully.");
                }
                else
                {
                    MessageBox.Show("Please select an employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clocking in: {ex.Message}");
            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridEmployee.CurrentCell.RowIndex;
            int columnIndex = 1;
            string name = (string)dataGridEmployee.Rows[rowIndex].Cells[columnIndex].Value;
            int id = (int)dataGridEmployee.Rows[rowIndex].Cells[0].Value;
            try
            {
                int employeeId = GetSelectedEmployeeId();
                if (employeeId != -1)
                {
                    TimeTrackingDAO timeTrackingDao = new TimeTrackingDAO();
                    timeTrackingDao.Clockout(employeeId);
                    MessageBox.Show("Employee clocked out successfully.");
                }
                else
                {
                    MessageBox.Show("Please select an employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clocking out: {ex.Message}");
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            refreshDataGrid();



        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridEmployee.CurrentCell.RowIndex;
            int columnIndex = 1;
            string name = (string)dataGridEmployee.Rows[rowIndex].Cells[columnIndex].Value;
            int id = (int)dataGridEmployee.Rows[rowIndex].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee " + name + "?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmployeeInformationDAO employeeInfoDAO = new EmployeeInformationDAO();
                employeeInfoDAO.DeleteEmployee(id);
                employeeInfoBindingSource.DataSource = employeeInfoDAO.getAllEmployeeInfo();
                dataGridEmployee.DataSource = employeeInfoBindingSource;



            }

        }
    }
}
