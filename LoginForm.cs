using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class LoginForm : Form
    {
        private string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Puerquita\\Documents\\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public LoginForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: Add logic if needed when form loads
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", signin_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string username = signin_username.Text.Trim();
                            MessageBox.Show("Login successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide(); // Hide login form
                            MainForm mainForm = new MainForm(username); // Pass username to MainForm
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_signupButton_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
