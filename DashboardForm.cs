﻿using System;
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
        private string username;
        public DashboardForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeIcon_backToMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
            this.Close();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
