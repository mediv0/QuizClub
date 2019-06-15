namespace quizclub.Usercontrols
{
    partial class ExamViewModel
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
            this.timer_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.second_lbl = new System.Windows.Forms.Label();
            this.minute_lbl = new System.Windows.Forms.Label();
            this.hour_lbl = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.examEndtimer = new System.Windows.Forms.Timer(this.components);
            this.next_btn = new System.Windows.Forms.Button();
            this.question_counter_lbl = new System.Windows.Forms.Label();
            this.question_title_lbl = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.option1_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.option2_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.option3_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.option4_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.endExam_btn = new System.Windows.Forms.Button();
            this.exam_result_panel = new System.Windows.Forms.Panel();
            this.timer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_panel
            // 
            this.timer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.timer_panel.Controls.Add(this.label6);
            this.timer_panel.Controls.Add(this.label5);
            this.timer_panel.Controls.Add(this.label4);
            this.timer_panel.Controls.Add(this.second_lbl);
            this.timer_panel.Controls.Add(this.minute_lbl);
            this.timer_panel.Controls.Add(this.hour_lbl);
            this.timer_panel.Controls.Add(this.bunifuSeparator1);
            this.timer_panel.Controls.Add(this.bunifuSeparator2);
            this.timer_panel.Location = new System.Drawing.Point(346, 567);
            this.timer_panel.Name = "timer_panel";
            this.timer_panel.Size = new System.Drawing.Size(569, 204);
            this.timer_panel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(405, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "second(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "minute(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "hour(s)";
            // 
            // second_lbl
            // 
            this.second_lbl.AutoSize = true;
            this.second_lbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_lbl.ForeColor = System.Drawing.Color.White;
            this.second_lbl.Location = new System.Drawing.Point(399, 7);
            this.second_lbl.Name = "second_lbl";
            this.second_lbl.Size = new System.Drawing.Size(83, 67);
            this.second_lbl.TabIndex = 2;
            this.second_lbl.Text = "10";
            // 
            // minute_lbl
            // 
            this.minute_lbl.AutoSize = true;
            this.minute_lbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute_lbl.ForeColor = System.Drawing.Color.White;
            this.minute_lbl.Location = new System.Drawing.Point(234, 7);
            this.minute_lbl.Name = "minute_lbl";
            this.minute_lbl.Size = new System.Drawing.Size(83, 67);
            this.minute_lbl.TabIndex = 1;
            this.minute_lbl.Text = "23";
            // 
            // hour_lbl
            // 
            this.hour_lbl.AutoSize = true;
            this.hour_lbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_lbl.ForeColor = System.Drawing.Color.White;
            this.hour_lbl.Location = new System.Drawing.Point(76, 7);
            this.hour_lbl.Name = "hour_lbl";
            this.hour_lbl.Size = new System.Drawing.Size(83, 67);
            this.hour_lbl.TabIndex = 0;
            this.hour_lbl.Text = "02";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(167, 34);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(43, 44);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(344, 34);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(43, 44);
            this.bunifuSeparator2.TabIndex = 4;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // examEndtimer
            // 
            this.examEndtimer.Interval = 1000;
            this.examEndtimer.Tick += new System.EventHandler(this.examEndtimer_Tick);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(36)))), ((int)(((byte)(89)))));
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(36)))), ((int)(((byte)(89)))));
            this.next_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.Transparent;
            this.next_btn.Location = new System.Drawing.Point(105, 423);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(115, 45);
            this.next_btn.TabIndex = 1;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // question_counter_lbl
            // 
            this.question_counter_lbl.AutoSize = true;
            this.question_counter_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_counter_lbl.Location = new System.Drawing.Point(19, 19);
            this.question_counter_lbl.Name = "question_counter_lbl";
            this.question_counter_lbl.Size = new System.Drawing.Size(134, 28);
            this.question_counter_lbl.TabIndex = 2;
            this.question_counter_lbl.Text = "question 1/20";
            // 
            // question_title_lbl
            // 
            this.question_title_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_title_lbl.Location = new System.Drawing.Point(98, 121);
            this.question_title_lbl.Name = "question_title_lbl";
            this.question_title_lbl.Size = new System.Drawing.Size(1056, 110);
            this.question_title_lbl.TabIndex = 3;
            this.question_title_lbl.Text = "Our Services are very diverse, so sometimes additional terms or product requireme" +
    "nts (including age requirements) may apply?\r\n";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(105, 84);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1039, 44);
            this.bunifuSeparator3.TabIndex = 8;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // option1_radio
            // 
            this.option1_radio.AutoSize = true;
            this.option1_radio.Depth = 0;
            this.option1_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.option1_radio.Location = new System.Drawing.Point(103, 255);
            this.option1_radio.Margin = new System.Windows.Forms.Padding(0);
            this.option1_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option1_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.option1_radio.Name = "option1_radio";
            this.option1_radio.Ripple = true;
            this.option1_radio.Size = new System.Drawing.Size(337, 30);
            this.option1_radio.TabIndex = 9;
            this.option1_radio.TabStop = true;
            this.option1_radio.Text = "Modifying and Terminating our Services";
            this.option1_radio.UseVisualStyleBackColor = true;
            // 
            // option2_radio
            // 
            this.option2_radio.AutoSize = true;
            this.option2_radio.Depth = 0;
            this.option2_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.option2_radio.Location = new System.Drawing.Point(103, 292);
            this.option2_radio.Margin = new System.Windows.Forms.Padding(0);
            this.option2_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option2_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.option2_radio.Name = "option2_radio";
            this.option2_radio.Ripple = true;
            this.option2_radio.Size = new System.Drawing.Size(173, 30);
            this.option2_radio.TabIndex = 10;
            this.option2_radio.TabStop = true;
            this.option2_radio.Text = "Using our Services";
            this.option2_radio.UseVisualStyleBackColor = true;
            // 
            // option3_radio
            // 
            this.option3_radio.AutoSize = true;
            this.option3_radio.Depth = 0;
            this.option3_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.option3_radio.Location = new System.Drawing.Point(103, 331);
            this.option3_radio.Margin = new System.Windows.Forms.Padding(0);
            this.option3_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option3_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.option3_radio.Name = "option3_radio";
            this.option3_radio.Ripple = true;
            this.option3_radio.Size = new System.Drawing.Size(193, 30);
            this.option3_radio.TabIndex = 11;
            this.option3_radio.TabStop = true;
            this.option3_radio.Text = "Your Google Account";
            this.option3_radio.UseVisualStyleBackColor = true;
            // 
            // option4_radio
            // 
            this.option4_radio.AutoSize = true;
            this.option4_radio.Depth = 0;
            this.option4_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.option4_radio.Location = new System.Drawing.Point(103, 369);
            this.option4_radio.Margin = new System.Windows.Forms.Padding(0);
            this.option4_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option4_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.option4_radio.Name = "option4_radio";
            this.option4_radio.Ripple = true;
            this.option4_radio.Size = new System.Drawing.Size(282, 30);
            this.option4_radio.TabIndex = 12;
            this.option4_radio.TabStop = true;
            this.option4_radio.Text = "Privacy and Copyright Protection";
            this.option4_radio.UseVisualStyleBackColor = true;
            // 
            // endExam_btn
            // 
            this.endExam_btn.BackColor = System.Drawing.Color.White;
            this.endExam_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endExam_btn.FlatAppearance.BorderSize = 0;
            this.endExam_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.endExam_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.endExam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endExam_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endExam_btn.ForeColor = System.Drawing.Color.Black;
            this.endExam_btn.Location = new System.Drawing.Point(99, 472);
            this.endExam_btn.Name = "endExam_btn";
            this.endExam_btn.Size = new System.Drawing.Size(125, 30);
            this.endExam_btn.TabIndex = 13;
            this.endExam_btn.Text = "End this exam";
            this.endExam_btn.UseVisualStyleBackColor = false;
            this.endExam_btn.Click += new System.EventHandler(this.endExam_btn_Click);
            // 
            // exam_result_panel
            // 
            this.exam_result_panel.Location = new System.Drawing.Point(0, 0);
            this.exam_result_panel.Name = "exam_result_panel";
            this.exam_result_panel.Size = new System.Drawing.Size(1251, 671);
            this.exam_result_panel.TabIndex = 14;
            // 
            // ExamViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.endExam_btn);
            this.Controls.Add(this.option4_radio);
            this.Controls.Add(this.option3_radio);
            this.Controls.Add(this.option2_radio);
            this.Controls.Add(this.option1_radio);
            this.Controls.Add(this.question_title_lbl);
            this.Controls.Add(this.question_counter_lbl);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.timer_panel);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.exam_result_panel);
            this.Name = "ExamViewModel";
            this.Size = new System.Drawing.Size(1251, 671);
            this.timer_panel.ResumeLayout(false);
            this.timer_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel timer_panel;
        private System.Windows.Forms.Label second_lbl;
        private System.Windows.Forms.Label minute_lbl;
        private System.Windows.Forms.Label hour_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Timer examEndtimer;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label question_counter_lbl;
        private System.Windows.Forms.Label question_title_lbl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private MaterialSkin.Controls.MaterialRadioButton option1_radio;
        private MaterialSkin.Controls.MaterialRadioButton option2_radio;
        private MaterialSkin.Controls.MaterialRadioButton option3_radio;
        private MaterialSkin.Controls.MaterialRadioButton option4_radio;
        private System.Windows.Forms.Button endExam_btn;
        private System.Windows.Forms.Panel exam_result_panel;
    }
}
