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
using quizclub;

namespace quizclub
{
    public partial class ForgetPassword_usercontrol : UserControl
    {
        ProgressBar progressBar = new ProgressBar();
        public ForgetPassword_usercontrol()
        {
            InitializeComponent();
            email_send_check.Visible =
                email_send_error.Visible = 
                Send_btn.Enabled = checkProvider.Visible =
                errorProvider.Visible = false;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            email_send_check.Visible = email_send_error.Visible = errorProvider.Visible = false;
            email_txtbox.Text = string.Empty;   
            this.SendToBack();
           
        }
        private void Send_btn_Click(object sender, EventArgs e)
        {
            ProgressBar.StartProgress();
            bool mailcheck;
            Ismail mail = new Ismail();
            if (SQL.checkEmailExists(email_txtbox.Text) == true)
            {
                mailcheck = mail.sendMail(email_txtbox.Text);
                if (mailcheck == true)
                {
                    errorProvider.Visible = false;
                    checkProvider.Visible = true;
                    email_send_check.Visible = true;
                    email_send_check.BringToFront();
                    email_send_error.Visible = false;
                }
                else
                {
                    errorProvider.Visible = true;
                    checkProvider.Visible = false;
                    email_send_error.Visible = true;
                    email_send_error.BringToFront();
                    email_send_check.Visible = false;
                    email_send_error.Text = "Something is wrong try again late";
                }
            }
            else
            {
                errorProvider.Visible = true;
                checkProvider.Visible = false;
                email_send_error.Visible = true;
                email_send_error.BringToFront();
                email_send_check.Visible = false;
                email_send_error.Text = "Email not exists";
            }
            ProgressBar.EndProgress();
            
        }
        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {
            
            bool checkmail = Ismail.emailCheck(email_txtbox.Text);
            if (checkmail == true)
            {
                checkProvider.Visible = true;
                errorProvider.Visible = false;
                Send_btn.Enabled = true;
            }
            else
            {
                errorProvider.Visible = true;
                checkProvider.Visible = false;
                Send_btn.Enabled = false;
            }
            
        }
    }
}
