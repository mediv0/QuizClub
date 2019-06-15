using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizclub
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            //login_usercontrol1.BringToFront();
            
            
            login_usercontrol1.BringToFront();
            bunifuElipse1.ApplyElipse(500);
            exit_picbox.BringToFront();
            minimize_picbox.BringToFront();
            // label transparent...
            Quiz_text.Parent = Club_txt.Parent = version_txt.Parent = information_txt.Parent = copyright_txt.Parent = Login_Left_bg;
            Quiz_text.BackColor = Club_txt.BackColor = version_txt.BackColor = information_txt.BackColor = copyright_txt.BackColor = Color.Transparent;
            //---
            login_usercontrol1.ButtonClick += new EventHandler(UserControl_ButtonClick);
            //----------------------
            SplashScreenform splashScreenform = new SplashScreenform();
            splashScreenform.Close();

        }
        private void Loginform_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        } 
        private void exit_picbox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure ?", "Exit", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) { Application.Exit(); }
        }
        private void minimize_picbox_Click(object sender, EventArgs e)  { this.WindowState = FormWindowState.Minimized;  }
        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                //ProgressBar.EndProgress();
                this.Hide();
                Student_profile student_Profile = new Student_profile();
                student_Profile.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
