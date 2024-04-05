using EasyBizPos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBizPos.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void changeTaxRate_Click(object sender, EventArgs e)
        {

            // Check if the current user is an admin
            if (!UserLogin.IsUserAdmin())
            {
                MessageBox.Show("You do not have permission to change the tax rate.", "Access Denied");
                return;
            }


            // Read the current tax rate from the JSON file
            double currentTaxRate = ConfigManager.Instance.GetSalesTaxRate();

            // Display the current tax rate in a message box
            MessageBox.Show("Current Tax Rate: " + currentTaxRate.ToString(), "Change Tax Rate");

            // Prompt the user to enter a new tax rate
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new tax rate (decimal between 0.00 and 1.00):", "Change Tax Rate");

            // Parse the input as a decimal
            if (decimal.TryParse(input, out decimal newTaxRate))
            {
                // Validate the new tax rate
                if (newTaxRate >= 0.00m && newTaxRate <= 1.00m)
                {
                    // Set the new tax rate
                    ConfigManager.Instance.SetSalesTaxRate(Convert.ToDouble(newTaxRate));
                    // For simplicity, we'll just display a message box here
                    MessageBox.Show("Tax rate changed successfully to " + newTaxRate.ToString(), "Change Tax Rate");
                }
                else
                {
                    MessageBox.Show("Invalid tax rate. Please enter a decimal between 0.00 and 1.00.", "Change Tax Rate");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid decimal.", "Change Tax Rate");
            }
        }
    }
}
