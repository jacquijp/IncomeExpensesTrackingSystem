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
    public partial class IncomeManagementForm : Form
    {
        private string currentUser;
        public IncomeManagementForm(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void IncomeManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewIncome_Click(object sender, EventArgs e)
        {
            AddNewIncomeForm addIncomeForm = new AddNewIncomeForm(currentUser);
            addIncomeForm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridIncome.SelectedRows.Count > 0)
            {
                string selectedID = dataGridIncome.SelectedRows[0].Cells["col_IdTransactionIncome"].Value.ToString();

                AddNewIncomeForm editForm = new AddNewIncomeForm(currentUser, selectedID);
                editForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Please select an income record to edit.", "Edit Income", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dataGridIncome.SelectedRows.Count > 0)
            {
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this income record?",
                                                             "Delete Income", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmDelete == DialogResult.Yes)
                {
                    // Aquí va la lógica para eliminar el registro de la base de datos
                    MessageBox.Show("Income record deleted successfully.", "Delete Income", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an income record to delete.", "Delete Income", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MainForm main = new MainForm(currentUser); 
            main.Show();
        }
    }
}
