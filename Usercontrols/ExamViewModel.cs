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
using System.Collections;
using quizclub.Classes;

namespace quizclub.Usercontrols
{
    public partial class ExamViewModel : UserControl
    {
        public event EventHandler ExamEndCalled; // maybe for next form..
        public static int exam_hour { get; set; } = 0;
        public static int exam_minute { get; set; } = 0;
        public static int exam_second { get; set; } = 0;
        public static int ExamScore { get; set; } = 0;

        int questionCounter = 1;
        int questionPos = 0;
        int UserAnswer;
        // set questions for start 
        public static Tuple<ArrayList, ArrayList, ArrayList, ArrayList, ArrayList, ArrayList,ArrayList> 
            TupleList = SQL.GetExamQuestions(ListofExams.ExamID); // send exam id for query
        // data 
        ArrayList questionTitle = TupleList.Item1;
        ArrayList option1 = TupleList.Item2;
        ArrayList option2 = TupleList.Item3;
        ArrayList option3 = TupleList.Item4;
        ArrayList option4 = TupleList.Item5;
        ArrayList Answer = TupleList.Item6; // check it late!
        ArrayList questionID = TupleList.Item7;
        //----------------------------------
        

        public ExamViewModel()
        {
            InitializeComponent();
            // hide exam result 
            exam_result_panel.Visible = false;

            // Load question 1
            //ListofExams.SingleExam[2].ToString();  // count of questions
            this.ExamEndCalled += new EventHandler(ExamEnd_Called); // end of exam 
            question_counter_lbl.Text = string.Format("question {0}/{1}", questionCounter, ListofExams.SingleExam[2]);
            question_title_lbl.Text = (questionTitle[questionPos]).ToString();
            option1_radio.Text = (option1[questionPos]).ToString();
            option2_radio.Text = (option2[questionPos]).ToString();
            option3_radio.Text = (option3[questionPos]).ToString();
            option4_radio.Text = (option4[questionPos]).ToString();
            //----------------------------------
            hour_lbl.Text = string.Format("{0:00}", exam_hour);
            minute_lbl.Text = string.Format("{0:00}",exam_minute);
            second_lbl.Text = string.Format("{0:00}", exam_second);
            examEndtimer.Interval = 1000;
            examEndtimer.Enabled = true;

            endExam_btn.Visible = false;
            endExam_btn.Enabled = false;
        }
        private void examEndtimer_Tick(object sender, EventArgs e)
        {
            
            if(exam_second == 0 && exam_minute > 0)
            {
                exam_minute--;
                exam_second = 60;
            }
            else if(exam_second == 0 && exam_minute == 0 && exam_hour > 0)
            {
                exam_hour--;
                exam_second = 60;
                exam_minute = 60;
            }
            if(exam_minute == 0 & exam_hour > 0)
            {
                exam_hour--;
                exam_minute = 60;
            }
            hour_lbl.Text = string.Format("{0:00}", exam_hour);
            minute_lbl.Text = string.Format("{0:00}", exam_minute);
            second_lbl.Text = string.Format("{0:00}", --exam_second);
            if (exam_minute == 0 && exam_second == 0 && exam_hour == 0)
            {
                // end of exam
                examEndtimer.Enabled = false;
                ExamEnd_Called(this, e);  
                
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (option1_radio.Checked == true || option2_radio.Checked == true || option3_radio.Checked == true || option4_radio.Checked == true)
            {
                if (option1_radio.Checked) { UserAnswer = Convert.ToInt32(userAnswerStats.Stats.option1); }
                else if (option2_radio.Checked) { UserAnswer = Convert.ToInt32(userAnswerStats.Stats.option2); }
                else if (option3_radio.Checked) { UserAnswer = Convert.ToInt32(userAnswerStats.Stats.option3); }
                else if (option4_radio.Checked) { UserAnswer = Convert.ToInt32(userAnswerStats.Stats.option4); }
                // save user answer for exam Result;
                SQL.CreateUserAnswer(Convert.ToInt32(questionID[questionPos]), Login_usercontrol.Username, UserAnswer, ListofExams.ExamID);
                //---------------------------------

                // red next question
                questionCounter++;
                questionPos++;
                if (questionPos + 1 > Convert.ToInt32(ListofExams.SingleExam[2]))
                {
                    
                    ExamEnd_Called(this, e);
                    // show exam result

                }
                else
                {
                    option1_radio.Checked = false;
                    option2_radio.Checked = false;
                    option3_radio.Checked = false;
                    option4_radio.Checked = false;

                    question_counter_lbl.Text = string.Format("question {0}/{1}", questionCounter, ListofExams.SingleExam[2]);
                    question_title_lbl.Text = (questionTitle[questionPos]).ToString();
                    option1_radio.Text = (option1[questionPos]).ToString();
                    option2_radio.Text = (option2[questionPos]).ToString();
                    option3_radio.Text = (option3[questionPos]).ToString();
                    option4_radio.Text = (option4[questionPos]).ToString();

                    endExam_btn.Enabled = true;
                    endExam_btn.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("select answer");
            }
        }
        private void ExamEnd_Called(object sender, EventArgs e)
        {
            // user answer data
            var useranswer_tuple = SQL.GetUserAnswer(Login_usercontrol.Username, ListofExams.ExamID);
            ArrayList userAnswer_questionID = useranswer_tuple.Item1;
            ArrayList userAnswer_answer = useranswer_tuple.Item2;
            // ----------------
            // when exam end  works to do
            //1. before increase check if(first time  user exam or not)
            // if not -> do not Increase exam count  -> leave it !
            // if yes -> increase exam count
            bool IsFirstExam = SQL.ISFirstExam(Login_usercontrol.Username);
            if (IsFirstExam == true)
            {
                // increase count
                SQL.IncreaseExamCount(Login_usercontrol.Username);
            }
            //2. compare user answer with question answer  each question 10 point
            for (int j = 0; j <  questionID.Count; j++)
            {
                int useranswer = Convert.ToInt32(userAnswer_answer[j]);
                int questionanswer = Convert.ToInt32(Answer[j]);
                if (useranswer == questionanswer) // user answer is true; +10 point for user
                {  
                    ExamScore += 10;
                }
            }
            // show form;
            ExamResult examresult = new ExamResult();
            examresult.BringToFront();
            exam_result_panel.BringToFront();
            exam_result_panel.Controls.Add(examresult);
            exam_result_panel.Visible = true;
        }

        private void endExam_btn_Click(object sender, EventArgs e)
        {
            // check this where this call come from   
            // 1. from this form
            // 2. from event in exam resultd
        }

        private void exam_result_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
