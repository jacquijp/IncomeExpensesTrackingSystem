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
    public partial class CategoryListForm : Form
    {
        private string currentUser;
        public CategoryListForm(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void button_AddNewCategory_Click(object sender, EventArgs e)
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
