using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Open Dashboard
        private void menuDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
        }

        // Open Category List
        private void menuCategoryList_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryList = new CategoryListForm();
            categoryList.Show();
        }

        // Open Income Management
        private void menuIncomeManagement_Click(object sender, EventArgs e)
        {
            IncomeManagementForm incomeManagement = new IncomeManagementForm();
            incomeManagement.Show();
        }

        // Open Expense Management
        private void menuExpenseManagement_Click(object sender, EventArgs e)
        {
            ExpenseManagementForm expenseManagement = new ExpenseManagementForm();
            expenseManagement.Show();
        }

        // Open Savings Management
        private void menuSavingsManagement_Click(object sender, EventArgs e)
        {
            SavingsManagementForm savingsManagement = new SavingsManagementForm();
            savingsManagement.Show();
        }

        // Open Reports
        private void menuReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
        }

        // Logout
        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
