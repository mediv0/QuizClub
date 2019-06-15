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

namespace quizclub.Forms
{
    public partial class DoExam : Form
    {
        public static int questionCount { get; set; } 
        public static string examTitle { get; set; }
        int numtemp = 1;
        public DoExam()
        {
            InitializeComponent();
        }
        private void DoExam_Load(object sender, EventArgs e)
        {
            ListofExams listofExams = new ListofExams();
            listofExams.Close();

            ExamResult examResult = new ExamResult();
            examResult.examEnd += new EventHandler(exit_picbox_Click);

            examTitle_lbl.Text = ListofExams.SingleExam[0] as string;
            examTitle = examTitle_lbl.Text; 
            Creator_lbl.Text = ListofExams.SingleExam[1] as string;
            questionCount_lbl.Text = ListofExams.SingleExam[2] + " questions";
            timeOut_lbl.Text = ListofExams.SingleExam[3] + " minute";
            // location for large titles...
            examTitle_lbl.Location = new Point(this.ClientSize.Width / 2 - examTitle_lbl.Width / 2, 195);
            examTitle_lbl.Anchor = AnchorStyles.None;

            ExamviewModel_panel.Visible = false;

            timer.Interval = 10;
            timer_Tick(this, e);

            exit_picbox.BringToFront();
            minimize_picbox.BringToFront();

            #region commends
            // if (exists)
            // read full name
            // read image 
            // read commend 



            #endregion
        }
        private void exit_picbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListofExams listofExams = new ListofExams();
            listofExams.ShowDialog();       
        }

        private void minimize_picbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DoExam_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            usernumber_lbl.Text = numtemp.ToString() + " users";               
            if(numtemp == 10) { timer.Enabled = false; }
            numtemp++;
            //timer.Enabled = false;
        }
        private void startExam_btn_Click(object sender, EventArgs e)
        {
            questionWarning_lbl.Visible = false;
            ExamviewModel_panel.BringToFront();
            // set exam time out then start ...
            double number = (Convert.ToDouble(ListofExams.SingleExam[3])) / 60;
            string numberToString = number.ToString();
            string[] SplitNumberPlace = numberToString.Split('.');
            if (Convert.ToDouble(SplitNumberPlace[0]) == 0)
            {
                // mean : timeout under 1 hourd  
                ExamViewModel.exam_minute = Convert.ToInt32(ListofExams.SingleExam[3]);
            }
            else
            {
                // time >= 1hour                
                ExamViewModel.exam_hour = Convert.ToInt32(SplitNumberPlace[0]);
                if(SplitNumberPlace[1].Length == 1)
                {
                    if(Convert.ToInt32(SplitNumberPlace[1][0]) > 0)
                    {
                        SplitNumberPlace[1] += 0.ToString();
                    }
                }
                else
                {
                    SplitNumberPlace[1] = SplitNumberPlace[1].Substring(0, 2);
                }
                ExamViewModel.exam_minute = Convert.ToInt32(SplitNumberPlace[1]);


                //number = Math.Round(number, 2)
            }
            ExamViewModel examViewModel = new ExamViewModel();
            ExamviewModel_panel.Controls.Add(examViewModel);
            ExamviewModel_panel.Visible = true;
        }
    }
}
