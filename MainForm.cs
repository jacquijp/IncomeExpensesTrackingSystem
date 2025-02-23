using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class MainForm : Form
    {
        private string currentUser; // Store current user if needed

        public MainForm(string user = "")
        {
            InitializeComponent();
            currentUser = user; // Store user if needed
        }

        // Load event for MainForm
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: Add initialization logic if needed
        }

        // Open Dashboard Form
        private void menuDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(currentUser); // Pass user if required
            dashboard.Show();
        }

        // Open Category List Form
        private void menuCategoryList_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryList = new CategoryListForm();
            categoryList.Show();
        }

        // Open Income Management Form
        private void menuIncomeManagement_Click(object sender, EventArgs e)
        {
            IncomeManagementForm incomeManagement = new IncomeManagementForm();
            incomeManagement.Show();
        }

        // Open Expense Management Form
        private void menuExpenseManagement_Click(object sender, EventArgs e)
        {
            ExpenseManagementForm expenseManagement = new ExpenseManagementForm();
            expenseManagement.Show();
        }

        // Open Savings Management Form
        private void menuSavingsManagement_Click(object sender, EventArgs e)
        {
            SavingsManagementForm savingsManagement = new SavingsManagementForm();
            savingsManagement.Show();
        }

        // Open Reports Form
        private void menuReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
        }

        // Logout function
        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                this.Hide(); // Hide MainForm before opening LoginForm
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        // Event placeholders (if required in the designer)
        private void buttonDashboard_Click(object sender, EventArgs e) { }
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }
        private void btnIncomeManagement_Click(object sender, EventArgs e) { }
    }
}
