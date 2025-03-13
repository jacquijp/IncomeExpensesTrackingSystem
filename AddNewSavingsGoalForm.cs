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

            // Ensure max length for concept
            txtNewSavingConcept.MaxLength = 255;
        }

        private void btnCancelNewSaving_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNewSaving_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtNewSavingConcept.Text) || string.IsNullOrWhiteSpace(txtNewSavingGoal.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate saving goal format
            if (!decimal.TryParse(txtNewSavingGoal.Text, out decimal savingGoal) || savingGoal <= 0)
            {
                MessageBox.Show("Invalid format for Saving Goal. Please enter a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional initial deposit: if empty, set to 0
            decimal initialDeposit = 0;
            if (!string.IsNullOrWhiteSpace(txtInitialDeposit.Text))
            {
                if (!decimal.TryParse(txtInitialDeposit.Text, out initialDeposit) || initialDeposit < 0)
                {
                    MessageBox.Show("Invalid format for Initial Deposit. Please enter a valid positive number or leave it blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Ensure the concept does not exceed the max database limit
            string savingConcept = txtNewSavingConcept.Text.Length > 255
                ? txtNewSavingConcept.Text.Substring(0, 255)
                : txtNewSavingConcept.Text;

            // Calculate progress percentage as decimal
            decimal progressValue = savingGoal > 0 ? (initialDeposit / savingGoal) * 100 : 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Savings (UserID, Concept, StartDate, Goal, Deposit, Currency, Progress) " +
                                   "VALUES ((SELECT UserID FROM Users WHERE Username = @Username), @Concept, @StartDate, @Goal, @Deposit, 'USD', @Progress)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        cmd.Parameters.AddWithValue("@Concept", savingConcept);
                        cmd.Parameters.AddWithValue("@StartDate", dateNewSaving.Value);
                        cmd.Parameters.AddWithValue("@Goal", savingGoal);
                        cmd.Parameters.AddWithValue("@Deposit", initialDeposit);
                        cmd.Parameters.AddWithValue("@Progress", progressValue); // Store as decimal

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
