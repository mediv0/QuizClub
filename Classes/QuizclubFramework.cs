using System;
using System.Text;
using System.Threading;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.Data.SqlClient;
using quizclub.Forms;
using System.Collections;
using quizclub.Usercontrols;
using System.IO;
using System.Collections.Generic;

namespace quizclub
{
    public class ProgressBar
    {
        private static Thread thread;
        public static void StartProgress()
        {
            thread = new Thread(new ThreadStart(ShowProgressbar));
            thread.Start();
        }
        private static void ShowProgressbar()
        {
            LoadingForm loadingform = new LoadingForm();
            loadingform.ShowDialog();

        }
        public static void EndProgress()
        {
            thread.Abort();
            thread = null;
        }
    }
    public class Quiz_NetworkConnection
    {
        public bool CheckNet()
        {
            string host = "www.google.com";
            int timeout = 10000;
            bool net_check = false;
            Ping ping = new Ping();
            try
            {
                PingReply pingreply = ping.Send(host, timeout);
                if (pingreply.Status == IPStatus.Success)
                {
                    net_check = true;
                }
            }
            catch (PingException)
            {
                net_check = false;

            }
            return net_check;
        }
        public bool Reapetcheck()
        {
            // infinity check;
            return true;
        }
    }
    public class Quiz_DatabaseConnection
    {
        // some code here soon...
    }
    public class Quiz_CheckUpdates
    {
        // some code here soon...
    }
    public class Quiz_FormMove
    {
        /*
           Quiz_MousMove.ReleaseCapture();
           Quiz_MousMove.SendMessage(this.Handle, Quiz_MousMove.WM_NCLBUTTONDOWN, Quiz_MousMove.HT_CAPTION, 0);
        */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
    public class Ismail
    {   
        public static bool emailCheck(string mail)
        {
            bool check;
            regexs emailRegex = new regexs();
            check = emailRegex.Email_regex(mail);
            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool sendMail(string emailAdress)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("your email here", "password");
                MailAddress from = new MailAddress("mail adress");
                MailAddress to = new MailAddress(emailAdress);
                MailMessage mailmessage = new MailMessage(from, to);
                mailmessage.Subject = "Hello";
                mailmessage.Body = "<h1>test password</h1>";
                mailmessage.IsBodyHtml = true;
                smtpClient.Send(mailmessage);
                return true;
            }
            catch (SmtpException)
            {
                return false;
            }
        }
    }
    public class regexs
    {
        public bool Email_regex(string matchstring)
        {
            matchstring.Trim();
            Regex regemail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regemail.Match(matchstring);
            if (match.Success == true)
            {
                return true;
            }
            else { return false; }
        }
        public bool username_regex(string matchstring)
        {
            matchstring.Trim();
            Regex reguser = new Regex(@"^(?=.{4,20}$)(?![-.])(?!.*[-.]{2})[a-zA-Z0-9._]+(?<![-.])$");
            Match match = reguser.Match(matchstring);
            if (match.Success == true) { return true; }
            else { return false; }
        }
        /*public bool name_family_regex(string matchstring)
        {
            matchstring.Trim();
            Regex regname_family = new Regex(@"^(\\b[A-Za-z]*\\b\\s+\\b[A-Za-z]*\\b+\\.[A-Za-z])$");
            Match match = regname_family.Match(matchstring);
            if(match.Success == true) { return true; }
            else { return false; }
        }*/
        public bool password_regex(string matchstring)
        {
            matchstring.Trim();
            var hasNumber_ = new Regex(@"[0-9]+"); // numbers.
            var hasUpperChar_ = new Regex(@"[A-Z]+"); // uppercase
            var hasMiniMaxChars_ = new Regex(@".{8,15}"); // length
            var hasLowerChar_ = new Regex(@"[a-z]+"); // lowercase
            var hasSymbols_ = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"); // symbols
            var Validate = hasNumber_.IsMatch(matchstring) && hasUpperChar_.IsMatch(matchstring) && hasLowerChar_.IsMatch(matchstring) && hasMiniMaxChars_.IsMatch(matchstring)
                || hasSymbols_.IsMatch(matchstring);
            if (Validate == true) { return true; }
            else { return false; }
        }
    }
    public class LinkColorChange
    {
        public static Color defaultcolor(Label l)
        {
            return l.ForeColor = Color.Black;
        }
        public static Color HoveredColor(Label l)
        {
            return l.ForeColor = Color.FromArgb(0, 192, 192);
        }
    }
    public class setLink
    {
        public static Process Linkset(string linkadress)
        {
            return Process.Start(linkadress);
        }
    }
    public class StandardPassword
    {
        public static string GeneratePassword(bool Lowercase, bool Uppercase, bool Numerics, bool Specials)
        {
            StringBuilder password_result = new StringBuilder();
            // Generate a standard password and return;
            const string LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
            const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMERIC_CHARACTERS = "0123456789";
            const string SPECIAL_CHARACTERS = @"!#$%&*@\";
            const byte PASSWORD_LENGTH = 15;
            // ---------------------------------------;
            if (Lowercase) { password_result.Append(LOWERCASE_CHARACTERS); }
            if (Uppercase) { password_result.Append(UPPERCASE_CHARACTERS); }
            if (Numerics) { password_result.Append(NUMERIC_CHARACTERS); }
            if (Specials) { password_result.Append(SPECIAL_CHARACTERS); }
            //---------------------------------------;
            char[] password = new char[PASSWORD_LENGTH];
            byte GetlengthPassword = Convert.ToByte(password_result.Length); // read length of ourpassword Chars;
            Random random = new Random();
            for (int charpos = 0; charpos < PASSWORD_LENGTH; charpos++)
            {
                password[charpos] = password_result[random.Next(GetlengthPassword - 1)];
            }
            return String.Join(null , password);
        }
    }
    public class CurrentDateTime
    {
        public static DateTime setCurrent()
        {
            DateTime setDatetime = DateTime.Now;
            int year = setDatetime.Year;
            int month = setDatetime.Month;
            int day = setDatetime.Day;
            int hour = setDatetime.Hour;
            int min = setDatetime.Minute;
            int sec = setDatetime.Second;
            DateTime date = new DateTime(year, month, day, hour, min, sec);
            return date;
        }
    }
    public class ExamCreationDB // save data for database....
    {
        // maybe private get;
        public string Title { get; set; }
        public int ExamType { get; set; }
        public ushort Length { get; set; }
        public int ExamID { get; set; }
        public int Timeout { get; set; }
        public string[] CreateQuestion() // Creat question
        {
            string[] question_maker = new string[Length];
            for (int i = 0; i < Length; i++)
            {
                string text = String.Format("Enter question #{0}", i + 1);
                question_maker[i] = text;
            }
            return question_maker;
        }
    }
    // sql 
    public class SQL
    {
        private static SqlConnection sqlConnection;
        private static string FilePath = Path.GetFullPath(Environment.CurrentDirectory);
        private static string DatabaseName = "QuizClubDB.mdf";

        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + FilePath + @"\" + DatabaseName + ";Integrated Security=True";
        }
        public static void CreateNewUserAccount(string username, string password, string email)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand sqlCommand = new SqlCommand("CreateNewUser", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("username", username);
                    SqlParameter sqlParameter2 = new SqlParameter("password", password);
                    SqlParameter sqlParameter3 = new SqlParameter("emailid", email);
                    sqlCommand.Parameters.Add(sqlParameter1);
                    sqlCommand.Parameters.Add(sqlParameter2);
                    sqlCommand.Parameters.Add(sqlParameter3);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                    }
                    else
                    {
                        MessageBox.Show("User created");
                    }
                }
            }
        }
        public static bool checkEmailExists(string email)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("CheckEmailExists", sqlConnection))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter = new SqlParameter("email", email);
                    cmd.Parameters.Add(sqlParameter);
                    sqlConnection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static bool CheckUser(string username, string password)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UserCheck", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("username", username);
                    SqlParameter sqlParameter2 = new SqlParameter("password", password);
                    cmd.Parameters.Add(sqlParameter1);
                    cmd.Parameters.Add(sqlParameter2);
                    sqlConnection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        private static bool CheckIsFirstLogin;
        public static bool Check_IsFirstLogin(string username)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("isFirstLoginCheck", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("username_", username);
                    sqlConnection.Open();
                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            CheckIsFirstLogin = Convert.ToBoolean(datareader["IsFirstLogin"]);
                        }
                    }
                }
                // 1 = > true   0 = > false;
                // if form intero load    make   corrent user first login to false   ....
                return CheckIsFirstLogin;
            }

        }
        private static bool Set_IsFirstLogin_;
        public static bool Set_IsFristLogin(bool isCheck, string username)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SetFirstLoginCheck", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("isfirstlogin", isCheck);
                    SqlParameter sqlParameter2 = new SqlParameter("username", username);
                    cmd.Parameters.Add(sqlParameter1);
                    cmd.Parameters.Add(sqlParameter2);
                    sqlConnection.Open();
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        Set_IsFirstLogin_ = true;
                    }
                    else
                    {
                        Set_IsFirstLogin_ = false;
                    }
                }
                return Set_IsFirstLogin_;
            }
        }
        public static ArrayList ProfileInformation_Show(string username)
        {
            ArrayList ProfileInformation_array = new ArrayList();
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetProfileInformation", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("username", username);
                    cmd.Parameters.Add(sqlParameter1);
                    sqlConnection.Open();
                    using (SqlDataReader SqlDataReader = cmd.ExecuteReader())
                    {
                        while (SqlDataReader.Read())
                        {
                            // full name top of dashboard == 0;
                            ProfileInformation_array.Add(Convert.ToString(SqlDataReader["Firstname"] + " " + SqlDataReader["Lastname"]));
                            // username == 1
                            ProfileInformation_array.Add(Convert.ToString(SqlDataReader["Username"]));
                            // firstname == 2
                            ProfileInformation_array.Add(Convert.ToString(SqlDataReader["Firstname"]));
                            // Lastname == 3
                            ProfileInformation_array.Add(Convert.ToString(SqlDataReader["Lastname"]));
                            // phonenumber == 4
                            ProfileInformation_array.Add(Convert.ToString(SqlDataReader["Phonenumber"]));
                            // country == 5
                            ProfileInformation_array.Add(Convert.ToString(SqlDataReader["Country"]));
                        }
                    }
                }
                return ProfileInformation_array;
            }
        }
        public static bool ProfileInformation_Set(string username, string Firstname, string Lastname, string Phonenumber, string Country)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SetProfileInformation", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("username", username);
                    SqlParameter sqlParameter2 = new SqlParameter("firstname", Firstname);
                    SqlParameter sqlParameter3 = new SqlParameter("lastname", Lastname);
                    SqlParameter sqlParameter4 = new SqlParameter("phoneNumber", Phonenumber);
                    SqlParameter sqlParameter5 = new SqlParameter("country", Country);
                    cmd.Parameters.Add(sqlParameter1);
                    cmd.Parameters.Add(sqlParameter2);
                    cmd.Parameters.Add(sqlParameter3);
                    cmd.Parameters.Add(sqlParameter4);
                    cmd.Parameters.Add(sqlParameter5);
                    sqlConnection.Open();
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Information has been updated");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static bool PasswordExists(string password)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("PasswordExists", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("password", password);
                    cmd.Parameters.Add(sqlParameter1);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static bool ProfileImage_Set(string username, byte[] image)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SetprofileImage", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("username", username);
                    SqlParameter sqlParameter2 = new SqlParameter("profileImage", image);
                    cmd.Parameters.Add(sqlParameter1);
                    cmd.Parameters.Add(sqlParameter2);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;

                    }
                }
            }
        }
        public static Image ProfileImage_Show(string username)
        {
            PictureBox pictureBox = new PictureBox();
            dashboard_usercontrol dashboard_Usercontrol = new dashboard_usercontrol();
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("ShowProfileImage", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("username", username);
                    cmd.Parameters.Add(sqlParameter1);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                        byte[] img = sqlDataReader["Picture"] as byte[];
                        MemoryStream memoryStream = new MemoryStream(img);
                        pictureBox.Image = Image.FromStream(memoryStream);
                        return pictureBox.Image;
                    }
                    else
                    {
                        return pictureBox.Image = null;
                    }
                }
            }
        }
        public static bool CreateNewExam(string examTitle, string examDate, int timeout, int acctableNumber,
            int questionCounts, string username, int categoryID)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("CreateExam", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new[]
                    {
                        new SqlParameter("@examtitle",examTitle),
                        new SqlParameter("@examdate",examDate),
                        new SqlParameter("@examtimeout",timeout),
                        new SqlParameter("@acctablenumber",acctableNumber),
                        new SqlParameter("@questioncount",questionCounts),
                        new SqlParameter("@username",username),
                        new SqlParameter("@category_id",categoryID),
                    });
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        public static ArrayList ShowCategory()
        {
            ArrayList arrayList = new ArrayList();
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("ShowCategories", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {

                        arrayList.Add(sqlDataReader["CategoryName"]);
                    }
                }
                return arrayList;
            }
        }
        public static int GetExamID(string examTitle)
        {
            int ExamID;
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetExamID", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sqlParameter1 = new SqlParameter("examtitle", examTitle);
                    cmd.Parameters.Add(sqlParameter1);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                        ExamID = Convert.ToInt32(sqlDataReader["Exam_ID"]);
                        return ExamID;
                    }
                    else
                    {
                        return -1;
                    }

                }
            }
        }
        public static string GetExamCatName(int id)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetExamName", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("catID", id);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();

                        return sqlDataReader["CategoryName"] as string;
                    }
                    else
                    {
                        // there is no shit in database
                        return "Default";
                    }
                }
            }
        }
        public static bool CreateQuestion(string questionTitle, int examID, string option1, string option2, string option3, string option4, int answer)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("CreateQuestion", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new[]
                    {
                        new SqlParameter("question_title",questionTitle),
                        new SqlParameter("examID",examID),
                        new SqlParameter("option1",option1),
                        new SqlParameter("option2",option2),
                        new SqlParameter("option3",option3),
                        new SqlParameter("option4",option4),
                        new SqlParameter("answer",answer),
                    });
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        public static Tuple<ArrayList, ArrayList, ArrayList, ArrayList> GetExamInformation()
        {
            // send this data
            ArrayList ExamTitle = new ArrayList();
            ArrayList QuestionCount = new ArrayList();
            ArrayList Category = new ArrayList();
            ArrayList Creator = new ArrayList();

            int CategoryID;

            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetExamInformation", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        ExamTitle.Add(sqlDataReader["ExamTitle"]);
                        QuestionCount.Add(sqlDataReader["QuestionCount"]);
                        // we need read each id -> convert to name;
                        CategoryID = Convert.ToInt32(sqlDataReader["CategoryID"]);

                        Category.Add(SQL.GetExamCatName(CategoryID));
                        Creator.Add(sqlDataReader["Username"]);
                    }
                    return new Tuple<ArrayList, ArrayList, ArrayList, ArrayList>(ExamTitle, QuestionCount, Category, Creator);
                }
            }
        }
        public static ArrayList GetExamSingleInformation(int id)
        {
            ArrayList SingleExamInformation = new ArrayList();
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetExamSingleInformation", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("examid", id);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        SingleExamInformation.Add(sqlDataReader["ExamTitle"]);
                        SingleExamInformation.Add(sqlDataReader["Username"]);
                        SingleExamInformation.Add(sqlDataReader["QuestionCount"]);
                        SingleExamInformation.Add(sqlDataReader["TimeOut"]);
                        // ----

                    }
                    return SingleExamInformation;
                }
            }
        }
        public static Tuple<ArrayList, ArrayList, ArrayList, ArrayList, ArrayList, ArrayList, ArrayList> GetExamQuestions(int id)
        {
            ArrayList questionTitle = new ArrayList();
            ArrayList option1 = new ArrayList();
            ArrayList option2 = new ArrayList();
            ArrayList option3 = new ArrayList();
            ArrayList option4 = new ArrayList();
            ArrayList Answer = new ArrayList();
            ArrayList questionID = new ArrayList();

            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SelectexamQuestions", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("examid", id);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        questionID.Add(sqlDataReader["QuestionID"]);
                        questionTitle.Add(sqlDataReader["QuestionTitle"]);
                        option1.Add(sqlDataReader["Option1"]);
                        option2.Add(sqlDataReader["option2"]);
                        option3.Add(sqlDataReader["option3"]);
                        option4.Add(sqlDataReader["option4"]);
                        Answer.Add(sqlDataReader["Answer"]);
                    }
                }
                return new Tuple<ArrayList, ArrayList, ArrayList, ArrayList, ArrayList, ArrayList, ArrayList>(questionTitle, option1, option2, option3, option4, Answer, questionID);
            }
        }
        public static void CreateUserAnswer(int questionID, string username, int answer, int ExamID)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("CreateUserAnswer", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new[]
                    {
                        new SqlParameter("questionID",questionID),
                        new SqlParameter("username",username),
                        new SqlParameter("answer",answer),
                        new SqlParameter("examId",ExamID)
                    }
                    );
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                }
            }
        }
        public static void IncreaseExamCount(string username)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("ExamCount", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("username", username);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                }
            }
        }
        public static bool ISFirstExam(string username)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("isThisFirstExam", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("username", username);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        // mean first exam
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static Tuple<ArrayList, ArrayList> GetUserAnswer(string username, int examID)
        {
            ArrayList questionID = new ArrayList();
            ArrayList answer = new ArrayList();
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetUserAnswer", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("examid", examID);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        questionID.Add(sqlDataReader["questionID"]);
                        answer.Add(sqlDataReader["answer"]);
                    }
                    return new Tuple<ArrayList, ArrayList>(questionID, answer);
                }
            }
        }
        public static int GetExamScore(int examID)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetExamScore", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("examid", examID);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    sqlDataReader.Read();
                    return Convert.ToInt32(sqlDataReader["AcctableScore"]);
                }
            }
        }
        public static void InsertExamResult(int examid , string username, int score ,string commend)
        {
            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertExamResult", sqlConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("score", score);
                    cmd.Parameters.AddWithValue("examid", examid);
                    cmd.Parameters.AddWithValue("commend", commend);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                }
            }
        }
    }
}
