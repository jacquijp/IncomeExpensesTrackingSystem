using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewExpenseForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        // Constructor that receives the current user
        public AddNewExpenseForm(string user)
        {
            InitializeComponent();
            currentUser = user;
            LoadExpenseCategories(); // Load categories when form opens
        }

        // Load user's expense categories into the dropdown
        private void LoadExpenseCategories()
        {
            comboBoxCategory.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryName FROM Categories WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username) AND CategoryType = 'Expense'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            comboBoxCategory.Items.Add(reader["CategoryName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text) || comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show("Invalid amount format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Expenses (UserID, ExpenseDate, CategoryName, Amount, Currency, Description) " +
                                   "VALUES ((SELECT UserID FROM Users WHERE Username = @Username), @ExpenseDate, @Category, @Amount, (SELECT Currency FROM Users WHERE Username = @Username), @Description)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", currentUser);
                        cmd.Parameters.AddWithValue("@ExpenseDate", dateTimePickerIncome.Value);
                        cmd.Parameters.AddWithValue("@Category", comboBoxCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Expense saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after saving
                        }
                        else
                        {
                            MessageBox.Show("No expense was added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelExpense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseNewExpense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}
