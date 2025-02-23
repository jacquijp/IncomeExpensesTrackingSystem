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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
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

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // Panel Left
            this.panel1.BackColor = System.Drawing.Color.FromArgb(10, 61, 98);
            this.panel1.Controls.Add(this.login_signupButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Size = new System.Drawing.Size(625, 1013);

            // Sign Up Button
            this.login_signupButton.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.login_signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupButton.Font = new System.Drawing.Font("Montserrat", 10.875F);
            this.login_signupButton.ForeColor = System.Drawing.Color.White;
            this.login_signupButton.Location = new System.Drawing.Point(45, 904);
            this.login_signupButton.Size = new System.Drawing.Size(527, 76);
            this.login_signupButton.Text = "SIGNUP";
            this.login_signupButton.UseVisualStyleBackColor = false;
            this.login_signupButton.Click += new System.EventHandler(this.login_signupButton_Click);

            // App Title Label
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(52, 481);
            this.label2.Text = "Income and Expenses Tracker";

            // Logo
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Close Button
            this.close_Click.AutoSize = true;
            this.close_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Click.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.close_Click.Location = new System.Drawing.Point(1225, 28);
            this.close_Click.Text = "X";
            this.close_Click.Click += new System.EventHandler(this.close_Click_Click);

            // Sign In Label
            this.signin_label.AutoSize = true;
            this.signin_label.Font = new System.Drawing.Font("Montserrat SemiBold", 16.125F, System.Drawing.FontStyle.Bold);
            this.signin_label.ForeColor = System.Drawing.Color.FromArgb(59, 65, 81);
            this.signin_label.Location = new System.Drawing.Point(648, 224);
            this.signin_label.Text = "SIGN IN";

            // Username Label
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(59, 65, 81);
            this.label4.Location = new System.Drawing.Point(661, 380);
            this.label4.Text = "Username";

            // Username Input
            this.signin_username.Font = new System.Drawing.Font("Lucida Sans", 10.125F);
            this.signin_username.Location = new System.Drawing.Point(660, 439);
            this.signin_username.Size = new System.Drawing.Size(576, 39);

            // Password Label
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(59, 65, 81);
            this.label5.Location = new System.Drawing.Point(663, 510);
            this.label5.Text = "Password";

            // Password Input
            this.login_password.Location = new System.Drawing.Point(660, 570);
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(576, 31);

            // Login Button
            this.login_button.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Montserrat", 10.875F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(670, 694);
            this.login_button.Size = new System.Drawing.Size(173, 76);
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);

            // Show Password Checkbox
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.Font = new System.Drawing.Font("Montserrat", 7.875F);
            this.login_showPassword.ForeColor = System.Drawing.Color.FromArgb(59, 65, 81);
            this.login_showPassword.Location = new System.Drawing.Point(1025, 620);
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.CheckedChanged += new System.EventHandler(this.login_showPassword_CheckedChanged);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(1279, 1013);
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
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
    }
}
