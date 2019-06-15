using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizclub;
using System.Data.SqlClient;

namespace quizclub.Forms
{
    public partial class Signup : Form
    {
        regexs regexs_ = new regexs();
        public Signup()
        {
            InitializeComponent();
            username_errorProvider.Visible = passwordeye_pic.Visible = password_errorprovider.Visible =
               repassword_errorprovider.Visible = email_errorprovider.Visible = checkBox_errorProvider.Visible = Username_error_lbl.Visible = 
               emailexists_error_lbl.Visible = false;
            password_txtbox.UseSystemPasswordChar = repassword_txtbox.UseSystemPasswordChar = true;    
        }

        private void Signup_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            if(regexs_.username_regex(username_txtbox.Text) && regexs_.password_regex(password_txtbox.Text) 
                && regexs_.Email_regex(email_txtbox.Text) && (password_txtbox.Text == repassword_txtbox.Text) && terms_checkbox.Checked)
            {
                // false all errors
                username_errorProvider.Visible = password_errorprovider.Visible =
                    repassword_errorprovider.Visible = email_errorprovider.Visible =
                    checkBox_errorProvider.Visible = false;

                bool checkemail = SQL.checkEmailExists(email_txtbox.Text);
                // check exists user   then else create user
                SqlConnection con = new SqlConnection(SQL.GetConnectionString());
                con.Open();
                SqlCommand cmd = new SqlCommand("UserExists", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter usernameParameter = new SqlParameter("username", username_txtbox.Text);
                cmd.Parameters.Add(usernameParameter);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows || checkemail == true)
                {
                    if (sqlDataReader.HasRows == true)
                    {
                        username_errorProvider.Visible = true;
                        Username_error_lbl.Visible = true;
                    }
                    if (checkemail)
                    {
                        email_errorprovider.Visible = true;
                        emailexists_error_lbl.Visible = true;
                    }
                }
                else
                {
                    username_errorProvider.Visible = false;
                    Username_error_lbl.Visible = false;
                    email_errorprovider.Visible = false;
                    emailexists_error_lbl.Visible = false;
                    SQL.CreateNewUserAccount(username_txtbox.Text,password_txtbox.Text,email_txtbox.Text);
                    username_txtbox.Text = string.Empty;
                    password_txtbox.Text = string.Empty;
                    email_txtbox.Text = string.Empty;
                    terms_checkbox.Checked = false;
                    repassword_txtbox.Text = string.Empty;
                }
            }
            else
            {
                if(regexs_.username_regex(username_txtbox.Text) == false) { username_errorProvider.Visible = true; }
                //else { username_errorProvider.Visible = false; }
                if(regexs_.password_regex(password_txtbox.Text) == false) { password_errorprovider.Visible = true; }
                //else { password_errorprovider.Visible = false; }
                if(regexs_.Email_regex(email_txtbox.Text) == false) { email_errorprovider.Visible = true; }
                //else { email_errorprovider.Visible = false; }
                if (password_txtbox.Text != repassword_txtbox.Text || repassword_txtbox.Text == string.Empty) { repassword_errorprovider.Visible = true; }
               // else { repassword_errorprovider.Visible = false; }
                if (terms_checkbox.Checked == false) { checkBox_errorProvider.Visible = true; }
                //else { checkBox_errorProvider.Visible = false; }
                //Username_error_lbl.Visible = false;
                //emailexists_error_lbl.Visible = false;
            }
        }
        /// <summary>
        /// set link for terms read more
        /// </summary>
        #region
        private void readmore_link_MouseEnter(object sender, EventArgs e) { LinkColorChange.defaultcolor(readmore_link); }
        private void readmore_link_MouseLeave(object sender, EventArgs e) { LinkColorChange.HoveredColor(readmore_link); }
        private void readmore_link_Click(object sender, EventArgs e) { setLink.Linkset("http://www.google.com"); }
        #endregion

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(password_txtbox.Text != String.Empty)
            {
                passwordeye_pic.Visible = true;
            }
            else
            {
                passwordeye_pic.Visible = false;
            }
        }
        byte step = 0;
        private void passwordeye_pic_Click(object sender, EventArgs e)
        {
            if(step == 0)
            {
                step++;
                password_txtbox.UseSystemPasswordChar = repassword_txtbox.UseSystemPasswordChar = false;
            }
            else
            {
                step--;
                password_txtbox.UseSystemPasswordChar = repassword_txtbox.UseSystemPasswordChar =true;
            }
        }

        private void username_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = false; }
        }
    }
}
