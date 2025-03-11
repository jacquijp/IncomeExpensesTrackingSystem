using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class EditIncomeForm : Form
    {
        private string currentUser;
        private string incomeID;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public EditIncomeForm(string user, string incomeID)
        {
            InitializeComponent();
            this.currentUser = user;
            this.incomeID = incomeID;
            LoadIncomeDetails(); // Load the selected income details
        }

        // Load the selected income details into the input fields
        private void LoadIncomeDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IncomeDate, Amount, Description FROM Incomes WHERE IncomeID = @IncomeID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IncomeID", incomeID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            datePickerIncome.Value = Convert.ToDateTime(reader["IncomeDate"]);
                            textBoxAmountIncome.Text = reader["Amount"].ToString();
                            textBoxDescriptionIncome.Text = reader["Description"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading income details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Save the edited income to the database
        private void btnSaveEditIncome_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Incomes SET IncomeDate = @IncomeDate, Amount = @Amount, Description = @Description WHERE IncomeID = @IncomeID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IncomeDate", datePickerIncome.Value);
                            cmd.Parameters.AddWithValue("@Amount", textBoxAmountIncome.Text);
                            cmd.Parameters.AddWithValue("@Description", textBoxDescriptionIncome.Text);
                            cmd.Parameters.AddWithValue("@IncomeID", incomeID);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Income updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No changes were made.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Validate required fields
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxAmountIncome.Text))
            {
                MessageBox.Show("Please enter an amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void EditIncomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelEditIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Close button event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
