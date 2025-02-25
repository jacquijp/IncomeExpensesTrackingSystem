using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncomeExpensesTrackingSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IncomeExpensesTrackingSystem
{
    public partial class DashboardForm : Form
    {
        private string currentUser;
        public DashboardForm(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }
    }
}
