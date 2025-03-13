namespace IncomeExpensesTrackingSystem
{
    partial class EditSavingsGoalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSavingsGoalForm));
            this.header_newIncome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_editSavings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEditSavingDeposit = new System.Windows.Forms.TextBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.txtEditSavingGoal = new System.Windows.Forms.TextBox();
            this.txtEditSavingConcept = new System.Windows.Forms.TextBox();
            this.labelEditGoal = new System.Windows.Forms.Label();
            this.labelConcept = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelEditSaving = new System.Windows.Forms.Button();
            this.btnSaveEditSaving = new System.Windows.Forms.Button();
            this.leftCornerLogo = new System.Windows.Forms.PictureBox();
            this.header_newIncome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // header_newIncome
            // 
            this.header_newIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.header_newIncome.Controls.Add(this.label2);
            this.header_newIncome.Controls.Add(this.label_editSavings);
            this.header_newIncome.Controls.Add(this.leftCornerLogo);
            this.header_newIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_newIncome.Location = new System.Drawing.Point(0, 0);
            this.header_newIncome.Name = "header_newIncome";
            this.header_newIncome.Size = new System.Drawing.Size(825, 76);
            this.header_newIncome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(751, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.close_Click_Click);
            // 
            // label_editSavings
            // 
            this.label_editSavings.AutoSize = true;
            this.label_editSavings.Font = new System.Drawing.Font("Montserrat", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_editSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label_editSavings.Location = new System.Drawing.Point(76, 9);
            this.label_editSavings.Name = "label_editSavings";
            this.label_editSavings.Padding = new System.Windows.Forms.Padding(10);
            this.label_editSavings.Size = new System.Drawing.Size(270, 62);
            this.label_editSavings.TabIndex = 1;
            this.label_editSavings.Text = "Edit Savings Goal";
            //this.label_editSavings.Click += new System.EventHandler(this.label_editSavings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEditSavingDeposit);
            this.panel1.Controls.Add(this.labelDeposit);
            this.panel1.Controls.Add(this.txtEditSavingGoal);
            this.panel1.Controls.Add(this.txtEditSavingConcept);
            this.panel1.Controls.Add(this.labelEditGoal);
            this.panel1.Controls.Add(this.labelConcept);
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 391);
            this.panel1.TabIndex = 3;
            // 
            // txtEditSavingDeposit
            // 
            this.txtEditSavingDeposit.Location = new System.Drawing.Point(201, 273);
            this.txtEditSavingDeposit.MaxLength = 10;
            this.txtEditSavingDeposit.Name = "txtEditSavingDeposit";
            this.txtEditSavingDeposit.Size = new System.Drawing.Size(256, 31);
            this.txtEditSavingDeposit.TabIndex = 26;
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.BackColor = System.Drawing.Color.Transparent;
            this.labelDeposit.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelDeposit.Location = new System.Drawing.Point(40, 259);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Padding = new System.Windows.Forms.Padding(10);
            this.labelDeposit.Size = new System.Drawing.Size(130, 58);
            this.labelDeposit.TabIndex = 25;
            this.labelDeposit.Text = "Deposit";
            // 
            // txtEditSavingGoal
            // 
            this.txtEditSavingGoal.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSavingGoal.Location = new System.Drawing.Point(201, 173);
            this.txtEditSavingGoal.Name = "txtEditSavingGoal";
            this.txtEditSavingGoal.Size = new System.Drawing.Size(256, 33);
            this.txtEditSavingGoal.TabIndex = 24;
            // 
            // txtEditSavingConcept
            // 
            this.txtEditSavingConcept.Location = new System.Drawing.Point(201, 69);
            this.txtEditSavingConcept.MaxLength = 10;
            this.txtEditSavingConcept.Name = "txtEditSavingConcept";
            this.txtEditSavingConcept.Size = new System.Drawing.Size(335, 31);
            this.txtEditSavingConcept.TabIndex = 23;
            // 
            // labelEditGoal
            // 
            this.labelEditGoal.AutoSize = true;
            this.labelEditGoal.BackColor = System.Drawing.Color.Transparent;
            this.labelEditGoal.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelEditGoal.Location = new System.Drawing.Point(49, 159);
            this.labelEditGoal.Name = "labelEditGoal";
            this.labelEditGoal.Padding = new System.Windows.Forms.Padding(10);
            this.labelEditGoal.Size = new System.Drawing.Size(91, 58);
            this.labelEditGoal.TabIndex = 22;
            this.labelEditGoal.Text = "Goal";
            // 
            // labelConcept
            // 
            this.labelConcept.AutoSize = true;
            this.labelConcept.BackColor = System.Drawing.Color.Transparent;
            this.labelConcept.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelConcept.Location = new System.Drawing.Point(40, 55);
            this.labelConcept.Name = "labelConcept";
            this.labelConcept.Padding = new System.Windows.Forms.Padding(10);
            this.labelConcept.Size = new System.Drawing.Size(138, 58);
            this.labelConcept.TabIndex = 21;
            this.labelConcept.Text = "Concept";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelEditSaving);
            this.panel2.Controls.Add(this.btnSaveEditSaving);
            this.panel2.Location = new System.Drawing.Point(9, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 137);
            this.panel2.TabIndex = 4;
            // 
            // btnCancelEditSaving
            // 
            this.btnCancelEditSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancelEditSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEditSaving.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancelEditSaving.Location = new System.Drawing.Point(380, 49);
            this.btnCancelEditSaving.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelEditSaving.Name = "btnCancelEditSaving";
            this.btnCancelEditSaving.Size = new System.Drawing.Size(178, 68);
            this.btnCancelEditSaving.TabIndex = 10;
            this.btnCancelEditSaving.Text = "Cancel";
            this.btnCancelEditSaving.UseVisualStyleBackColor = false;
            //this.btnCancelEditSaving.Click += new System.EventHandler(this.btnCancelSavings);
            // 
            // btnSaveEditSaving
            // 
            this.btnSaveEditSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSaveEditSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEditSaving.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnSaveEditSaving.Location = new System.Drawing.Point(591, 47);
            this.btnSaveEditSaving.Margin = new System.Windows.Forms.Padding(10);
            this.btnSaveEditSaving.Name = "btnSaveEditSaving";
            this.btnSaveEditSaving.Size = new System.Drawing.Size(178, 68);
            this.btnSaveEditSaving.TabIndex = 9;
            this.btnSaveEditSaving.Text = "Save";
            this.btnSaveEditSaving.UseVisualStyleBackColor = false;
            this.btnSaveEditSaving.Click += new System.EventHandler(this.btnSaveEditSaving_Click);
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
            // EditSavingsGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(825, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_newIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSavingsGoalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSavingsGoalForm";
            //this.Load += new System.EventHandler(this.EditSavingsGoalForm_Load);
            this.header_newIncome.ResumeLayout(false);
            this.header_newIncome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftCornerLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_newIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_editSavings;
        private System.Windows.Forms.PictureBox leftCornerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEditSavingDeposit;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.TextBox txtEditSavingGoal;
        private System.Windows.Forms.TextBox txtEditSavingConcept;
        private System.Windows.Forms.Label labelEditGoal;
        private System.Windows.Forms.Label labelConcept;
        private System.Windows.Forms.Button btnCancelEditSaving;
        private System.Windows.Forms.Button btnSaveEditSaving;
    }
}