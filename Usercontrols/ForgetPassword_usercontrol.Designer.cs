namespace quizclub
{
    partial class ForgetPassword_usercontrol
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
            this.email_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Send_btn = new System.Windows.Forms.Button();
            this.Email_txt = new System.Windows.Forms.Label();
            this.Login_txt = new System.Windows.Forms.Label();
            this.checkProvider = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email_send_check = new System.Windows.Forms.Label();
            this.email_send_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_txtbox
            // 
            this.email_txtbox.BackColor = System.Drawing.Color.White;
            this.email_txtbox.Depth = 0;
            this.email_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.email_txtbox.Hint = "";
            this.email_txtbox.Location = new System.Drawing.Point(115, 327);
            this.email_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_txtbox.MaxLength = 32767;
            this.email_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.PasswordChar = '\0';
            this.email_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email_txtbox.SelectedText = "";
            this.email_txtbox.SelectionLength = 0;
            this.email_txtbox.SelectionStart = 0;
            this.email_txtbox.Size = new System.Drawing.Size(634, 28);
            this.email_txtbox.TabIndex = 30;
            this.email_txtbox.TabStop = false;
            this.email_txtbox.UseSystemPasswordChar = false;
            this.email_txtbox.TextChanged += new System.EventHandler(this.username_txtbox_TextChanged);
            // 
            // Send_btn
            // 
            this.Send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.Send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.Send_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(70)))), ((int)(((byte)(29)))));
            this.Send_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(70)))), ((int)(((byte)(29)))));
            this.Send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_btn.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.Send_btn.ForeColor = System.Drawing.Color.White;
            this.Send_btn.Location = new System.Drawing.Point(489, 403);
            this.Send_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(258, 53);
            this.Send_btn.TabIndex = 29;
            this.Send_btn.Text = "Recover Password";
            this.Send_btn.UseVisualStyleBackColor = false;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Email_txt
            // 
            this.Email_txt.AutoSize = true;
            this.Email_txt.BackColor = System.Drawing.Color.Transparent;
            this.Email_txt.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Email_txt.ForeColor = System.Drawing.Color.Black;
            this.Email_txt.Location = new System.Drawing.Point(109, 286);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(62, 26);
            this.Email_txt.TabIndex = 28;
            this.Email_txt.Text = "Email";
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
            this.Login_txt.Size = new System.Drawing.Size(358, 51);
            this.Login_txt.TabIndex = 32;
            this.Login_txt.Text = "Password Recovery";
            // 
            // checkProvider
            // 
            this.checkProvider.BackgroundImage = global::quizclub.Properties.Resources.check;
            this.checkProvider.Location = new System.Drawing.Point(173, 292);
            this.checkProvider.Name = "checkProvider";
            this.checkProvider.Size = new System.Drawing.Size(16, 16);
            this.checkProvider.TabIndex = 34;
            this.checkProvider.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BackgroundImage = global::quizclub.Properties.Resources.Error;
            this.errorProvider.Location = new System.Drawing.Point(173, 292);
            this.errorProvider.Name = "errorProvider";
            this.errorProvider.Size = new System.Drawing.Size(16, 16);
            this.errorProvider.TabIndex = 33;
            this.errorProvider.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::quizclub.Properties.Resources.Returning;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(723, 194);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // email_send_check
            // 
            this.email_send_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email_send_check.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.email_send_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.email_send_check.Location = new System.Drawing.Point(204, 279);
            this.email_send_check.Name = "email_send_check";
            this.email_send_check.Size = new System.Drawing.Size(545, 50);
            this.email_send_check.TabIndex = 37;
            this.email_send_check.Text = "Password has been sent, Please check your inbox,if you dont see anything also che" +
    "ck spam folder";
            // 
            // email_send_error
            // 
            this.email_send_error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email_send_error.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.email_send_error.ForeColor = System.Drawing.Color.Red;
            this.email_send_error.Location = new System.Drawing.Point(208, 289);
            this.email_send_error.Name = "email_send_error";
            this.email_send_error.Size = new System.Drawing.Size(545, 31);
            this.email_send_error.TabIndex = 38;
            this.email_send_error.Text = "Something is wrong,Please try again late";
            // 
            // ForgetPassword_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.email_send_check);
            this.Controls.Add(this.checkProvider);
            this.Controls.Add(this.errorProvider);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.email_send_error);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgetPassword_usercontrol";
            this.Size = new System.Drawing.Size(898, 634);
            ((System.ComponentModel.ISupportInitialize)(this.checkProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField email_txtbox;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Label Email_txt;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.PictureBox errorProvider;
        private System.Windows.Forms.PictureBox checkProvider;
        private System.Windows.Forms.Label email_send_check;
        private System.Windows.Forms.Label email_send_error;
    }
}
