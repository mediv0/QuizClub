using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizclub.Usercontrols;
using quizclub.Forms;

namespace quizclub
{
    public partial class Student_profile : Form
    {
        public static Color btn_color() {
            return Color.FromArgb(69, 104, 220); }
        public static Color btn_activeColor() {
            return Color.FromArgb(54, 90, 207); }
        
        public Student_profile()
        {
            InitializeComponent();

            // set postion
            this.Location = new System.Drawing.Point(ClientSize.Width / 2 - this.Width / 2, ClientSize.Height / -this.Height);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;

            SQL.ProfileInformation_Show(Login_usercontrol.Username);
            //bunifuElipse1.ApplyElipse(pictureBox1, 20);       
            Dashboard_btn.color = btn_activeColor();
            dashboard_usercontrol2.BringToFront();
            minimize_picbox.BringToFront();
            exit_picbox.BringToFront();
            //------------------
            Loginform loginform = new Loginform();
            loginform.Close();
            

            // check first login
            if (SQL.Check_IsFirstLogin(Login_usercontrol.Username) == true) // mean this is first login
            {
                SQL.Set_IsFristLogin(false, Login_usercontrol.Username);
                ProfileIntero profileIntero = new ProfileIntero();
                profileIntero.ShowDialog();

                if (ProfileIntero.Intero_StepPos == 4 && SQL.Check_IsFirstLogin(Login_usercontrol.Username) == false)
                {
                    FirstAccountConfig firstAccountConfig = new FirstAccountConfig();
                    firstAccountConfig.ShowDialog();
                }
            }
        }
        private void Student_profile_Load(object sender, EventArgs e)
        {
            
            dashboard_usercontrol2.timer_Tick(this, e);
        }
        private void Student_Profile_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            DialogResult result = MessageBox.Show("Are u sure ?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                this.Hide();
                Loginform loginform = new Loginform();
                loginform.ShowDialog();
            }
        }
        private void Exams_btn_Click(object sender, EventArgs e)
        {
            Exams_btn.color = btn_activeColor();
            Dashboard_btn.color =
                settings_btn.color =
                btn_color();
            // open form
            exams_usercontrol1.BringToFront();
            settings_usercontrol1.setColorforErrors();
        }
        private void settings_btn_Click(object sender, EventArgs e)
        {
            // set active to fore
            settings_btn.color = btn_activeColor();
                Exams_btn.color =
                Dashboard_btn.color =
                btn_color();
            // open form
            settings_usercontrol1.BringToFront();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            Dashboard_btn.color = btn_activeColor();
                settings_btn.color =
                Exams_btn.color =
                btn_color();
            // form load
            dashboard_usercontrol2.BringToFront();
            settings_usercontrol1.setColorforErrors();
        }
        private void exit_picbox_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure ?", "Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) { Application.Exit(); }
        }

        private void minimize_picbox_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
