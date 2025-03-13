namespace IncomeExpensesTrackingSystem
{
    partial class SavingsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsManagementForm));
            this.label_savingsManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close_Click = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridSavings = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportSavings = new System.Windows.Forms.Button();
            this.btnDeleteSavings = new System.Windows.Forms.Button();
            this.btnEditSavings = new System.Windows.Forms.Button();
            this.btnAddNewSaving = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSavingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSavings)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_savingsManagement
            // 
            this.label_savingsManagement.AutoSize = true;
            this.label_savingsManagement.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_savingsManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_savingsManagement.Location = new System.Drawing.Point(92, 27);
            this.label_savingsManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_savingsManagement.Name = "label_savingsManagement";
            this.label_savingsManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_savingsManagement.Size = new System.Drawing.Size(359, 45);
            this.label_savingsManagement.TabIndex = 2;
            this.label_savingsManagement.Text = "Savings Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close_Click);
            this.panel1.Controls.Add(this.label_savingsManagement);
            this.panel1.Controls.Add(this.leftCornerLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(1392, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 38);
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
            this.close_Click.Location = new System.Drawing.Point(2860, 10);
            this.close_Click.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(34, 38);
            this.close_Click.TabIndex = 10;
            this.close_Click.Text = "X";
            // 
            // leftCornerLogo
            // 
            this.leftCornerLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftCornerLogo.Image = ((System.Drawing.Image)(resources.GetObject("leftCornerLogo.Image")));
            this.leftCornerLogo.Location = new System.Drawing.Point(22, 17);
            this.leftCornerLogo.Margin = new System.Windows.Forms.Padding(0);
            this.leftCornerLogo.Name = "leftCornerLogo";
            this.leftCornerLogo.Size = new System.Drawing.Size(52, 50);
            this.leftCornerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftCornerLogo.TabIndex = 1;
            this.leftCornerLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridSavings);
            this.panel2.Location = new System.Drawing.Point(64, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 538);
            this.panel2.TabIndex = 2;
            // 
            // dataGridSavings
            // 
            this.dataGridSavings.AllowUserToAddRows = false;
            this.dataGridSavings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dataGridSavings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSavings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colSavingID,
            this.colConcept,
            this.colStartDate,
            this.colGoal,
            this.colDeposit,
            this.colCurrency,
            this.colProgress});
            this.dataGridSavings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSavings.Location = new System.Drawing.Point(0, 0);
            this.dataGridSavings.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSavings.Name = "dataGridSavings";
            this.dataGridSavings.ReadOnly = true;
            this.dataGridSavings.RowHeadersVisible = false;
            this.dataGridSavings.RowHeadersWidth = 82;
            this.dataGridSavings.RowTemplate.Height = 33;
            this.dataGridSavings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSavings.Size = new System.Drawing.Size(1288, 538);
            this.dataGridSavings.TabIndex = 0;
            this.dataGridSavings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSavings_CellContentClick);
            this.dataGridSavings.SelectionChanged += new System.EventHandler(this.dataGridSavings_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportSavings);
            this.panel3.Controls.Add(this.btnDeleteSavings);
            this.panel3.Controls.Add(this.btnEditSavings);
            this.panel3.Location = new System.Drawing.Point(0, 862);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1436, 188);
            this.panel3.TabIndex = 3;
            // 
            // btnExportSavings
            // 
            this.btnExportSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnExportSavings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportSavings.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnExportSavings.Location = new System.Drawing.Point(1114, 31);
            this.btnExportSavings.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportSavings.Name = "btnExportSavings";
            this.btnExportSavings.Size = new System.Drawing.Size(268, 67);
            this.btnExportSavings.TabIndex = 9;
            this.btnExportSavings.Text = "Export to Excel";
            this.btnExportSavings.UseVisualStyleBackColor = false;
            this.btnExportSavings.Click += new System.EventHandler(this.btnExportSavings_Click);
            // 
            // btnDeleteSavings
            // 
            this.btnDeleteSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnDeleteSavings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSavings.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnDeleteSavings.Location = new System.Drawing.Point(248, 48);
            this.btnDeleteSavings.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSavings.Name = "btnDeleteSavings";
            this.btnDeleteSavings.Size = new System.Drawing.Size(142, 67);
            this.btnDeleteSavings.TabIndex = 8;
            this.btnDeleteSavings.Text = "Delete";
            this.btnDeleteSavings.UseVisualStyleBackColor = false;
            this.btnDeleteSavings.Click += new System.EventHandler(this.btnDeleteSavings_Click);
            // 
            // btnEditSavings
            // 
            this.btnEditSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEditSavings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSavings.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnEditSavings.Location = new System.Drawing.Point(76, 48);
            this.btnEditSavings.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSavings.Name = "btnEditSavings";
            this.btnEditSavings.Size = new System.Drawing.Size(142, 67);
            this.btnEditSavings.TabIndex = 7;
            this.btnEditSavings.Text = "Edit ";
            this.btnEditSavings.UseVisualStyleBackColor = false;
            this.btnEditSavings.Click += new System.EventHandler(this.btnEditSavings_Click);
            // 
            // btnAddNewSaving
            // 
            this.btnAddNewSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAddNewSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSaving.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnAddNewSaving.Location = new System.Drawing.Point(1112, 33);
            this.btnAddNewSaving.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewSaving.Name = "btnAddNewSaving";
            this.btnAddNewSaving.Size = new System.Drawing.Size(268, 67);
            this.btnAddNewSaving.TabIndex = 11;
            this.btnAddNewSaving.Text = "+ Add New Saving";
            this.btnAddNewSaving.UseVisualStyleBackColor = false;
            this.btnAddNewSaving.Click += new System.EventHandler(this.btnAddNewSaving_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddNewSaving);
            this.panel4.Location = new System.Drawing.Point(0, 119);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1436, 144);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.MinimumWidth = 10;
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Width = 60;
            // 
            // colSavingID
            // 
            this.colSavingID.HeaderText = "Saving ID";
            this.colSavingID.MinimumWidth = 10;
            this.colSavingID.Name = "colSavingID";
            this.colSavingID.ReadOnly = true;
            this.colSavingID.Width = 90;
            // 
            // colConcept
            // 
            this.colConcept.HeaderText = "Saving Concept ";
            this.colConcept.MinimumWidth = 10;
            this.colConcept.Name = "colConcept";
            this.colConcept.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "Starting Date";
            this.colStartDate.MinimumWidth = 10;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            this.colStartDate.Width = 90;
            // 
            // colGoal
            // 
            this.colGoal.HeaderText = "Saving Goal";
            this.colGoal.MinimumWidth = 10;
            this.colGoal.Name = "colGoal";
            this.colGoal.ReadOnly = true;
            // 
            // colDeposit
            // 
            this.colDeposit.HeaderText = "Deposit";
            this.colDeposit.MinimumWidth = 10;
            this.colDeposit.Name = "colDeposit";
            this.colDeposit.ReadOnly = true;
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.MinimumWidth = 10;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Width = 60;
            // 
            // colProgress
            // 
            this.colProgress.HeaderText = "Progress";
            this.colProgress.MinimumWidth = 10;
            this.colProgress.Name = "colProgress";
            this.colProgress.ReadOnly = true;
            // 
            // SavingsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1436, 1046);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SavingsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SavingsManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSavings)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_savingsManagement;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_Click;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridSavings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExportSavings;
        private System.Windows.Forms.Button btnDeleteSavings;
        private System.Windows.Forms.Button btnEditSavings;
        private System.Windows.Forms.Button btnAddNewSaving;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSavingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgress;
    }
}