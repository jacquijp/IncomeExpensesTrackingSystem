namespace IncomeExpensesTrackingSystem
{
    partial class AddNewExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewExpenseForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelCloseNewExpense = new System.Windows.Forms.Label();
            this.labelNewExpense = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelExpense = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panelHeader.Controls.Add(this.labelCloseNewExpense);
            this.panelHeader.Controls.Add(this.labelNewExpense);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(934, 76);
            this.panelHeader.TabIndex = 4;
            // 
            // labelCloseNewExpense
            // 
            this.labelCloseNewExpense.AutoSize = true;
            this.labelCloseNewExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseNewExpense.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseNewExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelCloseNewExpense.Location = new System.Drawing.Point(888, 9);
            this.labelCloseNewExpense.Name = "labelCloseNewExpense";
            this.labelCloseNewExpense.Size = new System.Drawing.Size(34, 38);
            this.labelCloseNewExpense.TabIndex = 12;
            this.labelCloseNewExpense.Text = "X";
            this.labelCloseNewExpense.Click += new System.EventHandler(this.labelCloseNewExpense_Click);
            // 
            // labelNewExpense
            // 
            this.labelNewExpense.AutoSize = true;
            this.labelNewExpense.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelNewExpense.Location = new System.Drawing.Point(76, 9);
            this.labelNewExpense.Name = "labelNewExpense";
            this.labelNewExpense.Padding = new System.Windows.Forms.Padding(10);
            this.labelNewExpense.Size = new System.Drawing.Size(281, 62);
            this.labelNewExpense.TabIndex = 1;
            this.labelNewExpense.Text = "Add New Expense";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.dateTimePickerIncome);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 391);
            this.panel1.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(271, 323);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(330, 31);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(271, 236);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(248, 33);
            this.textBoxAmount.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(271, 147);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(252, 33);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.CalendarFont = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIncome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIncome.Location = new System.Drawing.Point(271, 63);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(186, 31);
            this.dateTimePickerIncome.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDescription.Location = new System.Drawing.Point(67, 316);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(156, 38);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelAmount.Location = new System.Drawing.Point(67, 231);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(116, 38);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelCategory.Location = new System.Drawing.Point(66, 142);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(126, 38);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDate.Location = new System.Drawing.Point(67, 63);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(75, 38);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSaveExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnSaveExpense.Location = new System.Drawing.Point(692, 27);
            this.btnSaveExpense.Margin = new System.Windows.Forms.Padding(10);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(178, 68);
            this.btnSaveExpense.TabIndex = 11;
            this.btnSaveExpense.Text = "Save";
            this.btnSaveExpense.UseVisualStyleBackColor = false;
            this.btnSaveExpense.Click += new System.EventHandler(this.btnSaveExpense_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelExpense);
            this.panel2.Controls.Add(this.btnSaveExpense);
            this.panel2.Location = new System.Drawing.Point(12, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 138);
            this.panel2.TabIndex = 6;
            // 
            // btnCancelExpense
            // 
            this.btnCancelExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancelExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancelExpense.Location = new System.Drawing.Point(467, 27);
            this.btnCancelExpense.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelExpense.Name = "btnCancelExpense";
            this.btnCancelExpense.Size = new System.Drawing.Size(177, 68);
            this.btnCancelExpense.TabIndex = 13;
            this.btnCancelExpense.Text = "Cancel";
            this.btnCancelExpense.UseVisualStyleBackColor = false;
            this.btnCancelExpense.Click += new System.EventHandler(this.btnCancelExpense_Click);
            // 
            // AddNewExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(934, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewExpenseForm";
            this.Text = "AddNewExpenseForm";
            this.Load += new System.EventHandler(this.AddNewExpenseForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelCloseNewExpense;
        private System.Windows.Forms.Label labelNewExpense;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelExpense;
    }
}