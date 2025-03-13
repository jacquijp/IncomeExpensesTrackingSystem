namespace IncomeExpensesTrackingSystem
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.header_Reports = new System.Windows.Forms.Panel();
            this.label_closeX = new System.Windows.Forms.Label();
            this.label_reports = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_TransactionType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelReportFormat = new System.Windows.Forms.Label();
            this.abelTransactionType = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.labelGenerateReport = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.header_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_Reports
            // 
            this.header_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.header_Reports.Controls.Add(this.label_closeX);
            this.header_Reports.Controls.Add(this.label_reports);
            this.header_Reports.Controls.Add(this.leftCornerLogo);
            this.header_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_Reports.Location = new System.Drawing.Point(0, 0);
            this.header_Reports.Name = "header_Reports";
            this.header_Reports.Size = new System.Drawing.Size(847, 87);
            this.header_Reports.TabIndex = 3;
            // 
            // label_closeX
            // 
            this.label_closeX.AutoSize = true;
            this.label_closeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_closeX.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_closeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_closeX.Location = new System.Drawing.Point(801, 9);
            this.label_closeX.Name = "label_closeX";
            this.label_closeX.Size = new System.Drawing.Size(34, 38);
            this.label_closeX.TabIndex = 12;
            this.label_closeX.Text = "X";
            this.label_closeX.Click += new System.EventHandler(this.btnCloseReports);
            // 
            // label_reports
            // 
            this.label_reports.AutoSize = true;
            this.label_reports.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_reports.Location = new System.Drawing.Point(76, 9);
            this.label_reports.Name = "label_reports";
            this.label_reports.Padding = new System.Windows.Forms.Padding(10);
            this.label_reports.Size = new System.Drawing.Size(144, 62);
            this.label_reports.TabIndex = 1;
            this.label_reports.Text = "Reports";
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
            this.panel1.Controls.Add(this.comboBox_TransactionType);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.labelReportFormat);
            this.panel1.Controls.Add(this.abelTransactionType);
            this.panel1.Controls.Add(this.label_to);
            this.panel1.Controls.Add(this.label_from);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.labelGenerateReport);
            this.panel1.Location = new System.Drawing.Point(25, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 420);
            this.panel1.TabIndex = 4;
            // 
            // comboBox_TransactionType
            // 
            this.comboBox_TransactionType.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TransactionType.FormattingEnabled = true;
            this.comboBox_TransactionType.Location = new System.Drawing.Point(321, 284);
            this.comboBox_TransactionType.Name = "comboBox_TransactionType";
            this.comboBox_TransactionType.Size = new System.Drawing.Size(323, 41);
            this.comboBox_TransactionType.TabIndex = 30;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(483, 170);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(210, 31);
            this.dateTimePickerTo.TabIndex = 29;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(131, 170);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(199, 31);
            this.dateTimePickerFrom.TabIndex = 28;
            // 
            // labelReportFormat
            // 
            this.labelReportFormat.AutoSize = true;
            this.labelReportFormat.BackColor = System.Drawing.Color.Transparent;
            this.labelReportFormat.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelReportFormat.Location = new System.Drawing.Point(44, 384);
            this.labelReportFormat.Name = "labelReportFormat";
            this.labelReportFormat.Padding = new System.Windows.Forms.Padding(10);
            this.labelReportFormat.Size = new System.Drawing.Size(20, 58);
            this.labelReportFormat.TabIndex = 27;
            // 
            // abelTransactionType
            // 
            this.abelTransactionType.AutoSize = true;
            this.abelTransactionType.BackColor = System.Drawing.Color.Transparent;
            this.abelTransactionType.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abelTransactionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.abelTransactionType.Location = new System.Drawing.Point(32, 272);
            this.abelTransactionType.Name = "abelTransactionType";
            this.abelTransactionType.Padding = new System.Windows.Forms.Padding(10);
            this.abelTransactionType.Size = new System.Drawing.Size(240, 58);
            this.abelTransactionType.TabIndex = 26;
            this.abelTransactionType.Text = "Transaction Type";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.Color.Transparent;
            this.label_to.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label_to.Location = new System.Drawing.Point(421, 159);
            this.label_to.Name = "label_to";
            this.label_to.Padding = new System.Windows.Forms.Padding(10);
            this.label_to.Size = new System.Drawing.Size(65, 58);
            this.label_to.TabIndex = 25;
            this.label_to.Text = "To";
            this.label_to.Click += new System.EventHandler(this.label_to_Click);
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.Color.Transparent;
            this.label_from.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label_from.Location = new System.Drawing.Point(32, 159);
            this.label_from.Name = "label_from";
            this.label_from.Padding = new System.Windows.Forms.Padding(10);
            this.label_from.Size = new System.Drawing.Size(102, 58);
            this.label_from.TabIndex = 24;
            this.label_from.Text = "From";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label_date.Location = new System.Drawing.Point(32, 101);
            this.label_date.Name = "label_date";
            this.label_date.Padding = new System.Windows.Forms.Padding(10);
            this.label_date.Size = new System.Drawing.Size(95, 58);
            this.label_date.TabIndex = 23;
            this.label_date.Text = "Date";
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // labelGenerateReport
            // 
            this.labelGenerateReport.AutoSize = true;
            this.labelGenerateReport.BackColor = System.Drawing.Color.Transparent;
            this.labelGenerateReport.Font = new System.Drawing.Font("Montserrat Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelGenerateReport.Location = new System.Drawing.Point(13, 12);
            this.labelGenerateReport.Name = "labelGenerateReport";
            this.labelGenerateReport.Padding = new System.Windows.Forms.Padding(10);
            this.labelGenerateReport.Size = new System.Drawing.Size(297, 62);
            this.labelGenerateReport.TabIndex = 22;
            this.labelGenerateReport.Text = "Generate a report";
            this.labelGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGenerateReport.Click += new System.EventHandler(this.labelGenerateReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancel.Location = new System.Drawing.Point(376, 582);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 68);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnGenerateReport.Location = new System.Drawing.Point(574, 582);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(10);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(252, 68);
            this.btnGenerateReport.TabIndex = 11;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click_1);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 728);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_Reports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.header_Reports.ResumeLayout(false);
            this.header_Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_Reports;
        private System.Windows.Forms.Label label_closeX;
        private System.Windows.Forms.Label label_reports;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGenerateReport;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label labelReportFormat;
        private System.Windows.Forms.Label abelTransactionType;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.ComboBox comboBox_TransactionType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}