namespace IncomeExpensesTrackingSystem
{
    partial class EditIncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIncomeForm));
            this.header_editIncome = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDescriptionIncome = new System.Windows.Forms.TextBox();
            this.textBoxAmountIncome = new System.Windows.Forms.TextBox();
            this.datePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnCancelEditIncome = new System.Windows.Forms.Button();
            this.btnSaveEditIncome = new System.Windows.Forms.Button();
            this.header_editIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_editIncome
            // 
            this.header_editIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.header_editIncome.Controls.Add(this.btnClose);
            this.header_editIncome.Controls.Add(this.labelTitle);
            this.header_editIncome.Controls.Add(this.leftCornerLogo);
            this.header_editIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_editIncome.Location = new System.Drawing.Point(0, 0);
            this.header_editIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.header_editIncome.Name = "header_editIncome";
            this.header_editIncome.Size = new System.Drawing.Size(448, 40);
            this.header_editIncome.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnClose.Location = new System.Drawing.Point(426, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 18);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelTitle.Location = new System.Drawing.Point(38, 5);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelTitle.Size = new System.Drawing.Size(105, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Edit Income";
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
            this.panel1.Controls.Add(this.textBoxDescriptionIncome);
            this.panel1.Controls.Add(this.textBoxAmountIncome);
            this.panel1.Controls.Add(this.datePickerIncome);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Location = new System.Drawing.Point(33, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 194);
            this.panel1.TabIndex = 5;
            // 
            // textBoxDescriptionIncome
            // 
            this.textBoxDescriptionIncome.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptionIncome.Location = new System.Drawing.Point(127, 139);
            this.textBoxDescriptionIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescriptionIncome.Name = "textBoxDescriptionIncome";
            this.textBoxDescriptionIncome.Size = new System.Drawing.Size(130, 20);
            this.textBoxDescriptionIncome.TabIndex = 27;
            // 
            // textBoxAmountIncome
            // 
            this.textBoxAmountIncome.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountIncome.Location = new System.Drawing.Point(127, 88);
            this.textBoxAmountIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountIncome.Name = "textBoxAmountIncome";
            this.textBoxAmountIncome.Size = new System.Drawing.Size(130, 20);
            this.textBoxAmountIncome.TabIndex = 26;
            // 
            // datePickerIncome
            // 
            this.datePickerIncome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerIncome.Location = new System.Drawing.Point(127, 35);
            this.datePickerIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickerIncome.Name = "datePickerIncome";
            this.datePickerIncome.Size = new System.Drawing.Size(100, 20);
            this.datePickerIncome.TabIndex = 25;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDescription.Location = new System.Drawing.Point(25, 139);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelDescription.Size = new System.Drawing.Size(88, 28);
            this.labelDescription.TabIndex = 24;
            this.labelDescription.Text = "Description";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelAmount.Location = new System.Drawing.Point(25, 84);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelAmount.Size = new System.Drawing.Size(69, 28);
            this.labelAmount.TabIndex = 23;
            this.labelAmount.Text = "Amount";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDate.Location = new System.Drawing.Point(25, 26);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelDate.Size = new System.Drawing.Size(47, 28);
            this.labelDate.TabIndex = 22;
            this.labelDate.Text = "Date";
            // 
            // btnCancelEditIncome
            // 
            this.btnCancelEditIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancelEditIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEditIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancelEditIncome.Location = new System.Drawing.Point(221, 299);
            this.btnCancelEditIncome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelEditIncome.Name = "btnCancelEditIncome";
            this.btnCancelEditIncome.Size = new System.Drawing.Size(89, 35);
            this.btnCancelEditIncome.TabIndex = 14;
            this.btnCancelEditIncome.Text = "Cancel";
            this.btnCancelEditIncome.UseVisualStyleBackColor = false;
            this.btnCancelEditIncome.Click += new System.EventHandler(this.btnCancelEditIncome_Click);
            // 
            // btnSaveEditIncome
            // 
            this.btnSaveEditIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSaveEditIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEditIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnSaveEditIncome.Location = new System.Drawing.Point(326, 298);
            this.btnSaveEditIncome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveEditIncome.Name = "btnSaveEditIncome";
            this.btnSaveEditIncome.Size = new System.Drawing.Size(89, 35);
            this.btnSaveEditIncome.TabIndex = 13;
            this.btnSaveEditIncome.Text = "Save";
            this.btnSaveEditIncome.UseVisualStyleBackColor = false;
            this.btnSaveEditIncome.Click += new System.EventHandler(this.btnSaveEditIncome_Click);
            // 
            // EditIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(448, 363);
            this.Controls.Add(this.btnCancelEditIncome);
            this.Controls.Add(this.btnSaveEditIncome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_editIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditIncomeForm";
            this.Load += new System.EventHandler(this.EditIncomeForm_Load);
            this.header_editIncome.ResumeLayout(false);
            this.header_editIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_editIncome;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDescriptionIncome;
        private System.Windows.Forms.TextBox textBoxAmountIncome;
        private System.Windows.Forms.DateTimePicker datePickerIncome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnCancelEditIncome;
        private System.Windows.Forms.Button btnSaveEditIncome;
    }
}