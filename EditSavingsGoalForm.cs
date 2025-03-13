using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class EditSavingsGoalForm : Form
    {
        private DataGridViewRow selectedRow; // Store the selected row
        private string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;
        private string savingID; // Store the Saving ID

        public EditSavingsGoalForm(DataGridViewRow row)
        {
            InitializeComponent();
            selectedRow = row;
            LoadSelectedData(); // Load the data when the form opens
        }

        // Load data from the selected row
        private void LoadSelectedData()
        {
            if (selectedRow != null)
            {
                savingID = selectedRow.Cells["colSavingID"].Value?.ToString(); // Retrieve Saving ID
                txtEditSavingConcept.Text = selectedRow.Cells["colConcept"].Value?.ToString() ?? string.Empty;
                txtEditSavingGoal.Text = selectedRow.Cells["colGoal"].Value?.ToString() ?? string.Empty;
                txtEditSavingDeposit.Text = "0"; // Default new deposit to 0
            }
        }

        // Save button click event
        private void btnSaveEditSaving_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtEditSavingConcept.Text) || string.IsNullOrWhiteSpace(txtEditSavingGoal.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate saving goal format
            if (!decimal.TryParse(txtEditSavingGoal.Text, out decimal savingGoal) || savingGoal <= 0)
            {
                MessageBox.Show("Invalid format for Saving Goal. Please enter a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate new deposit (Optional but must be positive)
            decimal newDeposit = 0;
            if (!string.IsNullOrWhiteSpace(txtEditSavingDeposit.Text))
            {
                if (!decimal.TryParse(txtEditSavingDeposit.Text, out newDeposit) || newDeposit < 0)
                {
                    MessageBox.Show("Invalid format for Deposit. Please enter a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Retrieve the current total deposit
                    string getDepositQuery = "SELECT Deposit FROM Savings WHERE SavingID = @SavingID";
                    decimal currentDeposit = 0;

                    using (SqlCommand cmdGet = new SqlCommand(getDepositQuery, conn))
                    {
                        cmdGet.Parameters.AddWithValue("@SavingID", savingID);
                        var result = cmdGet.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentDeposit = Convert.ToDecimal(result);
                        }
                    }

                    // Sum new deposit with existing deposit
                    decimal updatedDeposit = currentDeposit + newDeposit;

                    // Calculate updated progress
                    decimal updatedProgress = (updatedDeposit / savingGoal) * 100;

                    // Update record in database
                    string updateQuery = "UPDATE Savings SET Concept = @Concept, Goal = @Goal, Deposit = @Deposit, Progress = @Progress WHERE SavingID = @SavingID";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@SavingID", savingID);
                        cmdUpdate.Parameters.AddWithValue("@Concept", txtEditSavingConcept.Text);
                        cmdUpdate.Parameters.AddWithValue("@Goal", savingGoal);
                        cmdUpdate.Parameters.AddWithValue("@Deposit", updatedDeposit);
                        cmdUpdate.Parameters.AddWithValue("@Progress", updatedProgress);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Savings goal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating savings goal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelEditSaving_Click(object sender, EventArgs e)
        {
            this.Close(); // Close without saving
        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
