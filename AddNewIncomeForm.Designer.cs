namespace IncomeExpensesTrackingSystem
{
    partial class AddNewIncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewIncomeForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelCloseNewIncome = new System.Windows.Forms.Label();
            this.labelNewIncome = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelIncome = new System.Windows.Forms.Button();
            this.btnSaveIncome = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panelHeader.Controls.Add(this.labelCloseNewIncome);
            this.panelHeader.Controls.Add(this.labelNewIncome);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(469, 42);
            this.panelHeader.TabIndex = 3;
            // 
            // labelCloseNewIncome
            // 
            this.labelCloseNewIncome.AutoSize = true;
            this.labelCloseNewIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseNewIncome.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseNewIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelCloseNewIncome.Location = new System.Drawing.Point(444, 5);
            this.labelCloseNewIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCloseNewIncome.Name = "labelCloseNewIncome";
            this.labelCloseNewIncome.Size = new System.Drawing.Size(17, 18);
            this.labelCloseNewIncome.TabIndex = 12;
            this.labelCloseNewIncome.Text = "X";
            this.labelCloseNewIncome.Click += new System.EventHandler(this.labelCloseNewIncome_Click);
            // 
            // labelNewIncome
            // 
            this.labelNewIncome.AutoSize = true;
            this.labelNewIncome.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelNewIncome.Location = new System.Drawing.Point(38, 5);
            this.labelNewIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewIncome.Name = "labelNewIncome";
            this.labelNewIncome.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelNewIncome.Size = new System.Drawing.Size(140, 32);
            this.labelNewIncome.TabIndex = 1;
            this.labelNewIncome.Text = "Add New Income";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 5);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(26, 26);
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
            this.panel1.Location = new System.Drawing.Point(4, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 242);
            this.panel1.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(136, 168);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(167, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(136, 123);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(126, 20);
            this.textBoxAmount.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(136, 76);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.CalendarFont = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIncome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIncome.Location = new System.Drawing.Point(136, 33);
            this.dateTimePickerIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerIncome.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDescription.Location = new System.Drawing.Point(34, 164);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(78, 18);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelAmount.Location = new System.Drawing.Point(34, 120);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(59, 18);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelCategory.Location = new System.Drawing.Point(33, 74);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(64, 18);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDate.Location = new System.Drawing.Point(34, 33);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 18);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelIncome);
            this.panel2.Controls.Add(this.btnSaveIncome);
            this.panel2.Location = new System.Drawing.Point(4, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 72);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelIncome
            // 
            this.btnCancelIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancelIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancelIncome.Location = new System.Drawing.Point(239, 14);
            this.btnCancelIncome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelIncome.Name = "btnCancelIncome";
            this.btnCancelIncome.Size = new System.Drawing.Size(89, 35);
            this.btnCancelIncome.TabIndex = 12;
            this.btnCancelIncome.Text = "Cancel";
            this.btnCancelIncome.UseVisualStyleBackColor = false;
            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSaveIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnSaveIncome.Location = new System.Drawing.Point(346, 14);
            this.btnSaveIncome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveIncome.Name = "btnSaveIncome";
            this.btnSaveIncome.Size = new System.Drawing.Size(89, 35);
            this.btnSaveIncome.TabIndex = 11;
            this.btnSaveIncome.Text = "Save";
            this.btnSaveIncome.UseVisualStyleBackColor = false;
            // 
            // AddNewIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 346);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewIncomeForm";
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
        private System.Windows.Forms.Label labelCloseNewIncome;
        private System.Windows.Forms.Label labelNewIncome;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnCancelIncome;
        private System.Windows.Forms.Button btnSaveIncome;
    }
}