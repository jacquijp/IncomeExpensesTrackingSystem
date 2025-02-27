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

        // Load distinct category types from the database
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
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox_CategoryType.Items.Add(reader["CategoryType"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboBox_CategoryType.SelectedIndex = 0; // Default to "All"
        }

        // Load distinct category names from the database
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
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox_CategoryName.Items.Add(reader["CategoryName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboBox_CategoryName.SelectedIndex = 0; // Default to "All"
        }

        // Handle View List button click to load filtered categories
        private void btn_ViewList_Click(object sender, EventArgs e)
        {
            LoadFilteredCategories();
        }

        // Load and filter categories based on user selection
        private void LoadFilteredCategories()
        {
            dataGridView_CategoryList.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryID, CategoryType, CategoryName FROM Categories WHERE 1=1";

                    if (comboBox_CategoryType.SelectedIndex > 0)
                        query += " AND CategoryType = @CategoryType";
                    if (comboBox_CategoryName.SelectedIndex > 0)
                        query += " AND CategoryName = @CategoryName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (comboBox_CategoryType.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@CategoryType", comboBox_CategoryType.SelectedItem.ToString());
                        if (comboBox_CategoryName.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@CategoryName", comboBox_CategoryName.SelectedItem.ToString());

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dataGridView_CategoryList.Rows.Add(false, reader["CategoryID"].ToString(), reader["CategoryType"].ToString(), reader["CategoryName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Open the Add New Category Form
        private void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addCategoryForm = new AddNewCategoryForm(this);
            addCategoryForm.ShowDialog();
            LoadFilteredCategories(); // Refresh the list after adding a new category
        }

        // Delete selected categories from the database
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
                                string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@CategoryID", categoryId);
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

        // Close the form and return to MainForm
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
