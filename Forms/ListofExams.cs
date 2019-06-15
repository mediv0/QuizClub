using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizclub;
using System.Collections;

namespace quizclub.Forms
{
    public partial class ListofExams : Form
    {
        public static int ExamID { get; set; }
        public static ArrayList SingleExam { get; set; }
        public ListofExams()
        {
            InitializeComponent();
            warning_lbl.Visible = false;
        }

        private void ListofExams_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }
        private void ListofExams_Load(object sender, EventArgs e)
        {
            //-----------------
            DoExam doexam = new DoExam();
            doexam.Close();

            ListViewItem item;
            ColumnHeader header1, header2 , header3 , header4;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header3 = new ColumnHeader();
            header4 = new ColumnHeader();
            // ListofExams.SmallImageList = imageList1;
            /*
            materialListView1.Columns.Add("ExamTitle");
            materialListView1.Columns.Add("Question Count");
            materialListView1.Columns.Add("Category");
            materialListView1.Columns.Add("Creator");
            */

            header1.Text = "Title";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 500;

            header2.Text = "Count";
            header2.TextAlign = HorizontalAlignment.Left;
            header2.Width = 200;

            header3.Text = "Category";
            header3.TextAlign = HorizontalAlignment.Left;
            header3.Width = 240;

            header4.Text = "Creator";
            header4.TextAlign = HorizontalAlignment.Left;
            header4.Width = 200;

            examListview.Columns.Add(header1);
            examListview.Columns.Add(header2);
            examListview.Columns.Add(header3);
            examListview.Columns.Add(header4);

            // data;
            var TupleExamList = SQL.GetExamInformation();
            ArrayList examTitle = TupleExamList.Item1;
            ArrayList QuestionCount = TupleExamList.Item2;
            ArrayList Category = TupleExamList.Item3;
            ArrayList Creator = TupleExamList.Item4;


            for(int i = 0;i<examTitle.Count;i++)
            {
                item = examListview.Items.Add(examTitle[i].ToString());
                item.SubItems.Add(QuestionCount[i].ToString());
                item.SubItems.Add(Category[i].ToString());
                item.SubItems.Add(Creator[i].ToString());
            }
            if(examTitle.Count <= 0)
            {
                //mean there is no exam..
                // works
                // exam list visible. false;
                // show label
                examListview.Visible = false;
                examListview.Enabled = false;
                warning_lbl.Visible = true;
                warning_lbl.Location = new Point(ClientSize.Width / 2 - warning_lbl.Width / 2, ClientSize.Height / 2 - warning_lbl.Height / 2); // set to center of parent screen

            }
        }
        private void examListview_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                var info = examListview.HitTest(e.X, e.Y);
               // var row = info.Item.Index;
                //var col = info.Item.SubItems.IndexOf(info.SubItem);
                string value = info.Item.SubItems[0].Text;
                DialogResult dialogResult = MessageBox.Show("do you want join this exam?", "Join a exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    string examUservalue = info.Item.SubItems[3].Text.TrimEnd();
                    if (Login_usercontrol.Username == examUservalue)
                    {
                        MessageBox.Show("you can not join your own exam");
                    }
                    else
                    {
                        ExamID = SQL.GetExamID(value);
                        SingleExam = SQL.GetExamSingleInformation(ExamID);

                        this.Hide();
                        DoExam doExam = new DoExam();
                        doExam.ShowDialog();
                    }
                }

            }
            catch {  }
        }
        private void exit_picbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_picbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void examListview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            if(e.ColumnIndex == 0)
            {
                e.NewWidth = 500;
            }
            else if(e.ColumnIndex == 1)
            {
                e.NewWidth = 200;
            }
            else if(e.ColumnIndex == 2)
            {
                e.NewWidth = 250;
            }

        }
    }

}
