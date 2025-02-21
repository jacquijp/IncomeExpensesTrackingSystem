namespace IncomeExpensesTrackingSystem
{
    partial class IncomeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close_Click = new System.Windows.Forms.Label();
            this.label_incomeManagement = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridIncome = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdTransactionIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exportIncome = new System.Windows.Forms.Button();
            this.deleteIncome = new System.Windows.Forms.Button();
            this.editIncome = new System.Windows.Forms.Button();
            this.AddNewIncome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncome)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close_Click);
            this.panel1.Controls.Add(this.label_incomeManagement);
            this.panel1.Controls.Add(this.leftCornerLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1468, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1418, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // close_Click
            // 
            this.close_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Click.Location = new System.Drawing.Point(2890, 9);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(34, 38);
            this.close_Click.TabIndex = 10;
            this.close_Click.Text = "X";
            this.close_Click.Click += new System.EventHandler(this.close_Click_Click);
            // 
            // label_incomeManagement
            // 
            this.label_incomeManagement.AutoSize = true;
            this.label_incomeManagement.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_incomeManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_incomeManagement.Location = new System.Drawing.Point(92, 27);
            this.label_incomeManagement.Name = "label_incomeManagement";
            this.label_incomeManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_incomeManagement.Size = new System.Drawing.Size(337, 45);
            this.label_incomeManagement.TabIndex = 2;
            this.label_incomeManagement.Text = "Income Managment";
            // 
            // leftCornerLogo
            // 
            this.leftCornerLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftCornerLogo.Image = ((System.Drawing.Image)(resources.GetObject("leftCornerLogo.Image")));
            this.leftCornerLogo.Location = new System.Drawing.Point(22, 18);
            this.leftCornerLogo.Margin = new System.Windows.Forms.Padding(0);
            this.leftCornerLogo.Name = "leftCornerLogo";
            this.leftCornerLogo.Size = new System.Drawing.Size(51, 50);
            this.leftCornerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftCornerLogo.TabIndex = 1;
            this.leftCornerLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridIncome);
            this.panel2.Location = new System.Drawing.Point(69, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 551);
            this.panel2.TabIndex = 2;
            // 
            // dataGridIncome
            // 
            this.dataGridIncome.AllowUserToAddRows = false;
            this.dataGridIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIncome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dataGridIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.col_IdTransactionIncome,
            this.colDate,
            this.colCategory,
            this.ColAmount,
            this.colCurrency,
            this.colDescription});
            this.dataGridIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIncome.EnableHeadersVisualStyles = false;
            this.dataGridIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dataGridIncome.Location = new System.Drawing.Point(0, 0);
            this.dataGridIncome.MultiSelect = false;
            this.dataGridIncome.Name = "dataGridIncome";
            this.dataGridIncome.ReadOnly = true;
            this.dataGridIncome.RowHeadersVisible = false;
            this.dataGridIncome.RowHeadersWidth = 82;
            this.dataGridIncome.RowTemplate.Height = 33;
            this.dataGridIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIncome.Size = new System.Drawing.Size(1316, 551);
            this.dataGridIncome.TabIndex = 2;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.MinimumWidth = 10;
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            // 
            // col_IdTransactionIncome
            // 
            this.col_IdTransactionIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_IdTransactionIncome.HeaderText = "Transaction ID";
            this.col_IdTransactionIncome.MinimumWidth = 10;
            this.col_IdTransactionIncome.Name = "col_IdTransactionIncome";
            this.col_IdTransactionIncome.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 10;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 10;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // ColAmount
            // 
            this.ColAmount.HeaderText = "Amount";
            this.ColAmount.MinimumWidth = 10;
            this.ColAmount.Name = "ColAmount";
            this.ColAmount.ReadOnly = true;
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.MinimumWidth = 10;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 10;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exportIncome);
            this.panel3.Controls.Add(this.deleteIncome);
            this.panel3.Controls.Add(this.editIncome);
            this.panel3.Location = new System.Drawing.Point(0, 813);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1468, 155);
            this.panel3.TabIndex = 3;
            // 
            // exportIncome
            // 
            this.exportIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.exportIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportIncome.Location = new System.Drawing.Point(1116, 17);
            this.exportIncome.Name = "exportIncome";
            this.exportIncome.Size = new System.Drawing.Size(269, 68);
            this.exportIncome.TabIndex = 6;
            this.exportIncome.Text = "Export to Excel";
            this.exportIncome.UseVisualStyleBackColor = false;
            this.exportIncome.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // deleteIncome
            // 
            this.deleteIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.deleteIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIncome.Location = new System.Drawing.Point(249, 34);
            this.deleteIncome.Name = "deleteIncome";
            this.deleteIncome.Size = new System.Drawing.Size(142, 68);
            this.deleteIncome.TabIndex = 5;
            this.deleteIncome.Text = "Delete";
            this.deleteIncome.UseVisualStyleBackColor = false;
            this.deleteIncome.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // editIncome
            // 
            this.editIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.editIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIncome.Location = new System.Drawing.Point(79, 34);
            this.editIncome.Name = "editIncome";
            this.editIncome.Size = new System.Drawing.Size(142, 68);
            this.editIncome.TabIndex = 4;
            this.editIncome.Text = "Edit ";
            this.editIncome.UseVisualStyleBackColor = false;
            this.editIncome.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // AddNewIncome
            // 
            this.AddNewIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.AddNewIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewIncome.Location = new System.Drawing.Point(1100, 151);
            this.AddNewIncome.Name = "AddNewIncome";
            this.AddNewIncome.Size = new System.Drawing.Size(269, 68);
            this.AddNewIncome.TabIndex = 3;
            this.AddNewIncome.Text = "+ Add New Income";
            this.AddNewIncome.UseVisualStyleBackColor = false;
            this.AddNewIncome.Click += new System.EventHandler(this.btnAddNewIncome_Click);
            // 
            // IncomeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1468, 969);
            this.Controls.Add(this.AddNewIncome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncomeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Management";
            this.Load += new System.EventHandler(this.IncomeManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Label label_incomeManagement;
        private System.Windows.Forms.Label close_Click;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdTransactionIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddNewIncome;
        private System.Windows.Forms.Button exportIncome;
        private System.Windows.Forms.Button deleteIncome;
        private System.Windows.Forms.Button editIncome;
        private System.Windows.Forms.Label label2;
    }
}