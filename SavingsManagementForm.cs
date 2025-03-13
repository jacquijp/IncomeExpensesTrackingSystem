using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace IncomeExpensesTrackingSystem
{
    public partial class SavingsManagementForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public SavingsManagementForm(string user)
        {
            InitializeComponent();
            currentUser = user;
            LoadSavingsData();
        }

        // Load savings data into the DataGridView
        private void LoadSavingsData()
        {
            dataGridSavings.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SavingID, Concept, StartDate, Goal, Deposit, Currency, Progress FROM Savings WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            // Format progress with %
                            string progressFormatted = $"{Convert.ToDecimal(reader["Progress"]):0.00}%";

                            dataGridSavings.Rows.Add(
                                false,  // Checkbox column
                                reader["SavingID"].ToString(),
                                reader["Concept"].ToString(),
                                Convert.ToDateTime(reader["StartDate"]).ToString("yyyy-MM-dd"),
                                reader["Goal"].ToString(),
                                reader["Deposit"].ToString(),
                                reader["Currency"].ToString(),
                                progressFormatted  // Show progress with %
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading savings data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Open the Add New Savings form
        private void btnAddNewSaving_Click(object sender, EventArgs e)
        {
            AddNewSavingsGoalForm newSavingForm = new AddNewSavingsGoalForm(currentUser);
            newSavingForm.ShowDialog();
            LoadSavingsData();
        }

        // Open the Edit Savings form
        private void btnEditSavings_Click(object sender, EventArgs e)
        {
            if (dataGridSavings.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridSavings.SelectedRows[0];
                EditSavingsGoalForm editForm = new EditSavingsGoalForm(selectedRow);
                editForm.ShowDialog();
                LoadSavingsData();
            }
            else
            {
                MessageBox.Show("Please select a savings goal to edit.", "Edit Savings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete selected savings goal
        private void btnDeleteSavings_Click(object sender, EventArgs e)
        {
            if (dataGridSavings.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this savings goal?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Savings WHERE SavingID = @SavingID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                string selectedID = dataGridSavings.SelectedRows[0].Cells["colConcept"].Value.ToString();
                                cmd.Parameters.AddWithValue("@SavingID", selectedID);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Savings goal deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSavingsData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting savings goal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a savings goal to delete.", "Delete Savings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Export savings data to Excel
        private void btnExportSavings_Click(object sender, EventArgs e)
        {
            if (dataGridSavings.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Savings Report");

                    // Write headers
                    for (int col = 0; col < dataGridSavings.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dataGridSavings.Columns[col].HeaderText;
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    }

                    // Write data from DataGridView
                    for (int row = 0; row < dataGridSavings.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridSavings.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 2, col + 1).Value = dataGridSavings.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string fileName = $"Savings_Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    string filePath = Path.Combine(folderPath, fileName);
                    workbook.SaveAs(filePath);
                    MessageBox.Show($"Export successful!\nFile saved at:\n{filePath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridSavings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dataGridSavings_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, EventArgs e)
        {

        }

    }
}
