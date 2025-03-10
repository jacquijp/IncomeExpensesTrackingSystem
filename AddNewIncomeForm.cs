using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewIncomeForm : Form
    {
        private string incomeId;
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public AddNewIncomeForm(string user, string id = "")
        {
            InitializeComponent();
            currentUser = user;
            incomeId = id;

            LoadIncomeCategories(); // Load income categories in ComboBox

            if (!string.IsNullOrEmpty(incomeId))
            {
                LoadIncomeData();
            }

            textBoxAmount.KeyPress += textBoxAmount_KeyPress;
            textBoxDescription.MaxLength = 255; // Set character limit for description
        }


        private void LoadIncomeData()
        {
            MessageBox.Show($"Loading income data for ID: {incomeId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadIncomeCategories()
        {
            comboBoxCategory.Items.Clear(); // Clear previous items

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryName FROM Categories WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username) AND CategoryType = 'Income'";

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
                    MessageBox.Show("Error loading income categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (comboBoxCategory.Items.Count > 0)
            {
                comboBoxCategory.SelectedIndex = 0; // Select first item by default
            }
        }

        private void btnCancelIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseNewIncome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewIncomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowIncomeManagementForm();
        }

        private void ShowIncomeManagementForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is IncomeManagementForm)
                {
                    form.Show();
                    return;
                }
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers, one decimal point, and control keys (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnSaveIncome_Click_1(object sender, EventArgs e)
        {
            {
                // Get values added by user
                string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
                string amountText = textBoxAmount.Text.Trim();
                string description = textBoxDescription.Text.Trim();
                DateTime incomeDate = dateTimePickerIncome.Value;

                // Validating filling of data
                if (string.IsNullOrEmpty(selectedCategory) || string.IsNullOrEmpty(amountText))
                {
                    MessageBox.Show("Please fill in all required fields (Category and Amount).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validating number format
                if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid amount greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Database connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Incomes (UserID, CategoryName, Amount, Description, IncomeDate) " +
                                       "VALUES ((SELECT UserID FROM Users WHERE Username = @Username), @Category, @Amount, @Description, @Date)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", currentUser);
                            cmd.Parameters.AddWithValue("@Category", selectedCategory);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? DBNull.Value : (object)description);
                            cmd.Parameters.AddWithValue("@Date", incomeDate);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close(); // Close the form after successful insert
                            }
                            else
                            {
                                MessageBox.Show("Failed to add income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
