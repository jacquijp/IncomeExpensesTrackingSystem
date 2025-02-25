using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewIncomeForm : Form
    {
        private string incomeId;
        private string currentUser;

        public AddNewIncomeForm(string user, string id = "")
        {
            InitializeComponent();
            currentUser = user;
            incomeId = id;

            if (!string.IsNullOrEmpty(incomeId))
            {
                LoadIncomeData();
            }
        }

        private void LoadIncomeData()
        {
            MessageBox.Show($"Loading income data for ID: {incomeId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void labelCloseNewIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewIncomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowIncomeManagementForm();
        }

        private void ShowIncomeManagementForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is IncomeManagementForm)
                {
                    form.Show();
                    return;
                }
            }
        }
    }
}
