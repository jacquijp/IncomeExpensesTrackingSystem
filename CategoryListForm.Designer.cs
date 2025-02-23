namespace IncomeExpensesTrackingSystem
{
    partial class CategoryListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close_Click = new System.Windows.Forms.Label();
            this.label_CategoryManagement = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel_dataCategoryList = new System.Windows.Forms.Panel();
            this.comboBox_CName = new System.Windows.Forms.ComboBox();
            this.comboBox_CType = new System.Windows.Forms.ComboBox();
            this.label_CName = new System.Windows.Forms.Label();
            this.label_CType = new System.Windows.Forms.Label();
            this.viewCategoryList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_CategoryList = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_AddNewCategory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel_dataCategoryList.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close_Click);
            this.panel1.Controls.Add(this.label_CategoryManagement);
            this.panel1.Controls.Add(this.leftCornerLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 52);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(696, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // close_Click
            // 
            this.close_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Click.Location = new System.Drawing.Point(1432, 5);
            this.close_Click.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(17, 18);
            this.close_Click.TabIndex = 10;
            this.close_Click.Text = "X";
            // 
            // label_CategoryManagement
            // 
            this.label_CategoryManagement.AutoSize = true;
            this.label_CategoryManagement.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CategoryManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_CategoryManagement.Location = new System.Drawing.Point(46, 14);
            this.label_CategoryManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CategoryManagement.Name = "label_CategoryManagement";
            this.label_CategoryManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_CategoryManagement.Size = new System.Drawing.Size(193, 24);
            this.label_CategoryManagement.TabIndex = 2;
            this.label_CategoryManagement.Text = "Category Management";
            // 
            // leftCornerLogo
            // 
            this.leftCornerLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftCornerLogo.Image = ((System.Drawing.Image)(resources.GetObject("leftCornerLogo.Image")));
            this.leftCornerLogo.Location = new System.Drawing.Point(11, 9);
            this.leftCornerLogo.Margin = new System.Windows.Forms.Padding(0);
            this.leftCornerLogo.Name = "leftCornerLogo";
            this.leftCornerLogo.Size = new System.Drawing.Size(26, 26);
            this.leftCornerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftCornerLogo.TabIndex = 1;
            this.leftCornerLogo.TabStop = false;
            // 
            // panel_dataCategoryList
            // 
            this.panel_dataCategoryList.Controls.Add(this.comboBox_CName);
            this.panel_dataCategoryList.Controls.Add(this.comboBox_CType);
            this.panel_dataCategoryList.Controls.Add(this.label_CName);
            this.panel_dataCategoryList.Controls.Add(this.label_CType);
            this.panel_dataCategoryList.Controls.Add(this.viewCategoryList);
            this.panel_dataCategoryList.Location = new System.Drawing.Point(0, 51);
            this.panel_dataCategoryList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_dataCategoryList.Name = "panel_dataCategoryList";
            this.panel_dataCategoryList.Size = new System.Drawing.Size(720, 83);
            this.panel_dataCategoryList.TabIndex = 2;
            // 
            // comboBox_CName
            // 
            this.comboBox_CName.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CName.FormattingEnabled = true;
            this.comboBox_CName.Location = new System.Drawing.Point(406, 27);
            this.comboBox_CName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_CName.Name = "comboBox_CName";
            this.comboBox_CName.Size = new System.Drawing.Size(152, 24);
            this.comboBox_CName.TabIndex = 11;
            // 
            // comboBox_CType
            // 
            this.comboBox_CType.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CType.FormattingEnabled = true;
            this.comboBox_CType.Location = new System.Drawing.Point(119, 27);
            this.comboBox_CType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_CType.Name = "comboBox_CType";
            this.comboBox_CType.Size = new System.Drawing.Size(152, 24);
            this.comboBox_CType.TabIndex = 10;
            // 
            // label_CName
            // 
            this.label_CName.AutoSize = true;
            this.label_CName.Font = new System.Drawing.Font("Montserrat SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label_CName.Location = new System.Drawing.Point(286, 27);
            this.label_CName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CName.Name = "label_CName";
            this.label_CName.Size = new System.Drawing.Size(125, 22);
            this.label_CName.TabIndex = 9;
            this.label_CName.Text = "Category Name";
            // 
            // label_CType
            // 
            this.label_CType.AutoSize = true;
            this.label_CType.Font = new System.Drawing.Font("Montserrat SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label_CType.Location = new System.Drawing.Point(8, 27);
            this.label_CType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CType.Name = "label_CType";
            this.label_CType.Size = new System.Drawing.Size(116, 22);
            this.label_CType.TabIndex = 8;
            this.label_CType.Text = "Category Type";
            // 
            // viewCategoryList
            // 
            this.viewCategoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.viewCategoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCategoryList.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCategoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.viewCategoryList.Location = new System.Drawing.Point(598, 20);
            this.viewCategoryList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewCategoryList.Name = "viewCategoryList";
            this.viewCategoryList.Size = new System.Drawing.Size(106, 35);
            this.viewCategoryList.TabIndex = 7;
            this.viewCategoryList.Text = "View List";
            this.viewCategoryList.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_CategoryList);
            this.panel2.Location = new System.Drawing.Point(112, 164);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 253);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView_CategoryList
            // 
            this.dataGridView_CategoryList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dataGridView_CategoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.col_IDCategory,
            this.colType,
            this.colName});
            this.dataGridView_CategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_CategoryList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_CategoryList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_CategoryList.Name = "dataGridView_CategoryList";
            this.dataGridView_CategoryList.RowHeadersVisible = false;
            this.dataGridView_CategoryList.RowHeadersWidth = 82;
            this.dataGridView_CategoryList.RowTemplate.Height = 33;
            this.dataGridView_CategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CategoryList.Size = new System.Drawing.Size(470, 253);
            this.dataGridView_CategoryList.TabIndex = 0;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.MinimumWidth = 10;
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 200;
            // 
            // col_IDCategory
            // 
            this.col_IDCategory.HeaderText = "ID";
            this.col_IDCategory.MinimumWidth = 10;
            this.col_IDCategory.Name = "col_IDCategory";
            this.col_IDCategory.ReadOnly = true;
            this.col_IDCategory.Width = 200;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 10;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 200;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 10;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // button_AddNewCategory
            // 
            this.button_AddNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.button_AddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddNewCategory.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.button_AddNewCategory.Location = new System.Drawing.Point(550, 23);
            this.button_AddNewCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AddNewCategory.Name = "button_AddNewCategory";
            this.button_AddNewCategory.Size = new System.Drawing.Size(154, 35);
            this.button_AddNewCategory.TabIndex = 12;
            this.button_AddNewCategory.Text = "+ Add New Category";
            this.button_AddNewCategory.UseVisualStyleBackColor = false;
            this.button_AddNewCategory.Click += new System.EventHandler(this.button_AddNewCategory_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.button2.Location = new System.Drawing.Point(406, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_AddNewCategory);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 446);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 96);
            this.panel3.TabIndex = 14;
            // 
            // CategoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(721, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_dataCategoryList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoryListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel_dataCategoryList.ResumeLayout(false);
            this.panel_dataCategoryList.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_Click;
        private System.Windows.Forms.Label label_CategoryManagement;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel_dataCategoryList;
        private System.Windows.Forms.Button viewCategoryList;
        private System.Windows.Forms.Label label_CName;
        private System.Windows.Forms.Label label_CType;
        private System.Windows.Forms.ComboBox comboBox_CName;
        private System.Windows.Forms.ComboBox comboBox_CType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_CategoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.Button button_AddNewCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
    }
}