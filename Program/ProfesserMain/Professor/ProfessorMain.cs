using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PClient;

namespace ProgramMain
{
    public partial class ProfesserMain : Form
    {
        public static ProfesserMain professerMain ;

        /*
        List<SP_StudentInfo.Student> _infoStudent = new List<SP_StudentInfo.Student>();
        public List<SP_StudentInfo.Student> infoStudent
        {
            get { return _infoStudent; }
            set { _infoStudent = value; }
        }*/

        /*
        String[,] teststu = {   {"000000001","가나다" }, // 서버에서 받아올 시 1열 추가 후 접속여부 저장
                                {"000000002","라마바" },
                                {"000000003","아자차" } };*/

        private String Sstime = DateTime.Now.ToString("g"); // 현재 시간

        private SP_LoginResult.Lecture lecture; //강의 정보(Lecture)
        private List<SP_LoginResult.Student> student = new List<SP_LoginResult.Student>(); // 학생정보(Student) 리스트

        private List<String> checkstu = new List<string>(); // 체크박스 선택된 학생id 리스트

        public DataGridView _studList 
        {// 학생 목록 DataGridView
            get { return studList; }
            set { _studList = studList; }
        }

        public ProfesserMain(List<SP_LoginResult.Lecture> lectures , List<SP_LoginResult.Student> students) //1.LoginForm에서 넘어옴
        {
            InitializeComponent();
            professerMain = this;
            get_lecture_stdent(lectures,students);//2.
        }

        private void get_lecture_stdent(List<SP_LoginResult.Lecture> lectures, List<SP_LoginResult.Student> students) //3.해당하는 수업 가져오고, 수업 듣는 학생 리스트 가져옴
        {
            //수정 필 필
            //String nowtime = DateTime.Now.ToString("HHmm");
            //String day = getDay(); //요일 찾기
            String nowtime = DateTime.Now.ToString("1205");
            String day = "수";
            foreach (var l in lectures) //강의 
            {
                if (Convert.ToInt32(l.strat_time) <= Convert.ToInt32(nowtime) && Convert.ToInt32(l.end_time) >= Convert.ToInt32(nowtime))
                {   //시간 비교
                    if (l.weekday == day)
                    {
                        //요일 비교
                        lecture = l;
                    }
                }
            }
            if (lecture == null)
            {
                MessageBox.Show("수업이 없습니다");
                return;
            }

            foreach (var s in students) //학생
            {   //학생 정보-강의- 비교
                if(lecture.lecture_code == s.lectureCode)
                {   //학생 리스트에 학생 추가
                    student.Add(s);
                }
            } 
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

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {

        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Image img1 = Properties.Resources.sky1;
            //Image img2 = Properties.Resources.sky2;
            //Image img3 = Properties.Resources.sky3;
            //Image img4 = Properties.Resources.sky4;


            for (int i = 0; i < student.Count; i++) //리스트에 미접속 학생 추가
            {
                studList.Rows.Add(false, student[i].studentId, student[i].studentName, Properties.Resources.default1, "", "");
                studList.Rows[i].ReadOnly = true;//선택 안되게
                studList.Rows[i].Height = 20;//행 높이조절

                studList.Rows[i].Cells[0].Style.BackColor = Color.Gray;//셀 회색으로 변경
                studList.Rows[i].Cells[1].Style.BackColor = Color.Gray;
                studList.Rows[i].Cells[2].Style.BackColor = Color.Gray;
                studList.Rows[i].Cells[3].Style.BackColor = Color.Gray;
                studList.Rows[i].Cells[4].Style.BackColor = Color.Gray;
                studList.Rows[i].Cells[5].Style.BackColor = Color.Gray;


            }

            if (lecture != null)
            {
                className.Text = lecture.lecture_name;//수업이름 설정
                classTime.Text = "수업 시간: " + lecture.strat_time + "~" + lecture.end_time;//수업 시간 설정
                                                                                         //시간되면 자동 수업 시작하게 설정하기
            }
            LoginForm.sessionManager.StudentListRequset();
        }


        private void listView1_SelectedIndexChanged_2(object sender, System.EventArgs e)
        {

        }
        
        // 스크린샷 버튼 이벤트
        private void screenbtn_Click(object sender, EventArgs e)
        {
           
         }
        
        private void questionbtn_Click(object sender, EventArgs e)
        {
            //체크 되어있는 학생의 학번을 리스트에 추가
            checkStuAdd();

            QuestionForm questionForm = new QuestionForm(); // 질문 폼 띄우기
            questionForm.Show();

            checkstu.Clear();//체크된 학생 리스트 비우기

        }



        private void allcheck_CheckedChanged(object sender, EventArgs e)//천체 체크
        { 
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)//체크되어 있으면
            {
                for (int i = studList.Rows.Count -1 ; i >= 0; i--)
                {
                    studList.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = studList.Rows.Count - 1; i >= 0; i--)
                {
                    studList.Rows[i].Cells[0].Value = false;
                }
            }
        }
        
        private void checkStuAdd()
        {
            //체크 되어있는 학생의 학번을 리스트에 추가
            for (int i = studList.Rows.Count - 1; i >= 0; i--)
            {
                
                if ((bool)studList.Rows[i].Cells[0].Value)//체크여부 확인
                {
                    checkstu.Add(studList.Rows[i].Cells[1].Value as String);//리스트에 추가
                }
            }
        }

        private void stuList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
        }

        private void allscreenbtn_Click(object sender, EventArgs e)
        {
            //체크 되어있는 학생의 학번을 리스트에 추가
            checkStuAdd();

            ScreenshotsForm screenshotsForm = new ScreenshotsForm();
            screenshotsForm.Show();

            checkstu.Clear();//체크된 학생 리스트 비우기
        }

        private void attendbtn_Click(object sender, EventArgs e)
        {
            attendBtn.Visible = false;
                            //수업 시간 받고 교시마다 활성화 되게 해야 함
        }

        private void studList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }


        private void studList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;

            int curR = e.RowIndex;
            int curC = e.ColumnIndex;

            //셀 타입
            Type type = grid.Rows[curR].Cells[curC].GetType();

            //학생 정보
            String id = grid.Rows[curR].Cells[1].Value.ToString();
            String name = grid.Rows[curR].Cells[2].Value.ToString();

            //스크린샷 셀
            if(type == typeof(DataGridViewImageCell))
            {
                Bitmap img = (Bitmap)grid.Rows[curR].Cells[curC].Value;
                /* ImageForm 확인 */
                ImageForm img_form = new ImageForm(id, name, img);
                img_form.ShowDialog();
            }

            //응답 셀
            if (curC == 4)
            {
                String reply = grid.Rows[curR].Cells[curC].Value.ToString();
                if (reply != "" && reply != null) //응답 있을 경우에만 
                {
                    //질문유형
                    if(reply== "True" || reply== "False")
                    {
                        ReplyYNForm replyYNForm = new ReplyYNForm(id, name, reply);
                        replyYNForm.Show();
                    }
                    else
                    {
                        ReplyForm replyForm = new ReplyForm(id, name, reply);
                        replyForm.Show();
                    }
                }
                else
                {

                }
            }

        }

        private void attenddanceBtn_Click(object sender, EventArgs e)
        {
            /* 출석부에 학생 리스트 전달 필요! */
            attendanceForm attendanceForm = new attendanceForm();
            attendanceForm.Show();
        }

        private void className_Click(object sender, EventArgs e)
        {

        }

        DateTime start_t;

        private void startBtn_Click(object sender, EventArgs e)
        {//수업 시작 버튼
            attendBtn.Visible = true;//출석버튼 보이게
            startBtn.Visible = false;//시작버튼 숨기기

            start_t = System.DateTime.Now;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            nowTime.Text = "현재 시간 : " + System.DateTime.Now.ToString("hh:mm:ss");//시계
            if(System.DateTime.Now.Second - start_t.Second >= 10 && startBtn.Visible == false)//수업 시작버튼 누르고 10초뒤 수업종료 버튼 활성화(테스트용)
            {                                                                                  //수업 시간 받아와서 종료시간에 활성화
                endBtn.Visible = true;
            }

            if(System.DateTime.Now.ToString("mm:ss") == "45:00")//수업 종료 5분전, 수업종료 알림 (수정)
            {
                MessageBox.Show("수업종료 5분전 입니다.");
            }
            else if(System.DateTime.Now.ToString("mm:ss") == "50:00")
            {
                MessageBox.Show("수업종료 시간 입니다");
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
