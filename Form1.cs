using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpensesTrackingSystem
{
    public partial class Form1 : Form
    {
        string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Puerquita\\Documents\\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_signupButton_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = (login_showPassword.Checked) ? '\0' : '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
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
                        MessageBox.Show("Login succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mForm = new MainForm();
                        mForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("incorrect username/password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void signin_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
