using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewIncomeForm : Form
    {
        private string incomeId;

        public AddNewIncomeForm()
        {
            InitializeComponent();
        }

        // Constructor for editing an existing income
        public AddNewIncomeForm(string id)
        {
            InitializeComponent();
            incomeId = id;
            LoadIncomeData(); // Call function to load existing data
        }

        private void LoadIncomeData()
        {
            if (!string.IsNullOrEmpty(incomeId))
            {
                // TODO: Implement logic to fetch and load income details from database
                MessageBox.Show($"Loading income data for ID: {incomeId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            this.Close();
        }

        private void btnCancelIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
