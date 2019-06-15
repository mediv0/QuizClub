using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections;

namespace quizclub
{
    class UserInformation
    {
        // user login information;
        private static string username;
        private static string password;
        private static string email;
        private static List<string> collect_information = new List<string>();
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        } 
        public static bool Login()
        {
            bool check;
            // send data();
            collect_information.InsertRange(collect_information.Count,new List<string> { username, password });
            check = sendInformation.DataSender(collect_information);
            if(check == true) {
                return check;
            }
            else {
                throw new WebException("Cannot Connect to the net");
                check = false;
                return check;
            }
        }
        public static bool Signup()
        {
            bool check;
            // send data();
            collect_information.InsertRange(collect_information.Count, new List<string> { username, password });
            check = sendInformation.DataSender(collect_information);
            if (check == true) {
                return check;
            }
            else
            {
                throw new WebException("Cannot Connect to the net");
                check = false;
                return check;
            }
            // return data;
        }
    }
}
