using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class EditExpenseForm : Form
    {
        private DataGridViewRow selectedRow; // Stores the selected expense row
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public EditExpenseForm(DataGridViewRow row)
        {
            InitializeComponent();
            selectedRow = row;
            LoadSelectedData(); // Load data from the selected expense
        }

        // Load the selected expense details into the input fields
        private void LoadSelectedData()
        {
            if (selectedRow != null)
            {
                datePickerExpense.Value = Convert.ToDateTime(selectedRow.Cells["colDate"].Value);
                textBoxAmount.Text = selectedRow.Cells["colAmount"].Value.ToString();
                textBoxDescription.Text = selectedRow.Cells["colDescription"].Value.ToString();
            }
        }

        // Save Edited Expense to the Database
        private void btnSaveEditExpense_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string expenseId = selectedRow.Cells["colExpenseID"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Expenses SET ExpenseDate = @Date, Amount = @Amount, Description = @Description WHERE ExpenseID = @ExpenseID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", datePickerExpense.Value);
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(textBoxAmount.Text));
                        cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                        cmd.Parameters.AddWithValue("@ExpenseID", expenseId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Expense updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validate required fields
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                MessageBox.Show("Please enter an amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(textBoxAmount.Text, out _))
            {
                MessageBox.Show("Invalid amount format. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Close the form without saving
        private void btnCancelEditExpense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Close button event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
