namespace quizclub.Usercontrols
{
    partial class dashboard_usercontrol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_usercontrol));
            this.SmallProfile_panel = new System.Windows.Forms.Panel();
            this.dateandTime_label = new MaterialSkin.Controls.MaterialLabel();
            this.username_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.ExamPassed_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.examfaild_number_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name_db_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.familiy_db_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.phone_db_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.country_db_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AllExams_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Permuim_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Allexams_Chart = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.examfaild_chart = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.ExamPassed_Chart = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.DatepickerTimer = new System.Windows.Forms.Timer(this.components);
            this.SmallProfile_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SmallProfile_panel
            // 
            this.SmallProfile_panel.BackColor = System.Drawing.Color.Transparent;
            this.SmallProfile_panel.Controls.Add(this.dateandTime_label);
            this.SmallProfile_panel.Controls.Add(this.username_label);
            this.SmallProfile_panel.Controls.Add(this.name_label);
            this.SmallProfile_panel.Controls.Add(this.profileImage);
            this.SmallProfile_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SmallProfile_panel.Location = new System.Drawing.Point(0, 0);
            this.SmallProfile_panel.Margin = new System.Windows.Forms.Padding(2);
            this.SmallProfile_panel.Name = "SmallProfile_panel";
            this.SmallProfile_panel.Size = new System.Drawing.Size(1112, 74);
            this.SmallProfile_panel.TabIndex = 3;
            // 
            // dateandTime_label
            // 
            this.dateandTime_label.Depth = 0;
            this.dateandTime_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateandTime_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.dateandTime_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateandTime_label.Image = global::quizclub.Properties.Resources.calendar;
            this.dateandTime_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateandTime_label.Location = new System.Drawing.Point(807, 21);
            this.dateandTime_label.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.dateandTime_label.MaximumSize = new System.Drawing.Size(281, 36);
            this.dateandTime_label.MinimumSize = new System.Drawing.Size(281, 36);
            this.dateandTime_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateandTime_label.Name = "dateandTime_label";
            this.dateandTime_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateandTime_label.Size = new System.Drawing.Size(281, 36);
            this.dateandTime_label.TabIndex = 6;
            this.dateandTime_label.Text = "materialLabel1";
            this.dateandTime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username_label.Location = new System.Drawing.Point(126, 43);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(113, 20);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "@Hyland12e_2";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.name_label.Location = new System.Drawing.Point(125, 11);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(328, 34);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Click here for change name";
            // 
            // profileImage
            // 
            this.profileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileImage.Image = global::quizclub.Properties.Resources.user;
            this.profileImage.Location = new System.Drawing.Point(51, 6);
            this.profileImage.Margin = new System.Windows.Forms.Padding(2);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(60, 60);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 2;
            this.profileImage.TabStop = false;
            // 
            // ExamPassed_label
            // 
            this.ExamPassed_label.AutoSize = true;
            this.ExamPassed_label.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamPassed_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.ExamPassed_label.Location = new System.Drawing.Point(593, 210);
            this.ExamPassed_label.Name = "ExamPassed_label";
            this.ExamPassed_label.Size = new System.Drawing.Size(39, 46);
            this.ExamPassed_label.TabIndex = 11;
            this.ExamPassed_label.Text = "0";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(596, 183);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(144, 27);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Exams passed";
            // 
            // examfaild_number_label
            // 
            this.examfaild_number_label.AutoSize = true;
            this.examfaild_number_label.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examfaild_number_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.examfaild_number_label.Location = new System.Drawing.Point(226, 210);
            this.examfaild_number_label.Name = "examfaild_number_label";
            this.examfaild_number_label.Size = new System.Drawing.Size(39, 46);
            this.examfaild_number_label.TabIndex = 14;
            this.examfaild_number_label.Text = "0";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(229, 183);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(132, 27);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Exams Failed";
            // 
            // name_db_lbl
            // 
            this.name_db_lbl.AutoSize = true;
            this.name_db_lbl.Font = new System.Drawing.Font("Open Sans", 10.8F);
            this.name_db_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.name_db_lbl.Location = new System.Drawing.Point(86, 371);
            this.name_db_lbl.Name = "name_db_lbl";
            this.name_db_lbl.Size = new System.Drawing.Size(197, 26);
            this.name_db_lbl.TabIndex = 10;
            this.name_db_lbl.Text = "click here for change";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(86, 351);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(58, 20);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "Name :";
            // 
            // familiy_db_lbl
            // 
            this.familiy_db_lbl.AutoSize = true;
            this.familiy_db_lbl.Font = new System.Drawing.Font("Open Sans", 10.8F);
            this.familiy_db_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.familiy_db_lbl.Location = new System.Drawing.Point(86, 445);
            this.familiy_db_lbl.Name = "familiy_db_lbl";
            this.familiy_db_lbl.Size = new System.Drawing.Size(197, 26);
            this.familiy_db_lbl.TabIndex = 16;
            this.familiy_db_lbl.Text = "click here for change";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(86, 425);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(63, 20);
            this.bunifuCustomLabel8.TabIndex = 15;
            this.bunifuCustomLabel8.Text = "Family :";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(85, 499);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(108, 20);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "Phonenumber";
            // 
            // phone_db_lbl
            // 
            this.phone_db_lbl.AutoSize = true;
            this.phone_db_lbl.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_db_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.phone_db_lbl.Location = new System.Drawing.Point(85, 519);
            this.phone_db_lbl.Name = "phone_db_lbl";
            this.phone_db_lbl.Size = new System.Drawing.Size(197, 26);
            this.phone_db_lbl.TabIndex = 18;
            this.phone_db_lbl.Text = "click here for change";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(86, 576);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel11.TabIndex = 19;
            this.bunifuCustomLabel11.Text = "Country :";
            // 
            // country_db_lbl
            // 
            this.country_db_lbl.AutoSize = true;
            this.country_db_lbl.Font = new System.Drawing.Font("Open Sans", 10.8F);
            this.country_db_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.country_db_lbl.Location = new System.Drawing.Point(86, 596);
            this.country_db_lbl.Name = "country_db_lbl";
            this.country_db_lbl.Size = new System.Drawing.Size(197, 26);
            this.country_db_lbl.TabIndex = 20;
            this.country_db_lbl.Text = "click here for change";
            // 
            // AllExams_label
            // 
            this.AllExams_label.AutoSize = true;
            this.AllExams_label.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllExams_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.AllExams_label.Location = new System.Drawing.Point(978, 210);
            this.AllExams_label.Name = "AllExams_label";
            this.AllExams_label.Size = new System.Drawing.Size(39, 46);
            this.AllExams_label.TabIndex = 23;
            this.AllExams_label.Text = "0";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(981, 183);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(73, 27);
            this.bunifuCustomLabel14.TabIndex = 22;
            this.bunifuCustomLabel14.Text = "Exams";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(516, 340);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(98, 23);
            this.bunifuCustomLabel15.TabIndex = 24;
            this.bunifuCustomLabel15.Text = "Biography :";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(516, 375);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(463, 123);
            this.bunifuCustomLabel16.TabIndex = 25;
            this.bunifuCustomLabel16.Text = resources.GetString("bunifuCustomLabel16.Text");
            // 
            // Permuim_btn
            // 
            this.Permuim_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(135)))), ((int)(((byte)(197)))));
            this.Permuim_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Permuim_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(135)))), ((int)(((byte)(197)))));
            this.Permuim_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(123)))), ((int)(((byte)(185)))));
            this.Permuim_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(123)))), ((int)(((byte)(185)))));
            this.Permuim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Permuim_btn.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.Permuim_btn.ForeColor = System.Drawing.Color.White;
            this.Permuim_btn.Location = new System.Drawing.Point(520, 569);
            this.Permuim_btn.Name = "Permuim_btn";
            this.Permuim_btn.Size = new System.Drawing.Size(534, 53);
            this.Permuim_btn.TabIndex = 26;
            this.Permuim_btn.Text = "Permium";
            this.Permuim_btn.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Allexams_Chart
            // 
            this.Allexams_Chart.animated = false;
            this.Allexams_Chart.animationIterval = 1;
            this.Allexams_Chart.animationSpeed = 3;
            this.Allexams_Chart.BackColor = System.Drawing.Color.White;
            this.Allexams_Chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Allexams_Chart.BackgroundImage")));
            this.Allexams_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Allexams_Chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.Allexams_Chart.LabelVisible = true;
            this.Allexams_Chart.LineProgressThickness = 8;
            this.Allexams_Chart.LineThickness = 5;
            this.Allexams_Chart.Location = new System.Drawing.Point(797, 135);
            this.Allexams_Chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Allexams_Chart.MaxValue = 100;
            this.Allexams_Chart.Name = "Allexams_Chart";
            this.Allexams_Chart.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Allexams_Chart.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.Allexams_Chart.Size = new System.Drawing.Size(152, 152);
            this.Allexams_Chart.TabIndex = 21;
            this.Allexams_Chart.Value = 0;
            // 
            // examfaild_chart
            // 
            this.examfaild_chart.animated = false;
            this.examfaild_chart.animationIterval = 1;
            this.examfaild_chart.animationSpeed = 1;
            this.examfaild_chart.BackColor = System.Drawing.Color.White;
            this.examfaild_chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("examfaild_chart.BackgroundImage")));
            this.examfaild_chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.examfaild_chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.examfaild_chart.LabelVisible = true;
            this.examfaild_chart.LineProgressThickness = 8;
            this.examfaild_chart.LineThickness = 5;
            this.examfaild_chart.Location = new System.Drawing.Point(45, 135);
            this.examfaild_chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.examfaild_chart.MaxValue = 100;
            this.examfaild_chart.Name = "examfaild_chart";
            this.examfaild_chart.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.examfaild_chart.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.examfaild_chart.Size = new System.Drawing.Size(152, 152);
            this.examfaild_chart.TabIndex = 12;
            this.examfaild_chart.Value = 0;
            // 
            // ExamPassed_Chart
            // 
            this.ExamPassed_Chart.animated = false;
            this.ExamPassed_Chart.animationIterval = 1;
            this.ExamPassed_Chart.animationSpeed = 3;
            this.ExamPassed_Chart.BackColor = System.Drawing.Color.White;
            this.ExamPassed_Chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExamPassed_Chart.BackgroundImage")));
            this.ExamPassed_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ExamPassed_Chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.ExamPassed_Chart.LabelVisible = true;
            this.ExamPassed_Chart.LineProgressThickness = 8;
            this.ExamPassed_Chart.LineThickness = 5;
            this.ExamPassed_Chart.Location = new System.Drawing.Point(412, 135);
            this.ExamPassed_Chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExamPassed_Chart.MaxValue = 100;
            this.ExamPassed_Chart.Name = "ExamPassed_Chart";
            this.ExamPassed_Chart.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ExamPassed_Chart.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(44)))));
            this.ExamPassed_Chart.Size = new System.Drawing.Size(152, 152);
            this.ExamPassed_Chart.TabIndex = 4;
            this.ExamPassed_Chart.Value = 0;
            // 
            // DatepickerTimer
            // 
            this.DatepickerTimer.Tick += new System.EventHandler(this.DatepickerTimer_Tick);
            // 
            // dashboard_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Permuim_btn);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.AllExams_label);
            this.Controls.Add(this.Allexams_Chart);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.country_db_lbl);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.phone_db_lbl);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.examfaild_number_label);
            this.Controls.Add(this.examfaild_chart);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.ExamPassed_label);
            this.Controls.Add(this.ExamPassed_Chart);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.SmallProfile_panel);
            this.Controls.Add(this.familiy_db_lbl);
            this.Controls.Add(this.name_db_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dashboard_usercontrol";
            this.Size = new System.Drawing.Size(1112, 699);
            this.Load += new System.EventHandler(this.dashboard_usercontrol_Load);
            this.SmallProfile_panel.ResumeLayout(false);
            this.SmallProfile_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel SmallProfile_panel;
        public Bunifu.Framework.UI.BunifuCustomLabel username_label;
        public Bunifu.Framework.UI.BunifuCustomLabel name_label;
        public System.Windows.Forms.PictureBox profileImage;
        public Bunifu.Framework.UI.BunifuCircleProgressbar ExamPassed_Chart;
        public Bunifu.Framework.UI.BunifuCustomLabel ExamPassed_label;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel examfaild_number_label;
        public Bunifu.Framework.UI.BunifuCircleProgressbar examfaild_chart;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuCustomLabel name_db_lbl;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public Bunifu.Framework.UI.BunifuCustomLabel familiy_db_lbl;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        public Bunifu.Framework.UI.BunifuCustomLabel phone_db_lbl;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        public Bunifu.Framework.UI.BunifuCustomLabel country_db_lbl;
        public Bunifu.Framework.UI.BunifuCustomLabel AllExams_label;
        public Bunifu.Framework.UI.BunifuCircleProgressbar Allexams_Chart;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        public MaterialSkin.Controls.MaterialLabel dateandTime_label;
        public System.Windows.Forms.Button Permuim_btn;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer DatepickerTimer;
    }
}
