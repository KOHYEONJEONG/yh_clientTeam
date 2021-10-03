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

        int TNum = 15; //타이머 진행 숫자
                       // string OrgStr = "";


        private void VisibleChange(bool FormVisible, bool TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nfiTray.Visible = TrayIconVisible;
        }


        private void student_main_Load(object sender, EventArgs e)
        {
             // this.lbl_timer.Text = OrgStr; //타이머 시간 확인용 라벨(후에 삭제)
            btn_absent.Enabled = false; //출석 버튼 비활성화
            btn_logout.Enabled = false;
            btn_quit.Enabled = false;

        }

        private void btn_absent_Click(object sender, EventArgs e)
        {
            //System.DateTime.Now.ToString("yyyy");
            string date = System.DateTime.Now.ToString("HH:mm:ss");
            //this.lbl_check.Text = date;

            this.Timer.Enabled = false;
            if (10 <= TNum)
            {
                //this.lbl_check.Text = "출 석 " + date;
                btn_absent.Text =  "출 석" +date;
                button1.Enabled = false;
            }
            else if (1 <= TNum)
            {
                //this.lbl_check.Text = "지 각 " + date;
                btn_absent.Text = "지 각" + date;
                button1.Enabled = false;
            }
            else if (0 == TNum)
            {
                //this.lbl_check.Text = "결 석 " + date;
                btn_absent.Text = "결 석" + date;
                button1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e) //교수님이 출석 활성화 버튼 클릭했을 때
                                                                //대신하는 예비용 버튼
        {
            this.btn_absent.ForeColor = Color.FromArgb(255, 255, 255);
            this.Timer.Enabled = true;
            btn_absent.Enabled = true;
            this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);
            button1.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lbl_timer.Text = "" + TNum; //예비용 타이머 시각 확인
            TNum--; //0~5분 : 출석 5분~15분 : 지각 15분 이후 : 결석 처리
           if(TNum < 0)
            {
                this.Timer.Enabled = false;
                return;
            }
            if (10 <= TNum)
            {
                this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);
                
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

        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            Student_askf ask = new Student_askf();
            ask.Show();
        }

        private void student_main_VisibleChanged(object sender, EventArgs e)
        {       
        }
       
      //  private void 열기toolStripMenuItem1_Click(object sender, EventArgs e)
      //  {
      //      VisibleChange(true, false);
     //   }
        //tray에서 오른쪽 마우스 클릭으로 열기 메뉴 클릭시 메인 폼 보임


        private void nfiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }
        //tray에서 유한대학교 아이콘 클릭시 메인 폼 보임


        private void student_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }
        //메인폼에서 닫기눌렀을 경우 tray로 이동

        private void cmsMenu_Opening(object sender, CancelEventArgs e)
        {

        }

       

    }
}
