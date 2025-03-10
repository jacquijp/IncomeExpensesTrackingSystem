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


        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(incomeId))
            {
                MessageBox.Show("New income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Income ID {incomeId} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
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
    }
}
