namespace IncomeExpensesTrackingSystem
{
    partial class AddNewCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCategoryForm));
            this.header_newIncome = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label_newCategory = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_AddNewCategory_CategoryName = new System.Windows.Forms.TextBox();
            this.comboBox_AddNewCategory_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveNewCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.header_newIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
           

            // 
            // header_newIncome
            // 
            this.header_newIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.header_newIncome.Controls.Add(this.label_close);
            this.header_newIncome.Controls.Add(this.label_newCategory);
            this.header_newIncome.Controls.Add(this.leftCornerLogo);
            this.header_newIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_newIncome.Location = new System.Drawing.Point(0, 0);
            this.header_newIncome.Margin = new System.Windows.Forms.Padding(2);
            this.header_newIncome.Name = "header_newIncome";
            this.header_newIncome.Size = new System.Drawing.Size(394, 45);
            this.header_newIncome.TabIndex = 1;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_close.Location = new System.Drawing.Point(375, 5);
            this.label_close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(17, 18);
            this.label_close.TabIndex = 12;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.lbl_closeX_Click);
            // 
            // label_newCategory
            // 
            this.label_newCategory.AutoSize = true;
            this.label_newCategory.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_newCategory.Location = new System.Drawing.Point(38, 5);
            this.label_newCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newCategory.Name = "label_newCategory";
            this.label_newCategory.Padding = new System.Windows.Forms.Padding(5);
            this.label_newCategory.Size = new System.Drawing.Size(120, 32);
            this.label_newCategory.TabIndex = 1;
            this.label_newCategory.Text = "New Category";
            // 
            // leftCornerLogo
            // 
            this.leftCornerLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftCornerLogo.Image = ((System.Drawing.Image)(resources.GetObject("leftCornerLogo.Image")));
            this.leftCornerLogo.Location = new System.Drawing.Point(4, 5);
            this.leftCornerLogo.Margin = new System.Windows.Forms.Padding(0);
            this.leftCornerLogo.Name = "leftCornerLogo";
            this.leftCornerLogo.Size = new System.Drawing.Size(26, 26);
            this.leftCornerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftCornerLogo.TabIndex = 2;
            this.leftCornerLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_AddNewCategory_CategoryName);
            this.panel1.Controls.Add(this.comboBox_AddNewCategory_Type);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Location = new System.Drawing.Point(20, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 236);
            this.panel1.TabIndex = 2;
            // 
            // textBox_AddNewCategory_CategoryName
            // 
            this.textBox_AddNewCategory_CategoryName.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AddNewCategory_CategoryName.Location = new System.Drawing.Point(143, 147);
            this.textBox_AddNewCategory_CategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AddNewCategory_CategoryName.Name = "textBox_AddNewCategory_CategoryName";
            this.textBox_AddNewCategory_CategoryName.Size = new System.Drawing.Size(190, 20);
            this.textBox_AddNewCategory_CategoryName.TabIndex = 23;
            // 
            // comboBox_AddNewCategory_Type
            // 
            this.comboBox_AddNewCategory_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AddNewCategory_Type.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_AddNewCategory_Type.FormattingEnabled = true;
            this.comboBox_AddNewCategory_Type.Location = new System.Drawing.Point(106, 75);
            this.comboBox_AddNewCategory_Type.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AddNewCategory_Type.Name = "comboBox_AddNewCategory_Type";
            this.comboBox_AddNewCategory_Type.Size = new System.Drawing.Size(170, 24);
            this.comboBox_AddNewCategory_Type.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Type";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelCategory.Location = new System.Drawing.Point(28, 138);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Padding = new System.Windows.Forms.Padding(5);
            this.labelCategory.Size = new System.Drawing.Size(114, 28);
            this.labelCategory.TabIndex = 14;
            this.labelCategory.Text = "Category Name";
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.button_Cancel.Location = new System.Drawing.Point(146, 12);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(89, 35);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveNewCategory
            // 
            this.btn_SaveNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_SaveNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveNewCategory.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveNewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btn_SaveNewCategory.Location = new System.Drawing.Point(263, 12);
            this.btn_SaveNewCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SaveNewCategory.Name = "btn_SaveNewCategory";
            this.btn_SaveNewCategory.Size = new System.Drawing.Size(89, 35);
            this.btn_SaveNewCategory.TabIndex = 7;
            this.btn_SaveNewCategory.Text = "Save";
            this.btn_SaveNewCategory.UseVisualStyleBackColor = false;
            this.btn_SaveNewCategory.Click += new System.EventHandler(this.btn_SaveNewCategory_Clic);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Cancel);
            this.panel2.Controls.Add(this.btn_SaveNewCategory);
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 70);
            this.panel2.TabIndex = 6;
            // 
            // AddNewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(394, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_newIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCategoryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCategoryForm";
            this.header_newIncome.ResumeLayout(false);
            this.header_newIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_newIncome;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_newCategory;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button btn_SaveNewCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_AddNewCategory_CategoryName;
        private System.Windows.Forms.ComboBox comboBox_AddNewCategory_Type;
    }
}