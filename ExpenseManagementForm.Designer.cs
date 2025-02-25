namespace IncomeExpensesTrackingSystem
{
    partial class ExpenseManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseManagementForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.close_Click = new System.Windows.Forms.Label();
            this.label_expensesManagement = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridExpenses = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExportExpenses = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.close_Click);
            this.panel1.Controls.Add(this.label_expensesManagement);
            this.panel1.Controls.Add(this.leftCornerLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnClose.Location = new System.Drawing.Point(698, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 18);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // label_expensesManagement
            // 
            this.label_expensesManagement.AutoSize = true;
            this.label_expensesManagement.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expensesManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_expensesManagement.Location = new System.Drawing.Point(46, 14);
            this.label_expensesManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_expensesManagement.Name = "label_expensesManagement";
            this.label_expensesManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_expensesManagement.Size = new System.Drawing.Size(186, 24);
            this.label_expensesManagement.TabIndex = 2;
            this.label_expensesManagement.Text = "Expenses Managment";
            this.label_expensesManagement.Click += new System.EventHandler(this.label_expensesManagement_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddExpense);
            this.panel2.Location = new System.Drawing.Point(496, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 68);
            this.panel2.TabIndex = 2;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAddExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnAddExpense.Location = new System.Drawing.Point(42, 27);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(153, 35);
            this.btnAddExpense.TabIndex = 4;
            this.btnAddExpense.Text = "+ Add New Expense";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridExpenses);
            this.panel3.Location = new System.Drawing.Point(42, 149);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 241);
            this.panel3.TabIndex = 3;
            // 
            // dataGridExpenses
            // 
            this.dataGridExpenses.AllowUserToAddRows = false;
            this.dataGridExpenses.AllowUserToDeleteRows = false;
            this.dataGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colExpenseID,
            this.colDate,
            this.colCategory,
            this.colAmount,
            this.colCurrency,
            this.colDescription});
            this.dataGridExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridExpenses.Location = new System.Drawing.Point(0, 0);
            this.dataGridExpenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridExpenses.Name = "dataGridExpenses";
            this.dataGridExpenses.RowHeadersVisible = false;
            this.dataGridExpenses.RowHeadersWidth = 82;
            this.dataGridExpenses.RowTemplate.Height = 33;
            this.dataGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExpenses.Size = new System.Drawing.Size(650, 241);
            this.dataGridExpenses.TabIndex = 0;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.MinimumWidth = 10;
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 200;
            // 
            // colExpenseID
            // 
            this.colExpenseID.HeaderText = "ID";
            this.colExpenseID.MinimumWidth = 10;
            this.colExpenseID.Name = "colExpenseID";
            this.colExpenseID.ReadOnly = true;
            this.colExpenseID.Width = 200;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 10;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 200;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 10;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 200;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 10;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 200;
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.MinimumWidth = 10;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Width = 200;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 10;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExportExpenses);
            this.panel4.Controls.Add(this.btnDeleteExpense);
            this.panel4.Controls.Add(this.btnEditExpense);
            this.panel4.Location = new System.Drawing.Point(38, 402);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(668, 81);
            this.panel4.TabIndex = 3;
            // 
            // btnExportExpenses
            // 
            this.btnExportExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnExportExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExpenses.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnExportExpenses.Location = new System.Drawing.Point(517, 18);
            this.btnExportExpenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportExpenses.Name = "btnExportExpenses";
            this.btnExportExpenses.Size = new System.Drawing.Size(134, 35);
            this.btnExportExpenses.TabIndex = 9;
            this.btnExportExpenses.Text = "Export to Excel";
            this.btnExportExpenses.UseVisualStyleBackColor = false;
            this.btnExportExpenses.Click += new System.EventHandler(this.btnExportExpenses_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnDeleteExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnDeleteExpense.Location = new System.Drawing.Point(88, 27);
            this.btnDeleteExpense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(71, 35);
            this.btnDeleteExpense.TabIndex = 8;
            this.btnDeleteExpense.Text = "Delete";
            this.btnDeleteExpense.UseVisualStyleBackColor = false;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnEditExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEditExpense.Location = new System.Drawing.Point(4, 27);
            this.btnEditExpense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(71, 35);
            this.btnEditExpense.TabIndex = 7;
            this.btnEditExpense.Text = "Edit ";
            this.btnEditExpense.UseVisualStyleBackColor = false;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // 
            // ExpenseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(720, 503);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExpenseManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpenseManagementForm";
            this.Load += new System.EventHandler(this.ExpenseManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label close_Click;
        private System.Windows.Forms.Label label_expensesManagement;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnExportExpenses;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.DataGridView dataGridExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}