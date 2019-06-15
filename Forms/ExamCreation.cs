using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using quizclub;
using System.Collections;
using System.Threading;

namespace quizclub.Forms
{
    public partial class ExamCreation : Form
    {
        ExamCreationDB examCreationDB = new ExamCreationDB();
        List<string> AutoQuestions = new List<string>();
        

        bool EndOfExamCreation = false; // end of exam when last question submited;
        ushort numberOfQuestion;
        byte questionCounter; // the counter for AutoSystemquestions list<>
        byte questionPos = 0; // see question;
        bool numbercheck = true; // check number for {number of questions}
        sbyte examCreationPos = -1;
        bool creationQuestionCheck = false;


        /// <summary>
        /// Load all objects
        /// </summary>
        public ExamCreation()
        {
            InitializeComponent();
            // other defult sets;
            Input_txt.Focus();
            //Input_txt.BorderStyle = BorderStyle.None;
            maxQuestions_label.Visible = false;
            questionCounter = 0;

            // disable option and answer visible
            Option1_txtbox.Visible = Option2_txtbox.Visible = 
                Option4_txtbox.Visible = Option3_txtbox.Visible = 
                Answer_Combobox.Visible = ShowCategory_comboBox.Visible =
                Option1_lbl.Visible = Option2_lbl.Visible = Option3_lbl.Visible = Option4_lbl.Visible =
                Answer_lbl.Visible = false;

            // add list of sys questions
            AutoQuestions.Add("Enter exam title");
            AutoQuestions.Add("Enter type of exam");
            AutoQuestions.Add("Number of questions");
            AutoQuestions.Add("Exam timeout(minutes)");
            //---
            // load text question into label
            autoSystemQuestions_lbl.Text = AutoQuestions[questionCounter];

        }  
        private void Input_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(questionCounter == 0 || questionCounter == 1){
                if (char.IsDigit(e.KeyChar)) { e.Handled = true; }
            }        
            // max question is 100;
            if (questionCounter == 2 || questionCounter == 3) {
                if (questionCounter == 2) Input_txt.MaxLength = 2;
                else if (questionCounter == 3) Input_txt.MaxLength = 3;
                maxQuestions_label.Visible = true;
                if (char.IsNumber(e.KeyChar) && char.IsNumber('1') || char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
            else
            {
                maxQuestions_label.Visible = false;
            }
           
        }
        private void ExamCreation_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }

        /// <summary>
        /// Store data in Array 
        /// </summary>
        private void next_btn_Click(object sender, EventArgs e)
        {
            // increase number for next question / question pos for save question position

            try
            {
                if (Input_txt.Text == AutoQuestions[0] || Input_txt.Text == AutoQuestions[1] || Input_txt.Text == AutoQuestions[2]
                || Input_txt.Text == "")
                {
                    MessageBox.Show("Error,Somthing is wrong");
                }
                else
                {
                    ArrayList arrayList = SQL.ShowCategory();
                    // 0 => title  of Exam
                    if (questionPos == 0)
                    {
                        examCreationDB.Title = Input_txt.Text;
                        ShowCategory_comboBox.Visible = true;
                        Input_txt.Enabled = false;
                        Input_txt.Text = " ";
                        ShowCategory_comboBox.Items.AddRange(arrayList.ToArray());
                        
                    }
                    else if (questionPos > 0)
                    {
                        // 1 => Type of Exam
                        if (questionPos == 1)
                        {
                            // we need read Categories from database here ... and put in ComboBox for works.
                            //examCreationDB.ExamType = Input_txt.Text;
                                Input_txt.Text = "";
                            ShowCategory_comboBox.Visible = false;
                            Input_txt.Enabled = true;
                            if (ShowCategory_comboBox.SelectedIndex >= 0)
                                examCreationDB.ExamType = ++ShowCategory_comboBox.SelectedIndex;
                            else
                                examCreationDB.ExamType = 7; // default
                        }
                        else if (questionPos == 2)
                        {
                            numberOfQuestion = Convert.ToUInt16(Input_txt.Text);
                            examCreationDB.Length = numberOfQuestion; // number of questions.
                            // 2 => number of questions         
                            if (numberOfQuestion >= 0) // allow nuber to select question count  default => 10 now is 0
                            {
                                numbercheck = true;
                            }
                            else
                            {
                                numbercheck = false;
                                MessageBox.Show("Limit questions : 10  max : 99", "Limit question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            Input_txt.Text = "";
                            // Create Exam in Database Here...
                            /*
                             * We need send CateogryName ToDatabase and send back CategoryID
                             * ExamTitle , ExamDate , TimeOut , AcctableScore , QuestionCount , CategoryID 
                             */

                        }
                        else if(questionPos == 3) // enter time of exam -> timeout
                        {
                            maxQuestions_label.Visible = false;
                            examCreationDB.Timeout = Convert.ToInt32(Input_txt.Text);
                        }
                        else if (questionPos >= 4)
                        {
                            
                            // read question title.... insert in database
                            SQL.CreateQuestion(Input_txt.Text, examCreationDB.ExamID, Option1_txtbox.Text, Option2_txtbox.Text, Option3_txtbox.Text, Option4_txtbox.Text, Convert.ToInt32(Answer_Combobox.Text));
                            Option1_txtbox.Text = Option2_txtbox.Text =
                            Option3_txtbox.Text = Option4_txtbox.Text =
                            Answer_Combobox.Text = string.Empty;
                            Input_txt.Text = "";
                            Answer_Combobox.SelectedText = string.Empty;


                            // add question options and answer here 
                            /*EXAMPLE :
                             *  option1 : txtbox1
                             *  option2 : txtbox2
                             *  option3 : txtbox3
                             *  option4 : txtbox4
                             *  answer  : txtbox5
                             *  
                             *  option array....
                             *  answer array.....
                             *  THEN CLEAN ALL   ...
                             */
                        }
                    }
                    if(numbercheck == true)
                    {
                        if(questionPos <= 3)
                        {
                            questionCounter++;
                            questionPos++;
                            if (questionPos <= 3)
                            {
                               
                                autoSystemQuestions_lbl.Text = AutoQuestions[questionCounter];

                            }
                            else
                            {
                                creationQuestionCheck = true;
                                maxQuestions_label.Visible = false;
                                Input_txt.MaxLength = 32000;

                                SQL.CreateNewExam(examCreationDB.Title, Convert.ToString(CurrentDateTime.setCurrent()), examCreationDB.Timeout, examCreationDB.Length * 10, examCreationDB.Length, Login_usercontrol.Username, examCreationDB.ExamType);
                                examCreationDB.ExamID = SQL.GetExamID(examCreationDB.Title);
                            }
                        }
                        if (creationQuestionCheck == true)
                        {
                            
                            // when Exam Created we need examID for each questions
                            /*
                             * ExamID : 1
                             * questionID : 1
                             * option1 : ......
                             * option2 : ......
                             * option3 : ......
                             * option4 : .....
                             * answer : ......
                             
                             * ExamID : 1
                             * questionID : 2
                             * option1 : ......
                             * option2 : ......
                             * option3 : ......
                             * option4 : .....
                             * answer : ......
                             */
                            if (examCreationPos == examCreationDB.Length - 1)
                            {
                                Thread.Sleep(2000);
                                EndOfExamCreation = true;
                                this.Close();                  
                            }
                            else
                            {
                                examCreationPos++;
                                string[] question_auto_title_Creation = examCreationDB.CreateQuestion(); // creat question title;
                                autoSystemQuestions_lbl.Text = question_auto_title_Creation[examCreationPos];
                                // viaible
                                Option1_txtbox.Visible = Option2_txtbox.Visible =
                                Option4_txtbox.Visible = Option3_txtbox.Visible =
                                Answer_Combobox.Visible =
                                Option1_lbl.Visible = Option2_lbl.Visible = Option3_lbl.Visible = Option4_lbl.Visible =
                                Answer_lbl.Visible = true;
                                // -------
                                Input_txt.Text = "";
                            }
                        }   
                    }                   
                }
            }
            catch
            {
                MessageBox.Show("Something is wrong try again late.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Closing form and Send data 
        /// </summary>
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // we need send data here with check any data coming or not;
            if(EndOfExamCreation == true)
            {
                // send data for database;       with SetMethod in ExamCreationDB
            }
            this.Close();
        }
    }
}