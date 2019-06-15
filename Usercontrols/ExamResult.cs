using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizclub.Forms;

namespace quizclub.Usercontrols
{
    public partial class ExamResult : UserControl
    {
        public event EventHandler examEnd;
        public static bool IsControl { get; set; }
        public int examScore = 0;
        public int tempScore = 0;
        public ExamResult()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Enabled = true;
            // load acctapleScore
            examScore = SQL.GetExamScore(ListofExams.ExamID);
            
            //4. Calculate   user -> passed    or user -> faild
            if(ExamViewModel.ExamScore >= (examScore / 2)) { userScore_lbl.ForeColor = Color.FromArgb(0, 230, 64); }
            else if(ExamViewModel.ExamScore < (examScore / 2) ) { userScore_lbl.ForeColor = Color.Red; }
            // > 50 Passed   < 50 failde
            examTitle_lbl.Text = DoExam.examTitle;
            examTitle_lbl.Location = new Point(this.ClientSize.Width / 2 - examTitle_lbl.Width / 2, 20);

            // load results
            SQL.InsertExamResult(ListofExams.ExamID, Login_usercontrol.Username, ExamViewModel.ExamScore, commend_txt.Text);

        }
        private void commend_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(commend_txt.Text.Length == 255) {
                e.Handled = true;
                if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            }
        }
        private void commend_txt_TextChanged(object sender, EventArgs e)
        {
            CommendLength_lbl.Text = (255 - commend_txt.Text.Length).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tempScore <= ExamViewModel.ExamScore)
            {
                userScore_lbl.Text = string.Format("{0}/{1}", tempScore, examScore);
                tempScore++;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            // work to do
            SQL.InsertExamResult(ListofExams.ExamID, Login_usercontrol.Username, ExamViewModel.ExamScore, commend_txt.Text);
            MessageBox.Show("you commend submited");
            if(examEnd != null) { end_btn_Click(this, e); }
            
        }
    }
}
