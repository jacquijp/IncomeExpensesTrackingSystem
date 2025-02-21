using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class MainForm : Form
    {
        private string username;

        public MainForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome, {username}!";
            labelDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Asegúrate de que DashboardForm existe en tu proyecto
            if (Application.OpenForms["DashboardForm"] == null)
            {
                DashboardForm dashboard = new DashboardForm(username);
                dashboard.Show();
                this.Hide();
            }
        }

        private void btnIncomeManagement_Click(object sender, EventArgs e)
        {
            // Si IncomeManagementForm no está creado, mantén esto comentado
            // IncomeManagementForm incomeForm = new IncomeManagementForm();
            // incomeForm.Show();
        }

        private void btnExpensesManagement_Click(object sender, EventArgs e)
        {
            // ExpensesManagementForm expensesForm = new ExpensesManagementForm();
            // expensesForm.Show();
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            // SavingsForm savingsForm = new SavingsForm();
            // savingsForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // ReportsForm reportsForm = new ReportsForm();
            // reportsForm.Show();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            // CategoryListForm categoryForm = new CategoryListForm();
            // categoryForm.Show();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings will be added soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help section will be added soon!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picDarkMode_Click(object sender, EventArgs e)
        {
            // Alternar entre modo claro y oscuro
            this.BackColor = this.BackColor == System.Drawing.Color.FromArgb(243, 244, 246)
                ? System.Drawing.Color.Black
                : System.Drawing.Color.FromArgb(243, 244, 246);
        }

        private void notificationsIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No new notifications!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void profilePicRightCorner_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
