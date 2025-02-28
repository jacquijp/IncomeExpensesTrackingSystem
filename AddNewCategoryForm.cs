using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewCategoryForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["IncomeExpensesDB"].ConnectionString;
        private CategoryListForm parentForm;
        private int currentUserID; // 🔹 Guardará el UserID del usuario actual

        public AddNewCategoryForm(CategoryListForm parent, int userID)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.currentUserID = userID; // 🔹 Se asigna el UserID recibido
            LoadCategoryTypes();
        }

        private void LoadCategoryTypes()
        {
            comboBox_AddNewCategory_Type.Items.Clear();
            comboBox_AddNewCategory_Type.Items.Add("Expense");
            comboBox_AddNewCategory_Type.Items.Add("Income");
            comboBox_AddNewCategory_Type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_closeX_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string query = "INSERT INTO Categories (UserID, CategoryType, CategoryName) VALUES (@UserID, @CategoryType, @CategoryName)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID); 
                    cmd.Parameters.AddWithValue("@CategoryType", categoryType);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresca la lista en CategoryListForm
                            parentForm.LoadFilteredCategories();

                            this.Close(); // Cierra el formulario después de guardar
                        }
                        else
                        {
                            MessageBox.Show("No category was added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
