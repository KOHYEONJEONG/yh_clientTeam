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
        public static student_main studentMain;
        public student_main(List<SS_LoginResult.Lecture> lectures, string studentId, string studentName)
        {
            InitializeComponent();
            studentMain = this;
            if(!get_lecture_stdent(lectures, studentId, studentName))
            {
                LoginForm.loginForm.loginCheck = 4;
                this.Close();
            }
            SetSize(lbl_subject);
        }

        SS_LoginResult.Lecture lecture;
    
        public string No { get; set; } //학생번호
        public string name { get; set; } //학생이름
        public string professorID { get; set; }//교수번호
        public string subject { get; set; }//교과목
        public string weekDay { get; set; }//요일
        public string start { get; set; }//시작시간
        public string end { get; set; }//끝나는 시간
        
        private void student_main_Load(object sender, EventArgs e)
        {

            btn_absent.Enabled = false;
           
            clock.Start(); //현재시간 타이머
            lblNo.Text = No;
            lbl_name.Text = name;
            lbl_day.Text = lecture.weekday;
            lbl_start.Text = lecture.strat_time;
            lbl_end.Text = lecture.end_time;
            lbl_subject.Text = lecture.lecture_name;
            lbl_period.Text = lecture.professor_id;

        }

        private bool get_lecture_stdent(List<SS_LoginResult.Lecture> lectures, string studentId, string studentName)//해당하는 수업 가져오고, 수업 듣는 학생 리스트 가져옴
        {
            //수정 필 필
            //String nowtime = DateTime.Now.ToString("HHmm");
            //String day = getDay();
            String nowtime = DateTime.Now.ToString("1205");
            String day = "수";
            No = studentId;
            name = studentName;
            foreach (var l in lectures)
            {
                if (Convert.ToInt32(l.strat_time) <= Convert.ToInt32(nowtime) && Convert.ToInt32(l.end_time) >= Convert.ToInt32(nowtime))
                {

                    if (l.weekday == day)
                    {

                        lecture = l;
                    }
                }
            }
            if (lecture == null)
            {
                return false;
            }
         

            Timer.Enabled = true;

            return true;

        }

        //글씨체 조정 함수
        public void SetSize(Label label)
        {
            string text = label.Text;
            if (text.Length > 7)
            {
                Font fs = new Font(lbl_subject.Font.Name, 10, FontStyle.Bold);
                lbl_subject.Font = fs;

            }
            else
            {
                // Font fb = new Font(lbl.Font.Name, 20,FontStyle.Bold);
                //Font fb = new Font(lbl.Font.Name, 20);
                //lbl.Font = fb;
            }
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
        private string getDay()
        {
            DateTime now = DateTime.Now;
            string day;

            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    day = "월";
                    break;
                case DayOfWeek.Tuesday:
                    day = "화";
                    break;
                case DayOfWeek.Wednesday:
                    day = "수";
                    break;
                case DayOfWeek.Thursday:
                    day = "목";
                    break;
                case DayOfWeek.Friday:
                    day = "금";
                    break;
                case DayOfWeek.Saturday:
                    day = "토";
                    break;
                case DayOfWeek.Sunday:
                    day = "일";
                    break;
                default:
                    day = "일";
                    break;
            }

            return day;
        }


        //시간표
        //Student_Schedule sS = new Student_Schedule();
        //sS.Show();

        private void button4_Click(object sender, EventArgs e)
        {
            lblNo.Text = No;
            lbl_name.Text = name;
            lbl_day.Text = lecture.weekday;
            lbl_start.Text = lecture.strat_time;
            lbl_end.Text = lecture.end_time;
            lbl_subject.Text = lecture.lecture_name;
            lbl_period.Text = lecture.professor_id;
        }
    }
}
