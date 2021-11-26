using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ProgramMain
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static SessionManager sessionManager;
        public static PacketManager packetManager;
        public LoginForm()
        {
            InitializeComponent();
            sessionManager = new SessionManager();
            packetManager = new PacketManager();
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

                    if (txt_id.Text.Equals("p") && txt_pw.Text.Equals("1234"))
                    {
                        exit = false;

                       
                        (new ProfesserMain()).Show();
                        this.Close();

                    }
                    else
                    {
                        if (txt_id.Text.Equals("s") && txt_pw.Text.Equals("1234"))
                        {
                            exit = false;

                            this.Hide();
                            //MessageBox.Show("학생프로그램", "확인", MessageBoxButtons.OK);
                            //student_main student = new student_main();
                            //student.Show();

                            //(new student_main()).Show();

                            this.Close();

                        }
                    }
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

        private void txt_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
