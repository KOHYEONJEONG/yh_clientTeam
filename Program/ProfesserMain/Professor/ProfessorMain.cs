using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using PClient;

namespace ProgramMain
{
    public partial class ProfesserMain : Form
    {
        public static ProfesserMain professerMain ;
        
        /*List<SP_StudentInfo.Student> _infoStudent = new List<SP_StudentInfo.Student>();
        public List<SP_StudentInfo.Student> infoStudent
        {
            get { return _infoStudent; }
            set { _infoStudent = value; }
        }*/

        private String Sstime = DateTime.Now.ToString("g");


        List<String> checkstu = new List<string>(); //체크박스 체크된 학생 리스트


        SP_LoginResult.Lecture lecture; //강의정보
        List<SP_LoginResult.Student> student = new List<SP_LoginResult.Student>(); //학생 정보 리스트

        public DataGridView _studList
        {
            get { return studList; }
            set { _studList = studList; }
        }


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

        public ProfesserMain(List<SP_LoginResult.Lecture> lectures , List<SP_LoginResult.Student> students, String proname)
        {
            InitializeComponent();
            professerMain = this;
            lblProfname.Text = proname;
            stdQustionCheck = 0;


            if (!get_lecture_stdent(lectures, students)){
                LoginForm.loginForm.loginCheck = 4;
                this.Close();
            }
        }




        private bool get_lecture_stdent(List<SP_LoginResult.Lecture> lectures, List<SP_LoginResult.Student> students)//해당하는 수업 가져오고, 수업 듣는 학생 리스트 가져옴
        {
            //수정 필 필
            //String nowtime = DateTime.Now.ToString("HHmm");
            //String day = getDay();
            String nowtime = DateTime.Now.ToString("1205");
            String day = "수";
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

            foreach (var s in students)
            {
                if(lecture.lecture_code == s.lectureCode)
                {
                    student.Add(s);
                }
            }

            Timer.Enabled = true;

            return true;
            
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
            Image img1 = Properties.Resources.sky1;
            Image img2 = Properties.Resources.sky2;
            Image img3 = Properties.Resources.sky3;
            Image img4 = Properties.Resources.sky4;


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

        }

        private void studList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)//마우스 올려놓으면 
        {


        }
        private void studList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = sender as DataGridView;

            int curR = e.RowIndex;
            int curC = e.ColumnIndex;

            if (curR < 0)//헤더 클릭 막기
            {
                return;
            }

            Type type = grid.Rows[curR].Cells[curC].GetType();

            if (type == typeof(DataGridViewImageCell))
            {
                Image img = grid.Rows[curR].Cells[curC].Value as Image;



                try
                {
                    Bitmap imgbitmap = new Bitmap(img);
                    Image resizedImage = resizeImage(imgbitmap, 250, img.Size.Height / (img.Size.Width / 250));
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
        private Image resizeImage(Image image, int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (Image)destinationImage;
        }


        private void listView1_SelectedIndexChanged_2(object sender, System.EventArgs e)
        {

        }
        
        // 스크린샷 버튼 이벤트
        private void screenbtn_Click(object sender, EventArgs e)
        {
            //체크 되어있는 학생의 학번을 리스트에 추가
            checkStuAdd();

            LoginForm.sessionManager.ScreenShotRequset(checkstu);

            checkstu.Clear();//체크된 학생 리스트 비우기
        }
        
        private void questionbtn_Click(object sender, EventArgs e)
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
                for (int i = studList.Rows.Count -1 ; i >= 0; i--)
                {
                    if (studList.Rows[i].Cells[0].ReadOnly)
                    {
                        continue;
                    }
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

     

        private void studList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }


        private void studList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;

            int curR = e.RowIndex;
            int curC = e.ColumnIndex;

            if (curR < 0)//헤더 클릭 막기
            {
                return;
            }

            Type type = grid.Rows[curR].Cells[curC].GetType();

            //학생 정보
            String id = grid.Rows[curR].Cells[1].Value.ToString();
            String name = grid.Rows[curR].Cells[2].Value.ToString();

            if (type == typeof(DataGridViewImageCell))
            {
                Bitmap img = (Bitmap)grid.Rows[curR].Cells[curC].Value;

                ImageForm img_form = new ImageForm(id, name, img);
                img_form.ShowDialog();
            }

            /* 응답 폼 확인 */
            if (curC == 4)
            {
                String reply = grid.Rows[curR].Cells[curC].Value.ToString();
                if (reply != "" && reply != null) //응답 있을 경우에만 
                {
                    //질문유형
                    if (reply == "True" || reply == "False")
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
                else { }
            }

        }

        private void attenddanceBtn_Click(object sender, EventArgs e)
        {
            attendanceForm attendanceForm = new attendanceForm();
            attendanceForm.Show();
        }

        private void className_Click(object sender, EventArgs e)
        {

        }



        int atndTime = 1;//교시
        private void attendbtn_Click(object sender, EventArgs e)
        {
            String nowtime = DateTime.Now.ToString("HHmm");
            

            LoginForm.sessionManager.AtdRequest(atndTime, 1);//교시,주차
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
            else if (System.DateTime.Now.ToString("hhmmss") == (Convert.ToInt32(lecture.end_time) -15).ToString() + "00")//수업 종료 5분전
            {
                MessageBox.Show("수업종료 5분전 입니다");
                endBtn.Visible = true;
                Timer.Enabled = false;
            }

            for (int i = 0; i < stuin; i++)
            {
                studList.Rows[i].ReadOnly = false;
            }

            //학생 질문&이미지 확인
            if (stdQustionCheck==1)
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

        
      

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
