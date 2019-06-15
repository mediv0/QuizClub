using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using quizclub.Usercontrols;
using System.IO;
using System.Resources;
using quizclub.Usercontrols;

namespace quizclub.Forms
{
    public partial class FirstAccountConfig : Form
    {
        List<string> questions = new List<string>(); // system questions;
        List<string> UserAnswer = new List<string>();
        sbyte questionStep = -1;
        string ImageLocation;
        
        public FirstAccountConfig()
        {
            InitializeComponent();
            questions.Add("Your firstname");
            questions.Add("Your lastname");
            questions.Add("Your phone");
            questions.Add("Your country");

            FirstConfig_texts.Visible = firstconfig_txtbox.Visible = true;
            country_comboBox.Visible = false;
        }
        private void FirstAccountConfig_Load(object sender, EventArgs e)
        {
            FirstConfig_texts.Text = questions[0];
        }
        private void FirstAccountConfig_MouseDown(object sender, MouseEventArgs e)
        {
            Quiz_FormMove.ReleaseCapture();
            Quiz_FormMove.SendMessage(this.Handle, Quiz_FormMove.WM_NCLBUTTONDOWN, Quiz_FormMove.HT_CAPTION, 0);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            questionStep++;
            if (firstconfig_txtbox.Text == string.Empty && questionStep < 3)
            {
                MessageBox.Show("Error");
            }
            else
            {
                if(questionStep == 0)
                {
                    
                    UserAnswer.Add(firstconfig_txtbox.Text);
                    firstconfig_txtbox.Text = string.Empty;
                    FirstConfig_texts.Text = questions[1];
                }
                else if(questionStep == 1)
                {
                    
                    UserAnswer.Add(firstconfig_txtbox.Text);
                    firstconfig_txtbox.Text = string.Empty;
                    FirstConfig_texts.Text = questions[2];
                    firstconfig_txtbox.MaxLength = 11;
                }
                else if(questionStep == 2)
                {
                    
                    UserAnswer.Add(firstconfig_txtbox.Text);
                    firstconfig_txtbox.Text = string.Empty;
                    FirstConfig_texts.Text = questions[3];
                    country_comboBox.Visible = true;
                    firstconfig_txtbox.Visible = false;

                }
                else if(questionStep >= 3) 
                {
                    if (country_comboBox.SelectedIndex >= 0)
                    {
                        UserAnswer.Add(country_comboBox.Text);
                        firstconfig_txtbox.Text = string.Empty;
                        SQL.ProfileInformation_Set(Login_usercontrol.Username, UserAnswer[0], UserAnswer[1], UserAnswer[2], UserAnswer[3]);
                        // image location 
                        var ImageLocation = @"E:\RealBarrel\quizclub v1\quizclub\quizclub\Resources\user.png";

                        byte[] img = null;
                        
                        using (FileStream fs = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read))
                        {
                            using (BinaryReader binaryReader = new BinaryReader(fs))
                            {
                                img = binaryReader.ReadBytes((int)fs.Length);
                                SQL.ProfileImage_Set(Login_usercontrol.Username, img);
                            }
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
            }
        }
        private void firstconfig_txtbox_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (questionStep == -1 || questionStep == 0) // name
            {
                if (char.IsLetter(e.KeyChar)||char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
            else if (FirstConfig_texts.Text == questions[2]) // phone number
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
    }
}

/*

Detail_lbl.Visible = false;
                checkFirsttext = true;
                switch (questionStep)
                {
                    case 0: // firstname
                        
                        UserAnswer.Add(firstconfig_txtbox.Text);
                        firstconfig_txtbox.Text = string.Empty;
                        FirstConfig_texts.Text = questions[1];
                        break;
                    case 1: // lastname
                        
                        UserAnswer.Add(firstconfig_txtbox.Text);
                        firstconfig_txtbox.Text = string.Empty;
                        FirstConfig_texts.Text = questions[2];
                        break;
                    case 2: // phonenumber
                        
                        UserAnswer.Add(firstconfig_txtbox.Text);
                        firstconfig_txtbox.Text = string.Empty;
                        FirstConfig_texts.Text = questions[3];
                        break;
                    case 3: // country
                        UserAnswer.Add(firstconfig_txtbox.Text);
                        firstconfig_txtbox.Text = string.Empty;
                        profileImage_picbox.Visible = choose_pic_btn.Visible = true;
                        FirstConfig_texts.Visible = firstconfig_txtbox.Visible = false;
                        FirstConfig_texts.Text = questions[4];
                        
                        break;
                    case 4:
                        
                        
                        try
                        {
                            byte[] img = null;
                            using (FileStream fs = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read))
                            {
                                using (BinaryReader br = new BinaryReader(fs))
                                {
                                    img = br.ReadBytes((int) fs.Length);
                                    SQL.ProfileImage_Set(Login_usercontrol.Username, img);
                                }
                            }
                        }
                        catch { }
                        SQL.ProfileInformation_Set(Login_usercontrol.Username, UserAnswer[0], UserAnswer[1], UserAnswer[2], UserAnswer[3]);
                        this.Close();
                        break;
                }
                */