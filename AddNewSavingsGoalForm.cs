using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewSavingsGoalForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public AddNewSavingsGoalForm(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnSaveNewSaving_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Savings (UserID, Concept, StartDate, Goal, Deposit, Currency, Progress) " +
                                   "VALUES ((SELECT UserID FROM Users WHERE Username = @Username), @Concept, @StartDate, @Goal, @Deposit, @Currency, @Progress)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        cmd.Parameters.AddWithValue("@Concept", txtNewSavingConcept.Text);
                        cmd.Parameters.AddWithValue("@StartDate", dateNewSaving.Value);
                        cmd.Parameters.AddWithValue("@Goal", Convert.ToDecimal(txtNewSavingGoal.Text));
                        cmd.Parameters.AddWithValue("@Deposit", Convert.ToDecimal(txtInitialDeposit.Text));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("New savings goal added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding savings goal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
