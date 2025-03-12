using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace IncomeExpensesTrackingSystem
{
    public partial class ExpenseManagementForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public ExpenseManagementForm(string user)
        {
            InitializeComponent();
            currentUser = user;
            LoadExpenses();

            // Set DataGridView default styles
            dataGridExpenses.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            dataGridExpenses.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            dataGridExpenses.GridColor = System.Drawing.Color.FromArgb(10, 61, 98);

            // Set selection colors
            dataGridExpenses.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridExpenses.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);

            // Optional: Alternate row style
            dataGridExpenses.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
        }

        // Load expense data from the database
        private void LoadExpenses()
        {
            dataGridExpenses.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ExpenseID, ExpenseDate, CategoryName, Amount, Currency, Description " +
                                   "FROM Expenses WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridExpenses.Rows.Add(false,
                                                      reader["ExpenseID"].ToString(),
                                                      Convert.ToDateTime(reader["ExpenseDate"]).ToString("yyyy-MM-dd"),
                                                      reader["CategoryName"].ToString(),
                                                      reader["Amount"].ToString(),
                                                      reader["Currency"].ToString(),
                                                      reader["Description"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExpenseManagementForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        // Open Add New Expense form
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddNewExpenseForm addExpenseForm = new AddNewExpenseForm(currentUser);
            addExpenseForm.ShowDialog();
            LoadExpenses();
        }

        // Open Edit Expense form
        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dataGridExpenses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridExpenses.SelectedRows[0];

                EditExpenseForm editForm = new EditExpenseForm(selectedRow);
                editForm.ShowDialog();

                LoadExpenses();
            }
            else
            {
                MessageBox.Show("Please select an expense to edit.", "Edit Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete selected expense record
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dataGridExpenses.SelectedRows.Count > 0)
            {
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this expense?",
                                                             "Delete Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmDelete == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Expenses WHERE ExpenseID = @ExpenseID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                string selectedID = dataGridExpenses.SelectedRows[0].Cells["colExpenseID"].Value.ToString();
                                cmd.Parameters.AddWithValue("@ExpenseID", selectedID);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Expense record deleted successfully.", "Delete Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadExpenses();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting expense record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an expense record to delete.", "Delete Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Export expense data to Excel 
        private void btnExportExpenses_Click(object sender, EventArgs e)
        {
            if (dataGridExpenses.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create a new Excel workbook
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Expense Report");

                    // Write the headers
                    for (int col = 0; col < dataGridExpenses.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dataGridExpenses.Columns[col].HeaderText;
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    }

                    // Write the data from DataGridView
                    for (int row = 0; row < dataGridExpenses.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridExpenses.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 2, col + 1).Value = dataGridExpenses.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    // Auto-fit columns for better readability
                    worksheet.Columns().AdjustToContents();

                    // Generate file path
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string fileName = $"Expense_Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    string filePath = Path.Combine(folderPath, fileName);

                    // Save the Excel file
                    workbook.SaveAs(filePath);

                    // Confirmation message
                    MessageBox.Show($"Export successful!\nFile saved at:\n{filePath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the Excel file automatically
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }

        private void dataGridExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridExpenses.Columns[e.ColumnIndex].Name != "colSelect")
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dataGridExpenses.Rows[e.RowIndex].Cells["colSelect"];
                checkbox.Value = !(checkbox.Value is bool && (bool)checkbox.Value);
            }
        }
    }
}
