using System.Windows.Forms;
namespace quizclub
{
    partial class Student_profile
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
            

            this.Sidebarmenu_panel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.settings_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Exams_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.exit_picbox = new System.Windows.Forms.PictureBox();
            this.minimize_picbox = new System.Windows.Forms.PictureBox();
            this.dashboard_usercontrol2 = new quizclub.Usercontrols.dashboard_usercontrol();
            this.settings_usercontrol1 = new quizclub.Usercontrols.Settings_usercontrol();
            this.exams_usercontrol1 = new quizclub.Usercontrols.Exams_usercontrol();
            this.Sidebarmenu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebarmenu_panel
            // 
            this.Sidebarmenu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.Sidebarmenu_panel.Controls.Add(this.logout_btn);
            this.Sidebarmenu_panel.Controls.Add(this.Dashboard_btn);
            this.Sidebarmenu_panel.Controls.Add(this.settings_btn);
            this.Sidebarmenu_panel.Controls.Add(this.Exams_btn);
            this.Sidebarmenu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebarmenu_panel.Location = new System.Drawing.Point(0, 0);
            this.Sidebarmenu_panel.Margin = new System.Windows.Forms.Padding(2);
            this.Sidebarmenu_panel.Name = "Sidebarmenu_panel";
            this.Sidebarmenu_panel.Size = new System.Drawing.Size(172, 700);
            this.Sidebarmenu_panel.TabIndex = 0;
            this.Sidebarmenu_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_Profile_MouseDown);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(0, 659);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(172, 41);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.Dashboard_btn.color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.Dashboard_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.Dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard_btn.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Image = global::quizclub.Properties.Resources.dashboardbtn_png;
            this.Dashboard_btn.ImagePosition = 25;
            this.Dashboard_btn.ImageZoom = 25;
            this.Dashboard_btn.LabelPosition = 43;
            this.Dashboard_btn.LabelText = "Dashboard";
            this.Dashboard_btn.Location = new System.Drawing.Point(0, 0);
            this.Dashboard_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(172, 133);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.settings_btn.color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.settings_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_btn.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.settings_btn.ForeColor = System.Drawing.Color.White;
            this.settings_btn.Image = global::quizclub.Properties.Resources.settingsbtn;
            this.settings_btn.ImagePosition = 25;
            this.settings_btn.ImageZoom = 25;
            this.settings_btn.LabelPosition = 43;
            this.settings_btn.LabelText = "Settings";
            this.settings_btn.Location = new System.Drawing.Point(0, 243);
            this.settings_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(172, 115);
            this.settings_btn.TabIndex = 6;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // Exams_btn
            // 
            this.Exams_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.Exams_btn.color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.Exams_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.Exams_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exams_btn.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Exams_btn.ForeColor = System.Drawing.Color.White;
            this.Exams_btn.Image = global::quizclub.Properties.Resources.exambtn_png;
            this.Exams_btn.ImagePosition = 25;
            this.Exams_btn.ImageZoom = 25;
            this.Exams_btn.LabelPosition = 43;
            this.Exams_btn.LabelText = "Exams";
            this.Exams_btn.Location = new System.Drawing.Point(0, 133);
            this.Exams_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Exams_btn.Name = "Exams_btn";
            this.Exams_btn.Size = new System.Drawing.Size(172, 115);
            this.Exams_btn.TabIndex = 3;
            this.Exams_btn.Click += new System.EventHandler(this.Exams_btn_Click);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(-19, -19);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 2;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // exit_picbox
            // 
            this.exit_picbox.BackColor = System.Drawing.Color.Transparent;
            this.exit_picbox.BackgroundImage = global::quizclub.Properties.Resources.exit_btn;
            this.exit_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_picbox.Location = new System.Drawing.Point(1263, 12);
            this.exit_picbox.Name = "exit_picbox";
            this.exit_picbox.Size = new System.Drawing.Size(16, 16);
            this.exit_picbox.TabIndex = 14;
            this.exit_picbox.TabStop = false;
            this.exit_picbox.Click += new System.EventHandler(this.exit_picbox_Click_1);
            // 
            // minimize_picbox
            // 
            this.minimize_picbox.BackColor = System.Drawing.Color.Transparent;
            this.minimize_picbox.BackgroundImage = global::quizclub.Properties.Resources.minimize;
            this.minimize_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_picbox.Location = new System.Drawing.Point(1232, 12);
            this.minimize_picbox.Name = "minimize_picbox";
            this.minimize_picbox.Size = new System.Drawing.Size(16, 16);
            this.minimize_picbox.TabIndex = 15;
            this.minimize_picbox.TabStop = false;
            this.minimize_picbox.Click += new System.EventHandler(this.minimize_picbox_Click_1);
            // 
            // dashboard_usercontrol2
            // 
            this.dashboard_usercontrol2.BackColor = System.Drawing.Color.White;
            this.dashboard_usercontrol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dashboard_usercontrol2.Location = new System.Drawing.Point(182, 36);
            this.dashboard_usercontrol2.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard_usercontrol2.Name = "dashboard_usercontrol2";
            this.dashboard_usercontrol2.Size = new System.Drawing.Size(1110, 699);
            this.dashboard_usercontrol2.TabIndex = 17;
            this.dashboard_usercontrol2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_Profile_MouseDown);
            // 
            // settings_usercontrol1
            // 
            this.settings_usercontrol1.BackColor = System.Drawing.Color.White;
            this.settings_usercontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.settings_usercontrol1.Location = new System.Drawing.Point(182, 34);
            this.settings_usercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.settings_usercontrol1.Name = "settings_usercontrol1";
            this.settings_usercontrol1.Size = new System.Drawing.Size(1111, 664);
            this.settings_usercontrol1.TabIndex = 18;
            this.settings_usercontrol1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_Profile_MouseDown);
            // 
            // exams_usercontrol1
            // 
            this.exams_usercontrol1.BackColor = System.Drawing.Color.White;
            this.exams_usercontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.exams_usercontrol1.Location = new System.Drawing.Point(175, 33);
            this.exams_usercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.exams_usercontrol1.Name = "exams_usercontrol1";
            this.exams_usercontrol1.Size = new System.Drawing.Size(1125, 665);
            this.exams_usercontrol1.TabIndex = 19;
            this.exams_usercontrol1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_Profile_MouseDown);
            // 
            // Student_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.minimize_picbox);
            this.Controls.Add(this.exit_picbox);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.Sidebarmenu_panel);
            this.Controls.Add(this.exams_usercontrol1);
            this.Controls.Add(this.settings_usercontrol1);
            this.Controls.Add(this.dashboard_usercontrol2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Student_profile_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_Profile_MouseDown);
            this.Sidebarmenu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Sidebarmenu_panel;
        private Bunifu.Framework.UI.BunifuTileButton Dashboard_btn;
        private Bunifu.Framework.UI.BunifuTileButton Exams_btn;
        private Bunifu.Framework.UI.BunifuTileButton settings_btn;
        private System.Windows.Forms.Button logout_btn;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.PictureBox exit_picbox;
        private System.Windows.Forms.PictureBox minimize_picbox;
        private Usercontrols.dashboard_usercontrol dashboard_usercontrol2;
        private Usercontrols.Settings_usercontrol settings_usercontrol1;
        private Usercontrols.Exams_usercontrol exams_usercontrol1;
    }
}