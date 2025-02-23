using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewIncomeForm : Form
    {
        public AddNewIncomeForm()
        {
            InitializeComponent();
        }

        private void NewIncomeForm_Load(object sender, EventArgs e)
        {
            // Initialize dropdowns or settings if needed
        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            // Validate fields before saving
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text) || comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Income saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseNewIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
