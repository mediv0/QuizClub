namespace quizclub
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.Quiz_text = new System.Windows.Forms.Label();
            this.Club_txt = new System.Windows.Forms.Label();
            this.version_txt = new System.Windows.Forms.Label();
            this.information_txt = new System.Windows.Forms.Label();
            this.copyright_txt = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit_picbox = new System.Windows.Forms.PictureBox();
            this.minimize_picbox = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TwitterBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Login_Left_bg = new System.Windows.Forms.PictureBox();
            this.forgetPassword_usercontrol2 = new quizclub.ForgetPassword_usercontrol();
            this.login_usercontrol1 = new quizclub.Login_usercontrol();
            this.forgetPassword_usercontrol1 = new quizclub.ForgetPassword_usercontrol();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Left_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // Quiz_text
            // 
            this.Quiz_text.AutoSize = true;
            this.Quiz_text.BackColor = System.Drawing.Color.Transparent;
            this.Quiz_text.Font = new System.Drawing.Font("Open Sans ExtraBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Quiz_text.ForeColor = System.Drawing.Color.White;
            this.Quiz_text.Location = new System.Drawing.Point(109, 28);
            this.Quiz_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quiz_text.Name = "Quiz_text";
            this.Quiz_text.Size = new System.Drawing.Size(131, 61);
            this.Quiz_text.TabIndex = 1;
            this.Quiz_text.Text = "Quiz";
            // 
            // Club_txt
            // 
            this.Club_txt.AutoSize = true;
            this.Club_txt.BackColor = System.Drawing.Color.Transparent;
            this.Club_txt.Font = new System.Drawing.Font("Open Sans", 36.66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Club_txt.ForeColor = System.Drawing.Color.White;
            this.Club_txt.Location = new System.Drawing.Point(119, 84);
            this.Club_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Club_txt.Name = "Club_txt";
            this.Club_txt.Size = new System.Drawing.Size(100, 51);
            this.Club_txt.TabIndex = 2;
            this.Club_txt.Text = "Club";
            // 
            // version_txt
            // 
            this.version_txt.AutoSize = true;
            this.version_txt.BackColor = System.Drawing.Color.Transparent;
            this.version_txt.Font = new System.Drawing.Font("Open Sans Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.version_txt.ForeColor = System.Drawing.Color.White;
            this.version_txt.Location = new System.Drawing.Point(207, 107);
            this.version_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.version_txt.Name = "version_txt";
            this.version_txt.Size = new System.Drawing.Size(91, 23);
            this.version_txt.TabIndex = 3;
            this.version_txt.Text = "0.0.1Alpha";
            // 
            // information_txt
            // 
            this.information_txt.BackColor = System.Drawing.Color.Transparent;
            this.information_txt.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.information_txt.ForeColor = System.Drawing.Color.White;
            this.information_txt.Location = new System.Drawing.Point(72, 242);
            this.information_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.information_txt.Name = "information_txt";
            this.information_txt.Size = new System.Drawing.Size(253, 58);
            this.information_txt.TabIndex = 4;
            this.information_txt.Text = "First Cross-platform Online Examination System in IRAN\r\n\r\n";
            // 
            // copyright_txt
            // 
            this.copyright_txt.AutoSize = true;
            this.copyright_txt.BackColor = System.Drawing.Color.Transparent;
            this.copyright_txt.Font = new System.Drawing.Font("Open Sans Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.copyright_txt.ForeColor = System.Drawing.Color.White;
            this.copyright_txt.Location = new System.Drawing.Point(28, 596);
            this.copyright_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_txt.Name = "copyright_txt";
            this.copyright_txt.Size = new System.Drawing.Size(342, 20);
            this.copyright_txt.TabIndex = 5;
            this.copyright_txt.Text = "Copyright 2017 RealBarrel Inc. All rights reserved.";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exit_picbox
            // 
            this.exit_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_picbox.BackgroundImage")));
            this.exit_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_picbox.Location = new System.Drawing.Point(1246, 28);
            this.exit_picbox.Name = "exit_picbox";
            this.exit_picbox.Size = new System.Drawing.Size(16, 16);
            this.exit_picbox.TabIndex = 10;
            this.exit_picbox.TabStop = false;
            this.exit_picbox.Click += new System.EventHandler(this.exit_picbox_Click);
            // 
            // minimize_picbox
            // 
            this.minimize_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_picbox.BackgroundImage")));
            this.minimize_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_picbox.Location = new System.Drawing.Point(1215, 28);
            this.minimize_picbox.Name = "minimize_picbox";
            this.minimize_picbox.Size = new System.Drawing.Size(16, 16);
            this.minimize_picbox.TabIndex = 11;
            this.minimize_picbox.TabStop = false;
            this.minimize_picbox.Click += new System.EventHandler(this.minimize_picbox_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "            Login with Facebook";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(25, 516);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(134)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(344, 65);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "            Login with Facebook";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            // 
            // TwitterBtn
            // 
            this.TwitterBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(245)))));
            this.TwitterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(245)))));
            this.TwitterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwitterBtn.BorderRadius = 0;
            this.TwitterBtn.ButtonText = "             Login with Twitter";
            this.TwitterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwitterBtn.DisabledColor = System.Drawing.Color.Gray;
            this.TwitterBtn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TwitterBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.TwitterBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("TwitterBtn.Iconimage")));
            this.TwitterBtn.Iconimage_right = null;
            this.TwitterBtn.Iconimage_right_Selected = null;
            this.TwitterBtn.Iconimage_Selected = null;
            this.TwitterBtn.IconMarginLeft = 0;
            this.TwitterBtn.IconMarginRight = 0;
            this.TwitterBtn.IconRightVisible = true;
            this.TwitterBtn.IconRightZoom = 0D;
            this.TwitterBtn.IconVisible = true;
            this.TwitterBtn.IconZoom = 40D;
            this.TwitterBtn.IsTab = false;
            this.TwitterBtn.Location = new System.Drawing.Point(25, 447);
            this.TwitterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TwitterBtn.Name = "TwitterBtn";
            this.TwitterBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(245)))));
            this.TwitterBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.TwitterBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TwitterBtn.selected = false;
            this.TwitterBtn.Size = new System.Drawing.Size(344, 65);
            this.TwitterBtn.TabIndex = 6;
            this.TwitterBtn.Text = "             Login with Twitter";
            this.TwitterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TwitterBtn.Textcolor = System.Drawing.Color.White;
            this.TwitterBtn.TextFont = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            // 
            // Login_Left_bg
            // 
            this.Login_Left_bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_Left_bg.BackgroundImage")));
            this.Login_Left_bg.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login_Left_bg.Location = new System.Drawing.Point(0, 0);
            this.Login_Left_bg.Margin = new System.Windows.Forms.Padding(2);
            this.Login_Left_bg.Name = "Login_Left_bg";
            this.Login_Left_bg.Size = new System.Drawing.Size(401, 640);
            this.Login_Left_bg.TabIndex = 0;
            this.Login_Left_bg.TabStop = false;
            this.Login_Left_bg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginform_MouseDown);
            // 
            // forgetPassword_usercontrol2
            // 
            this.forgetPassword_usercontrol2.BackColor = System.Drawing.Color.White;
            this.forgetPassword_usercontrol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.forgetPassword_usercontrol2.Location = new System.Drawing.Point(400, 0);
            this.forgetPassword_usercontrol2.Margin = new System.Windows.Forms.Padding(2);
            this.forgetPassword_usercontrol2.Name = "forgetPassword_usercontrol2";
            this.forgetPassword_usercontrol2.Size = new System.Drawing.Size(999, 709);
            this.forgetPassword_usercontrol2.TabIndex = 13;
            this.forgetPassword_usercontrol2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginform_MouseDown);
            // 
            // login_usercontrol1
            // 
            this.login_usercontrol1.BackColor = System.Drawing.Color.White;
            this.login_usercontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.login_usercontrol1.Location = new System.Drawing.Point(405, 0);
            this.login_usercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.login_usercontrol1.Name = "login_usercontrol1";
            this.login_usercontrol1.Size = new System.Drawing.Size(902, 634);
            this.login_usercontrol1.TabIndex = 12;
            this.login_usercontrol1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginform_MouseDown);
            // 
            // forgetPassword_usercontrol1
            // 
            this.forgetPassword_usercontrol1.BackColor = System.Drawing.Color.White;
            this.forgetPassword_usercontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.forgetPassword_usercontrol1.Location = new System.Drawing.Point(405, 0);
            this.forgetPassword_usercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.forgetPassword_usercontrol1.Name = "forgetPassword_usercontrol1";
            this.forgetPassword_usercontrol1.Size = new System.Drawing.Size(902, 634);
            this.forgetPassword_usercontrol1.TabIndex = 13;
            this.forgetPassword_usercontrol1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginform_MouseDown);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 640);
            this.Controls.Add(this.exit_picbox);
            this.Controls.Add(this.minimize_picbox);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.TwitterBtn);
            this.Controls.Add(this.copyright_txt);
            this.Controls.Add(this.information_txt);
            this.Controls.Add(this.version_txt);
            this.Controls.Add(this.Club_txt);
            this.Controls.Add(this.Quiz_text);
            this.Controls.Add(this.Login_Left_bg);
            this.Controls.Add(this.login_usercontrol1);
            this.Controls.Add(this.forgetPassword_usercontrol2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginform";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginform_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Left_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_Left_bg;
        private System.Windows.Forms.Label Quiz_text;
        private System.Windows.Forms.Label Club_txt;
        private System.Windows.Forms.Label version_txt;
        private System.Windows.Forms.Label information_txt;
        private System.Windows.Forms.Label copyright_txt;
        private Bunifu.Framework.UI.BunifuFlatButton TwitterBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox exit_picbox;
        private System.Windows.Forms.PictureBox minimize_picbox;
        private Login_usercontrol login_usercontrol1;
        private ForgetPassword_usercontrol forgetPassword_usercontrol1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ForgetPassword_usercontrol forgetPassword_usercontrol2;
    }
}