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

    public partial class ProfileIntero : Form
    {
        public bool checkLastClick { get; set; }
        
        List<string> intero_texts = new List<string>();
        public static sbyte Intero_StepPos = -1;
        public ProfileIntero()
        {
            InitializeComponent();
            
            welcome_lbl.Parent = smile_lbl.Parent = username_lbl.Parent = this;
            welcome_lbl.BackColor = smile_lbl.BackColor = username_lbl.BackColor =Color.Transparent;
            Intero_tuts_lbl.Visible = false;
            username_lbl.Text = Login_usercontrol.Username;
            username_lbl.Dock = DockStyle.Fill;
            username_lbl.Anchor = AnchorStyles.Top;
            username_lbl.Anchor = AnchorStyles.Bottom;
            username_lbl.Anchor = AnchorStyles.Left;
            username_lbl.Anchor = AnchorStyles.Right;
            // set intero texts here ....
            intero_texts.Add("Fast and safe, our app is very fast, you can create exams for free or you can join one of them"); // 0 
            intero_texts.Add("We give information to u as chart and statistics. so you can see your result easily");
            intero_texts.Add("this is your first login to this app, please configuration your settings. ");
            intero_texts.Add("Good Luck");
        }

        private void ProfileIntero_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }

        private void ProfileIntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 13 = > enter key
            if(e.KeyChar == (char)13)
            {
                // fire click
                next_btn_Click(this, e);
                if(Intero_StepPos == 4)
                {
                    next_btn_Click(this, e);
                }
            }
        }
        private void next_btn_Click(object sender, EventArgs e)
        {
            // fire list
            Intero_StepPos++;
            Intero_tuts_lbl.Visible = true;
            welcome_lbl.Visible =
            smile_lbl.Visible =
            introduces_lbl.Visible =
            username_lbl.Visible = false;
                
            switch (Intero_StepPos)
            {
                case 0:
                    Intero_tuts_lbl.Text = intero_texts[Intero_StepPos];
                    break;
                case 1:
                    Intero_tuts_lbl.Text = intero_texts[Intero_StepPos];
                    break;
                case 2:
                    Intero_tuts_lbl.Text = intero_texts[Intero_StepPos];
                    break;
                case 3:
                    // this mean good luck!
                    Intero_tuts_lbl.Text = intero_texts[Intero_StepPos];
                    Intero_tuts_lbl.Font = new Font(Intero_tuts_lbl.Font.FontFamily,26);
                    next_btn.Text = "End";
                    break;
                case 4:
                    checkLastClick = true;
                    this.Close();
                    break;
            }
        }
    }
}
