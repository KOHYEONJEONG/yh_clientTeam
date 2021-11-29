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
    // 여기 메인폼에서는 출석체크, 시간표보기, 질문 들어오면 받는 폼.
    // 질문보내는것은 폼열어서 보내면 됨.
    
    public partial class student_main : Form
    {
        public static student_main studentMain;
        List<SS_LoginResult.Lecture> _lectures;
        public Timer _atdTimer
        {
            get { return atdTimer; }
            set { atdTimer = value; }
        }
        public Button _btn_absent
        {
            get { return btn_absent; }
            set { btn_absent = value; }
        }

        SS_LoginResult.Lecture lecture;

         
        public SS_AtdRequest atdRequest
        {
            get;
            set;
        }


        public student_main(List<SS_LoginResult.Lecture> lectures, string studentId, string studentName)
        {
            InitializeComponent();
            studentMain = this;
            atdRequest = new SS_AtdRequest();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (!get_lecture_stdent(lectures, studentId, studentName))
            {
                LoginForm.loginForm.loginCheck = 4;
                this.Close();
            }
            _lectures = lectures;
            SetSize(lbl_subject);
        }
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
        

        #region Student_answer.cs폼 열기위해서
        public int quizcheck;//Student_answer.cs폼 열기위한 신호 변수
        SS_Quiz _ss_quiz;//Student_answer.cs폼 생성자에 값을 전달하기 위해서 
        public SS_Quiz ss_Quiz
        {
            get { return _ss_quiz; }
            set { _ss_quiz = value; }
        }
        SS_QuizOX _ss_quizOX;//StudentOX.cs폼 생성자에 값을 전달하기 위해서 
        public SS_QuizOX ss_QuizOX
        {
            get { return _ss_quizOX; }
            set { _ss_quizOX = value; }
        }
        #endregion       
       
    
      public string No { get; set; } //학생번호
        public string name { get; set; } //학생이름
/*        public string professorID { get; set; }//교수번호
        public string subject { get; set; }//교과목
        public string weekDay { get; set; }//요일
        public string start { get; set; }//시작시간
        public string end { get; set; }//끝나는 시간*/
        
        private void student_main_Load(object sender, EventArgs e)
        {

            btn_absent.Enabled = false;
           
            clock.Start(); //현재시간 타이머
            lblNo.Text = No;
            lbl_name.Text = name;
            lbl_day.Text = lecture.weekday+"요일";
            //MessageBox.Show(lecture.strat_time.Length.ToString());
            lbl_start.Text = lecture.strat_time.Substring(0, 2) + ":"+ lecture.strat_time.Substring(2, 2);
            lbl_end.Text = lecture.end_time.Substring(0, 2) +":"+ lecture.end_time.Substring(2,2);
            lbl_subject.Text = lecture.lecture_name;
            lbl_period.Text = lecture.professor_id+"교수님";//교수님 성함

        }

        private bool get_lecture_stdent(List<SS_LoginResult.Lecture> lectures, string studentId, string studentName)//해당하는 수업 가져오고, 수업 듣는 학생 리스트 가져옴
        {
            //수정 필 필
            String nowtime = DateTime.Now.ToString("HHmm");
            String day = getDay();
            //String nowtime = DateTime.Now.ToString("1205");
            //String day = "수";
            No = studentId;
            name = studentName;

            quizcheck = 0;//student_answer폼 신호



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

            

            return true;

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Student_Schedule schedule = new Student_Schedule(_lectures);
            
            schedule.Show();
          
        }

      

        //int TNum = 900; //타이머 진행 숫자(출석시간)

        private void btn_absent_Click(object sender, EventArgs e)
        {
            btn_absent.Enabled = false;
            LoginForm.sessionManager.AtdSend(atdRequest.week, 1, atdRequest.classTime);            
            //System.DateTime.Now.ToString("yyyy");
            //출석 버튼 클릭했을때 클릭한 시간 나타내기
            //string date = DateTime.Now.ToString("HHmm");
            //타이머 비활성화
            //this.atdTimer.Enabled = false;

            //int atd = 0;

            // TNum(타이머 제한 시간)에 따라 출석, 지각, 결석 분류
            /*if (600 <= TNum)
            {
                btn_absent.Text = "출 석" + date;
                //button1.Enabled = false;
                atd = 1;
            }
            else if (0 < TNum && TNum < 600)
            {
                btn_absent.Text = "지 각" + date;
               // button1.Enabled = false;
                atd = 2;
            }
            else if (TNum == 0)
            {
                btn_absent.Text = "결 석" + date;
               // button1.Enabled = false;
                atd = 0;
            }*/

            

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //this.lbl_timer.Text = "" + TNum; //예비용 타이머 시각 확인
            //TNum--; //0~5분 :출석  5분~15분 :지각   15분 이후 :결석 처리(900초)
            //if (TNum < 0)
            //{
            //    this.atdTimer.Enabled = false;
            //    return;
            //}
            //if (600 <= TNum)
            //{
            //    this.btn_absent.BackColor = Color.FromArgb(0, 163, 133);

            //}
            //else if (0 < TNum && TNum < 600)
            //{
            //    this.btn_absent.BackColor = Color.FromArgb(255, 128, 0);
            //    this.btn_absent.Text = "지 각";
            //}
            //else if (TNum == 0)
            //{
            //    this.btn_absent.BackColor = Color.FromArgb(239, 72, 72);
            //    this.btn_absent.Text = "결 석";
            //}


            // 교수님 질문오면( 핸들러 -> quizcheck신호 주고 -> 열기 )
            if (quizcheck == 1)
            {
                quizcheck = 0;
                Student_answer sa = new Student_answer(ss_Quiz);
                sa.ShowDialog();                
            }
            else if(quizcheck == 2)
            {
                quizcheck = 0;
                StudentOX sa = new StudentOX(ss_QuizOX);
                sa.ShowDialog();                
            }

            Click_Statck = 0;
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

        public bool isClosing = false;
        private void student_main_FormClosing(object sender, FormClosingEventArgs e)
        {  
            if (isClosing)
            {
                LoginForm.loginForm.exit = 2;
                LoginForm.loginForm.Close();
            }
            else
            {
                e.Cancel = true;
                VisibleChange(false, true);
            }
            
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_askf ask = new Student_askf();
            ask.ShowDialog();
            this.Show();
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

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_start_Click(object sender, EventArgs e)
        {

        }

        int Click_Statck = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Click_Statck++;
            if (Click_Statck > 6)
            {
                waterBtn.Visible = true;
            }           
        }

        private void waterBtn_Click(object sender, EventArgs e)
        {
            waterBtn.Visible = false;
            viewBtn.Enabled = true;
            Click_Statck = 0;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            Click_Statck++;
            if (Click_Statck > 7)
            {
                viewBtn.Text = "┣┿┿┿┿┿┿┿┿┿┿┿┿┿┿┿┿┤";
                
                this.isClosing = true;
            }
            else
            {
                viewBtn.Text = "수업중";
            }
        }

        private void lblNo_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
