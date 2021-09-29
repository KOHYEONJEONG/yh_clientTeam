using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProfessorMain
{
    public partial class ProfesserMain : Form
    {
        private String Sstime = DateTime.Now.ToString("g");
        String[,] teststu = {   {"000000001","가나다" },
                                {"000000002","라마바" },
                                {"000000003","아자차" } };


        List<String> checkstu = new List<string>();

        public ProfesserMain()
        {
            InitializeComponent();
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


            for (int i = 0; i < teststu.Length / 2; i++) //접속학생 리스트에 학생 추가
                {
                    studList.Rows.Add(false, teststu[i, 0] , teststu[i, 1], Properties.Resources._default, "","");
                }

            studList.Rows[1].Cells[3].Value = img1;
            studList.Rows[0].Cells[3].Value = img2;



            for (int i = 0; i < teststu.Length / 2; i++) //미접속학생 리스트에 학생 추가
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = teststu[i, 0];
                lvi.SubItems.Add(teststu[i, 1]);
                unconstu.Items.Add(lvi);

            }

            className.Text = "수업 이름";//수업이름 설정
            classTime.Text = "00:00 ~ 00:00";//수업 시간 설정
                                            //시간되면 자동 수업 시작하게 설정하기

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

            Type type = grid.Rows[curR].Cells[curC].GetType();

            if(type == typeof(DataGridViewImageCell))
            {

            }

            Image img = grid.Rows[curR].Cells[curC].Value as Image;


            ImageForm img_form = new ImageForm(img.ToString(), Sstime, img);
            img_form.ShowDialog();

        }

        private void attenddanceBtn_Click(object sender, EventArgs e)
        {
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
            nowTime.Text = System.DateTime.Now.ToString("hh:mm:ss");//시계
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

        
    }
}
