﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewCategoryForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;
        private CategoryListForm parentForm;

        public AddNewCategoryForm(CategoryListForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadCategoryTypes();
        }

        private void LoadCategoryTypes()
        {
            comboBox_AddNewCategory_Type.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Type FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_AddNewCategory_Type.Items.Add(reader["Type"].ToString());
                }
            }
        }

        private void btn_SaveNewCategory_Click(object sender, EventArgs e)
        {
            string categoryName = textBox_AddNewCategory_CategoryName.Text.Trim();
            string categoryType = comboBox_AddNewCategory_Type.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(categoryType))
            {
                MessageBox.Show("Both fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Categories (Type, Name) VALUES (@Type, @Name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Type", categoryType);
                cmd.Parameters.AddWithValue("@Name", categoryName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llamar al método del formulario principal para actualizar la tabla
            parentForm.LoadFilteredCategories();

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_closeX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
