using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizclub
{
    public partial class SplashScreenform : Form
    {
        byte count;
        //bool net_Connect_Checker;
       // Quiz_NetworkConnection networkConnection = new Quiz_NetworkConnection();
        public SplashScreenform()
        {
            InitializeComponent();
            //label1.Parent = pictureBox1;
            //label1.BackColor = Color.Transparent;
        }
        private void SplashScreenform_Load(object sender, EventArgs e)
        {
            // try_connect_net.Enabled = try_connect_net.Visible = false;
            //net_Connect_Checker = networkConnection.CheckNet();
            // check connect to database  in update!
            //check for updates in update!
            //---- check net for connec;
            /*   if (net_Connect_Checker == true)
               {
                   status_label.Text = "Connected to the internet!";
                   status_label.ForeColor = Color.Green;
                   count = 5;
                   timer1.Tick += new EventHandler(timer1_Tick);
                   timer1.Interval = 1000;
                   timer1.Enabled = true;
               }
               else
               {
                   status_label.Text = "Connot connect to the internet!";
                   status_label.ForeColor = Color.Red;
                   try_connect_net.Enabled = try_connect_net.Visible = true;
               }
               */
            count =5;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                timer1.Enabled = false;
                this.Hide();
                Loginform loginform = new Loginform();
                loginform.ShowDialog();
                this.Close();
            }
        }

    }
}
