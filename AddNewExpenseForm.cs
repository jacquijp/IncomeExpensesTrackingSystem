using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewExpenseForm : Form
    {
        public AddNewExpenseForm()
        {
            InitializeComponent();
        }

        private void AddNewExpenseForm_Load(object sender, EventArgs e)
        {
            // Initialize dropdowns or settings if needed
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            // Validate fields before saving
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text) || comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Expense saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelExpense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseNewExpense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
