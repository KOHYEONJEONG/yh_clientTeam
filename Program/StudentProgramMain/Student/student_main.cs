using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramMain.Student
{
    public partial class student_main : Form
    {
        public student_main()
        {
            InitializeComponent();
        }

        private void student_main_Load(object sender, EventArgs e)
        {
            btn_absent.Enabled = false;
            //현재시간 타이머
            clock.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //녹색으로 바꾸고 버튼 활성화
            this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);
            btn_absent.Enabled = true;
            //타이머 활성화
            this.Timer.Enabled = true;
            //예비버튼 비활성화
            button1.Enabled = false;
        }

        int TNum = 900; //타이머 진행 숫자(출석시간)

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
                btn_absent.Text = "출 석" + date;
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            //this.lbl_timer.Text = "" + TNum; //예비용 타이머 시각 확인
            TNum--; //0~5분 :출석  5분~15분 :지각   15분 이후 :결석 처리(900초)
            if (TNum < 0)
            {
                this.Timer.Enabled = false;
                return;
            }
            if (600 <= TNum)
            {
                this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);

            }
            else if (0 < TNum && TNum < 600)
            {
                this.btn_absent.BackColor = Color.FromArgb(255, 128, 0);
                this.btn_absent.Text = "지 각";
            }
            else if (TNum == 0)
            {
                this.btn_absent.BackColor = Color.FromArgb(239, 72, 72);
                this.btn_absent.Text = "결 석";
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            //Student_askf ask = new Student_askf();
           // ask.Show();
        }
        // string OrgStr = "";

        //트레이아이콘을 위한 함수
        private void VisibleChange(bool FormVisible, bool TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nfiTray.Visible = TrayIconVisible;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void nfiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }

        private void student_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
             Student_askf ask = new Student_askf();
             ask.Show();
        }
    }
}
