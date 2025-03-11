using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace IncomeExpensesTrackingSystem
{
    public partial class RegisterForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void login_signupButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(register_username.Text) ||
                string.IsNullOrWhiteSpace(register_password.Text) ||
                string.IsNullOrWhiteSpace(register_confirm_password.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid password. Type at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text != register_confirm_password.Text)
            {
                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that a currency is selected
            if (listBox_Currency.SelectedItem == null)
            {
                MessageBox.Show("Please select a currency.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedCurrency = listBox_Currency.SelectedItem.ToString();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    // Check if username exists
                    string selectUsername = "SELECT COUNT(*) FROM Users WHERE username = @usern";
                    using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        int userExists = (int)checkUser.ExecuteScalar();

                        if (userExists > 0)
                        {
                            string tempUsern = char.ToUpper(register_username.Text[0]) + register_username.Text.Substring(1);
                            MessageBox.Show($"{tempUsern} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Encrypt password
                    string hashedPassword = HashPassword(register_password.Text.Trim());

                    // Insert new user including the currency column
                    string insertData = "INSERT INTO Users (username, password, date_create, Currency) VALUES (@usern, @pass, @date, @currency)";
                    using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                    {
                        insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        insertUser.Parameters.AddWithValue("@pass", hashedPassword);
                        insertUser.Parameters.AddWithValue("@date", DateTime.Now);
                        insertUser.Parameters.AddWithValue("@currency", selectedCurrency);

                        insertUser.ExecuteNonQuery();

                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginForm login = new LoginForm();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void register_show_password_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = register_show_password.Checked;
            register_password.PasswordChar = isChecked ? '\0' : '*';
            register_confirm_password.PasswordChar = isChecked ? '\0' : '*';
        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change event
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void listBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
