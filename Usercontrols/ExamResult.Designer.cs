namespace quizclub.Usercontrols
{
    partial class ExamResult
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
            this.userScore_lbl = new System.Windows.Forms.Label();
            this.yourScore_lbl = new System.Windows.Forms.Label();
            this.commend_txt = new System.Windows.Forms.TextBox();
            this.commendTitle = new System.Windows.Forms.Label();
            this.CommendLength_lbl = new System.Windows.Forms.Label();
            this.commendpic = new System.Windows.Forms.PictureBox();
            this.end_btn = new System.Windows.Forms.Button();
            this.examTitle_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.commendpic)).BeginInit();
            this.SuspendLayout();
            // 
            // userScore_lbl
            // 
            this.userScore_lbl.AutoSize = true;
            this.userScore_lbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScore_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(64)))));
            this.userScore_lbl.Location = new System.Drawing.Point(191, 171);
            this.userScore_lbl.Name = "userScore_lbl";
            this.userScore_lbl.Size = new System.Drawing.Size(196, 67);
            this.userScore_lbl.TabIndex = 25;
            this.userScore_lbl.Text = "95/100";
            // 
            // yourScore_lbl
            // 
            this.yourScore_lbl.AutoSize = true;
            this.yourScore_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScore_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yourScore_lbl.Location = new System.Drawing.Point(270, 229);
            this.yourScore_lbl.Name = "yourScore_lbl";
            this.yourScore_lbl.Size = new System.Drawing.Size(102, 28);
            this.yourScore_lbl.TabIndex = 26;
            this.yourScore_lbl.Text = "Your score";
            // 
            // commend_txt
            // 
            this.commend_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commend_txt.Location = new System.Drawing.Point(96, 351);
            this.commend_txt.MaxLength = 255;
            this.commend_txt.Multiline = true;
            this.commend_txt.Name = "commend_txt";
            this.commend_txt.Size = new System.Drawing.Size(409, 148);
            this.commend_txt.TabIndex = 27;
            this.commend_txt.TextChanged += new System.EventHandler(this.commend_txt_TextChanged);
            this.commend_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commend_txt_KeyPress);
            // 
            // commendTitle
            // 
            this.commendTitle.AutoSize = true;
            this.commendTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commendTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commendTitle.Location = new System.Drawing.Point(91, 312);
            this.commendTitle.Name = "commendTitle";
            this.commendTitle.Size = new System.Drawing.Size(339, 28);
            this.commendTitle.TabIndex = 28;
            this.commendTitle.Text = "enter your commend about this exam";
            // 
            // CommendLength_lbl
            // 
            this.CommendLength_lbl.AutoSize = true;
            this.CommendLength_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommendLength_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CommendLength_lbl.Location = new System.Drawing.Point(92, 509);
            this.CommendLength_lbl.Name = "CommendLength_lbl";
            this.CommendLength_lbl.Size = new System.Drawing.Size(33, 19);
            this.CommendLength_lbl.TabIndex = 29;
            this.CommendLength_lbl.Text = "255";
            // 
            // commendpic
            // 
            this.commendpic.Image = global::quizclub.Properties.Resources.contract;
            this.commendpic.Location = new System.Drawing.Point(477, 313);
            this.commendpic.Name = "commendpic";
            this.commendpic.Size = new System.Drawing.Size(28, 27);
            this.commendpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commendpic.TabIndex = 30;
            this.commendpic.TabStop = false;
            // 
            // end_btn
            // 
            this.end_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.end_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.end_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.end_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(170)))), ((int)(((byte)(185)))));
            this.end_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_btn.ForeColor = System.Drawing.Color.Transparent;
            this.end_btn.Location = new System.Drawing.Point(226, 526);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(115, 45);
            this.end_btn.TabIndex = 31;
            this.end_btn.Text = "End";
            this.end_btn.UseVisualStyleBackColor = false;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // examTitle_lbl
            // 
            this.examTitle_lbl.AutoSize = true;
            this.examTitle_lbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.examTitle_lbl.Location = new System.Drawing.Point(442, 48);
            this.examTitle_lbl.Name = "examTitle_lbl";
            this.examTitle_lbl.Size = new System.Drawing.Size(331, 57);
            this.examTitle_lbl.TabIndex = 32;
            this.examTitle_lbl.Text = "This is exam title";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.examTitle_lbl);
            this.Controls.Add(this.end_btn);
            this.Controls.Add(this.commendpic);
            this.Controls.Add(this.CommendLength_lbl);
            this.Controls.Add(this.commendTitle);
            this.Controls.Add(this.commend_txt);
            this.Controls.Add(this.yourScore_lbl);
            this.Controls.Add(this.userScore_lbl);
            this.Name = "ExamResult";
            this.Size = new System.Drawing.Size(1251, 671);
            ((System.ComponentModel.ISupportInitialize)(this.commendpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userScore_lbl;
        private System.Windows.Forms.Label yourScore_lbl;
        private System.Windows.Forms.TextBox commend_txt;
        private System.Windows.Forms.Label commendTitle;
        private System.Windows.Forms.Label CommendLength_lbl;
        private System.Windows.Forms.PictureBox commendpic;
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.Label examTitle_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}
