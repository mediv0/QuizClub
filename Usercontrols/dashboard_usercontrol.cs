using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using quizclub.Forms;
using System.Collections;

namespace quizclub.Usercontrols
{
    public partial class dashboard_usercontrol : UserControl
    {
        
        public static string fullname_sender{ get; set; }
        public static Image profileImage_sender { get; set; }
        int Step = 1;
        int state = 0;
        // data from Server ..............
        int FaildChartValue = 100;
        int ExamFaildNumber = 20;

        int PassedChartvalue = 55;
        int ExamPassednumber = 30;

        int AllExamChartValue = 70;
        int AllExamNumber = 70;
        // step check bool
        bool StepCheck = false;
        // ----------------------------------
        public dashboard_usercontrol()
        {
            InitializeComponent();
            // form load animation _ tick.

            // save chart value , we need; example : faild chart = read from database so we have the value;


            // profile image circle
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.AddEllipse(0, 0, profileImage.Width - 1, profileImage.Height - 1);
            Region region = new Region(graphicpath);
            profileImage.Region = region;
        }
        private void dashboard_usercontrol_Load(object sender, EventArgs e)
        {
            DatepickerTimer_Tick(this, e);
            ArrayList Profile = SQL.ProfileInformation_Show(Login_usercontrol.Username);
            for(int i = 0; i<Profile.Count;i++)
            {
                switch(i)
                {
                    case 0:
                        // mean full name
                        name_label.Text = Profile[i] as string;
                        fullname_sender = name_label.Text;
                        break;
                    case 1:
                        // mean username
                        username_label.Text = "@" + Profile[i] as string;
                        break;
                    case 2:
                        // mean firstname
                        name_db_lbl.Text = Profile[i] as string;
                        break;
                    case 3:
                        // mean lastname
                        familiy_db_lbl.Text = Profile[i] as string;
                        break;
                    case 4:
                        // mean phonenumber
                        phone_db_lbl.Text = Profile[i] as string;
                        break;
                    case 5:
                        // mean country
                        country_db_lbl.Text = Profile[i] as string;
                        break;
                }                                    
            }
            profileImage.Image = SQL.ProfileImage_Show(Login_usercontrol.Username);
        }
        public void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            // check with true and false ----------------- check with state

            if (state == 0) // check first char in form
            {
                examfaild_chart.Value = ++Step;
                if (Step == FaildChartValue) { state = 1; StepCheck = true; }
            }
            else if (state == 1) // check first number in form
            {

                if (StepCheck == true) // check with last data;
                {
                    Step = 0;
                    StepCheck = false;
                }
                examfaild_number_label.Text = (++Step).ToString();
                if (Step == ExamFaildNumber) { state = 2; StepCheck = true; }
            }

            else if (state == 2)
            {
                if (StepCheck == true)
                {
                    Step = 0;
                    StepCheck = false;
                }
                ExamPassed_Chart.Value = ++Step;
                if (Step == PassedChartvalue) { state = 3; StepCheck = true; }
            }

            else if (state == 3)
            {
                if (StepCheck == true)
                {
                    Step = 0;
                    StepCheck = false;
                }
                ExamPassed_label.Text = (++Step).ToString();
                if (Step == ExamPassednumber) { state = 4; StepCheck = true; }
            }

            else if (state == 4)
            {
                if (StepCheck == true)
                {
                    Step = 0;
                    StepCheck = false;
                }
                Allexams_Chart.Value = (++Step);
                if (Step == AllExamChartValue) { state = 5; StepCheck = true; }
            }

            else if (state == 5)
            {
                if(StepCheck == true)
                {
                    Step = 0;
                    StepCheck = false;
                }
                AllExams_label.Text = (++Step).ToString();
                if(Step == AllExamNumber) { state = 6;StepCheck = true; }
            }
            else
            {
                state = 0;
                timer.Enabled = false;
            }
        }

        private void DatepickerTimer_Tick(object sender, EventArgs e)
        {
            DatepickerTimer.Enabled = true;
            dateandTime_label.Text = CurrentDateTime.setCurrent().ToString();
        }
    }
}
