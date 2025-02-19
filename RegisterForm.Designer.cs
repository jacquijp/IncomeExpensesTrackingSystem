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
            this.registerHere_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.register_button.Font = new System.Drawing.Font("Lucida Sans", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.register_button.Location = new System.Drawing.Point(653, 744);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(173, 76);
            this.register_button.TabIndex = 16;
            this.register_button.Text = "SIGN IN";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(653, 500);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(576, 31);
            this.register_password.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(646, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Lucida Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(653, 368);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(576, 39);
            this.register_username.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(646, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.Font = new System.Drawing.Font("Lucida Sans", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.signin_label.Location = new System.Drawing.Point(645, 194);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(215, 48);
            this.signin_label.TabIndex = 11;
            this.signin_label.Text = "REGISTER";
            // 
            // close_Click
            // 
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Click.Location = new System.Drawing.Point(1212, 22);
            this.close_Click.Name = "close_Click";
            this.close_Click.Size = new System.Drawing.Size(29, 29);
            this.close_Click.TabIndex = 9;
            this.close_Click.Text = "X";
            this.close_Click.Click += new System.EventHandler(this.close_Click_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.registerHere_Button);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 942);
            this.panel1.TabIndex = 10;
            // 
            // registerHere_Button
            // 
            this.registerHere_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.registerHere_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.registerHere_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.registerHere_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.registerHere_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerHere_Button.Font = new System.Drawing.Font("Lucida Sans", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHere_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.registerHere_Button.Location = new System.Drawing.Point(45, 824);
            this.registerHere_Button.Name = "registerHere_Button";
            this.registerHere_Button.Size = new System.Drawing.Size(527, 76);
            this.registerHere_Button.TabIndex = 9;
            this.registerHere_Button.Text = "HERE";
            this.registerHere_Button.UseVisualStyleBackColor = false;
            this.registerHere_Button.Click += new System.EventHandler(this.login_signupButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label6.Location = new System.Drawing.Point(240, 766);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "SIGN IN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(92, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 194);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(266, 254);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(266, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // register_confirm_password
            // 
            this.register_confirm_password.Location = new System.Drawing.Point(653, 621);
            this.register_confirm_password.Name = "register_confirm_password";
            this.register_confirm_password.PasswordChar = '*';
            this.register_confirm_password.Size = new System.Drawing.Size(576, 31);
            this.register_confirm_password.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(646, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Confirm Password";
            // 
            // register_show_password
            // 
            this.register_show_password.AutoSize = true;
            this.register_show_password.Font = new System.Drawing.Font("Lucida Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_show_password.Location = new System.Drawing.Point(1032, 675);
            this.register_show_password.Name = "register_show_password";
            this.register_show_password.Size = new System.Drawing.Size(194, 28);
            this.register_show_password.TabIndex = 20;
            this.register_show_password.Text = "Show Password";
            this.register_show_password.UseVisualStyleBackColor = true;
            this.register_show_password.CheckedChanged += new System.EventHandler(this.register_show_password_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1253, 942);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox register_confirm_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox register_show_password;
    }
}