using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizclub.Usercontrols;
using quizclub.Forms;

namespace quizclub
{   
    public partial class Login_usercontrol : UserControl
    {
        public static string Username { get; set; }
        public event EventHandler ButtonClick; // login form close from event;
        private byte step = 0;
        //private bool checkConncted;
        public Login_usercontrol()
        {
            InitializeComponent();
            password_txtbox.UseSystemPasswordChar = true;
            username_errorProvider.Visible = 
            password_errorProvider.Visible =
            password_eye_pic.Visible =
            PasswordError_label.Visible = sql_usernameIncorecct_lbl.Visible =
            password_errorProvider.Visible =
            username_errorProvider.Visible =
            //password_eye_pic.Visible =
            PasswordError_label.Visible = false;
        }
        private void forget_password_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            ForgetPassword_usercontrol forgetPassword_Usercontrol = new ForgetPassword_usercontrol();
            forgetPassword_Usercontrol.BringToFront();
            password_errorProvider.Visible = 
            username_errorProvider.Visible =
           // password_eye_pic.Visible =
            PasswordError_label.Visible = false;
        }
        regexs regex = new regexs();
        protected void login_btn_Click(object sender, EventArgs e)
        {
            
            if (regex.username_regex(username_txtbox.Text) && regex.password_regex(password_txtbox.Text))
            {
                try
                {
                    // check data in database  => true let in!
                    if (SQL.CheckUser(username_txtbox.Text, password_txtbox.Text) == true)
                    {
                        
                        Username = username_txtbox.Text;
                        //user access => true;                   
                        //-------------------
                        if (this.ButtonClick != null) { ButtonClick(this, e); }
                    }
                    else
                    {
                        sql_usernameIncorecct_lbl.Visible = true;
                        sql_usernameIncorecct_lbl.Text = "Username or password are incorrect";
                        
                    }
                }
                catch
                {

                }
            }
            else
            {
                sql_usernameIncorecct_lbl.Visible = false;
                if(regex.username_regex(username_txtbox.Text)==false) { username_errorProvider.Visible = true; }
                else { username_errorProvider.Visible = false; }
                if(regex.password_regex(password_txtbox.Text)== false) { password_errorProvider.Visible = true; }
                else { password_errorProvider.Visible = false; }
            }
        }
        private void Signup_btn_Click(object sender, EventArgs e)
        {
            password_errorProvider.Visible = 
            username_errorProvider.Visible = 
            PasswordError_label.Visible = false;
            // open form
            Signup signup = new Signup();
            signup.Location = this.Location;
            signup.ShowDialog();
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(password_txtbox.Text != string.Empty){
                password_eye_pic.Visible = true;
            }
            else {
                password_eye_pic.Visible = false;
            }
        }
        private void password_eye_pic_Click(object sender, EventArgs e)
        {
            if(step == 0){
                step++;
                password_txtbox.UseSystemPasswordChar = false;
            }
            else {
                step--;
                password_txtbox.UseSystemPasswordChar = true;
            }
            
        }
    }
}
