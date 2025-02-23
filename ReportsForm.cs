using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class ReportsForm : Form
    {

        private string currentUser;
        public ReportsForm(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnCloseReports(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }

        private void labelGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void label_date_Click(object sender, EventArgs e)
        {

        }

        private void label_to_Click(object sender, EventArgs e)
        {

        }
    }
}
