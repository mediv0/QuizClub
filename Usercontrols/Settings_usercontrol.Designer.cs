namespace quizclub.Usercontrols
{
    partial class Settings_usercontrol
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
            this.personal_uc_label = new System.Windows.Forms.Label();
            this.privacy_uc_label = new System.Windows.Forms.Label();
            this.help_uc_label = new System.Windows.Forms.Label();
            this.name_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Username_txt = new System.Windows.Forms.Label();
            this.famili_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.family_txt = new System.Windows.Forms.Label();
            this.phonenumber_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.renewpassword_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.renewPassword_lbl = new System.Windows.Forms.Label();
            this.newpassword_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.autopass_uc_label = new System.Windows.Forms.Label();
            this.password_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_uc_label = new System.Windows.Forms.Label();
            this.autopassword_uc_toggle = new MetroFramework.Controls.MetroToggle();
            this.passworddetail_uc_label = new System.Windows.Forms.Label();
            this.smalltogglePass_uc_lbl = new System.Windows.Forms.Label();
            this.email_uc_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email_lbl = new System.Windows.Forms.Label();
            this.changeprofileImage_uc_label = new System.Windows.Forms.Label();
            this.changeImage_uc_btn = new System.Windows.Forms.Button();
            this.viewaccount_uc_txt = new System.Windows.Forms.Label();
            this.premuim_uc_txt = new System.Windows.Forms.Label();
            this.feedback_uc_txt = new System.Windows.Forms.Label();
            this.help_uc_txt = new System.Windows.Forms.Label();
            this.App_uc_lbl = new System.Windows.Forms.Label();
            this.about_uc_txt = new System.Windows.Forms.Label();
            this.platform_uc_txt = new System.Windows.Forms.Label();
            this.Savesettings_btn = new System.Windows.Forms.Button();
            this.Country_Combobox = new MetroFramework.Controls.MetroComboBox();
            this.PictureBox_Openfile_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.nightmod_uc_label = new System.Windows.Forms.Label();
            this.Nightmodtoggle = new MetroFramework.Controls.MetroToggle();
            this.smalltoggleNightmod_uc_lbl = new System.Windows.Forms.Label();
            this.template_uc_label = new System.Windows.Forms.Label();
            this.ImageSave_btn = new System.Windows.Forms.Button();
            this.PasswordEye_uc_pic = new System.Windows.Forms.PictureBox();
            this.passwordEye_re_uc_pic = new System.Windows.Forms.PictureBox();
            this.profileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEye_uc_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye_re_uc_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // personal_uc_label
            // 
            this.personal_uc_label.AutoSize = true;
            this.personal_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.personal_uc_label.Location = new System.Drawing.Point(91, 38);
            this.personal_uc_label.Name = "personal_uc_label";
            this.personal_uc_label.Size = new System.Drawing.Size(74, 20);
            this.personal_uc_label.TabIndex = 0;
            this.personal_uc_label.Text = "Personal";
            // 
            // privacy_uc_label
            // 
            this.privacy_uc_label.AutoSize = true;
            this.privacy_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.privacy_uc_label.Location = new System.Drawing.Point(465, 38);
            this.privacy_uc_label.Name = "privacy_uc_label";
            this.privacy_uc_label.Size = new System.Drawing.Size(65, 20);
            this.privacy_uc_label.TabIndex = 1;
            this.privacy_uc_label.Text = "Privacy";
            // 
            // help_uc_label
            // 
            this.help_uc_label.AutoSize = true;
            this.help_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.help_uc_label.Location = new System.Drawing.Point(859, 38);
            this.help_uc_label.Name = "help_uc_label";
            this.help_uc_label.Size = new System.Drawing.Size(71, 20);
            this.help_uc_label.TabIndex = 3;
            this.help_uc_label.Text = "Account";
            // 
            // name_uc_txtbox
            // 
            this.name_uc_txtbox.Depth = 0;
            this.name_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.name_uc_txtbox.Hint = "";
            this.name_uc_txtbox.Location = new System.Drawing.Point(96, 128);
            this.name_uc_txtbox.MaxLength = 32767;
            this.name_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.name_uc_txtbox.Name = "name_uc_txtbox";
            this.name_uc_txtbox.PasswordChar = '\0';
            this.name_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name_uc_txtbox.SelectedText = "";
            this.name_uc_txtbox.SelectionLength = 0;
            this.name_uc_txtbox.SelectionStart = 0;
            this.name_uc_txtbox.Size = new System.Drawing.Size(294, 28);
            this.name_uc_txtbox.TabIndex = 21;
            this.name_uc_txtbox.TabStop = false;
            this.name_uc_txtbox.UseSystemPasswordChar = false;
            this.name_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_uc_txtbox_KeyPress);
            this.name_uc_txtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.name_uc_txtbox_MouseDown);
            // 
            // Username_txt
            // 
            this.Username_txt.AutoSize = true;
            this.Username_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Username_txt.ForeColor = System.Drawing.Color.Black;
            this.Username_txt.Location = new System.Drawing.Point(90, 104);
            this.Username_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(48, 20);
            this.Username_txt.TabIndex = 20;
            this.Username_txt.Text = "name";
            // 
            // famili_uc_txtbox
            // 
            this.famili_uc_txtbox.Depth = 0;
            this.famili_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.famili_uc_txtbox.Hint = "";
            this.famili_uc_txtbox.Location = new System.Drawing.Point(94, 197);
            this.famili_uc_txtbox.MaxLength = 32767;
            this.famili_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.famili_uc_txtbox.Name = "famili_uc_txtbox";
            this.famili_uc_txtbox.PasswordChar = '\0';
            this.famili_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.famili_uc_txtbox.SelectedText = "";
            this.famili_uc_txtbox.SelectionLength = 0;
            this.famili_uc_txtbox.SelectionStart = 0;
            this.famili_uc_txtbox.Size = new System.Drawing.Size(296, 28);
            this.famili_uc_txtbox.TabIndex = 23;
            this.famili_uc_txtbox.TabStop = false;
            this.famili_uc_txtbox.UseSystemPasswordChar = false;
            this.famili_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_uc_txtbox_KeyPress);
            this.famili_uc_txtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.famili_uc_txtbox_MouseDown);
            // 
            // family_txt
            // 
            this.family_txt.AutoSize = true;
            this.family_txt.BackColor = System.Drawing.Color.Transparent;
            this.family_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.family_txt.ForeColor = System.Drawing.Color.Black;
            this.family_txt.Location = new System.Drawing.Point(90, 174);
            this.family_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.family_txt.Name = "family_txt";
            this.family_txt.Size = new System.Drawing.Size(52, 20);
            this.family_txt.TabIndex = 22;
            this.family_txt.Text = "family";
            // 
            // phonenumber_uc_txtbox
            // 
            this.phonenumber_uc_txtbox.Depth = 0;
            this.phonenumber_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.phonenumber_uc_txtbox.Hint = "09373733333";
            this.phonenumber_uc_txtbox.Location = new System.Drawing.Point(94, 272);
            this.phonenumber_uc_txtbox.MaxLength = 12;
            this.phonenumber_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.phonenumber_uc_txtbox.Name = "phonenumber_uc_txtbox";
            this.phonenumber_uc_txtbox.PasswordChar = '\0';
            this.phonenumber_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phonenumber_uc_txtbox.SelectedText = "";
            this.phonenumber_uc_txtbox.SelectionLength = 0;
            this.phonenumber_uc_txtbox.SelectionStart = 0;
            this.phonenumber_uc_txtbox.Size = new System.Drawing.Size(296, 28);
            this.phonenumber_uc_txtbox.TabIndex = 25;
            this.phonenumber_uc_txtbox.TabStop = false;
            this.phonenumber_uc_txtbox.UseSystemPasswordChar = false;
            this.phonenumber_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenumber_uc_txtbox_KeyPress);
            this.phonenumber_uc_txtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phonenumber_uc_txtbox_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "country";
            // 
            // renewpassword_uc_txtbox
            // 
            this.renewpassword_uc_txtbox.Depth = 0;
            this.renewpassword_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.renewpassword_uc_txtbox.Hint = "";
            this.renewpassword_uc_txtbox.Location = new System.Drawing.Point(470, 462);
            this.renewpassword_uc_txtbox.MaxLength = 32767;
            this.renewpassword_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.renewpassword_uc_txtbox.Name = "renewpassword_uc_txtbox";
            this.renewpassword_uc_txtbox.PasswordChar = '\0';
            this.renewpassword_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.renewpassword_uc_txtbox.SelectedText = "";
            this.renewpassword_uc_txtbox.SelectionLength = 0;
            this.renewpassword_uc_txtbox.SelectionStart = 0;
            this.renewpassword_uc_txtbox.Size = new System.Drawing.Size(294, 28);
            this.renewpassword_uc_txtbox.TabIndex = 35;
            this.renewpassword_uc_txtbox.TabStop = false;
            this.renewpassword_uc_txtbox.UseSystemPasswordChar = false;
            this.renewpassword_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_uc_txtbox_KeyPress);
            // 
            // renewPassword_lbl
            // 
            this.renewPassword_lbl.AutoSize = true;
            this.renewPassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.renewPassword_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.renewPassword_lbl.ForeColor = System.Drawing.Color.Black;
            this.renewPassword_lbl.Location = new System.Drawing.Point(466, 439);
            this.renewPassword_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.renewPassword_lbl.Name = "renewPassword_lbl";
            this.renewPassword_lbl.Size = new System.Drawing.Size(94, 20);
            this.renewPassword_lbl.TabIndex = 34;
            this.renewPassword_lbl.Text = "re password";
            // 
            // newpassword_uc_txtbox
            // 
            this.newpassword_uc_txtbox.Depth = 0;
            this.newpassword_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.newpassword_uc_txtbox.Hint = "";
            this.newpassword_uc_txtbox.Location = new System.Drawing.Point(468, 386);
            this.newpassword_uc_txtbox.MaxLength = 32767;
            this.newpassword_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.newpassword_uc_txtbox.Name = "newpassword_uc_txtbox";
            this.newpassword_uc_txtbox.PasswordChar = '\0';
            this.newpassword_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newpassword_uc_txtbox.SelectedText = "";
            this.newpassword_uc_txtbox.SelectionLength = 0;
            this.newpassword_uc_txtbox.SelectionStart = 0;
            this.newpassword_uc_txtbox.Size = new System.Drawing.Size(296, 28);
            this.newpassword_uc_txtbox.TabIndex = 33;
            this.newpassword_uc_txtbox.TabStop = false;
            this.newpassword_uc_txtbox.UseSystemPasswordChar = false;
            this.newpassword_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_uc_txtbox_KeyPress);
            this.newpassword_uc_txtbox.TextChanged += new System.EventHandler(this.newpassword_uc_txtbox_TextChanged);
            // 
            // newpassword_lbl
            // 
            this.newpassword_lbl.AutoSize = true;
            this.newpassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.newpassword_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newpassword_lbl.ForeColor = System.Drawing.Color.Black;
            this.newpassword_lbl.Location = new System.Drawing.Point(464, 363);
            this.newpassword_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(109, 20);
            this.newpassword_lbl.TabIndex = 32;
            this.newpassword_lbl.Text = "new password";
            // 
            // autopass_uc_label
            // 
            this.autopass_uc_label.AutoSize = true;
            this.autopass_uc_label.BackColor = System.Drawing.Color.Transparent;
            this.autopass_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.autopass_uc_label.ForeColor = System.Drawing.Color.Black;
            this.autopass_uc_label.Location = new System.Drawing.Point(464, 188);
            this.autopass_uc_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.autopass_uc_label.Name = "autopass_uc_label";
            this.autopass_uc_label.Size = new System.Drawing.Size(115, 20);
            this.autopass_uc_label.TabIndex = 30;
            this.autopass_uc_label.Text = "Autopassword";
            // 
            // password_uc_txtbox
            // 
            this.password_uc_txtbox.Depth = 0;
            this.password_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.password_uc_txtbox.Hint = "";
            this.password_uc_txtbox.Location = new System.Drawing.Point(470, 135);
            this.password_uc_txtbox.MaxLength = 32767;
            this.password_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_uc_txtbox.Name = "password_uc_txtbox";
            this.password_uc_txtbox.PasswordChar = '\0';
            this.password_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password_uc_txtbox.SelectedText = "";
            this.password_uc_txtbox.SelectionLength = 0;
            this.password_uc_txtbox.SelectionStart = 0;
            this.password_uc_txtbox.Size = new System.Drawing.Size(294, 28);
            this.password_uc_txtbox.TabIndex = 29;
            this.password_uc_txtbox.TabStop = false;
            this.password_uc_txtbox.UseSystemPasswordChar = false;
            this.password_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_uc_txtbox_KeyPress);
            this.password_uc_txtbox.TextChanged += new System.EventHandler(this.password_uc_txtbox_TextChanged);
            // 
            // password_uc_label
            // 
            this.password_uc_label.AutoSize = true;
            this.password_uc_label.BackColor = System.Drawing.Color.Transparent;
            this.password_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password_uc_label.ForeColor = System.Drawing.Color.Black;
            this.password_uc_label.Location = new System.Drawing.Point(464, 117);
            this.password_uc_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.password_uc_label.Name = "password_uc_label";
            this.password_uc_label.Size = new System.Drawing.Size(76, 20);
            this.password_uc_label.TabIndex = 28;
            this.password_uc_label.Text = "password";
            // 
            // autopassword_uc_toggle
            // 
            this.autopassword_uc_toggle.AutoSize = true;
            this.autopassword_uc_toggle.Location = new System.Drawing.Point(469, 313);
            this.autopassword_uc_toggle.Name = "autopassword_uc_toggle";
            this.autopassword_uc_toggle.Size = new System.Drawing.Size(80, 17);
            this.autopassword_uc_toggle.TabIndex = 36;
            this.autopassword_uc_toggle.Text = "Off";
            this.autopassword_uc_toggle.UseSelectable = true;
            this.autopassword_uc_toggle.CheckedChanged += new System.EventHandler(this.autopassword_uc_toggle_CheckedChanged);
            // 
            // passworddetail_uc_label
            // 
            this.passworddetail_uc_label.BackColor = System.Drawing.Color.Transparent;
            this.passworddetail_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passworddetail_uc_label.ForeColor = System.Drawing.Color.Black;
            this.passworddetail_uc_label.Location = new System.Drawing.Point(464, 221);
            this.passworddetail_uc_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.passworddetail_uc_label.Name = "passworddetail_uc_label";
            this.passworddetail_uc_label.Size = new System.Drawing.Size(300, 58);
            this.passworddetail_uc_label.TabIndex = 37;
            this.passworddetail_uc_label.Text = "With this feature, you can automatically create a random password";
            // 
            // smalltogglePass_uc_lbl
            // 
            this.smalltogglePass_uc_lbl.AutoSize = true;
            this.smalltogglePass_uc_lbl.BackColor = System.Drawing.Color.Transparent;
            this.smalltogglePass_uc_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.smalltogglePass_uc_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.smalltogglePass_uc_lbl.Location = new System.Drawing.Point(466, 281);
            this.smalltogglePass_uc_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.smalltogglePass_uc_lbl.Name = "smalltogglePass_uc_lbl";
            this.smalltogglePass_uc_lbl.Size = new System.Drawing.Size(135, 20);
            this.smalltogglePass_uc_lbl.TabIndex = 38;
            this.smalltogglePass_uc_lbl.Text = "Genrate password";
            // 
            // email_uc_txtbox
            // 
            this.email_uc_txtbox.Depth = 0;
            this.email_uc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)), true);
            this.email_uc_txtbox.Hint = "";
            this.email_uc_txtbox.Location = new System.Drawing.Point(470, 544);
            this.email_uc_txtbox.MaxLength = 32767;
            this.email_uc_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.email_uc_txtbox.Name = "email_uc_txtbox";
            this.email_uc_txtbox.PasswordChar = '\0';
            this.email_uc_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email_uc_txtbox.SelectedText = "";
            this.email_uc_txtbox.SelectionLength = 0;
            this.email_uc_txtbox.SelectionStart = 0;
            this.email_uc_txtbox.Size = new System.Drawing.Size(294, 28);
            this.email_uc_txtbox.TabIndex = 36;
            this.email_uc_txtbox.TabStop = false;
            this.email_uc_txtbox.UseSystemPasswordChar = false;
            this.email_uc_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_uc_txtbox_KeyPress);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.Transparent;
            this.email_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.email_lbl.ForeColor = System.Drawing.Color.Black;
            this.email_lbl.Location = new System.Drawing.Point(466, 521);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(47, 20);
            this.email_lbl.TabIndex = 39;
            this.email_lbl.Text = "email";
            // 
            // changeprofileImage_uc_label
            // 
            this.changeprofileImage_uc_label.AutoSize = true;
            this.changeprofileImage_uc_label.BackColor = System.Drawing.Color.Transparent;
            this.changeprofileImage_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.changeprofileImage_uc_label.ForeColor = System.Drawing.Color.Black;
            this.changeprofileImage_uc_label.Location = new System.Drawing.Point(184, 406);
            this.changeprofileImage_uc_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.changeprofileImage_uc_label.Name = "changeprofileImage_uc_label";
            this.changeprofileImage_uc_label.Size = new System.Drawing.Size(104, 20);
            this.changeprofileImage_uc_label.TabIndex = 42;
            this.changeprofileImage_uc_label.Text = "change Image";
            // 
            // changeImage_uc_btn
            // 
            this.changeImage_uc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeImage_uc_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeImage_uc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeImage_uc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeImage_uc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImage_uc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.changeImage_uc_btn.Location = new System.Drawing.Point(186, 433);
            this.changeImage_uc_btn.Name = "changeImage_uc_btn";
            this.changeImage_uc_btn.Size = new System.Drawing.Size(100, 28);
            this.changeImage_uc_btn.TabIndex = 43;
            this.changeImage_uc_btn.Text = "Change";
            this.changeImage_uc_btn.UseVisualStyleBackColor = true;
            this.changeImage_uc_btn.Click += new System.EventHandler(this.changeImage_uc_btn_Click);
            // 
            // viewaccount_uc_txt
            // 
            this.viewaccount_uc_txt.AutoSize = true;
            this.viewaccount_uc_txt.BackColor = System.Drawing.Color.Transparent;
            this.viewaccount_uc_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewaccount_uc_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewaccount_uc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewaccount_uc_txt.Location = new System.Drawing.Point(859, 78);
            this.viewaccount_uc_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.viewaccount_uc_txt.Name = "viewaccount_uc_txt";
            this.viewaccount_uc_txt.Size = new System.Drawing.Size(100, 20);
            this.viewaccount_uc_txt.TabIndex = 47;
            this.viewaccount_uc_txt.Text = "View account";
            this.viewaccount_uc_txt.Click += new System.EventHandler(this.viewaccount_uc_txt_Click_1);
            this.viewaccount_uc_txt.MouseEnter += new System.EventHandler(this.viewaccount_uc_txt_MouseEnter);
            this.viewaccount_uc_txt.MouseLeave += new System.EventHandler(this.viewaccount_uc_txt_MouseLeave);
            // 
            // premuim_uc_txt
            // 
            this.premuim_uc_txt.AutoSize = true;
            this.premuim_uc_txt.BackColor = System.Drawing.Color.Transparent;
            this.premuim_uc_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.premuim_uc_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.premuim_uc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.premuim_uc_txt.Location = new System.Drawing.Point(859, 112);
            this.premuim_uc_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.premuim_uc_txt.Name = "premuim_uc_txt";
            this.premuim_uc_txt.Size = new System.Drawing.Size(73, 20);
            this.premuim_uc_txt.TabIndex = 48;
            this.premuim_uc_txt.Text = "Premuim";
            this.premuim_uc_txt.Click += new System.EventHandler(this.premuim_uc_txt_Click);
            this.premuim_uc_txt.MouseEnter += new System.EventHandler(this.premuim_uc_txt_MouseEnter);
            this.premuim_uc_txt.MouseLeave += new System.EventHandler(this.premuim_uc_txt_MouseLeave);
            // 
            // feedback_uc_txt
            // 
            this.feedback_uc_txt.AutoSize = true;
            this.feedback_uc_txt.BackColor = System.Drawing.Color.Transparent;
            this.feedback_uc_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedback_uc_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.feedback_uc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.feedback_uc_txt.Location = new System.Drawing.Point(859, 261);
            this.feedback_uc_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.feedback_uc_txt.Name = "feedback_uc_txt";
            this.feedback_uc_txt.Size = new System.Drawing.Size(74, 20);
            this.feedback_uc_txt.TabIndex = 51;
            this.feedback_uc_txt.Text = "Feedback";
            this.feedback_uc_txt.Click += new System.EventHandler(this.feedback_uc_txt_Click);
            this.feedback_uc_txt.MouseEnter += new System.EventHandler(this.feedback_uc_txt_MouseEnter);
            this.feedback_uc_txt.MouseLeave += new System.EventHandler(this.feedback_uc_txt_MouseLeave);
            // 
            // help_uc_txt
            // 
            this.help_uc_txt.AutoSize = true;
            this.help_uc_txt.BackColor = System.Drawing.Color.Transparent;
            this.help_uc_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_uc_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.help_uc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.help_uc_txt.Location = new System.Drawing.Point(859, 227);
            this.help_uc_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.help_uc_txt.Name = "help_uc_txt";
            this.help_uc_txt.Size = new System.Drawing.Size(41, 20);
            this.help_uc_txt.TabIndex = 50;
            this.help_uc_txt.Text = "Help";
            this.help_uc_txt.Click += new System.EventHandler(this.help_uc_txt_Click);
            this.help_uc_txt.MouseEnter += new System.EventHandler(this.help_uc_txt_MouseEnter);
            this.help_uc_txt.MouseLeave += new System.EventHandler(this.help_uc_txt_MouseLeave);
            // 
            // App_uc_lbl
            // 
            this.App_uc_lbl.AutoSize = true;
            this.App_uc_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.App_uc_lbl.Location = new System.Drawing.Point(859, 183);
            this.App_uc_lbl.Name = "App_uc_lbl";
            this.App_uc_lbl.Size = new System.Drawing.Size(37, 20);
            this.App_uc_lbl.TabIndex = 49;
            this.App_uc_lbl.Text = "App";
            // 
            // about_uc_txt
            // 
            this.about_uc_txt.AutoSize = true;
            this.about_uc_txt.BackColor = System.Drawing.Color.Transparent;
            this.about_uc_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_uc_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.about_uc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.about_uc_txt.Location = new System.Drawing.Point(859, 298);
            this.about_uc_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.about_uc_txt.Name = "about_uc_txt";
            this.about_uc_txt.Size = new System.Drawing.Size(50, 20);
            this.about_uc_txt.TabIndex = 52;
            this.about_uc_txt.Text = "About";
            this.about_uc_txt.Click += new System.EventHandler(this.about_uc_txt_Click);
            this.about_uc_txt.MouseEnter += new System.EventHandler(this.about_uc_txt_MouseEnter);
            this.about_uc_txt.MouseLeave += new System.EventHandler(this.about_uc_txt_MouseLeave);
            // 
            // platform_uc_txt
            // 
            this.platform_uc_txt.AutoSize = true;
            this.platform_uc_txt.BackColor = System.Drawing.Color.Transparent;
            this.platform_uc_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platform_uc_txt.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.platform_uc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.platform_uc_txt.Location = new System.Drawing.Point(859, 334);
            this.platform_uc_txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.platform_uc_txt.Name = "platform_uc_txt";
            this.platform_uc_txt.Size = new System.Drawing.Size(76, 20);
            this.platform_uc_txt.TabIndex = 53;
            this.platform_uc_txt.Text = "Platforms";
            this.platform_uc_txt.Click += new System.EventHandler(this.platform_uc_txt_Click);
            this.platform_uc_txt.MouseEnter += new System.EventHandler(this.platform_uc_txt_MouseEnter);
            this.platform_uc_txt.MouseLeave += new System.EventHandler(this.platform_uc_txt_MouseLeave);
            // 
            // Savesettings_btn
            // 
            this.Savesettings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Savesettings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savesettings_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Savesettings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Savesettings_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Savesettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savesettings_btn.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Savesettings_btn.ForeColor = System.Drawing.Color.White;
            this.Savesettings_btn.Location = new System.Drawing.Point(917, 584);
            this.Savesettings_btn.Name = "Savesettings_btn";
            this.Savesettings_btn.Size = new System.Drawing.Size(159, 55);
            this.Savesettings_btn.TabIndex = 54;
            this.Savesettings_btn.Text = "Save settings";
            this.Savesettings_btn.UseVisualStyleBackColor = false;
            this.Savesettings_btn.Click += new System.EventHandler(this.Savesettings_btn_Click_1);
            // 
            // Country_Combobox
            // 
            this.Country_Combobox.FormattingEnabled = true;
            this.Country_Combobox.ItemHeight = 24;
            this.Country_Combobox.Items.AddRange(new object[] {
            "Iran",
            "United Kingdom",
            "Usa",
            "Pakistan ( not recommended )"});
            this.Country_Combobox.Location = new System.Drawing.Point(97, 349);
            this.Country_Combobox.Name = "Country_Combobox";
            this.Country_Combobox.PromptText = "Iran";
            this.Country_Combobox.Size = new System.Drawing.Size(293, 30);
            this.Country_Combobox.TabIndex = 55;
            this.Country_Combobox.UseSelectable = true;
            this.Country_Combobox.TextChanged += new System.EventHandler(this.Country_Combobox_TextChanged);
            // 
            // PictureBox_Openfile_Dialog
            // 
            this.PictureBox_Openfile_Dialog.FileName = "openFileDialog1";
            // 
            // nightmod_uc_label
            // 
            this.nightmod_uc_label.AutoSize = true;
            this.nightmod_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nightmod_uc_label.Location = new System.Drawing.Point(90, 492);
            this.nightmod_uc_label.Name = "nightmod_uc_label";
            this.nightmod_uc_label.Size = new System.Drawing.Size(81, 20);
            this.nightmod_uc_label.TabIndex = 2;
            this.nightmod_uc_label.Text = "Template";
            // 
            // Nightmodtoggle
            // 
            this.Nightmodtoggle.AutoSize = true;
            this.Nightmodtoggle.Location = new System.Drawing.Point(96, 618);
            this.Nightmodtoggle.Name = "Nightmodtoggle";
            this.Nightmodtoggle.Size = new System.Drawing.Size(80, 17);
            this.Nightmodtoggle.TabIndex = 45;
            this.Nightmodtoggle.Text = "Off";
            this.Nightmodtoggle.UseSelectable = true;
            // 
            // smalltoggleNightmod_uc_lbl
            // 
            this.smalltoggleNightmod_uc_lbl.AutoSize = true;
            this.smalltoggleNightmod_uc_lbl.BackColor = System.Drawing.Color.Transparent;
            this.smalltoggleNightmod_uc_lbl.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.smalltoggleNightmod_uc_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.smalltoggleNightmod_uc_lbl.Location = new System.Drawing.Point(93, 586);
            this.smalltoggleNightmod_uc_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.smalltoggleNightmod_uc_lbl.Name = "smalltoggleNightmod_uc_lbl";
            this.smalltoggleNightmod_uc_lbl.Size = new System.Drawing.Size(124, 20);
            this.smalltoggleNightmod_uc_lbl.TabIndex = 46;
            this.smalltoggleNightmod_uc_lbl.Text = "Night mod(soon)";
            // 
            // template_uc_label
            // 
            this.template_uc_label.BackColor = System.Drawing.Color.Transparent;
            this.template_uc_label.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.template_uc_label.ForeColor = System.Drawing.Color.Black;
            this.template_uc_label.Location = new System.Drawing.Point(92, 522);
            this.template_uc_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.template_uc_label.Name = "template_uc_label";
            this.template_uc_label.Size = new System.Drawing.Size(300, 58);
            this.template_uc_label.TabIndex = 44;
            this.template_uc_label.Text = "You can use night Mode to change the appearance of the software";
            // 
            // ImageSave_btn
            // 
            this.ImageSave_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageSave_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ImageSave_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ImageSave_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ImageSave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageSave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ImageSave_btn.Location = new System.Drawing.Point(290, 434);
            this.ImageSave_btn.Name = "ImageSave_btn";
            this.ImageSave_btn.Size = new System.Drawing.Size(100, 28);
            this.ImageSave_btn.TabIndex = 59;
            this.ImageSave_btn.Text = "Save";
            this.ImageSave_btn.UseVisualStyleBackColor = true;
            this.ImageSave_btn.Visible = false;
            this.ImageSave_btn.Click += new System.EventHandler(this.ImageSave_btn_Click);
            // 
            // PasswordEye_uc_pic
            // 
            this.PasswordEye_uc_pic.BackColor = System.Drawing.Color.Transparent;
            this.PasswordEye_uc_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordEye_uc_pic.Image = global::quizclub.Properties.Resources.password_eye;
            this.PasswordEye_uc_pic.Location = new System.Drawing.Point(772, 136);
            this.PasswordEye_uc_pic.Name = "PasswordEye_uc_pic";
            this.PasswordEye_uc_pic.Size = new System.Drawing.Size(20, 18);
            this.PasswordEye_uc_pic.TabIndex = 58;
            this.PasswordEye_uc_pic.TabStop = false;
            this.PasswordEye_uc_pic.Click += new System.EventHandler(this.PasswordEye_uc_pic_Click_1);
            // 
            // passwordEye_re_uc_pic
            // 
            this.passwordEye_re_uc_pic.BackColor = System.Drawing.Color.Transparent;
            this.passwordEye_re_uc_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordEye_re_uc_pic.Image = global::quizclub.Properties.Resources.password_eye;
            this.passwordEye_re_uc_pic.Location = new System.Drawing.Point(772, 382);
            this.passwordEye_re_uc_pic.Name = "passwordEye_re_uc_pic";
            this.passwordEye_re_uc_pic.Size = new System.Drawing.Size(20, 18);
            this.passwordEye_re_uc_pic.TabIndex = 57;
            this.passwordEye_re_uc_pic.TabStop = false;
            this.passwordEye_re_uc_pic.Click += new System.EventHandler(this.passwordEye_uc_pic_Click);
            // 
            // profileImage
            // 
            this.profileImage.BackgroundImage = global::quizclub.Properties.Resources.profileImage;
            this.profileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileImage.Image = global::quizclub.Properties.Resources.user;
            this.profileImage.Location = new System.Drawing.Point(94, 402);
            this.profileImage.Margin = new System.Windows.Forms.Padding(2);
            this.profileImage.MaximumSize = new System.Drawing.Size(60, 60);
            this.profileImage.MinimumSize = new System.Drawing.Size(60, 60);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(60, 60);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 41;
            this.profileImage.TabStop = false;
            this.profileImage.Click += new System.EventHandler(this.profileImage_Click);
            // 
            // Settings_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ImageSave_btn);
            this.Controls.Add(this.password_uc_label);
            this.Controls.Add(this.PasswordEye_uc_pic);
            this.Controls.Add(this.passwordEye_re_uc_pic);
            this.Controls.Add(this.Savesettings_btn);
            this.Controls.Add(this.platform_uc_txt);
            this.Controls.Add(this.about_uc_txt);
            this.Controls.Add(this.feedback_uc_txt);
            this.Controls.Add(this.help_uc_txt);
            this.Controls.Add(this.App_uc_lbl);
            this.Controls.Add(this.premuim_uc_txt);
            this.Controls.Add(this.viewaccount_uc_txt);
            this.Controls.Add(this.smalltoggleNightmod_uc_lbl);
            this.Controls.Add(this.Nightmodtoggle);
            this.Controls.Add(this.template_uc_label);
            this.Controls.Add(this.changeImage_uc_btn);
            this.Controls.Add(this.changeprofileImage_uc_label);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.email_uc_txtbox);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.smalltogglePass_uc_lbl);
            this.Controls.Add(this.passworddetail_uc_label);
            this.Controls.Add(this.autopassword_uc_toggle);
            this.Controls.Add(this.renewpassword_uc_txtbox);
            this.Controls.Add(this.renewPassword_lbl);
            this.Controls.Add(this.newpassword_uc_txtbox);
            this.Controls.Add(this.newpassword_lbl);
            this.Controls.Add(this.autopass_uc_label);
            this.Controls.Add(this.password_uc_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phonenumber_uc_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.famili_uc_txtbox);
            this.Controls.Add(this.family_txt);
            this.Controls.Add(this.name_uc_txtbox);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.help_uc_label);
            this.Controls.Add(this.nightmod_uc_label);
            this.Controls.Add(this.privacy_uc_label);
            this.Controls.Add(this.personal_uc_label);
            this.Controls.Add(this.Country_Combobox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings_usercontrol";
            this.Size = new System.Drawing.Size(1133, 699);
            this.Load += new System.EventHandler(this.Settings_usercontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEye_uc_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye_re_uc_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personal_uc_label;
        private System.Windows.Forms.Label privacy_uc_label;
        private System.Windows.Forms.Label help_uc_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField name_uc_txtbox;
        private System.Windows.Forms.Label Username_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField famili_uc_txtbox;
        private System.Windows.Forms.Label family_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField phonenumber_uc_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField renewpassword_uc_txtbox;
        private System.Windows.Forms.Label renewPassword_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField newpassword_uc_txtbox;
        private System.Windows.Forms.Label newpassword_lbl;
        private System.Windows.Forms.Label autopass_uc_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField password_uc_txtbox;
        private System.Windows.Forms.Label password_uc_label;
        private MetroFramework.Controls.MetroToggle autopassword_uc_toggle;
        private System.Windows.Forms.Label passworddetail_uc_label;
        private System.Windows.Forms.Label smalltogglePass_uc_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField email_uc_txtbox;
        private System.Windows.Forms.Label email_lbl;
        public System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.Label changeprofileImage_uc_label;
        private System.Windows.Forms.Button changeImage_uc_btn;
        private System.Windows.Forms.Label viewaccount_uc_txt;
        private System.Windows.Forms.Label premuim_uc_txt;
        private System.Windows.Forms.Label feedback_uc_txt;
        private System.Windows.Forms.Label help_uc_txt;
        private System.Windows.Forms.Label App_uc_lbl;
        private System.Windows.Forms.Label about_uc_txt;
        private System.Windows.Forms.Label platform_uc_txt;
        private System.Windows.Forms.Button Savesettings_btn;
        private MetroFramework.Controls.MetroComboBox Country_Combobox;
        public System.Windows.Forms.OpenFileDialog PictureBox_Openfile_Dialog;
        private System.Windows.Forms.PictureBox passwordEye_re_uc_pic;
        private System.Windows.Forms.PictureBox PasswordEye_uc_pic;
        private System.Windows.Forms.Label nightmod_uc_label;
        private MetroFramework.Controls.MetroToggle Nightmodtoggle;
        private System.Windows.Forms.Label smalltoggleNightmod_uc_lbl;
        private System.Windows.Forms.Label template_uc_label;
        private System.Windows.Forms.Button ImageSave_btn;
    }
}
