namespace quizclub.Forms
{
    partial class DoExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoExam));
            this.examTitle_lbl = new System.Windows.Forms.Label();
            this.Creator_lbl = new System.Windows.Forms.Label();
            this.questionCount_lbl = new System.Windows.Forms.Label();
            this.timeOut_lbl = new System.Windows.Forms.Label();
            this.startExam_btn = new System.Windows.Forms.Button();
            this.usernumber_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_picbox = new System.Windows.Forms.PictureBox();
            this.minimize_picbox = new System.Windows.Forms.PictureBox();
            this.ExamviewModel_panel = new System.Windows.Forms.Panel();
            this.questionWarning_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).BeginInit();
            this.ExamviewModel_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // examTitle_lbl
            // 
            this.examTitle_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examTitle_lbl.AutoSize = true;
            this.examTitle_lbl.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.examTitle_lbl.Location = new System.Drawing.Point(448, 192);
            this.examTitle_lbl.Name = "examTitle_lbl";
            this.examTitle_lbl.Size = new System.Drawing.Size(354, 67);
            this.examTitle_lbl.TabIndex = 16;
            this.examTitle_lbl.Text = "Exam title here";
            // 
            // Creator_lbl
            // 
            this.Creator_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Creator_lbl.AutoSize = true;
            this.Creator_lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_lbl.Location = new System.Drawing.Point(454, 270);
            this.Creator_lbl.MaximumSize = new System.Drawing.Size(111, 28);
            this.Creator_lbl.MinimumSize = new System.Drawing.Size(111, 28);
            this.Creator_lbl.Name = "Creator_lbl";
            this.Creator_lbl.Size = new System.Drawing.Size(111, 28);
            this.Creator_lbl.TabIndex = 20;
            this.Creator_lbl.Text = "MahdiFakhr";
            // 
            // questionCount_lbl
            // 
            this.questionCount_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionCount_lbl.AutoSize = true;
            this.questionCount_lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCount_lbl.Location = new System.Drawing.Point(569, 270);
            this.questionCount_lbl.Name = "questionCount_lbl";
            this.questionCount_lbl.Size = new System.Drawing.Size(119, 28);
            this.questionCount_lbl.TabIndex = 21;
            this.questionCount_lbl.Text = "25 questions";
            // 
            // timeOut_lbl
            // 
            this.timeOut_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeOut_lbl.AutoSize = true;
            this.timeOut_lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOut_lbl.Location = new System.Drawing.Point(694, 270);
            this.timeOut_lbl.Name = "timeOut_lbl";
            this.timeOut_lbl.Size = new System.Drawing.Size(98, 28);
            this.timeOut_lbl.TabIndex = 22;
            this.timeOut_lbl.Text = "45 minute";
            // 
            // startExam_btn
            // 
            this.startExam_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.startExam_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startExam_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(195)))));
            this.startExam_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.startExam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startExam_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startExam_btn.ForeColor = System.Drawing.Color.White;
            this.startExam_btn.Location = new System.Drawing.Point(460, 336);
            this.startExam_btn.Name = "startExam_btn";
            this.startExam_btn.Size = new System.Drawing.Size(320, 63);
            this.startExam_btn.TabIndex = 23;
            this.startExam_btn.Text = "enter";
            this.startExam_btn.UseVisualStyleBackColor = false;
            this.startExam_btn.Click += new System.EventHandler(this.startExam_btn_Click);
            // 
            // usernumber_lbl
            // 
            this.usernumber_lbl.AutoSize = true;
            this.usernumber_lbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernumber_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.usernumber_lbl.Location = new System.Drawing.Point(577, 82);
            this.usernumber_lbl.Name = "usernumber_lbl";
            this.usernumber_lbl.Size = new System.Drawing.Size(138, 57);
            this.usernumber_lbl.TabIndex = 24;
            this.usernumber_lbl.Text = " users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(584, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "done this exam";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 583);
            this.label7.MaximumSize = new System.Drawing.Size(311, 89);
            this.label7.MinimumSize = new System.Drawing.Size(311, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 89);
            this.label7.TabIndex = 26;
            this.label7.Text = "This is Awesome i Suggest to other user do this exam tnx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(532, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sara Kylin";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 489);
            this.label9.MaximumSize = new System.Drawing.Size(111, 28);
            this.label9.MinimumSize = new System.Drawing.Size(111, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "Commends";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quizclub.Properties.Resources.profileImage;
            this.pictureBox2.Location = new System.Drawing.Point(437, 563);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::quizclub.Properties.Resources.Examfile;
            this.pictureBox1.Location = new System.Drawing.Point(432, 60);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(165, 119);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(165, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // exit_picbox
            // 
            this.exit_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_picbox.BackgroundImage")));
            this.exit_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_picbox.Location = new System.Drawing.Point(1230, 6);
            this.exit_picbox.Name = "exit_picbox";
            this.exit_picbox.Size = new System.Drawing.Size(16, 16);
            this.exit_picbox.TabIndex = 14;
            this.exit_picbox.TabStop = false;
            this.exit_picbox.Click += new System.EventHandler(this.exit_picbox_Click);
            // 
            // minimize_picbox
            // 
            this.minimize_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_picbox.BackgroundImage")));
            this.minimize_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_picbox.Location = new System.Drawing.Point(1199, 6);
            this.minimize_picbox.Name = "minimize_picbox";
            this.minimize_picbox.Size = new System.Drawing.Size(16, 16);
            this.minimize_picbox.TabIndex = 15;
            this.minimize_picbox.TabStop = false;
            this.minimize_picbox.Click += new System.EventHandler(this.minimize_picbox_Click);
            // 
            // ExamviewModel_panel
            // 
            this.ExamviewModel_panel.Controls.Add(this.questionWarning_lbl);
            this.ExamviewModel_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExamviewModel_panel.Location = new System.Drawing.Point(0, 28);
            this.ExamviewModel_panel.Name = "ExamviewModel_panel";
            this.ExamviewModel_panel.Size = new System.Drawing.Size(1251, 671);
            this.ExamviewModel_panel.TabIndex = 30;
            // 
            // questionWarning_lbl
            // 
            this.questionWarning_lbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionWarning_lbl.ForeColor = System.Drawing.Color.Red;
            this.questionWarning_lbl.Location = new System.Drawing.Point(465, 391);
            this.questionWarning_lbl.Name = "questionWarning_lbl";
            this.questionWarning_lbl.Size = new System.Drawing.Size(310, 43);
            this.questionWarning_lbl.TabIndex = 0;
            this.questionWarning_lbl.Text = "Be careful when answering, after registering the answer, you can\'t redo this acti" +
    "on\r\n";
            // 
            // DoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 699);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usernumber_lbl);
            this.Controls.Add(this.startExam_btn);
            this.Controls.Add(this.timeOut_lbl);
            this.Controls.Add(this.questionCount_lbl);
            this.Controls.Add(this.Creator_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.examTitle_lbl);
            this.Controls.Add(this.exit_picbox);
            this.Controls.Add(this.minimize_picbox);
            this.Controls.Add(this.ExamviewModel_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoExam";
            this.Load += new System.EventHandler(this.DoExam_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoExam_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).EndInit();
            this.ExamviewModel_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_picbox;
        private System.Windows.Forms.PictureBox minimize_picbox;
        private System.Windows.Forms.Label examTitle_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Creator_lbl;
        private System.Windows.Forms.Label questionCount_lbl;
        private System.Windows.Forms.Label timeOut_lbl;
        private System.Windows.Forms.Button startExam_btn;
        private System.Windows.Forms.Label usernumber_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel ExamviewModel_panel;
        private System.Windows.Forms.Label questionWarning_lbl;
    }
}