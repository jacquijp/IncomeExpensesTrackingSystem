using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class EditIncomeForm : Form
    {
        private DataGridViewRow selectedRow; // Store the selected income row

        // Constructor receiving the selected row from Income Management
        public EditIncomeForm(DataGridViewRow row)
        {
            InitializeComponent();
            selectedRow = row;
            LoadSelectedData(); // Load data from the selected row
        }

        // Load the selected income details into the input fields
        private void LoadSelectedData()
        {
            if (selectedRow != null)
            {
                datePickerIncome.Value = Convert.ToDateTime(selectedRow.Cells["colDate"].Value);
                textBoxAmountIncome.Text = selectedRow.Cells["colAmount"].Value.ToString();
                textBoxDescriptionIncome.Text = selectedRow.Cells["colDescription"].Value.ToString();
            }
        }

        // Save Edited Income
        private void btnSaveEditIncome_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                selectedRow.Cells["colDate"].Value = datePickerIncome.Value.ToShortDateString();
                selectedRow.Cells["colAmount"].Value = textBoxAmountIncome.Text;
                selectedRow.Cells["colDescription"].Value = textBoxDescriptionIncome.Text;

                MessageBox.Show("Income updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Validate required fields
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxAmountIncome.Text))
            {
                MessageBox.Show("Please enter an amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Close the form without saving
        private void btnCancelEditIncome_Click(object sender, EventArgs e)
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
