using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class MainForm : Form
    {
        private string currentUser; 

        public MainForm(string user = "")
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome, {currentUser}!";
            labelDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(currentUser);
            dashboard.Show();
            this.Hide();
        }

        private void btnIncomeManagement_Click(object sender, EventArgs e)
        {
            IncomeManagementForm incomeManagement = new IncomeManagementForm(currentUser);
            incomeManagement.Show();
        }


        private void btnExpenseManagement_Click(object sender, EventArgs e)
        {
            ExpenseManagementForm expenseForm = new ExpenseManagementForm();
            expenseForm.Show();
            this.Hide();
        }

        private void btnSavingsManagement_Click(object sender, EventArgs e)
        {
            SavingsManagementForm savingsForm = new SavingsManagementForm();
            savingsForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
            this.Hide();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryList = new CategoryListForm();
            categoryList.Show();
            this.Hide();
        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

       
        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings feature coming soon!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help section is under development.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark Mode feature coming soon!", "Dark Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
    }
}
