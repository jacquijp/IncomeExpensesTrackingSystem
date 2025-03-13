using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class DashboardForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public DashboardForm(string user)
        {
            InitializeComponent();
            currentUser = user;
            LoadDashboardData();
        }

        // Load dashboard statistics from the database
        private void LoadDashboardData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Get UserID
                    string userIdQuery = "SELECT UserID FROM Users WHERE Username = @Username";
                    SqlCommand userCmd = new SqlCommand(userIdQuery, conn);
                    userCmd.Parameters.AddWithValue("@Username", currentUser);
                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    if (userId == 0)
                    {
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 1️⃣ Net Income (Last 3 months)
                    string netIncomeQuery = @"
                        SELECT 
                            SUM(CASE WHEN Type = 'Income' THEN Amount ELSE -Amount END) AS NetIncome 
                        FROM (
                            SELECT Amount, 'Income' AS Type FROM Incomes WHERE UserID = @UserID AND IncomeDate >= DATEADD(MONTH, -3, GETDATE())
                            UNION ALL
                            SELECT Amount, 'Expense' AS Type FROM Expenses WHERE UserID = @UserID AND ExpenseDate >= DATEADD(MONTH, -3, GETDATE())
                        ) AS CombinedTransactions";

                    SqlCommand netIncomeCmd = new SqlCommand(netIncomeQuery, conn);
                    netIncomeCmd.Parameters.AddWithValue("@UserID", userId);
                    object netIncomeResult = netIncomeCmd.ExecuteScalar();
                    label_NetIncome.Text = $"Net Income: {(netIncomeResult != DBNull.Value ? Convert.ToDecimal(netIncomeResult) : 0):C}";

                    // 2️⃣ Current Savings
                    string currentSavingsQuery = "SELECT SUM(Deposit) FROM Savings WHERE UserID = @UserID";
                    SqlCommand savingsCmd = new SqlCommand(currentSavingsQuery, conn);
                    savingsCmd.Parameters.AddWithValue("@UserID", userId);
                    object savingsResult = savingsCmd.ExecuteScalar();
                    label4.Text = $"Current Savings: {(savingsResult != DBNull.Value ? Convert.ToDecimal(savingsResult) : 0):C}";

                    // 3️⃣ Today's Income
                    string todayIncomeQuery = "SELECT SUM(Amount) FROM Incomes WHERE UserID = @UserID AND IncomeDate = CAST(GETDATE() AS DATE)";
                    SqlCommand todayIncomeCmd = new SqlCommand(todayIncomeQuery, conn);
                    todayIncomeCmd.Parameters.AddWithValue("@UserID", userId);
                    object todayIncomeResult = todayIncomeCmd.ExecuteScalar();
                    label6.Text = $"Today's Income: {(todayIncomeResult != DBNull.Value ? Convert.ToDecimal(todayIncomeResult) : 0):C}";

                    // 4️⃣ Today's Expenses
                    string todayExpensesQuery = "SELECT SUM(Amount) FROM Expenses WHERE UserID = @UserID AND ExpenseDate = CAST(GETDATE() AS DATE)";
                    SqlCommand todayExpensesCmd = new SqlCommand(todayExpensesQuery, conn);
                    todayExpensesCmd.Parameters.AddWithValue("@UserID", userId);
                    object todayExpensesResult = todayExpensesCmd.ExecuteScalar();
                    label7.Text = $"Today's Expenses: {(todayExpensesResult != DBNull.Value ? Convert.ToDecimal(todayExpensesResult) : 0):C}";

                    // 5️⃣ Main Income Categories (Top 3)
                    string mainIncomeCategoriesQuery = @"
                        SELECT TOP 3 CategoryName, SUM(Amount) AS Total 
                        FROM Incomes 
                        WHERE UserID = @UserID 
                        GROUP BY CategoryName 
                        ORDER BY Total DESC";

                    SqlCommand mainIncomeCmd = new SqlCommand(mainIncomeCategoriesQuery, conn);
                    mainIncomeCmd.Parameters.AddWithValue("@UserID", userId);
                    SqlDataReader incomeReader = mainIncomeCmd.ExecuteReader();

                    string incomeCategories = "Main Income Categories:\n";
                    while (incomeReader.Read())
                    {
                        incomeCategories += $"{incomeReader["CategoryName"]}: {Convert.ToDecimal(incomeReader["Total"]):C}\n";
                    }
                    incomeReader.Close();
                    label8.Text = incomeCategories;

                    // 6️⃣ Main Expense Categories (Top 3)
                    string mainExpenseCategoriesQuery = @"
                        SELECT TOP 3 CategoryType, SUM(Amount) AS Total 
                        FROM Expenses 
                        WHERE UserID = @UserID 
                        GROUP BY CategoryType 
                        ORDER BY Total DESC";

                    SqlCommand mainExpenseCmd = new SqlCommand(mainExpenseCategoriesQuery, conn);
                    mainExpenseCmd.Parameters.AddWithValue("@UserID", userId);
                    SqlDataReader expenseReader = mainExpenseCmd.ExecuteReader();

                    string expenseCategories = "Main Expenses Categories:\n";
                    while (expenseReader.Read())
                    {
                        expenseCategories += $"{expenseReader["CategoryType"]}: {Convert.ToDecimal(expenseReader["Total"]):C}\n";
                    }
                    expenseReader.Close();
                    label9.Text = expenseCategories;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        }
}
