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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_Click = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridIncome = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdTransactionIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.close_Click);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.leftCornerLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1468, 92);
            this.panel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(92, 27);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(674, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Income Managment";
            // 
            // close_Click
            // 
            this.close_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Click.Location = new System.Drawing.Point(1422, 9);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(34, 38);
            this.close_Click.TabIndex = 10;
            this.close_Click.Text = "X";
            this.close_Click.Click += new System.EventHandler(this.close_Click_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridIncome);
            this.panel2.Location = new System.Drawing.Point(100, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 583);
            this.panel2.TabIndex = 2;
            // 
            // dataGridIncome
            // 
            this.dataGridIncome.AllowUserToAddRows = false;
            this.dataGridIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIncome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dataGridIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.col_IdTransactionIncome,
            this.colDate,
            this.colCategory,
            this.ColAmount,
            this.colCurrency,
            this.colDescription});
            this.dataGridIncome.EnableHeadersVisualStyles = false;
            this.dataGridIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dataGridIncome.Location = new System.Drawing.Point(-7, 9);
            this.dataGridIncome.MultiSelect = false;
            this.dataGridIncome.Name = "dataGridIncome";
            this.dataGridIncome.ReadOnly = true;
            this.dataGridIncome.RowHeadersVisible = false;
            this.dataGridIncome.RowHeadersWidth = 82;
            this.dataGridIncome.RowTemplate.Height = 33;
            this.dataGridIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIncome.Size = new System.Drawing.Size(1285, 565);
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
            // IncomeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1468, 969);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Label label1;
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
    }
}