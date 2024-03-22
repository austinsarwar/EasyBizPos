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
    public partial class EmployeeForm : Form
    {
        BindingSource employeeInfoBindingSource = new BindingSource();

        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            EmployeeInformationDAO employeeInfoDAO = new EmployeeInformationDAO();
            employeeInfoBindingSource.DataSource = employeeInfoDAO.getAllEmployeeInfo();
            dataGridEmployee.DataSource = employeeInfoBindingSource;

            SetupDataGridColumns();
        }

        private void SetupDataGridColumns()
        {
            dataGridEmployee.AutoGenerateColumns = false;
            dataGridEmployee.Columns.Clear(); // Clear existing columns

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Employee_ID";
            idColumn.HeaderText = "Employee ID";
            dataGridEmployee.Columns.Add(idColumn);

            DataGridViewColumn usernameColumn = new DataGridViewTextBoxColumn();
            usernameColumn.DataPropertyName = "Username";
            usernameColumn.HeaderText = "Username";
            dataGridEmployee.Columns.Add(usernameColumn);

            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dataGridEmployee.Columns.Add(nameColumn);

            DataGridViewColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.DataPropertyName = "Role";
            roleColumn.HeaderText = "Role";
            dataGridEmployee.Columns.Add(roleColumn);

            DataGridViewColumn phoneNumberColumn = new DataGridViewTextBoxColumn();
            phoneNumberColumn.DataPropertyName = "PhoneNumber";
            phoneNumberColumn.HeaderText = "Phone Number";
            dataGridEmployee.Columns.Add(phoneNumberColumn);

            DataGridViewColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";
            dataGridEmployee.Columns.Add(emailColumn);

            DataGridViewColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.DataPropertyName = "Admin";
            adminColumn.HeaderText = "Admin";
            dataGridEmployee.Columns.Add(adminColumn);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
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
            var selectedEmployee = (Employee)employeeInfoBindingSource.List[rowIndex];
            string name = selectedEmployee.Name;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee " + name + "?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmployeeInformationDAO employeeInfoDAO = new EmployeeInformationDAO();
                employeeInfoDAO.DeleteEmployee(selectedEmployee.Employee_ID);
                refreshDataGrid();
            }
        }


        private void refreshDataGrid()
        {
            EmployeeInformationDAO employeeInfoDAO = new EmployeeInformationDAO();
            employeeInfoBindingSource.DataSource = employeeInfoDAO.getAllEmployeeInfo();
            dataGridEmployee.DataSource = employeeInfoBindingSource;
        }
    }
}
