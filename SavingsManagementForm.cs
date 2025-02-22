using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncomeExpensesTrackingSystem;

namespace IncomeExpensesTrackingSystem
{
    public partial class SavingsManagementForm : Form
    {
        public SavingsManagementForm()
        {
            InitializeComponent();
            LoadSavingsData(); // Load initial savings data into the DataGridView
        }

        private void LoadSavingsData()
        {
            // Testing: Load sample savings data
            dataGridSavings.Rows.Add("1", "Vacation", "2024-01-01", "5000", "1000", "USD", "20%");
            dataGridSavings.Rows.Add("2", "New Car", "2024-02-15", "15000", "3000", "USD", "20%");
            dataGridSavings.Rows.Add("3", "Emergency Fund", "2023-10-10", "10000", "2500", "USD", "25%");
        }

        private void btnAddNewSaving_Click(object sender, EventArgs e)
        {
            AddNewSavingsGoalForm newSavingForm = new AddNewSavingsGoalForm();
            newSavingForm.ShowDialog();
        }

        private void btnEditSavings_Click(object sender, EventArgs e)
        {
            if (dataGridSavings.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridSavings.SelectedRows[0];

                // Open the EditSavingsGoalForm and pass the selected row
                EditSavingsGoalForm editForm = new EditSavingsGoalForm(selectedRow);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a savings goal to edit.", "Edit Savings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteSavings_Click(object sender, EventArgs e)
        {
            if (dataGridSavings.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this savings goal?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    dataGridSavings.Rows.RemoveAt(dataGridSavings.SelectedRows[0].Index);
                    MessageBox.Show("Savings goal deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a savings goal to delete.", "Delete Savings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportSavings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exporting to Excel... (Functionality to be implemented)", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridSavings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridSavings_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
