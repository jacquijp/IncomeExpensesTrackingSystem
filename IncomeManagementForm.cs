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
    public partial class IncomeManagementForm : Form
    {
        public IncomeManagementForm()
        {
            InitializeComponent();
        }

        private void IncomeManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
