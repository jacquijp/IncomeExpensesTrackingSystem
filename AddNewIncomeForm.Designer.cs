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
            this.header_newIncome = new System.Windows.Forms.Panel();
            this.label_newIncome = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dateTimePicker_NewIncome = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_AmountNewIncome = new System.Windows.Forms.TextBox();
            this.textBox_DescripNewIncome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveIncome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.header_newIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_newIncome
            // 
            this.header_newIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.header_newIncome.Controls.Add(this.label2);
            this.header_newIncome.Controls.Add(this.label_newIncome);
            this.header_newIncome.Controls.Add(this.leftCornerLogo);
            this.header_newIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_newIncome.Location = new System.Drawing.Point(0, 0);
            this.header_newIncome.Name = "header_newIncome";
            this.header_newIncome.Size = new System.Drawing.Size(1051, 87);
            this.header_newIncome.TabIndex = 0;
            this.header_newIncome.Paint += new System.Windows.Forms.PaintEventHandler(this.header_newIncome_Paint);
            // 
            // label_newIncome
            // 
            this.label_newIncome.AutoSize = true;
            this.label_newIncome.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_newIncome.Location = new System.Drawing.Point(76, 9);
            this.label_newIncome.Name = "label_newIncome";
            this.label_newIncome.Padding = new System.Windows.Forms.Padding(10);
            this.label_newIncome.Size = new System.Drawing.Size(210, 62);
            this.label_newIncome.TabIndex = 1;
            this.label_newIncome.Text = "New Income";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(1005, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_DescripNewIncome);
            this.panel1.Controls.Add(this.textBox_AmountNewIncome);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker_NewIncome);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Location = new System.Drawing.Point(9, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 453);
            this.panel1.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDate.Location = new System.Drawing.Point(45, 74);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(10);
            this.labelDate.Size = new System.Drawing.Size(95, 58);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelCategory.Location = new System.Drawing.Point(45, 158);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Padding = new System.Windows.Forms.Padding(10);
            this.labelCategory.Size = new System.Drawing.Size(146, 58);
            this.labelCategory.TabIndex = 14;
            this.labelCategory.Text = "Category";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelAmount.Location = new System.Drawing.Point(45, 243);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Padding = new System.Windows.Forms.Padding(10);
            this.labelAmount.Size = new System.Drawing.Size(136, 58);
            this.labelAmount.TabIndex = 15;
            this.labelAmount.Text = "Amount";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDescription.Location = new System.Drawing.Point(45, 324);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(10);
            this.labelDescription.Size = new System.Drawing.Size(176, 58);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Description";
            // 
            // dateTimePicker_NewIncome
            // 
            this.dateTimePicker_NewIncome.CalendarFont = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NewIncome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NewIncome.Location = new System.Drawing.Point(219, 87);
            this.dateTimePicker_NewIncome.Name = "dateTimePicker_NewIncome";
            this.dateTimePicker_NewIncome.Size = new System.Drawing.Size(196, 31);
            this.dateTimePicker_NewIncome.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // textBox_AmountNewIncome
            // 
            this.textBox_AmountNewIncome.Location = new System.Drawing.Point(219, 247);
            this.textBox_AmountNewIncome.MaxLength = 10;
            this.textBox_AmountNewIncome.Name = "textBox_AmountNewIncome";
            this.textBox_AmountNewIncome.Size = new System.Drawing.Size(270, 31);
            this.textBox_AmountNewIncome.TabIndex = 19;
            // 
            // textBox_DescripNewIncome
            // 
            this.textBox_DescripNewIncome.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DescripNewIncome.Location = new System.Drawing.Point(219, 338);
            this.textBox_DescripNewIncome.Name = "textBox_DescripNewIncome";
            this.textBox_DescripNewIncome.Size = new System.Drawing.Size(762, 33);
            this.textBox_DescripNewIncome.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.saveIncome);
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 135);
            this.panel2.TabIndex = 5;
            // 
            // saveIncome
            // 
            this.saveIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.saveIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveIncome.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.saveIncome.Location = new System.Drawing.Point(833, 23);
            this.saveIncome.Margin = new System.Windows.Forms.Padding(10);
            this.saveIncome.Name = "saveIncome";
            this.saveIncome.Size = new System.Drawing.Size(178, 68);
            this.saveIncome.TabIndex = 7;
            this.saveIncome.Text = "Save";
            this.saveIncome.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.button1.Location = new System.Drawing.Point(619, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddNewIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1051, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_newIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewIncomeForm";
            this.Load += new System.EventHandler(this.AddNewIncomeForm_Load);
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
        private System.Windows.Forms.Label label_newIncome;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBox_DescripNewIncome;
        private System.Windows.Forms.TextBox textBox_AmountNewIncome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NewIncome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveIncome;
    }
}