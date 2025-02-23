namespace IncomeExpensesTrackingSystem
{
    partial class EditExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExpenseForm));
            this.header_newIncome = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.datePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnCancelEditExpense = new System.Windows.Forms.Button();
            this.btnSaveEditExpense = new System.Windows.Forms.Button();
            this.header_newIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_newIncome
            // 
            this.header_newIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.header_newIncome.Controls.Add(this.btnClose);
            this.header_newIncome.Controls.Add(this.labelTitle);
            this.header_newIncome.Controls.Add(this.leftCornerLogo);
            this.header_newIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_newIncome.Location = new System.Drawing.Point(0, 0);
            this.header_newIncome.Name = "header_newIncome";
            this.header_newIncome.Size = new System.Drawing.Size(825, 76);
            this.header_newIncome.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnClose.Location = new System.Drawing.Point(779, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelTitle.Location = new System.Drawing.Point(76, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.labelTitle.Size = new System.Drawing.Size(420, 124);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Edit Expense";
            // 
            // leftCornerLogo
            // 
            this.leftCornerLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftCornerLogo.Image = ((System.Drawing.Image)(resources.GetObject("leftCornerLogo.Image")));
            this.leftCornerLogo.Location = new System.Drawing.Point(9, 9);
            this.leftCornerLogo.Margin = new System.Windows.Forms.Padding(0);
            this.leftCornerLogo.Name = "leftCornerLogo";
            this.leftCornerLogo.Size = new System.Drawing.Size(51, 50);
            this.leftCornerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftCornerLogo.TabIndex = 2;
            this.leftCornerLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.datePickerExpense);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Location = new System.Drawing.Point(26, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 373);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelEditExpense);
            this.panel2.Controls.Add(this.btnSaveEditExpense);
            this.panel2.Location = new System.Drawing.Point(26, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 141);
            this.panel2.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDate.Location = new System.Drawing.Point(50, 50);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(10);
            this.labelDate.Size = new System.Drawing.Size(95, 58);
            this.labelDate.TabIndex = 22;
            this.labelDate.Text = "Date";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelAmount.Location = new System.Drawing.Point(50, 161);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Padding = new System.Windows.Forms.Padding(10);
            this.labelAmount.Size = new System.Drawing.Size(136, 58);
            this.labelAmount.TabIndex = 23;
            this.labelAmount.Text = "Amount";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDescription.Location = new System.Drawing.Point(50, 268);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(10);
            this.labelDescription.Size = new System.Drawing.Size(176, 58);
            this.labelDescription.TabIndex = 24;
            this.labelDescription.Text = "Description";
            // 
            // datePickerExpense
            // 
            this.datePickerExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerExpense.Location = new System.Drawing.Point(254, 67);
            this.datePickerExpense.Name = "datePickerExpense";
            this.datePickerExpense.Size = new System.Drawing.Size(196, 31);
            this.datePickerExpense.TabIndex = 25;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(254, 170);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(256, 33);
            this.textBoxAmount.TabIndex = 26;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(254, 268);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(256, 33);
            this.textBoxDescription.TabIndex = 27;
            // 
            // btnCancelEditExpense
            // 
            this.btnCancelEditExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancelEditExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEditExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancelEditExpense.Location = new System.Drawing.Point(376, 26);
            this.btnCancelEditExpense.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelEditExpense.Name = "btnCancelEditExpense";
            this.btnCancelEditExpense.Size = new System.Drawing.Size(178, 68);
            this.btnCancelEditExpense.TabIndex = 12;
            this.btnCancelEditExpense.Text = "Cancel";
            this.btnCancelEditExpense.UseVisualStyleBackColor = false;
            this.btnCancelEditExpense.Click += new System.EventHandler(this.btnCancelEditExpense_Click);
            // 
            // btnSaveEditExpense
            // 
            this.btnSaveEditExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSaveEditExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEditExpense.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnSaveEditExpense.Location = new System.Drawing.Point(587, 24);
            this.btnSaveEditExpense.Margin = new System.Windows.Forms.Padding(10);
            this.btnSaveEditExpense.Name = "btnSaveEditExpense";
            this.btnSaveEditExpense.Size = new System.Drawing.Size(178, 68);
            this.btnSaveEditExpense.TabIndex = 11;
            this.btnSaveEditExpense.Text = "Save";
            this.btnSaveEditExpense.UseVisualStyleBackColor = false;
            this.btnSaveEditExpense.Click += new System.EventHandler(this.btnSaveEditExpense_Click);
            // 
            // EditExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_newIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditExpenseForm";
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
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker datePickerExpense;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button btnCancelEditExpense;
        private System.Windows.Forms.Button btnSaveEditExpense;
    }
}