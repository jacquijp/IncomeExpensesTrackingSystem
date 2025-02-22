using System;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
    public partial class AddNewIncomeForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewIncomeForm));
            this.header_newIncome = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label_newIncome = new System.Windows.Forms.Label();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_DescripNewIncome = new System.Windows.Forms.TextBox();
            this.textBox_AmountNewIncome = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NewIncome = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelIncome = new System.Windows.Forms.Button();
            this.btnSaveIncome = new System.Windows.Forms.Button();

            // Inicialización de componentes
            this.header_newIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // 
            // header_newIncome
            // 
            this.header_newIncome.BackColor = System.Drawing.Color.FromArgb(10, 61, 98);
            this.header_newIncome.Controls.Add(this.labelClose);
            this.header_newIncome.Controls.Add(this.label_newIncome);
            this.header_newIncome.Controls.Add(this.leftCornerLogo);
            this.header_newIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_newIncome.Location = new System.Drawing.Point(0, 0);
            this.header_newIncome.Name = "header_newIncome";
            this.header_newIncome.Size = new System.Drawing.Size(1051, 87);
            this.header_newIncome.TabIndex = 0;

            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(1005, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 22);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);

            // 
            // label_newIncome
            // 
            this.label_newIncome.AutoSize = true;
            this.label_newIncome.Font = new System.Drawing.Font("Montserrat", 10.125F);
            this.label_newIncome.ForeColor = System.Drawing.Color.White;
            this.label_newIncome.Location = new System.Drawing.Point(76, 25);
            this.label_newIncome.Name = "label_newIncome";
            this.label_newIncome.Padding = new System.Windows.Forms.Padding(10);
            this.label_newIncome.Size = new System.Drawing.Size(168, 42);
            this.label_newIncome.TabIndex = 1;
            this.label_newIncome.Text = "New Income";

            // 
            // leftCornerLogo
            // 
            this.leftCornerLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftCornerLogo.Image = ((System.Drawing.Image)(resources.GetObject("leftCornerLogo.Image")));
            this.leftCornerLogo.Location = new System.Drawing.Point(9, 15);
            this.leftCornerLogo.Name = "leftCornerLogo";
            this.leftCornerLogo.Size = new System.Drawing.Size(50, 50);
            this.leftCornerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftCornerLogo.TabIndex = 2;
            this.leftCornerLogo.TabStop = false;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_DescripNewIncome);
            this.panel1.Controls.Add(this.textBox_AmountNewIncome);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.dateTimePicker_NewIncome);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Location = new System.Drawing.Point(9, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 400);
            this.panel1.TabIndex = 1;

            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelIncome);
            this.panel2.Controls.Add(this.btnSaveIncome);
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 100);
            this.panel2.TabIndex = 5;

            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.Text = "Save";
            this.btnSaveIncome.Location = new System.Drawing.Point(750, 30);
            this.btnSaveIncome.Click += new System.EventHandler(this.btnSaveIncome_Click);

            // 
            // btnCancelIncome
            // 
            this.btnCancelIncome.Text = "Cancel";
            this.btnCancelIncome.Location = new System.Drawing.Point(600, 30);
            this.btnCancelIncome.Click += new System.EventHandler(this.btnCancelIncome_Click);

            // 
            // AddNewIncomeForm
            // 
            this.ClientSize = new System.Drawing.Size(1051, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_newIncome);
            this.Name = "AddNewIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Income";
            this.Load += new System.EventHandler(this.AddNewIncomeForm_Load);

            // Finalizar inicialización de componentes
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
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_DescripNewIncome;
        private System.Windows.Forms.TextBox textBox_AmountNewIncome;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NewIncome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelIncome;
        private System.Windows.Forms.Button btnSaveIncome;
    }
}
