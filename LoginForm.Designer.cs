namespace IncomeExpensesTrackingSystem
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.login_signupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_Click = new System.Windows.Forms.Label();
            this.signin_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signin_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.login_showPassword = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.labelCreateAccount);
            this.panel1.Controls.Add(this.login_signupButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 506);
            this.panel1.TabIndex = 8;
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelCreateAccount.Location = new System.Drawing.Point(101, 424);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(106, 17);
            this.labelCreateAccount.TabIndex = 3;
            this.labelCreateAccount.Text = "Create an account";
            // 
            // login_signupButton
            // 
            this.login_signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.login_signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupButton.Font = new System.Drawing.Font("Montserrat", 10.875F);
            this.login_signupButton.ForeColor = System.Drawing.Color.White;
            this.login_signupButton.Location = new System.Drawing.Point(22, 452);
            this.login_signupButton.Margin = new System.Windows.Forms.Padding(2);
            this.login_signupButton.Name = "login_signupButton";
            this.login_signupButton.Size = new System.Drawing.Size(264, 38);
            this.login_signupButton.TabIndex = 0;
            this.login_signupButton.Text = "SIGNUP";
            this.login_signupButton.UseVisualStyleBackColor = false;
            this.login_signupButton.Click += new System.EventHandler(this.login_signupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // close_Click
            // 
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.close_Click.Location = new System.Drawing.Point(612, 14);
            this.close_Click.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(15, 15);
            this.close_Click.TabIndex = 7;
            this.close_Click.Text = "X";
            this.close_Click.Click += new System.EventHandler(this.close_Click_Click);
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.Font = new System.Drawing.Font("Montserrat SemiBold", 16.125F, System.Drawing.FontStyle.Bold);
            this.signin_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.signin_label.Location = new System.Drawing.Point(324, 112);
            this.signin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(102, 34);
            this.signin_label.TabIndex = 2;
            this.signin_label.Text = "SIGN IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(330, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // signin_username
            // 
            this.signin_username.Font = new System.Drawing.Font("Lucida Sans", 10.125F);
            this.signin_username.Location = new System.Drawing.Point(330, 220);
            this.signin_username.Margin = new System.Windows.Forms.Padding(2);
            this.signin_username.Name = "signin_username";
            this.signin_username.Size = new System.Drawing.Size(290, 23);
            this.signin_username.TabIndex = 3;
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(330, 285);
            this.login_password.Margin = new System.Windows.Forms.Padding(2);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(290, 20);
            this.login_password.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(332, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Montserrat", 10.875F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(335, 347);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(86, 38);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_showPassword
            // 
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.Font = new System.Drawing.Font("Montserrat", 7.875F);
            this.login_showPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.login_showPassword.Location = new System.Drawing.Point(516, 310);
            this.login_showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.login_showPassword.Name = "login_showPassword";
            this.login_showPassword.Size = new System.Drawing.Size(113, 21);
            this.login_showPassword.TabIndex = 0;
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.CheckedChanged += new System.EventHandler(this.login_showPassword_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 506);
            this.Controls.Add(this.login_showPassword);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.signin_label);
            this.Controls.Add(this.signin_username);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.close_Click);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button login_signupButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close_Click;
        private System.Windows.Forms.Label signin_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signin_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
