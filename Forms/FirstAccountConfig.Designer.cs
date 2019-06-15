namespace quizclub.Forms
{
    partial class FirstAccountConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstconfig_txtbox = new System.Windows.Forms.TextBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.FirstConfig_texts = new System.Windows.Forms.Label();
            this.country_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 90);
            this.label1.MaximumSize = new System.Drawing.Size(342, 51);
            this.label1.MinimumSize = new System.Drawing.Size(342, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Configuration";
            // 
            // firstconfig_txtbox
            // 
            this.firstconfig_txtbox.BackColor = System.Drawing.Color.White;
            this.firstconfig_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstconfig_txtbox.Font = new System.Drawing.Font("Open Sans Light", 25F);
            this.firstconfig_txtbox.ForeColor = System.Drawing.Color.Black;
            this.firstconfig_txtbox.HideSelection = false;
            this.firstconfig_txtbox.Location = new System.Drawing.Point(27, 265);
            this.firstconfig_txtbox.Name = "firstconfig_txtbox";
            this.firstconfig_txtbox.Size = new System.Drawing.Size(487, 64);
            this.firstconfig_txtbox.TabIndex = 1;
            this.firstconfig_txtbox.TabStop = false;
            this.firstconfig_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstconfig_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstconfig_txtbox_KeyPress);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(137, 433);
            this.next_btn.MaximumSize = new System.Drawing.Size(228, 49);
            this.next_btn.MinimumSize = new System.Drawing.Size(228, 49);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(228, 49);
            this.next_btn.TabIndex = 1;
            this.next_btn.TabStop = false;
            this.next_btn.Text = "next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // FirstConfig_texts
            // 
            this.FirstConfig_texts.AutoSize = true;
            this.FirstConfig_texts.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FirstConfig_texts.Location = new System.Drawing.Point(23, 242);
            this.FirstConfig_texts.Name = "FirstConfig_texts";
            this.FirstConfig_texts.Size = new System.Drawing.Size(114, 20);
            this.FirstConfig_texts.TabIndex = 4;
            this.FirstConfig_texts.Text = "Your Firstname";
            // 
            // country_comboBox
            // 
            this.country_comboBox.BackColor = System.Drawing.Color.White;
            this.country_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.country_comboBox.Font = new System.Drawing.Font("Open Sans Light", 25F);
            this.country_comboBox.FormattingEnabled = true;
            this.country_comboBox.Items.AddRange(new object[] {
            "India",
            "Iran",
            "Pakistan",
            "United Kingdom",
            "United State"});
            this.country_comboBox.Location = new System.Drawing.Point(27, 265);
            this.country_comboBox.Name = "country_comboBox";
            this.country_comboBox.Size = new System.Drawing.Size(487, 65);
            this.country_comboBox.Sorted = true;
            this.country_comboBox.TabIndex = 5;
            // 
            // FirstAccountConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 561);
            this.Controls.Add(this.FirstConfig_texts);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country_comboBox);
            this.Controls.Add(this.firstconfig_txtbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FirstAccountConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstAccountConfig";
            this.Load += new System.EventHandler(this.FirstAccountConfig_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirstAccountConfig_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstconfig_txtbox;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label FirstConfig_texts;
        private System.Windows.Forms.ComboBox country_comboBox;
    }
}