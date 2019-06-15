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
    public partial class Exams_usercontrol : UserControl
    {
        public Exams_usercontrol()
        {
            InitializeComponent();
        }

        private void CreateExam_btn_Click(object sender, EventArgs e)
        {
            // call creation form
            ExamCreation examCreation = new ExamCreation();
            examCreation.ShowDialog();
        }

        private void otherExams_btn_Click(object sender, EventArgs e)
        {
            ListofExams listofExams = new ListofExams();
            listofExams.ShowDialog();
        }
    }
}
