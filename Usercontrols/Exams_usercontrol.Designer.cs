namespace quizclub.Usercontrols
{
    partial class Exams_usercontrol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateExam_btn = new System.Windows.Forms.Button();
            this.otherExams_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a exam or join in one of our exams";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Open Sans Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(263, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "Improve yourself see your statistics check your status after each exam with chart" +
    "s or you can create a new exam for other users";
            // 
            // CreateExam_btn
            // 
            this.CreateExam_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.CreateExam_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateExam_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.CreateExam_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.CreateExam_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.CreateExam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateExam_btn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CreateExam_btn.ForeColor = System.Drawing.Color.White;
            this.CreateExam_btn.Location = new System.Drawing.Point(281, 53);
            this.CreateExam_btn.Name = "CreateExam_btn";
            this.CreateExam_btn.Size = new System.Drawing.Size(534, 65);
            this.CreateExam_btn.TabIndex = 4;
            this.CreateExam_btn.Text = "Create a exam";
            this.CreateExam_btn.UseVisualStyleBackColor = false;
            this.CreateExam_btn.Click += new System.EventHandler(this.CreateExam_btn_Click);
            // 
            // otherExams_btn
            // 
            this.otherExams_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(101)))), ((int)(((byte)(76)))));
            this.otherExams_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otherExams_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(101)))), ((int)(((byte)(76)))));
            this.otherExams_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(70)))), ((int)(((byte)(44)))));
            this.otherExams_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(70)))), ((int)(((byte)(44)))));
            this.otherExams_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherExams_btn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.otherExams_btn.ForeColor = System.Drawing.Color.White;
            this.otherExams_btn.Location = new System.Drawing.Point(281, 151);
            this.otherExams_btn.Name = "otherExams_btn";
            this.otherExams_btn.Size = new System.Drawing.Size(534, 65);
            this.otherExams_btn.TabIndex = 5;
            this.otherExams_btn.Text = "Other exams";
            this.otherExams_btn.UseVisualStyleBackColor = false;
            this.otherExams_btn.Click += new System.EventHandler(this.otherExams_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::quizclub.Properties.Resources.Exam_Background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 309);
            this.panel1.TabIndex = 0;
            // 
            // Exams_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.otherExams_btn);
            this.Controls.Add(this.CreateExam_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Exams_usercontrol";
            this.Size = new System.Drawing.Size(1112, 699);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateExam_btn;
        private System.Windows.Forms.Button otherExams_btn;
    }
}
