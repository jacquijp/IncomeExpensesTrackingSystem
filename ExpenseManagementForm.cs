using System;
using System.Data;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class ExpenseManagementForm : Form
    {
        public ExpenseManagementForm()
        {
            InitializeComponent();
        }

        // Form Load Event
        private void ExpenseManagementForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        // Close the Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load expense data into the DataGridView
        private void LoadExpenses()
        {
            // Simulated data for testing
            dataGridExpenses.Rows.Clear();
            dataGridExpenses.Rows.Add(false, "1", "2024-02-20", "Groceries", "50.00", "USD", "Weekly grocery shopping");
            dataGridExpenses.Rows.Add(false, "2", "2024-02-18", "Transport", "15.00", "USD", "Bus ticket for the week");
        }

        // Add New Expense
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddNewExpenseForm addExpense = new AddNewExpenseForm();
            addExpense.ShowDialog();
            LoadExpenses(); // Refresh data after adding a new expense
        }

        // Edit Selected Expense
        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dataGridExpenses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridExpenses.SelectedRows[0];
                EditExpenseForm editExpense = new EditExpenseForm(selectedRow);
                editExpense.ShowDialog();
                LoadExpenses(); // Refresh data after editing
            }
            else
            {
                MessageBox.Show("Please select an expense to edit.", "Edit Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Selected Expense
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dataGridExpenses.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    dataGridExpenses.Rows.RemoveAt(dataGridExpenses.SelectedRows[0].Index);
                    MessageBox.Show("Expense deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.", "Delete Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Export Expenses
        private void btnExportExpenses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exporting to Excel... (Functionality to be implemented)", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
