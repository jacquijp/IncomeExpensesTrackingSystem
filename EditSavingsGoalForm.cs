using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class EditSavingsGoalForm : Form
    {
        private DataGridViewRow selectedRow; // Store the selected row

        // Constructor
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
                txtEditSavingConcept.Text = selectedRow.Cells["colConcept"].Value?.ToString() ?? string.Empty;
                txtEditSavingGoal.Text = selectedRow.Cells["colGoal"].Value?.ToString() ?? string.Empty;
                txtEditSavingDeposit.Text = selectedRow.Cells["colDeposit"].Value?.ToString() ?? string.Empty;
            }
        }

        // Save button click event
        private void btnSaveEditSaving_Click(object sender, EventArgs e)
        {
            // Update the values in the original DataGridViewRow
            selectedRow.Cells["colConcept"].Value = txtEditSavingConcept.Text;
            selectedRow.Cells["colGoal"].Value = txtEditSavingGoal.Text;
            selectedRow.Cells["colDeposit"].Value = txtEditSavingDeposit.Text;

            MessageBox.Show("Savings goal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Close the form after saving
        }

        private void btnCancelEditSaving_Click(object sender, EventArgs e)
        {
            this.Close(); // Close without saving
        }

        private void EditSavingsGoalForm_Load(object sender, EventArgs e)
        {
            
        }

       
        private void label_editSavings_Click(object sender, EventArgs e)
        {
            
        }

       
        private void close_Click_Click(object sender, EventArgs e)
        {
            this.Close(); // x label
        }
    }
}
