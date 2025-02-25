using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewIncomeForm : Form
    {
        private string incomeId;
        private string currentUser;

        // Constructor
        public AddNewIncomeForm(string user, string id = "")
        {
            InitializeComponent();
            this.FormClosing += AddNewIncomeForm_FormClosing;
            currentUser = user;
            incomeId = id;

            if (!string.IsNullOrEmpty(incomeId))
            {
                LoadIncomeData(); // Load data if editing an existing income
            }
        }

        private void LoadIncomeData()
        {
            // Simulated loading income data from a database
            MessageBox.Show($"Loading income data for ID: {incomeId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(incomeId))
            {
                MessageBox.Show("New income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Income ID {incomeId} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CloseAndReturnToIncomeManagement();
        }

        private void btnCancelIncome_Click(object sender, EventArgs e)
        {
            CloseAndReturnToIncomeManagement();
        }

        private void labelCloseNewIncome_Click(object sender, EventArgs e)
        {
            CloseAndReturnToIncomeManagement();
        }

        private void AddNewIncomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAndReturnToIncomeManagement();
        }

        // Function to ensure consistency when closing the form
        private void CloseAndReturnToIncomeManagement()
        {
            this.Hide();
            IncomeManagementForm incomeForm = new IncomeManagementForm(currentUser);
            incomeForm.Show();
        }
    }
}
