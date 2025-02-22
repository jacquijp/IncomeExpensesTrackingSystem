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
        private DataGridViewRow selectedRow;

        public EditSavingsGoalForm(DataGridViewRow row)
        {
            InitializeComponent();
            selectedRow = row;
            LoadData();
        }

        private void LoadData()
        {
            // Load selected data into the text fields
            txtEditSavingConcept.Text = selectedRow.Cells["colConcept"].Value.ToString();
            txtEditSavingGoal.Text = selectedRow.Cells["colGoal"].Value.ToString();
            txtEditSavingDeposit.Text = selectedRow.Cells["colDeposit"].Value.ToString();
        }


    private void label_editSavings_Click(object sender, EventArgs e)
        {

        }

        private void close_Click_Click(object sender, EventArgs e)
        {

        }

        private void EditSavingsGoalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveEditSaving_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelEditSaving_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
