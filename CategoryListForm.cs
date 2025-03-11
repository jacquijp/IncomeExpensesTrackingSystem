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
        private int currentUserID;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;

        public CategoryListForm(string currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            this.currentUserID = GetUserID(currentUser); 

            LoadCategoryTypes();
            LoadCategoryNames();
            InitializeDataGridView();
        }

        // Method to retrieve the UserID from the database
        private int GetUserID(string username)
        {
            int userID = -1; // Default value in case of an error

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            userID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving UserID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return userID;
        }

        // Initialize DataGridView and ensure "Select" column is a checkbox
        private void InitializeDataGridView()
        {
            // If the "Select" column doesn't exist, add it
            if (dataGridView_CategoryList.Columns["colSelect"] == null)
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "colSelect";
                chk.HeaderText = "Select";
                chk.Width = 50;
                dataGridView_CategoryList.Columns.Insert(0, chk);
            }
        }

        // Load categories filtered by the current user
        public void LoadFilteredCategories()
        {
            dataGridView_CategoryList.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryID, CategoryType, CategoryName FROM Categories WHERE UserID = @UserID";

                    if (comboBox_CategoryType.SelectedIndex > 0)
                        query += " AND CategoryType = @CategoryType";
                    if (comboBox_CategoryName.SelectedIndex > 0)
                        query += " AND CategoryName = @CategoryName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", currentUserID);

                        if (comboBox_CategoryType.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@CategoryType", comboBox_CategoryType.SelectedItem.ToString());
                        if (comboBox_CategoryName.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@CategoryName", comboBox_CategoryName.SelectedItem.ToString());

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Ensure values are correctly ordered: [CheckBox, ID, Type, Name]
                            dataGridView_CategoryList.Rows.Add(
                                false,  // This should always be a boolean
                                reader["CategoryID"],
                                reader["CategoryType"].ToString(),
                                reader["CategoryName"].ToString()
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Open the "Add New Category" form and pass the current user ID
        private void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addCategoryForm = new AddNewCategoryForm(this, currentUserID);
            addCategoryForm.ShowDialog();
            LoadFilteredCategories(); // Refresh after adding a new category
        }

        // Delete selected categories
        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dataGridView_CategoryList.Rows)
                    {
                        // Ensure the checkbox is checked before deleting
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
            LoadFilteredCategories(); // Refresh after deletion
        }

        // Load unique category types into the dropdown
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
            comboBox_CategoryType.SelectedIndex = 0; // Default selection to "All"
        }

        // Load unique category names into the dropdown
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
            comboBox_CategoryName.SelectedIndex = 0; // Default selection to "All"
        }

        // Refresh the category list when clicking "View List"
        private void btn_ViewList_Click(object sender, EventArgs e)
        {
            LoadFilteredCategories();
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(currentUser);
            main.Show();
        }

        private void dataGridView_CategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
