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
    public partial class AddNewIncomeForm : Form
    {
        private string incomeId;
        public AddNewIncomeForm()
        {
            InitializeComponent();
        }

        public AddNewIncomeForm(string id)
        {
            InitializeComponent();
            incomeId = id;
        }

        private void AddNewIncomeForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(incomeId))
            {
                LoadIncomeData(incomeId);
            }
        }

        private void LoadIncomeData(string id)
        {
            MessageBox.Show($"Loading income data for ID: {id}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
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
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBox_AmountNewIncome.Text))
            {
                MessageBox.Show("Amount is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancelIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
