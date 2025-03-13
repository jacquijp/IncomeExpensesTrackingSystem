using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace IncomeExpensesTrackingSystem
{
    public partial class ReportsForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public ReportsForm(string user)
        {
            InitializeComponent();
            currentUser = user;

            // Fill comboBox with transaction types
            comboBox_TransactionType.Items.Add("Incomes");
            comboBox_TransactionType.Items.Add("Expenses");
            comboBox_TransactionType.SelectedIndex = 0; // Default selection
        }

        // Close the ReportsForm and go back to MainForm
        private void btnCloseReports(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Return to MainForm
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }

        // Generate the report in Excel
        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            // Validate date range
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("The 'From' date cannot be later than the 'To' date.", "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate transaction type selection
            if (comboBox_TransactionType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a transaction type (Incomes or Expenses).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string transactionType = comboBox_TransactionType.SelectedItem.ToString();

            // Build the query depending on the transaction type
            string query = "";
            string dateColumn = "";
            if (transactionType == "Incomes")
            {
                query = "SELECT IncomeID, IncomeDate, CategoryName, Amount, Description " +
                        "FROM Incomes " +
                        "WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username) " +
                        "AND IncomeDate >= @FromDate " +
                        "AND IncomeDate <= @ToDate";
                dateColumn = "IncomeDate";
            }
            else // "Expenses"
            {
                query = "SELECT CategoryID, ExpenseDate, CategoryType, Amount, '' AS Description " +
                        "FROM Expenses " +
                        "WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username) " +
                        "AND ExpenseDate >= @FromDate " +
                        "AND ExpenseDate <= @ToDate";
                dateColumn = "ExpenseDate";
            }

            // Fetch data from DB
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        cmd.Parameters.AddWithValue("@FromDate", dateTimePickerFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dateTimePickerTo.Value.Date);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Check if we have data to export
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No transactions found for the selected range and type.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Export to Excel using ClosedXML
            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Report");

                    // Add headers
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dt.Columns[col].ColumnName;
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    }

                    // Add rows
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        for (int col = 0; col < dt.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 2, col + 1).Value = dt.Rows[row][col]?.ToString();
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string fileName = $"Report_{transactionType}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    string filePath = System.IO.Path.Combine(folderPath, fileName);

                    workbook.SaveAs(filePath);

                    MessageBox.Show($"Report generated successfully!\nFile saved at:\n{filePath}", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional: If you have events for these labels
        private void labelGenerateReport_Click(object sender, EventArgs e)
        {
            // Not used
        }

        private void label_date_Click(object sender, EventArgs e)
        {
            // Not used
        }

        private void label_to_Click(object sender, EventArgs e)
        {
            // Not used
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
