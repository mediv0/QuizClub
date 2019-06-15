namespace quizclub.Forms
{
    partial class ListofExams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofExams));
            this.exit_picbox = new System.Windows.Forms.PictureBox();
            this.minimize_picbox = new System.Windows.Forms.PictureBox();
            this.examListview = new MaterialSkin.Controls.MaterialListView();
            this.warning_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_picbox
            // 
            this.exit_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_picbox.BackgroundImage")));
            this.exit_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_picbox.Location = new System.Drawing.Point(1187, 12);
            this.exit_picbox.Name = "exit_picbox";
            this.exit_picbox.Size = new System.Drawing.Size(16, 16);
            this.exit_picbox.TabIndex = 12;
            this.exit_picbox.TabStop = false;
            this.exit_picbox.Click += new System.EventHandler(this.exit_picbox_Click);
            // 
            // minimize_picbox
            // 
            this.minimize_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_picbox.BackgroundImage")));
            this.minimize_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_picbox.Location = new System.Drawing.Point(1156, 12);
            this.minimize_picbox.Name = "minimize_picbox";
            this.minimize_picbox.Size = new System.Drawing.Size(16, 16);
            this.minimize_picbox.TabIndex = 13;
            this.minimize_picbox.TabStop = false;
            this.minimize_picbox.Click += new System.EventHandler(this.minimize_picbox_Click);
            // 
            // examListview
            // 
            this.examListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examListview.Depth = 0;
            this.examListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.examListview.FullRowSelect = true;
            this.examListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.examListview.LabelEdit = true;
            this.examListview.Location = new System.Drawing.Point(26, 34);
            this.examListview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.examListview.MouseState = MaterialSkin.MouseState.OUT;
            this.examListview.Name = "examListview";
            this.examListview.OwnerDraw = true;
            this.examListview.Size = new System.Drawing.Size(1177, 683);
            this.examListview.TabIndex = 14;
            this.examListview.UseCompatibleStateImageBehavior = false;
            this.examListview.View = System.Windows.Forms.View.Details;
            this.examListview.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.examListview_ColumnWidthChanging);
            this.examListview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.examListview_MouseDown);
            // 
            // warning_lbl
            // 
            this.warning_lbl.AutoSize = true;
            this.warning_lbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_lbl.ForeColor = System.Drawing.Color.Red;
            this.warning_lbl.Location = new System.Drawing.Point(332, 324);
            this.warning_lbl.Name = "warning_lbl";
            this.warning_lbl.Size = new System.Drawing.Size(512, 37);
            this.warning_lbl.TabIndex = 15;
            this.warning_lbl.Text = "there is no exam at this time try again late";
            // 
            // ListofExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 720);
            this.Controls.Add(this.warning_lbl);
            this.Controls.Add(this.examListview);
            this.Controls.Add(this.exit_picbox);
            this.Controls.Add(this.minimize_picbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListofExams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListofExams";
            this.Load += new System.EventHandler(this.ListofExams_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListofExams_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_picbox;
        private System.Windows.Forms.PictureBox minimize_picbox;
        private MaterialSkin.Controls.MaterialListView examListview;
        private System.Windows.Forms.Label warning_lbl;
    }
}