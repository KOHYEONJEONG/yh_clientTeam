using StudentProgramMain.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// id: tjdals0231
/// pwd: alfl02@!
/// name:홍성민
/// </summary>
namespace StudentProgramMain
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static SessionManager sessionManager;//보내는 용도
        public static PacketManager packetManager;


        public static LoginForm loginForm;

        public int loginCheck
        {
            get; set;
        }

        SS_LoginResult _ss_LoginResult;
        public SS_LoginResult ss_LoginResult
        {
            get { return _ss_LoginResult; }
            set { _ss_LoginResult = value; }
        }


        public LoginForm()
        {
            InitializeComponent();
            sessionManager = new SessionManager();
            packetManager = new PacketManager();
            loginForm = this;
            loginCheck = 0;
            
        }
        public int exit = 1;


        private void LoginForm_Load(object sender, EventArgs e)
        {
            //글자수 제한
            this.txt_id.MaxLength = 32;
            this.txt_pw.MaxLength = 32;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

            IPAddress ip = IPAddress.Parse("49.247.149.125");
            IPEndPoint endPoint = new IPEndPoint(ip, 7777);
            Connector connector = new Connector();
            connector.Connect(endPoint, () => { return sessionManager.Generate(); });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals("") || txt_pw.Text.Equals(""))
            {
                if (txt_id.Text.Equals(""))
                {
                    MessageBox.Show("ID를 입력해주세요.");
                    txt_id.Focus();
                }
                else
                {
                    if (txt_pw.Text.Equals(""))
                    {
                        MessageBox.Show("password를 입력해주세요.");
                        txt_pw.Focus();
                    }
                }
            }
            else
            {

                //  pw 유효성 검사 후 로그인 
                if (CheckPassword())  //!
                {

                    sessionManager.LoginSend(txt_id.Text, txt_pw.Text);
                 
                    exit = 0;
                    this.Hide();                    
                }
                else
                {

                    //특수문자 중 !,@외 문자가 들어 있을 경우.
                    txt_pw.Text = "";
                    txt_pw.Focus();
                }

            }
        }

        //유효성검사
        public bool CheckPassword()
        {
            string idChecker = Regex.Replace(txt_pw.Text, @"[^0-9a-zA-Z!@ ]{1,32}", "", RegexOptions.Singleline);


            if (txt_pw.Text.Equals(idChecker) == false)
            {

                txt_pw.Text.Remove(0, txt_pw.Text.Length);

                txt_pw.Text = "";
                txt_pw.Focus();
                MessageBox.Show("특수문자(!,@는 제외)\n공백은 허용되지 않습니다..");
                return false;

            }
            else
            {
                return true;
            }



        }//CheckPassword

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == 0)
            {
                return;
            }

            else if(exit == 1)
            {
                if (MessageBox.Show("알림창", "학습 도우미 프로그램을 종료하시나요?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.ExitThread();
            }
        }
        public Timer _loginCheckTimer
        {
            get { return loginCheckTimer; }
            set { loginCheckTimer = value; }
        }

        private void loginCheckTimer_Tick(object sender, EventArgs e)
        {
            
            if (loginCheck == 1)//로그인 성공
            {
                
                loginCheckTimer.Enabled = false;
                
                student_main studentMain = new student_main(ss_LoginResult.lectures, ss_LoginResult.studentID, ss_LoginResult.name);
                try
                {
                    //MessageBox.Show("로그인 성공");
                    studentMain.ShowDialog();
                }
                catch
                {

                }
                if (loginCheck == 4)//수업 없음
                {
                    MessageBox.Show("수업이 없습니다");
                    Application.ExitThread();
                }
                exit = 0;
                //Application.ExitThread();
            }
            else if (loginCheck == 2)//로그인 실패
            {
                //MessageBox.Show("아이디 및 비밀번호를 다시 확인해주세요.");
                LoginForm.loginForm.Show();
                loginCheck = 0;
            }



        }
        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pw.Focus();
            }
        }

        private void txt_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
