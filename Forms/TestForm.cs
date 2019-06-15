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
    public partial class TestForm : Form
    {
        ExamResult Examresult = new ExamResult();
        public TestForm()
        {
            InitializeComponent();
            panel1.Controls.Add(Examresult);
        }
    }
}
