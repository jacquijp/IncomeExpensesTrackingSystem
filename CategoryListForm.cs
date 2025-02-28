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
            this.currentUserID = GetUserID(currentUser); // Obtener el UserID basado en el nombre

            LoadCategoryTypes();
            LoadCategoryNames();
        }

        // 🔹 Método para obtener el UserID basado en el Username
        private int GetUserID(string username)
        {
            int userID = -1; // Si no encuentra nada, devuelve -1 para evitar errores

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

        // 🔹 Cargar solo las categorías del usuario actual
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

        // 🔹 Modificado para pasar currentUserID a AddNewCategoryForm
        private void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addCategoryForm = new AddNewCategoryForm(this, currentUserID);
            addCategoryForm.ShowDialog();
            LoadFilteredCategories(); // Refrescar después de agregar una nueva categoría
        }

        // 🔹 Método para eliminar categorías seleccionadas
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

        private void LoadCategoryTypes()
        {
            comboBox_CategoryType.Items.Clear();
            comboBox_CategoryType.Items.Add("All"); // Siempre incluir "All"

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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
