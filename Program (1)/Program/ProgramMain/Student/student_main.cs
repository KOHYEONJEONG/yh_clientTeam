using ProgramMain.Student;
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
    public partial class student_main : Form
    {
        public student_main()
        {
            InitializeComponent();
        }


        private void student_main_Load(object sender, EventArgs e)
        {
             // this.lbl_timer.Text = OrgStr; //타이머 시간 확인용 라벨(후에 삭제)
            btn_absent.Enabled = false; //출석 버튼 비활성화, 교수님이 활성화하시면 눌리도록
            btn_logout.Enabled = false; //로그아웃 버튼 비활성화 로그아웃 가능 시간(수업시간 종료 10분 전)
            btn_quit.Enabled = false; //종료 버튼 비활성화 종료 가능 시간(수업시간 종료 10분 전)
            //현재시간 타이머
            clock.Start();
        }


        private void button1_Click(object sender, EventArgs e) //교수님이 출석 활성화 버튼 클릭했을 때
                                                               //대신하는 예비용 버튼
        {
            //녹색으로 바꾸고 버튼 활성화
            this.btn_absent.ForeColor = Color.FromArgb(255, 255, 255); this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);
            btn_absent.Enabled = true;
            //타이머 활성화
            this.Timer.Enabled = true; 
            //예비버튼 비활성화
            button1.Enabled = false;
        }

        int TNum = 900; //타이머 진행 숫자(출석시간)
                       // string OrgStr = "";

        //출석버튼 클릭했을 때 이벤트 코딩
        private void btn_absent_Click(object sender, EventArgs e)
        {
            //System.DateTime.Now.ToString("yyyy");
            //출석 버튼 클릭했을때 클릭한 시간 나타내기
            string date = System.DateTime.Now.ToString("HH:mm:ss");
            //타이머 비활성화
            this.Timer.Enabled = false;

            // TNum(타이머 제한 시간)에 따라 출석, 지각, 결석 분류
            if (600 <= TNum)
            {  
                btn_absent.Text =  "출 석" + date;
                button1.Enabled = false;
            }
            else if (0 < TNum && TNum < 600)
            { 
                btn_absent.Text = "지 각" + date;
                button1.Enabled = false;
            }
            else if (TNum == 0)
            {
                btn_absent.Text = "결 석" + date;
                button1.Enabled = false;
            }
        }

        //출석 시간에 대한 타이머 계산
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lbl_timer.Text = "" + TNum; //예비용 타이머 시각 확인
            TNum--; //0~5분 :출석  5분~15분 :지각   15분 이후 :결석 처리(900초)
           if(TNum < 0)
            {
                this.Timer.Enabled = false;
                return;
            }
            if (600 <= TNum )
            {
                this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);
                
            }
            else if (0 < TNum && TNum < 600)
            {
                this.btn_absent.BackColor = Color.FromArgb(255, 128, 0);
                this.btn_absent.Text = "지 각";
            }
            else if( TNum == 0)
            {
                this.btn_absent.BackColor = Color.FromArgb(239, 72, 72);
                this.btn_absent.Text = "결 석";
            }
        }

        //현재시간 계산
        private void clock_Tick(object sender, EventArgs e)
        {
            //현재시간 라벨
            //string clock = System.DateTime.Now.ToString("HH : mm");
            //this.lbl_clock.Text = clock;
            DateTime datetime = DateTime.Now;
            this.lbl_clock.Text = datetime.ToString("HH : mm");
        }


        //질문버튼 클릭했을때 질문폼 나타나기
        private void btn_ask_Click(object sender, EventArgs e)
        {
            Student_askf ask = new Student_askf();
            ask.Show();
        }


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
            lbl_hak.Text = a.ToString();
            lbl_name.Text = b.ToString();
            lbl_subject.Text = c.ToString();
            lbl_day.Text = d.ToString();
            lbl_period.Text = (e.ToString() + "교시")  ;
            lbl_classhour.Text = f.ToString();
        }


        //quit 버튼 클릭했을때 종료
        private void btn_quit_Click(object sender, EventArgs e)
        { 
                Application.Exit();
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
    }
}
