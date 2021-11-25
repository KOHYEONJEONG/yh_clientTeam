using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PClient;
using System.Net;


namespace ProgramMain
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static SessionManager sessionManager;
        public static PacketManager packetManager;
        public static LoginForm loginForm;
        public int loginCheck
        {
            get; set;
        }

        SP_LoginResult _sp_LoginResult;
        public SP_LoginResult sp_LoginResult
        {
            get { return _sp_LoginResult; }
            set { _sp_LoginResult = value; }
        }
        

        public LoginForm()
        {
            InitializeComponent();

            sessionManager = new SessionManager();
            packetManager = new PacketManager();
            loginForm = this;
            loginCheck = 0;
        }

        Boolean exit = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            //글자수 제한
            this.txt_id.MaxLength = 32;
            this.txt_pw.MaxLength = 32;


            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

            // 프로그램 실행할때 세션 매니저, 패킷 매니저 객체 생성


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
            if (!exit)
            {
                return;
            }

            else
            {

                if (MessageBox.Show("알림창", "학습 도우미 프로그램을 종료하시나요?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
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
                ProfesserMain professerMain = new ProfesserMain(sp_LoginResult.lectures,sp_LoginResult.students);
                loginCheckTimer.Enabled = false;
                try
                {
                    professerMain.ShowDialog();
                }
                catch
                {

                }
                if (loginCheck == 4)//수업 없음
                {
                    MessageBox.Show("수업이 없습니다");
                }
                exit = false;
                Application.ExitThread();
            }
            else if (loginCheck == 2)//로그인 실패
            {
                LoginForm.loginForm.Show();
                loginCheck = 0;
            }
            
        }

        private void txt_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}
