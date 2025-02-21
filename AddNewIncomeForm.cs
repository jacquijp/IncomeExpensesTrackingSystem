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
        private string incomeId; // Para editar un ingreso existente

        // New income
        public AddNewIncomeForm()
        {
            InitializeComponent();
        }

        // edit existing income
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

        private void btnSave_Click(object sender, EventArgs e)
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
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
