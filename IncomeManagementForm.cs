using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class IncomeManagementForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public IncomeManagementForm(string user)
        {
            InitializeComponent();
            currentUser = user;
            LoadIncomeData(); // Load income data when the form is opened
        }

        private void LoadIncomeData()
        {
            dataGridIncome.Rows.Clear(); // Clear existing rows before adding new data

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IncomeID, IncomeDate, CategoryName, Amount, Description FROM Incomes WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridIncome.Rows.Add(false,
                                                    reader["IncomeID"].ToString(),
                                                    Convert.ToDateTime(reader["IncomeDate"]).ToString("yyyy-MM-dd"),
                                                    reader["CategoryName"].ToString(),
                                                    reader["Amount"].ToString(),
                                                    "USD", // 🔹 Currency column (update later if needed)
                                                    reader["Description"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading income data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IncomeManagementForm_Load(object sender, EventArgs e)
        {
            LoadIncomeData(); // Ensure the data is loaded when the form opens
        }

        private void btnAddNewIncome_Click(object sender, EventArgs e)
        {
            AddNewIncomeForm incomeForm = new AddNewIncomeForm(currentUser);
            incomeForm.ShowDialog();
            LoadIncomeData(); // Refresh the table after adding an income
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridIncome.SelectedRows.Count > 0)
            {
                string selectedID = dataGridIncome.SelectedRows[0].Cells["col_IdTransactionIncome"].Value.ToString();

                AddNewIncomeForm editForm = new AddNewIncomeForm(currentUser, selectedID);
                editForm.Show();
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
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Incomes WHERE IncomeID = @IncomeID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                string selectedID = dataGridIncome.SelectedRows[0].Cells["col_IdTransactionIncome"].Value.ToString();
                                cmd.Parameters.AddWithValue("@IncomeID", selectedID);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Income record deleted successfully.", "Delete Income", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadIncomeData(); // Refresh data after deletion
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting income record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an income record to delete.", "Delete Income", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export to Excel functionality is not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }
    }
}
