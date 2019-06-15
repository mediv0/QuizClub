using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections;

namespace quizclub.Usercontrols
{
    
    public partial class Settings_usercontrol : UserControl
    {
        private string LastPictureLocation { get; set; }
        public Settings_usercontrol()
        {
            InitializeComponent();
            Nightmodtoggle.Enabled =
            passwordEye_re_uc_pic.Visible = PasswordEye_uc_pic.Visible = false;
            newpassword_uc_txtbox.UseSystemPasswordChar = renewpassword_uc_txtbox.UseSystemPasswordChar = password_uc_txtbox.UseSystemPasswordChar = true;

            //  Set image profile Circle
            // circle
            GraphicsPath graphicProfilePath = new GraphicsPath();
            graphicProfilePath.AddEllipse(0, 0, profileImage.Width - 1, profileImage.Height - 1);
            Region region = new Region(graphicProfilePath);
            profileImage.Region = region;
            // ----
            ImageSave_btn.Enabled = false;
            ImageSave_btn.Visible = false;
            
        }
        public void setColorforErrors(Color? c = null)
        {
            Username_txt.ForeColor = c ?? Color.Black;
            password_uc_label.ForeColor = c ?? Color.Black;
            email_lbl.ForeColor = c ?? Color.Black;
            family_txt.ForeColor = c ?? Color.Black;
            family_txt.ForeColor = c ?? Color.Black;
            //c.GetValueOrDefault(Color.Black);
        }
        private void Settings_usercontrol_Load(object sender, EventArgs e)
        {
            //autopassword_uc_toggle.Checked = false;
            autopassword_uc_toggle_CheckedChanged(this, e);
            // set information to hint 

            ArrayList Profile = SQL.ProfileInformation_Show(Login_usercontrol.Username);
            for (int i = 0; i < Profile.Count; i++)
            {
                switch (i)
                {
                    case 2:
                        // mean firstname
                        name_uc_txtbox.Text = Profile[i] as string;
                        break;
                    case 3:
                        // mean lastname
                        famili_uc_txtbox.Text = Profile[i] as string;
                        break;
                    case 4:
                        // mean phonenumber
                        phonenumber_uc_txtbox.Text = Profile[i] as string;
                        break;
                    case 5:
                        // mean country
                        Country_Combobox.PromptText = Profile[i] as string;
                        break;
                }
            }
            profileImage.Image = SQL.ProfileImage_Show(Login_usercontrol.Username);
        }
        private void viewaccount_uc_txt_MouseEnter(object sender, EventArgs e) { LinkColorChange.defaultcolor(viewaccount_uc_txt); }
        private void viewaccount_uc_txt_MouseLeave(object sender, EventArgs e)  { LinkColorChange.HoveredColor(viewaccount_uc_txt);}
        private void premuim_uc_txt_MouseEnter(object sender, EventArgs e) {  LinkColorChange.defaultcolor(premuim_uc_txt); }
        private void premuim_uc_txt_MouseLeave(object sender, EventArgs e) { LinkColorChange.HoveredColor(premuim_uc_txt); }
        private void help_uc_txt_MouseEnter(object sender, EventArgs e){ LinkColorChange.defaultcolor(help_uc_txt); }
        private void help_uc_txt_MouseLeave(object sender, EventArgs e) { LinkColorChange.HoveredColor(help_uc_txt); }
        private void feedback_uc_txt_MouseEnter(object sender, EventArgs e) {  LinkColorChange.defaultcolor(feedback_uc_txt); }
        private void feedback_uc_txt_MouseLeave(object sender, EventArgs e) { LinkColorChange.HoveredColor(feedback_uc_txt); }
        private void about_uc_txt_MouseEnter(object sender, EventArgs e)  {  LinkColorChange.defaultcolor(about_uc_txt); }
        private void about_uc_txt_MouseLeave(object sender, EventArgs e) { LinkColorChange.HoveredColor(about_uc_txt); }
        private void platform_uc_txt_MouseEnter(object sender, EventArgs e) { LinkColorChange.defaultcolor(platform_uc_txt); }
        private void platform_uc_txt_MouseLeave(object sender, EventArgs e) { LinkColorChange.HoveredColor(platform_uc_txt);  }
        private void premuim_uc_txt_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        private void help_uc_txt_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        private void feedback_uc_txt_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        private void about_uc_txt_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        private void platform_uc_txt_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        private void viewaccount_uc_txt_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        private void viewaccount_uc_txt_Click_1(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }

        private void phonenumber_uc_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)){ e.Handled = false; }
            else { e.Handled = true; }
        }
        private void name_uc_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) { e.Handled = false ; }
            else { e.Handled = true; }
        }
        private void profileImage_Click(object sender, EventArgs e)
        {
            changeImage_uc_btn_Click(this, e);
        }
        // image location
        private void changeImage_uc_btn_Click(object sender, EventArgs e)
        {
            PictureBox_Openfile_Dialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg";
            PictureBox_Openfile_Dialog.Title = "Select Profile Image";
            if(PictureBox_Openfile_Dialog.ShowDialog() == DialogResult.OK)
            {
                // work do to...
                LastPictureLocation = PictureBox_Openfile_Dialog.FileName.ToString();
                profileImage.Image = new Bitmap(PictureBox_Openfile_Dialog.FileName);
                ImageSave_btn.Visible = true;
                ImageSave_btn.Enabled = true;
            }
            
        }
        private void ImageSave_btn_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            using (FileStream fs = new FileStream(LastPictureLocation, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    img = br.ReadBytes((int)fs.Length);
                    SQL.ProfileImage_Set(Login_usercontrol.Username, img);
                    ImageSave_btn.Visible = false;
                    ImageSave_btn.Enabled = false;
                }
            }
        }
        private void Country_Combobox_TextChanged(object sender, EventArgs e)
        {
            // search in combobox
            string comboresult = "";
            comboresult += Country_Combobox.Text;
            int index = Country_Combobox.FindString(comboresult);
            Country_Combobox.SelectedIndex = index;
        }

        // password generator 
        private void autopassword_uc_toggle_CheckedChanged(object sender, EventArgs e)
        {
            string password;
            if(autopassword_uc_toggle.Checked) {
                // disable enable for new password region

                newpassword_lbl.Enabled = 
                renewPassword_lbl.Enabled = 
                newpassword_uc_txtbox.Enabled = 
                renewpassword_uc_txtbox.Enabled = true;
                //---------------------------------------
                password = StandardPassword.GeneratePassword(true,true,true,true);
                newpassword_uc_txtbox.Text = renewpassword_uc_txtbox.Text = password;
                passwordEye_re_uc_pic.Visible = true;
            }
            else if(autopassword_uc_toggle.Checked== false)
            {
                // disable enable for new password region

                newpassword_lbl.Enabled = false;
                renewPassword_lbl.Enabled = false;
                newpassword_uc_txtbox.Enabled = false;
                renewpassword_uc_txtbox.Enabled = false;
                //---------------------------------------
                newpassword_uc_txtbox.Text = renewpassword_uc_txtbox.Text = string.Empty;
                passwordEye_re_uc_pic.Visible = false;
            }
        }
        byte step;
        private void passwordEye_uc_pic_Click(object sender, EventArgs e)
        {
            
            if (step == 0) {
                step++;
                newpassword_uc_txtbox.UseSystemPasswordChar = renewpassword_uc_txtbox.UseSystemPasswordChar = false;
            }
            else {
                step--;
                newpassword_uc_txtbox.UseSystemPasswordChar = renewpassword_uc_txtbox.UseSystemPasswordChar = true;
            }
        }
        private void PasswordEye_uc_pic_Click_1(object sender, EventArgs e)
        {
            if(step == 0) {
                step++;
                password_uc_txtbox.UseSystemPasswordChar = false;
            }
            else
            {
                step--;
                password_uc_txtbox.UseSystemPasswordChar = true;
            }
        }
        private void password_uc_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(password_uc_txtbox.Text != string.Empty) {
                PasswordEye_uc_pic.Visible = true;
            }
            else {
                PasswordEye_uc_pic.Visible = false;
            }
        }

        private void newpassword_uc_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (newpassword_uc_txtbox.Text != string.Empty) {
                passwordEye_re_uc_pic.Visible = true;
            }
            else {
                passwordEye_re_uc_pic.Visible = false;
            }
        }

        private void password_uc_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = false; }
        }


        /// <summary>
        /// Save change in setting page and save in database
        /// </summary>
        regexs regex = new regexs();
        private void Savesettings_btn_Click_1(object sender, EventArgs e)
        {
            // channge settings and send to data base in first
            if (regex.Email_regex(email_uc_txtbox.Text) == true && SQL.checkEmailExists(email_uc_txtbox.Text) == true
                && (regex.password_regex(password_uc_txtbox.Text) == true && SQL.PasswordExists(password_uc_txtbox.Text ) == true))
            {
                if(regex.password_regex(newpassword_uc_txtbox.Text) == true && newpassword_uc_txtbox.Text != password_uc_txtbox.Text && newpassword_uc_txtbox.Text == renewpassword_uc_txtbox.Text)
                {
                    MessageBox.Show("Password Changed!");
                }
                password_uc_label.ForeColor = Color.Black;
                email_lbl.ForeColor = Color.Black;
                family_txt.ForeColor = Color.Black;
                Username_txt.ForeColor = Color.Black;
                // Set Settings information
                   // if(name_uc_txtbox.Text == string.Empty) { name_uc_txtbox.Text = name_uc_txtbox.Hint; }
                   // if(famili_uc_txtbox.Text == string.Empty) { famili_uc_txtbox.Text = famili_uc_txtbox.Hint; }
                    if(Country_Combobox.Text == string.Empty) { Country_Combobox.Text = Country_Combobox.PromptText; }
                        SQL.ProfileInformation_Set(Login_usercontrol.Username, name_uc_txtbox.Text, famili_uc_txtbox.Text, phonenumber_uc_txtbox.Text, Country_Combobox.Text);
            }
            else
            {
                if(regex.Email_regex(email_uc_txtbox.Text) == false || SQL.checkEmailExists(email_uc_txtbox.Text) == false) { email_lbl.ForeColor = Color.Red; }
                else { email_lbl.ForeColor = Color.Black; }
                if(regex.password_regex(password_uc_txtbox.Text) == false || SQL.PasswordExists(password_uc_txtbox.Text) == false) { password_uc_label.ForeColor = Color.Red; }
                else { password_uc_label.ForeColor = Color.Black; }
            }
        }
        private void name_uc_txtbox_MouseDown(object sender, MouseEventArgs e) { name_uc_txtbox.SelectAll(); }
        private void famili_uc_txtbox_MouseDown(object sender, MouseEventArgs e) { famili_uc_txtbox.SelectAll(); }
        private void phonenumber_uc_txtbox_MouseDown(object sender, MouseEventArgs e) { phonenumber_uc_txtbox.SelectAll(); }
    }
}
