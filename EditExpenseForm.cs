using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class EditExpenseForm : Form
    {
        private DataGridViewRow selectedRow; // Store the selected expense

        // Constructor that receives the selected row from the Expense Management table
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

        // Save Edited Expense
        private void btnSaveEditExpense_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                selectedRow.Cells["colDate"].Value = datePickerExpense.Value.ToShortDateString();
                selectedRow.Cells["colAmount"].Value = textBoxAmount.Text;
                selectedRow.Cells["colDescription"].Value = textBoxDescription.Text;

                MessageBox.Show("Expense updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
