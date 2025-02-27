using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class CategoryListForm : Form
    {
        private string currentUser;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public CategoryListForm(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadCategoryTypes();
            LoadCategoryNames();
        }

        private void LoadCategoryTypes()
        {
            comboBox_CategoryType.Items.Clear();
            comboBox_CategoryType.Items.Add("All");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT CategoryType FROM Categories";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox_CategoryType.Items.Add(reader["Type"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboBox_CategoryType.SelectedIndex = 0; // Default "All"
        }

        private void LoadCategoryNames()
        {
            comboBox_CategoryName.Items.Clear();
            comboBox_CategoryName.Items.Add("All");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT CategoryName FROM Categories";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox_CategoryName.Items.Add(reader["Name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboBox_CategoryName.SelectedIndex = 0; // Default "All"
        }

        public void btn_ViewList_Click(object sender, EventArgs e)
        {
            LoadFilteredCategories();
        }

        public void LoadFilteredCategories()
        {
            dataGridView_CategoryList.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID, Type, Name FROM Categories WHERE 1=1";
                    if (comboBox_CategoryType.SelectedIndex > 0)
                        query += " AND Type = @Type";
                    if (comboBox_CategoryName.SelectedIndex > 0)
                        query += " AND Name = @Name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (comboBox_CategoryType.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@Type", comboBox_CategoryType.SelectedItem.ToString());
                        if (comboBox_CategoryName.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@Name", comboBox_CategoryName.SelectedItem.ToString());

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dataGridView_CategoryList.Rows.Add(false, reader["ID"].ToString(), reader["Type"].ToString(), reader["Name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addCategoryForm = new AddNewCategoryForm(this);
            addCategoryForm.ShowDialog();
            LoadFilteredCategories(); // Refresh categories after adding
        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dataGridView_CategoryList.Rows)
                    {
                        if (row.Cells["colSelect"].Value != null && Convert.ToBoolean(row.Cells["colSelect"].Value))
                        {
                            string categoryId = row.Cells["col_IDCategory"].Value?.ToString();
                            if (!string.IsNullOrEmpty(categoryId))
                            {
                                string query = "DELETE FROM Categories WHERE ID = @ID";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@ID", categoryId);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadFilteredCategories();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }
    }
}
