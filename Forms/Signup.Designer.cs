namespace quizclub.Forms
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordeye_pic = new System.Windows.Forms.PictureBox();
            this.repassword_errorprovider = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_errorprovider = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_errorProvider = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_txt = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.email_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.repassword_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.checkBox_errorProvider = new System.Windows.Forms.PictureBox();
            this.readmore_link = new System.Windows.Forms.Label();
            this.terms_checkbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.username_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email_errorprovider = new System.Windows.Forms.PictureBox();
            this.emailexists_error_lbl = new System.Windows.Forms.Label();
            this.Username_error_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordeye_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repassword_errorprovider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorprovider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_errorProvider)).BeginInit();
            this.signup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(138, 444);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 68;
            this.label7.Text = "Email";
            // 
            // passwordeye_pic
            // 
            this.passwordeye_pic.BackColor = System.Drawing.Color.White;
            this.passwordeye_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordeye_pic.Image = global::quizclub.Properties.Resources.password_eye;
            this.passwordeye_pic.Location = new System.Drawing.Point(509, 270);
            this.passwordeye_pic.Name = "passwordeye_pic";
            this.passwordeye_pic.Size = new System.Drawing.Size(20, 18);
            this.passwordeye_pic.TabIndex = 67;
            this.passwordeye_pic.TabStop = false;
            this.passwordeye_pic.Click += new System.EventHandler(this.passwordeye_pic_Click);
            // 
            // repassword_errorprovider
            // 
            this.repassword_errorprovider.BackColor = System.Drawing.Color.White;
            this.repassword_errorprovider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.repassword_errorprovider.Location = new System.Drawing.Point(268, 346);
            this.repassword_errorprovider.Name = "repassword_errorprovider";
            this.repassword_errorprovider.Size = new System.Drawing.Size(16, 16);
            this.repassword_errorprovider.TabIndex = 66;
            this.repassword_errorprovider.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(138, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 64;
            this.label5.Text = "Re Password";
            // 
            // password_errorprovider
            // 
            this.password_errorprovider.BackColor = System.Drawing.Color.White;
            this.password_errorprovider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.password_errorprovider.Location = new System.Drawing.Point(236, 245);
            this.password_errorprovider.Name = "password_errorprovider";
            this.password_errorprovider.Size = new System.Drawing.Size(16, 16);
            this.password_errorprovider.TabIndex = 63;
            this.password_errorprovider.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(138, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 61;
            this.label3.Text = "Password";
            // 
            // username_errorProvider
            // 
            this.username_errorProvider.BackColor = System.Drawing.Color.White;
            this.username_errorProvider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.username_errorProvider.Location = new System.Drawing.Point(236, 148);
            this.username_errorProvider.Name = "username_errorProvider";
            this.username_errorProvider.Size = new System.Drawing.Size(16, 16);
            this.username_errorProvider.TabIndex = 60;
            this.username_errorProvider.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(132, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Username";
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.BackColor = System.Drawing.Color.Transparent;
            this.Login_txt.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_txt.ForeColor = System.Drawing.Color.White;
            this.Login_txt.Location = new System.Drawing.Point(25, 23);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(150, 51);
            this.Login_txt.TabIndex = 57;
            this.Login_txt.Text = "Sign up";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Depth = 0;
            this.email_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.email_txtbox.Hint = "";
            this.email_txtbox.Location = new System.Drawing.Point(81, 380);
            this.email_txtbox.MaxLength = 32767;
            this.email_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.PasswordChar = '\0';
            this.email_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email_txtbox.SelectedText = "";
            this.email_txtbox.SelectionLength = 0;
            this.email_txtbox.SelectionStart = 0;
            this.email_txtbox.Size = new System.Drawing.Size(391, 28);
            this.email_txtbox.TabIndex = 4;
            this.email_txtbox.TabStop = false;
            this.email_txtbox.UseSystemPasswordChar = false;
            this.email_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txtbox_KeyPress);
            // 
            // repassword_txtbox
            // 
            this.repassword_txtbox.Depth = 0;
            this.repassword_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.repassword_txtbox.Hint = "";
            this.repassword_txtbox.Location = new System.Drawing.Point(81, 287);
            this.repassword_txtbox.MaxLength = 32767;
            this.repassword_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.repassword_txtbox.Name = "repassword_txtbox";
            this.repassword_txtbox.PasswordChar = '\0';
            this.repassword_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.repassword_txtbox.SelectedText = "";
            this.repassword_txtbox.SelectionLength = 0;
            this.repassword_txtbox.SelectionStart = 0;
            this.repassword_txtbox.Size = new System.Drawing.Size(391, 28);
            this.repassword_txtbox.TabIndex = 3;
            this.repassword_txtbox.TabStop = false;
            this.repassword_txtbox.UseSystemPasswordChar = false;
            this.repassword_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txtbox_KeyPress);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Depth = 0;
            this.password_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.password_txtbox.Hint = "";
            this.password_txtbox.Location = new System.Drawing.Point(81, 188);
            this.password_txtbox.MaxLength = 32767;
            this.password_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '\0';
            this.password_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password_txtbox.SelectedText = "";
            this.password_txtbox.SelectionLength = 0;
            this.password_txtbox.SelectionStart = 0;
            this.password_txtbox.Size = new System.Drawing.Size(391, 28);
            this.password_txtbox.TabIndex = 2;
            this.password_txtbox.TabStop = false;
            this.password_txtbox.UseSystemPasswordChar = false;
            this.password_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txtbox_KeyPress);
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.Color.White;
            this.signup_panel.Controls.Add(this.Username_error_lbl);
            this.signup_panel.Controls.Add(this.emailexists_error_lbl);
            this.signup_panel.Controls.Add(this.checkBox_errorProvider);
            this.signup_panel.Controls.Add(this.readmore_link);
            this.signup_panel.Controls.Add(this.terms_checkbox);
            this.signup_panel.Controls.Add(this.cancel_btn);
            this.signup_panel.Controls.Add(this.Signup_btn);
            this.signup_panel.Controls.Add(this.username_txtbox);
            this.signup_panel.Controls.Add(this.password_txtbox);
            this.signup_panel.Controls.Add(this.repassword_txtbox);
            this.signup_panel.Controls.Add(this.email_txtbox);
            this.signup_panel.Location = new System.Drawing.Point(62, 93);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(556, 599);
            this.signup_panel.TabIndex = 71;
            // 
            // checkBox_errorProvider
            // 
            this.checkBox_errorProvider.BackColor = System.Drawing.Color.White;
            this.checkBox_errorProvider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.checkBox_errorProvider.Location = new System.Drawing.Point(327, 442);
            this.checkBox_errorProvider.Name = "checkBox_errorProvider";
            this.checkBox_errorProvider.Size = new System.Drawing.Size(16, 16);
            this.checkBox_errorProvider.TabIndex = 72;
            this.checkBox_errorProvider.TabStop = false;
            // 
            // readmore_link
            // 
            this.readmore_link.AutoSize = true;
            this.readmore_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readmore_link.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.readmore_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.readmore_link.Location = new System.Drawing.Point(71, 472);
            this.readmore_link.Name = "readmore_link";
            this.readmore_link.Size = new System.Drawing.Size(80, 20);
            this.readmore_link.TabIndex = 75;
            this.readmore_link.Text = "Readmore";
            this.readmore_link.Click += new System.EventHandler(this.readmore_link_Click);
            this.readmore_link.MouseEnter += new System.EventHandler(this.readmore_link_MouseEnter);
            this.readmore_link.MouseLeave += new System.EventHandler(this.readmore_link_MouseLeave);
            // 
            // terms_checkbox
            // 
            this.terms_checkbox.AutoSize = true;
            this.terms_checkbox.Depth = 0;
            this.terms_checkbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.terms_checkbox.Location = new System.Drawing.Point(75, 442);
            this.terms_checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.terms_checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.terms_checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.terms_checkbox.Name = "terms_checkbox";
            this.terms_checkbox.Ripple = false;
            this.terms_checkbox.Size = new System.Drawing.Size(293, 20);
            this.terms_checkbox.TabIndex = 74;
            this.terms_checkbox.Text = "i agree to the terms and conditions";
            this.terms_checkbox.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(291, 537);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(247, 48);
            this.cancel_btn.TabIndex = 73;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Signup_btn.ForeColor = System.Drawing.Color.White;
            this.Signup_btn.Location = new System.Drawing.Point(26, 537);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(247, 48);
            this.Signup_btn.TabIndex = 72;
            this.Signup_btn.Text = "Sign up";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Depth = 0;
            this.username_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.username_txtbox.Hint = "";
            this.username_txtbox.Location = new System.Drawing.Point(75, 83);
            this.username_txtbox.MaxLength = 32767;
            this.username_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.PasswordChar = '\0';
            this.username_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username_txtbox.SelectedText = "";
            this.username_txtbox.SelectionLength = 0;
            this.username_txtbox.SelectionStart = 0;
            this.username_txtbox.Size = new System.Drawing.Size(391, 28);
            this.username_txtbox.TabIndex = 1;
            this.username_txtbox.TabStop = false;
            this.username_txtbox.UseSystemPasswordChar = false;
            this.username_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txtbox_KeyPress);
            // 
            // email_errorprovider
            // 
            this.email_errorprovider.BackColor = System.Drawing.Color.White;
            this.email_errorprovider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.email_errorprovider.Location = new System.Drawing.Point(204, 450);
            this.email_errorprovider.Name = "email_errorprovider";
            this.email_errorprovider.Size = new System.Drawing.Size(16, 16);
            this.email_errorprovider.TabIndex = 70;
            this.email_errorprovider.TabStop = false;
            // 
            // emailexists_error_lbl
            // 
            this.emailexists_error_lbl.AutoSize = true;
            this.emailexists_error_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.emailexists_error_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.emailexists_error_lbl.ForeColor = System.Drawing.Color.Red;
            this.emailexists_error_lbl.Location = new System.Drawing.Point(170, 355);
            this.emailexists_error_lbl.Name = "emailexists_error_lbl";
            this.emailexists_error_lbl.Size = new System.Drawing.Size(186, 20);
            this.emailexists_error_lbl.TabIndex = 72;
            this.emailexists_error_lbl.Text = "This email exists in server";
            // 
            // Username_error_lbl
            // 
            this.Username_error_lbl.AutoSize = true;
            this.Username_error_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Username_error_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Username_error_lbl.ForeColor = System.Drawing.Color.Red;
            this.Username_error_lbl.Location = new System.Drawing.Point(202, 55);
            this.Username_error_lbl.Name = "Username_error_lbl";
            this.Username_error_lbl.Size = new System.Drawing.Size(217, 20);
            this.Username_error_lbl.TabIndex = 76;
            this.Username_error_lbl.Text = "This username exists in server";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(694, 728);
            this.Controls.Add(this.email_errorprovider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwordeye_pic);
            this.Controls.Add(this.repassword_errorprovider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_errorprovider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_errorProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.signup_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Signup";
            this.Text = "Signup";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Signup_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.passwordeye_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repassword_errorprovider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorprovider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_errorProvider)).EndInit();
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox passwordeye_pic;
        private System.Windows.Forms.PictureBox repassword_errorprovider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox password_errorprovider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox username_errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Login_txt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel signup_panel;
        private MaterialSkin.Controls.MaterialSingleLineTextField username_txtbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField password_txtbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField repassword_txtbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField email_txtbox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button Signup_btn;
        private MaterialSkin.Controls.MaterialCheckBox terms_checkbox;
        private System.Windows.Forms.Label readmore_link;
        private System.Windows.Forms.PictureBox email_errorprovider;
        private System.Windows.Forms.PictureBox checkBox_errorProvider;
        private System.Windows.Forms.Label Username_error_lbl;
        private System.Windows.Forms.Label emailexists_error_lbl;
    }
}