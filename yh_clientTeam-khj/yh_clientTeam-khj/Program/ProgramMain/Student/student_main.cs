using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMain
{
<<<<<<< HEAD
    public partial class student_main : Form // 상속 클래스 변경
=======
    public partial class student_main : Form
>>>>>>> 84f1bcc3514678422dcca97cb8313b4516eeb706
    {
        public student_main()
        {
            InitializeComponent();

<<<<<<< HEAD
        private void student_main_Load(object sender, EventArgs e)
        {
             // this.lbl_timer.Text = OrgStr; //타이머 시간 확인용 라벨(후에 삭제)
            btn_absent.Enabled = false; //출석 버튼 비활성화, 교수님이 활성화하시면 눌리도록
            //btn_logout.Enabled = false; //로그아웃 버튼 비활성화 로그아웃 가능 시간(수업시간 종료 10분 전)
            //btn_quit.Enabled = false; //종료 버튼 비활성화 종료 가능 시간(수업시간 종료 10분 전)
            //btn_manager삭제
            //현재시간 타이머
            clock.Start();
=======
>>>>>>> 84f1bcc3514678422dcca97cb8313b4516eeb706
        }

        int TNum = 15; //타이머 진행 숫자
        string OrgStr = "";
       

        
        

        private void student_main_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //녹색으로 바꾸고 버튼 활성화
            this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);
            btn_absent.Enabled = true;
            //타이머 활성화
            this.Timer.Enabled = true; 
            //예비버튼 비활성화
            button1.Enabled = false;
        }

        int TNum = 900; //타이머 진행 숫자(출석시간)
                        // string OrgStr = "";

 
  

        //출석버튼 클릭했을 때 이벤트 코딩
=======
            this.lbl_timer.Text = OrgStr; //타이머 시간 확인용 라벨(후에 삭제)
            btn_absent.Enabled = false; //출석 버튼 비활성화
        }

>>>>>>> 84f1bcc3514678422dcca97cb8313b4516eeb706
        private void btn_absent_Click(object sender, EventArgs e)
        {
            
            //System.DateTime.Now.ToString("yyyy");
            string date = System.DateTime.Now.ToString("HH:mm:ss");

            this.Timer.Enabled = false;
            if (10 <= TNum)
            { 
                this.lbl_check.Text = "출 석 " + date;
                button1.Enabled = false;
            }
            else if (1 <= TNum)
            {
                this.lbl_check.Text = "지 각 " + date;
                button1.Enabled = false;
            }
            else if (0 == TNum)
            {
                this.lbl_check.Text = "결 석 " + date;
                button1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e) //교수님이 출석 활성화 버튼 클릭했을 때
                                                                //대신하는 예비용 버튼
        {
            this.Timer.Enabled = true;
            btn_absent.Enabled = true;
            this.btn_absent.BackColor = Color.FromArgb(128, 255, 128);
            button1.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //this.lbl_timer.Text = "" + TNum; //예비용 타이머 시각 확인
            TNum--; //0~5분 :출석  5분~15분 :지각   15분 이후 :결석 처리(900초)
=======
            this.lbl_timer.Text = "" + TNum; //예비용 타이머 시각 확인
            TNum--; //0~5분 : 출석 5분~15분 : 지각 15분 이후 : 결석 처리
>>>>>>> 84f1bcc3514678422dcca97cb8313b4516eeb706
           if(TNum < 0)
            {
                this.Timer.Enabled = false;
                return;
            }
            if (10 <= TNum)
            {
                this.btn_absent.BackColor = Color.FromArgb(128, 255, 128);
                
            }
            else if (1 <= TNum)
            {
                this.btn_absent.BackColor = Color.FromArgb(255, 128, 0);
                this.btn_absent.Text = "지 각";
            }
            else if( 0 == TNum)
            {
                this.btn_absent.BackColor = Color.FromArgb(239, 72, 72);
                this.btn_absent.Text = "결 석";
            }
        }

        private void lbl_check_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //현재시간 라벨
            //string clock = System.DateTime.Now.ToString("HH : mm");
            //this.lbl_clock.Text = clock;
            DateTime datetime = DateTime.Now;
            //this.lbl_clock.Text = datetime.ToString("HH : mm");
        }
=======
>>>>>>> 84f1bcc3514678422dcca97cb8313b4516eeb706

        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            Student_askf ask = new Student_askf();
            ask.Show();
        }
<<<<<<< HEAD


        //트레이아이콘을 위한 함수
        private void VisibleChange(bool FormVisible, bool TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nfiTray.Visible = TrayIconVisible;
        }


        //트레이아이콘을 위한 메뉴바
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }


        //tray에서 오른쪽 마우스 클릭으로 열기 메뉴 클릭시 메인 폼 보임
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }


        //tray에서 유한대학교 아이콘 더블클릭시 메인 폼 보임
        private void nfiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }
       

        //메인폼에서 닫기눌렀을 경우 tray로 이동
        private void student_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }


        //정보관리 버튼 클릭 시 이벤트
        private void btn_manager_Click(object sender, EventArgs e)
        {
            //자식폼(정보관리) 호출
            student_manager smanager = new student_manager();

            //자식폼 이벤트 호출하기
            smanager.childFormEvent += EventMethod;

            //자식폼 show
            smanager.ShowDialog();
        }


        //정보관리를 위한 이벤트 메소드
        public void EventMethod(string a, string b, string c, string d, string e, string f)
        {
            //lbl_hak.Text = a.ToString();
            lbl_name.Text = b.ToString();
            lbl_subject.Text = c.ToString();
            lbl_day.Text = d.ToString();
            lbl_period.Text = (e.ToString() + "교시")  ;
            lbl_classhour.Text = f.ToString();
        }


       

       








        //==================================================================================================
        //==================================================================================================
        private void lbl_check_Click(object sender, EventArgs e)
        {
        }
        private void student_main_VisibleChanged(object sender, EventArgs e)
        {
        }
        private void cmsMenu_Opening(object sender, CancelEventArgs e)
        {
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void lbl_classhour_Click(object sender, EventArgs e)
        {

        }

        private void lbl_period_Click(object sender, EventArgs e)
        {

        }

        private void lbl_day_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 84f1bcc3514678422dcca97cb8313b4516eeb706
    }
}
