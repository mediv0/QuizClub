namespace quizclub.Forms
{
    partial class ExamCreation
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Input_txt = new System.Windows.Forms.TextBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.maxQuestions_label = new System.Windows.Forms.Label();
            this.autoSystemQuestions_lbl = new System.Windows.Forms.Label();
            this.Option1_txtbox = new System.Windows.Forms.TextBox();
            this.Option1_lbl = new System.Windows.Forms.Label();
            this.Option2_lbl = new System.Windows.Forms.Label();
            this.Option2_txtbox = new System.Windows.Forms.TextBox();
            this.Option4_lbl = new System.Windows.Forms.Label();
            this.Option4_txtbox = new System.Windows.Forms.TextBox();
            this.Option3_lbl = new System.Windows.Forms.Label();
            this.Option3_txtbox = new System.Windows.Forms.TextBox();
            this.Answer_lbl = new System.Windows.Forms.Label();
            this.Answer_Combobox = new System.Windows.Forms.ComboBox();
            this.ShowCategory_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::quizclub.Properties.Resources.Text_ExamCreation;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(289, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 64);
            this.panel1.TabIndex = 0;
            // 
            // Input_txt
            // 
            this.Input_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.Input_txt.Font = new System.Drawing.Font("Open Sans Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_txt.ForeColor = System.Drawing.Color.White;
            this.Input_txt.Location = new System.Drawing.Point(49, 262);
            this.Input_txt.Name = "Input_txt";
            this.Input_txt.Size = new System.Drawing.Size(523, 76);
            this.Input_txt.TabIndex = 0;
            this.Input_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_txt_KeyPress);
            // 
            // next_btn
            // 
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Location = new System.Drawing.Point(49, 636);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(247, 48);
            this.next_btn.TabIndex = 1;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(314, 636);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(247, 48);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // maxQuestions_label
            // 
            this.maxQuestions_label.AutoSize = true;
            this.maxQuestions_label.Font = new System.Drawing.Font("Open Sans Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxQuestions_label.ForeColor = System.Drawing.Color.White;
            this.maxQuestions_label.Location = new System.Drawing.Point(47, 355);
            this.maxQuestions_label.Name = "maxQuestions_label";
            this.maxQuestions_label.Size = new System.Drawing.Size(231, 33);
            this.maxQuestions_label.TabIndex = 2;
            this.maxQuestions_label.Text = "Max questions : 100";
            // 
            // autoSystemQuestions_lbl
            // 
            this.autoSystemQuestions_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoSystemQuestions_lbl.AutoSize = true;
            this.autoSystemQuestions_lbl.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.autoSystemQuestions_lbl.ForeColor = System.Drawing.Color.White;
            this.autoSystemQuestions_lbl.Location = new System.Drawing.Point(45, 208);
            this.autoSystemQuestions_lbl.Name = "autoSystemQuestions_lbl";
            this.autoSystemQuestions_lbl.Size = new System.Drawing.Size(311, 46);
            this.autoSystemQuestions_lbl.TabIndex = 4;
            this.autoSystemQuestions_lbl.Text = "Enter question title";
            // 
            // Option1_txtbox
            // 
            this.Option1_txtbox.Font = new System.Drawing.Font("Open Sans Light", 16F);
            this.Option1_txtbox.Location = new System.Drawing.Point(49, 377);
            this.Option1_txtbox.Name = "Option1_txtbox";
            this.Option1_txtbox.Size = new System.Drawing.Size(255, 44);
            this.Option1_txtbox.TabIndex = 5;
            this.Option1_txtbox.Tag = "1";
            // 
            // Option1_lbl
            // 
            this.Option1_lbl.AutoSize = true;
            this.Option1_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Option1_lbl.ForeColor = System.Drawing.Color.White;
            this.Option1_lbl.Location = new System.Drawing.Point(47, 353);
            this.Option1_lbl.Name = "Option1_lbl";
            this.Option1_lbl.Size = new System.Drawing.Size(66, 20);
            this.Option1_lbl.TabIndex = 6;
            this.Option1_lbl.Text = "Option1";
            // 
            // Option2_lbl
            // 
            this.Option2_lbl.AutoSize = true;
            this.Option2_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Option2_lbl.ForeColor = System.Drawing.Color.White;
            this.Option2_lbl.Location = new System.Drawing.Point(315, 353);
            this.Option2_lbl.Name = "Option2_lbl";
            this.Option2_lbl.Size = new System.Drawing.Size(66, 20);
            this.Option2_lbl.TabIndex = 8;
            this.Option2_lbl.Text = "Option2";
            // 
            // Option2_txtbox
            // 
            this.Option2_txtbox.Font = new System.Drawing.Font("Open Sans Light", 16F);
            this.Option2_txtbox.Location = new System.Drawing.Point(317, 377);
            this.Option2_txtbox.Name = "Option2_txtbox";
            this.Option2_txtbox.Size = new System.Drawing.Size(255, 44);
            this.Option2_txtbox.TabIndex = 7;
            this.Option2_txtbox.Tag = "2";
            // 
            // Option4_lbl
            // 
            this.Option4_lbl.AutoSize = true;
            this.Option4_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Option4_lbl.ForeColor = System.Drawing.Color.White;
            this.Option4_lbl.Location = new System.Drawing.Point(315, 428);
            this.Option4_lbl.Name = "Option4_lbl";
            this.Option4_lbl.Size = new System.Drawing.Size(66, 20);
            this.Option4_lbl.TabIndex = 12;
            this.Option4_lbl.Text = "Option4";
            // 
            // Option4_txtbox
            // 
            this.Option4_txtbox.Font = new System.Drawing.Font("Open Sans Light", 16F);
            this.Option4_txtbox.Location = new System.Drawing.Point(317, 452);
            this.Option4_txtbox.Name = "Option4_txtbox";
            this.Option4_txtbox.Size = new System.Drawing.Size(255, 44);
            this.Option4_txtbox.TabIndex = 11;
            this.Option4_txtbox.Tag = "4";
            // 
            // Option3_lbl
            // 
            this.Option3_lbl.AutoSize = true;
            this.Option3_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Option3_lbl.ForeColor = System.Drawing.Color.White;
            this.Option3_lbl.Location = new System.Drawing.Point(47, 428);
            this.Option3_lbl.Name = "Option3_lbl";
            this.Option3_lbl.Size = new System.Drawing.Size(66, 20);
            this.Option3_lbl.TabIndex = 10;
            this.Option3_lbl.Text = "Option3";
            // 
            // Option3_txtbox
            // 
            this.Option3_txtbox.Font = new System.Drawing.Font("Open Sans Light", 16F);
            this.Option3_txtbox.Location = new System.Drawing.Point(49, 452);
            this.Option3_txtbox.Name = "Option3_txtbox";
            this.Option3_txtbox.Size = new System.Drawing.Size(255, 44);
            this.Option3_txtbox.TabIndex = 9;
            this.Option3_txtbox.Tag = "3";
            // 
            // Answer_lbl
            // 
            this.Answer_lbl.AutoSize = true;
            this.Answer_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Answer_lbl.ForeColor = System.Drawing.Color.White;
            this.Answer_lbl.Location = new System.Drawing.Point(47, 504);
            this.Answer_lbl.Name = "Answer_lbl";
            this.Answer_lbl.Size = new System.Drawing.Size(60, 20);
            this.Answer_lbl.TabIndex = 14;
            this.Answer_lbl.Text = "Answer";
            // 
            // Answer_Combobox
            // 
            this.Answer_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Answer_Combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer_Combobox.Font = new System.Drawing.Font("Open Sans Light", 16F);
            this.Answer_Combobox.FormattingEnabled = true;
            this.Answer_Combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Answer_Combobox.Location = new System.Drawing.Point(49, 529);
            this.Answer_Combobox.Name = "Answer_Combobox";
            this.Answer_Combobox.Size = new System.Drawing.Size(523, 45);
            this.Answer_Combobox.TabIndex = 15;
            // 
            // ShowCategory_comboBox
            // 
            this.ShowCategory_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowCategory_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCategory_comboBox.Font = new System.Drawing.Font("Open Sans Light", 30F);
            this.ShowCategory_comboBox.FormattingEnabled = true;
            this.ShowCategory_comboBox.Location = new System.Drawing.Point(24, 262);
            this.ShowCategory_comboBox.Name = "ShowCategory_comboBox";
            this.ShowCategory_comboBox.Size = new System.Drawing.Size(575, 76);
            this.ShowCategory_comboBox.TabIndex = 16;
            // 
            // ExamCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(631, 700);
            this.Controls.Add(this.ShowCategory_comboBox);
            this.Controls.Add(this.Answer_Combobox);
            this.Controls.Add(this.Answer_lbl);
            this.Controls.Add(this.Option4_lbl);
            this.Controls.Add(this.Option4_txtbox);
            this.Controls.Add(this.Option3_lbl);
            this.Controls.Add(this.Option3_txtbox);
            this.Controls.Add(this.Option2_lbl);
            this.Controls.Add(this.Option2_txtbox);
            this.Controls.Add(this.Option1_lbl);
            this.Controls.Add(this.Option1_txtbox);
            this.Controls.Add(this.autoSystemQuestions_lbl);
            this.Controls.Add(this.maxQuestions_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.Input_txt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExamCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamCreation";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExamCreation_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Input_txt;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label maxQuestions_label;
        private System.Windows.Forms.Label autoSystemQuestions_lbl;
        private System.Windows.Forms.ComboBox Answer_Combobox;
        private System.Windows.Forms.Label Answer_lbl;
        private System.Windows.Forms.Label Option4_lbl;
        private System.Windows.Forms.TextBox Option4_txtbox;
        private System.Windows.Forms.Label Option3_lbl;
        private System.Windows.Forms.TextBox Option3_txtbox;
        private System.Windows.Forms.Label Option2_lbl;
        private System.Windows.Forms.TextBox Option2_txtbox;
        private System.Windows.Forms.Label Option1_lbl;
        private System.Windows.Forms.TextBox Option1_txtbox;
        private System.Windows.Forms.ComboBox ShowCategory_comboBox;
    }
}