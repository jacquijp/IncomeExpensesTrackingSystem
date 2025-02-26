namespace IncomeExpensesTrackingSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.register_button = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signin_label = new System.Windows.Forms.Label();
            this.close_Click = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerHere_Button = new System.Windows.Forms.Button();
            this.lbl_alreadyanuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_confirm_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_show_password = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.register_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.register_button.Location = new System.Drawing.Point(326, 387);
            this.register_button.Margin = new System.Windows.Forms.Padding(2);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(86, 40);
            this.register_button.TabIndex = 16;
            this.register_button.Text = "SIGN IN";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(326, 260);
            this.register_password.Margin = new System.Windows.Forms.Padding(2);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(290, 20);
            this.register_password.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(323, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Lucida Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(326, 191);
            this.register_username.Margin = new System.Windows.Forms.Padding(2);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(290, 23);
            this.register_username.TabIndex = 13;
            this.register_username.TextChanged += new System.EventHandler(this.register_username_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(323, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.Font = new System.Drawing.Font("Montserrat SemiBold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.signin_label.Location = new System.Drawing.Point(322, 101);
            this.signin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(128, 34);
            this.signin_label.TabIndex = 11;
            this.signin_label.Text = "REGISTER";
            // 
            // close_Click
            // 
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Click.Location = new System.Drawing.Point(606, 11);
            this.close_Click.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(15, 15);
            this.close_Click.TabIndex = 9;
            this.close_Click.Text = "X";
            this.close_Click.Click += new System.EventHandler(this.close_Click_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.registerHere_Button);
            this.panel1.Controls.Add(this.lbl_alreadyanuser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 490);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 191);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // registerHere_Button
            // 
            this.registerHere_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.registerHere_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.registerHere_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.registerHere_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.registerHere_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerHere_Button.Font = new System.Drawing.Font("Montserrat", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHere_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.registerHere_Button.Location = new System.Drawing.Point(22, 428);
            this.registerHere_Button.Margin = new System.Windows.Forms.Padding(2);
            this.registerHere_Button.Name = "registerHere_Button";
            this.registerHere_Button.Size = new System.Drawing.Size(264, 40);
            this.registerHere_Button.TabIndex = 9;
            this.registerHere_Button.Text = "LOGIN HERE";
            this.registerHere_Button.UseVisualStyleBackColor = false;
            this.registerHere_Button.Click += new System.EventHandler(this.login_signupButton_Click);
            // 
            // lbl_alreadyanuser
            // 
            this.lbl_alreadyanuser.AutoSize = true;
            this.lbl_alreadyanuser.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alreadyanuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lbl_alreadyanuser.Location = new System.Drawing.Point(101, 401);
            this.lbl_alreadyanuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_alreadyanuser.Name = "lbl_alreadyanuser";
            this.lbl_alreadyanuser.Size = new System.Drawing.Size(106, 18);
            this.lbl_alreadyanuser.TabIndex = 9;
            this.lbl_alreadyanuser.Text = "Already an user?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(17, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income and Expenses Tracker";
            // 
            // register_confirm_password
            // 
            this.register_confirm_password.Location = new System.Drawing.Point(326, 323);
            this.register_confirm_password.Margin = new System.Windows.Forms.Padding(2);
            this.register_confirm_password.Name = "register_confirm_password";
            this.register_confirm_password.PasswordChar = '*';
            this.register_confirm_password.Size = new System.Drawing.Size(290, 20);
            this.register_confirm_password.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(323, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Confirm Password";
            // 
            // register_show_password
            // 
            this.register_show_password.AutoSize = true;
            this.register_show_password.Font = new System.Drawing.Font("Montserrat", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_show_password.Location = new System.Drawing.Point(509, 349);
            this.register_show_password.Margin = new System.Windows.Forms.Padding(2);
            this.register_show_password.Name = "register_show_password";
            this.register_show_password.Size = new System.Drawing.Size(113, 21);
            this.register_show_password.TabIndex = 20;
            this.register_show_password.Text = "Show Password";
            this.register_show_password.UseVisualStyleBackColor = true;
            this.register_show_password.CheckedChanged += new System.EventHandler(this.register_show_password_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(626, 490);
            this.Controls.Add(this.register_show_password);
            this.Controls.Add(this.register_confirm_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signin_label);
            this.Controls.Add(this.close_Click);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label signin_label;
        private System.Windows.Forms.Label close_Click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerHere_Button;
        private System.Windows.Forms.Label lbl_alreadyanuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox register_confirm_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox register_show_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}