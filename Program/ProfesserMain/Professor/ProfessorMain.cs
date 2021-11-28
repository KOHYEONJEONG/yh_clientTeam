using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using PClient;

namespace ProgramMain
{
    public partial class ProfesserMain : Form
    {
        public static ProfesserMain professerMain;

        /*List<SP_StudentInfo.Student> _infoStudent = new List<SP_StudentInfo.Student>();
        public List<SP_StudentInfo.Student> infoStudent
        {
            get { return _infoStudent; }
            set { _infoStudent = value; }
        }*/

        public DataGridView _studList
        {
            get { return studList; }
            set { _studList = studList; }
        }

        private int _outIndex = -1;
        public int outIndex
        {
            get { return _outIndex; }
            set { _outIndex = value; }
        }



        List<String> checkstu = new List<string>(); //체크박스 체크된 학생 리스트

        SP_LoginResult.Lecture lecture; //강의정보
        List<SP_LoginResult.Student> student = new List<SP_LoginResult.Student>(); //학생 정보 리스트

        public int stdQustionCheck; //학생 질문 들어오는거 체크 : 0=nothing, 1=학생 질문&이미지, 2=이미지, 3=텍스트

        SP_Qustion _sp_Qustion; //학생 질문 텍스트&이미지 정보
        public SP_Qustion sp_Qustion
        {
            get { return _sp_Qustion; }
            set { _sp_Qustion = value; }
        }

        SP_QustionImg _sp_QustionImg;//학생 질문 이미지 정보
        public SP_QustionImg sp_QustionImg
        {
            get { return _sp_QustionImg; }
            set { _sp_QustionImg = value; }
        }

        SP_QustionText _sp_QustionText; //학생 질문 텍스트 정보
        public SP_QustionText sp_QustionText
        {
            get { return _sp_QustionText; }
            set { _sp_QustionText = value; }
        }



        public ProfesserMain(List<SP_LoginResult.Lecture> lectures, List<SP_LoginResult.Student> students, String proname)
        {
            InitializeComponent();
            professerMain = this;//현재 폼 static으로 저장
            lblProfname.Text = proname;//교수이름 출력

            if (!get_lecture_stdent(lectures, students)) {//수업 학생 정보 출력 메서드 호출
                LoginForm.loginForm.loginCheck = 4;//수업없음을 알림
                this.Close();//창닫기
            }
            foreach (DataGridViewColumn item in studList.Columns) { item.SortMode = DataGridViewColumnSortMode.NotSortable; }



        }




        private bool get_lecture_stdent(List<SP_LoginResult.Lecture> lectures, List<SP_LoginResult.Student> students)//해당하는 수업 가져오고, 수업 듣는 학생 리스트 가져옴
        {
            //수정 필 필
            String nowtime = DateTime.Now.ToString("HHmm");
            String day = Tool.getDay();
            //String nowtime = DateTime.Now.ToString("1005");
            //String day = "수";
            foreach (var l in lectures)//수업정보 저장
            {
                if (Convert.ToInt32(l.strat_time) <= Convert.ToInt32(nowtime) && Convert.ToInt32(l.end_time) >= Convert.ToInt32(nowtime))
                {

                    if (l.weekday == day)
                    {

                        lecture = l;
                    }
                }
            }

            if (lecture == null)//수업 없으면
            {

                return false;
            }

            foreach (var s in students)//학생 정보 저장
            {
                if (lecture.lecture_code == s.lectureCode)
                {
                    student.Add(s);
                }
            }



            Timer.Enabled = true;//동작 감지 타이머 킴

            return true;//정상 실행

        }



        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {

        }


        private void Form1_Load(object sender, System.EventArgs e)
        {

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

            if (lecture != null)//수업이 있으면
            {
                className.Text = lecture.lecture_name;//수업이름 설정
                classTime.Text = "수업 시간: " + lecture.strat_time + "~" + lecture.end_time;//수업 시간 설정
                                                                                         //시간되면 자동 수업 시작하게 설정하기
            }

        }


        private void listView1_SelectedIndexChanged_2(object sender, System.EventArgs e)
        {

        }

        // 스크린샷 버튼 이벤트
        private void screenbtn_Click(object sender, EventArgs e)//스크린샷 버튼 이벤트
        {
            //체크 되어있는 학생의 학번을 리스트에 추가
            checkStuAdd();

            LoginForm.sessionManager.ScreenShotRequset(checkstu);//서버에 스크린샷 요청

            checkstu.Clear();//체크된 학생 리스트 비우기
        }

        private void questionbtn_Click(object sender, EventArgs e)//질문버튼 이벤트
        {
            //체크 되어있는 학생의 학번을 리스트에 추가
            checkStuAdd();

            QuestionForm questionForm = new QuestionForm(); // 질문 폼 띄우기
            questionForm.ShowDialog();

            if (questionForm._radio_write.Checked)//학생입력
            {
                LoginForm.sessionManager.QuizRequset(questionForm.checklist, questionForm._tb_question.Text);
            }
            else if (questionForm._radio_yorn.Checked)//OX
            {
                LoginForm.sessionManager.QuizOXRequset(questionForm.checklist, questionForm._tb_question.Text);
            }
            else//취소
            {

            }



            checkstu.Clear();//체크된 학생 리스트 비우기

        }



        private void allcheck_CheckedChanged(object sender, EventArgs e)//천체 체크
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)//체크되어 있으면
            {
                for (int i = 0 ; i < studList.Rows.Count ; i++)
                {
                    if (studList.Rows[i].ReadOnly)//접속하지 않은 학생 체크 X
                    {
                        break;
                    }
                    studList.Rows[i].Cells[0].Value = true;//체크
                }
            }
            else
            {
                for (int i = studList.Rows.Count - 1; i >= 0; i--)//체크 해제
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



        private void studList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void studList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//리스트 더블클릭
        {
            //이미지셀 클릭 부분
            DataGridView grid = sender as DataGridView;//이벤트 발생한 리스트 저장
            //클릭한 셀 인덱스
            int curR = e.RowIndex;
            int curC = e.ColumnIndex;

            if (curR < 0)//헤더 클릭 막기
            {
                return;
            }

            Type type = grid.Rows[curR].Cells[curC].GetType();//셀 타입 저장

            if (type == typeof(DataGridViewImageCell))//셀타입이 이미지 셀이면
            {
                Image img = grid.Rows[curR].Cells[curC].Value as Image;//이미지 저장

                ImageForm img_form = new ImageForm(grid.Rows[curR].Cells[2].Value.ToString(), grid.Rows[curR].Cells[1].Value.ToString(), img);//폼 띄움
                img_form.ShowDialog();
            }

            //응답 셀 클릭 부분
            String id = grid.Rows[curR].Cells[1].Value.ToString();//학번 저장
            String name = grid.Rows[curR].Cells[2].Value.ToString();//이름 저장

            //응답 셀
            if (curC == 4)
            {
                String reply = grid.Rows[curR].Cells[curC].Value.ToString();//내용 저장
                if (reply != "" && reply != null) //응답 있을 경우에만 
                {
                    //질문유형
                    if (reply == "O" || reply == "X")
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
        private void studList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void studList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)//마우스 움직였을 때
        {
            //이미지 셀에 마우스 가면 확대
            DataGridView grid = sender as DataGridView;

            int curR = e.RowIndex;
            int curC = e.ColumnIndex;

            if (curR < 0)//헤더 클릭 막기
            {
                return;
            }

            Type type = grid.Rows[curR].Cells[curC].GetType();

            if (type == typeof(DataGridViewImageCell))//사진 확대
            {
                Image img = grid.Rows[curR].Cells[curC].Value as Image;//이미지 저장



                try
                {
                    Bitmap imgbitmap = new Bitmap(img);
                    Image resizedImage = Tool.resizeImage(imgbitmap, 250, img.Size.Height / (img.Size.Width / 250));
                    previewBox.Image = resizedImage;

                    previewBox.Location = new Point(Control.MousePosition.X - this.Location.X, Control.MousePosition.Y - this.Location.Y - 30);

                    previewBox.Visible = true;


                }
                catch
                {

                }
            }
            else
            {
                previewBox.Visible = false;
            }
        }

        private void attenddanceBtn_Click(object sender, EventArgs e)
        {
            LoginForm.sessionManager.AtdListRequest();
            attendanceForm attendanceForm = new attendanceForm(lecture.lecture_name);
            attendanceForm.Show();
        }

        private void className_Click(object sender, EventArgs e)
        {

        }



        int atndTime = 1;//교시
        private void attendbtn_Click(object sender, EventArgs e)
        {
            

            LoginForm.sessionManager.AtdRequest(atndTime, Tool.GetWeekNumber(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.DayOfWeek));//교시,주차
            attendBtn.Visible = false;
            //수업 시간 받고 교시마다 활성화 되게 해야 함
        }

        int _stuin = 0;//readonly 해제를 위한 변수
        public int stuin
        {
            get { return _stuin; }
            set { _stuin = value; }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            nowTime.Text = "현재 시간 : " + System.DateTime.Now.ToString("hh:mm:ss");//시계

            if (System.DateTime.Now.ToString("hhmmss") == (Convert.ToInt32(lecture.strat_time) + 100).ToString() + "00")//2교시 출석체크 시작
            {
                atndTime = 2;
                attendBtn.Visible = true;
            }
            else if (System.DateTime.Now.ToString("hhmmss") == (Convert.ToInt32(lecture.strat_time) + 200).ToString() + "00")//3교시 출석체크 시작
            {
                atndTime = 3;
                attendBtn.Visible = true;
            }
            else if (System.DateTime.Now.ToString("hhmmss") == (Convert.ToInt32(lecture.end_time) - 55).ToString() + "00")//수업 종료 5분전
            {
                MessageBox.Show("수업종료 5분전 입니다");
                endBtn.Visible = true;
                
            }


            //학생 질문&이미지 확인
            if (stdQustionCheck == 1)
            {
                StdAskCheckForm stdAskCheckForm = new StdAskCheckForm(sp_Qustion);
                stdAskCheckForm.Show();
                stdQustionCheck = 0;
            }
            if (stdQustionCheck == 2)
            {
                StdAskCheckForm stdAskCheckForm = new StdAskCheckForm(sp_QustionImg);
                stdAskCheckForm.Show();
                stdQustionCheck = 0;
            }
            if (stdQustionCheck == 3)
            {
                StdAskCheckForm stdAskCheckForm = new StdAskCheckForm(sp_QustionText);
                stdAskCheckForm.Show();
                stdQustionCheck = 0;
            }


        }



        bool closeIndex = false;
        private void endBtn_Click(object sender, EventArgs e)
        {
            LoginForm.sessionManager.EndOfClassRequset();
            closeIndex = true;
            this.Close();
        }

        private void ProfesserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeIndex == false)//종료버튼이 아니면 안꺼지게
            {
                e.Cancel = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            closeIndex = true;
        }
    }
}
