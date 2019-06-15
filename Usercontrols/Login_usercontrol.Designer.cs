namespace quizclub
{
    partial class Login_usercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.forget_password = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.username_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Login_txt = new System.Windows.Forms.Label();
            this.PasswordError_label = new System.Windows.Forms.Label();
            this.password_eye_pic = new System.Windows.Forms.PictureBox();
            this.password_errorProvider = new System.Windows.Forms.PictureBox();
            this.username_errorProvider = new System.Windows.Forms.PictureBox();
            this.sql_usernameIncorecct_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.password_eye_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_txt
            // 
            this.Username_txt.AutoSize = true;
            this.Username_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_txt.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Username_txt.ForeColor = System.Drawing.Color.Black;
            this.Username_txt.Location = new System.Drawing.Point(118, 233);
            this.Username_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(106, 26);
            this.Username_txt.TabIndex = 9;
            this.Username_txt.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // forget_password
            // 
            this.forget_password.AutoSize = true;
            this.forget_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forget_password.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.forget_password.Location = new System.Drawing.Point(120, 449);
            this.forget_password.Name = "forget_password";
            this.forget_password.Size = new System.Drawing.Size(171, 20);
            this.forget_password.TabIndex = 15;
            this.forget_password.Text = "Forgot Your Password ?";
            this.forget_password.Click += new System.EventHandler(this.forget_password_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(70)))), ((int)(((byte)(29)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(70)))), ((int)(((byte)(29)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(499, 508);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(258, 54);
            this.login_btn.TabIndex = 16;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(185)))));
            this.Signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(185)))));
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.Signup_btn.ForeColor = System.Drawing.Color.White;
            this.Signup_btn.Location = new System.Drawing.Point(123, 507);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(363, 54);
            this.Signup_btn.TabIndex = 17;
            this.Signup_btn.Text = "Sign up";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Depth = 0;
            this.username_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.username_txtbox.Hint = "";
            this.username_txtbox.Location = new System.Drawing.Point(124, 273);
            this.username_txtbox.MaxLength = 32767;
            this.username_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.PasswordChar = '\0';
            this.username_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username_txtbox.SelectedText = "";
            this.username_txtbox.SelectionLength = 0;
            this.username_txtbox.SelectionStart = 0;
            this.username_txtbox.Size = new System.Drawing.Size(633, 28);
            this.username_txtbox.TabIndex = 19;
            this.username_txtbox.TabStop = false;
            this.username_txtbox.UseSystemPasswordChar = false;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Depth = 0;
            this.password_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.password_txtbox.Hint = "";
            this.password_txtbox.Location = new System.Drawing.Point(124, 390);
            this.password_txtbox.MaxLength = 32767;
            this.password_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '\0';
            this.password_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password_txtbox.SelectedText = "";
            this.password_txtbox.SelectionLength = 0;
            this.password_txtbox.SelectionStart = 0;
            this.password_txtbox.Size = new System.Drawing.Size(633, 28);
            this.password_txtbox.TabIndex = 20;
            this.password_txtbox.TabStop = false;
            this.password_txtbox.UseSystemPasswordChar = false;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.BackColor = System.Drawing.Color.Transparent;
            this.Login_txt.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_txt.ForeColor = System.Drawing.Color.Black;
            this.Login_txt.Location = new System.Drawing.Point(61, 23);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(115, 51);
            this.Login_txt.TabIndex = 21;
            this.Login_txt.Text = "Login";
            // 
            // PasswordError_label
            // 
            this.PasswordError_label.AutoSize = true;
            this.PasswordError_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordError_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PasswordError_label.ForeColor = System.Drawing.Color.Red;
            this.PasswordError_label.Location = new System.Drawing.Point(476, 343);
            this.PasswordError_label.Name = "PasswordError_label";
            this.PasswordError_label.Size = new System.Drawing.Size(281, 20);
            this.PasswordError_label.TabIndex = 36;
            this.PasswordError_label.Text = "Enter 8 character for password or more";
            // 
            // password_eye_pic
            // 
            this.password_eye_pic.BackColor = System.Drawing.Color.Transparent;
            this.password_eye_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_eye_pic.Image = global::quizclub.Properties.Resources.password_eye;
            this.password_eye_pic.Location = new System.Drawing.Point(739, 390);
            this.password_eye_pic.Name = "password_eye_pic";
            this.password_eye_pic.Size = new System.Drawing.Size(20, 18);
            this.password_eye_pic.TabIndex = 37;
            this.password_eye_pic.TabStop = false;
            this.password_eye_pic.Click += new System.EventHandler(this.password_eye_pic_Click);
            // 
            // password_errorProvider
            // 
            this.password_errorProvider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.password_errorProvider.Location = new System.Drawing.Point(217, 343);
            this.password_errorProvider.Name = "password_errorProvider";
            this.password_errorProvider.Size = new System.Drawing.Size(16, 16);
            this.password_errorProvider.TabIndex = 35;
            this.password_errorProvider.TabStop = false;
            // 
            // username_errorProvider
            // 
            this.username_errorProvider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.username_errorProvider.Location = new System.Drawing.Point(222, 238);
            this.username_errorProvider.Name = "username_errorProvider";
            this.username_errorProvider.Size = new System.Drawing.Size(16, 16);
            this.username_errorProvider.TabIndex = 34;
            this.username_errorProvider.TabStop = false;
            // 
            // sql_usernameIncorecct_lbl
            // 
            this.sql_usernameIncorecct_lbl.AutoSize = true;
            this.sql_usernameIncorecct_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.sql_usernameIncorecct_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sql_usernameIncorecct_lbl.ForeColor = System.Drawing.Color.Red;
            this.sql_usernameIncorecct_lbl.Location = new System.Drawing.Point(311, 147);
            this.sql_usernameIncorecct_lbl.Name = "sql_usernameIncorecct_lbl";
            this.sql_usernameIncorecct_lbl.Size = new System.Drawing.Size(261, 20);
            this.sql_usernameIncorecct_lbl.TabIndex = 38;
            this.sql_usernameIncorecct_lbl.Text = "Username or password are incorrect";
            // 
            // Login_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sql_usernameIncorecct_lbl);
            this.Controls.Add(this.password_eye_pic);
            this.Controls.Add(this.PasswordError_label);
            this.Controls.Add(this.password_errorProvider);
            this.Controls.Add(this.username_errorProvider);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.forget_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_usercontrol";
            this.Size = new System.Drawing.Size(898, 634);
            ((System.ComponentModel.ISupportInitialize)(this.password_eye_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forget_password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button Signup_btn;
        private MaterialSkin.Controls.MaterialSingleLineTextField username_txtbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField password_txtbox;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.PictureBox username_errorProvider;
        private System.Windows.Forms.PictureBox password_errorProvider;
        private System.Windows.Forms.Label PasswordError_label;
        private System.Windows.Forms.PictureBox password_eye_pic;
        private System.Windows.Forms.Label sql_usernameIncorecct_lbl;
    }
}
