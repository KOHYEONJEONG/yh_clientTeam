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
    public partial class Student_Schedule : Form
    {
        string[,] sc = new string[9, 6]  { { "09:00 ~ 09:50 ", "", "", "", "", "" }, { "10:00 ~ 10:50 ", "", "", "", "", "" },
            { "11:00 ~ 11:50 ", "", "", "", "", "" }, { "12:00 ~ 12:50 ", "", "", "", "", "" },
            { "1:00 ~ 1:50 ", "", "", "", "", "" }, { "2:00 ~ 2:50 ", "", "", "", "", "" },
            { "3:00 ~ 3:50 ", "", "", "", "", "" }, { "4:00 ~ 4:50 ", "", "", "", "", "" },
            { "5:00 ~ 5:50 ", "", "", "", "", "" }};
        DataTable table;
        public Student_Schedule(List<SS_LoginResult.Lecture> lectures)
        {
            InitializeComponent();

            table = new DataTable();
            
            // column을 추가
            table.Columns.Add("시간", typeof(string));
            table.Columns.Add("월", typeof(string));
            table.Columns.Add("화", typeof(string));
            table.Columns.Add("수", typeof(string));
            table.Columns.Add("목", typeof(string));
            table.Columns.Add("금", typeof(string));
            int weekday = 0;
            foreach(SS_LoginResult.Lecture lec in lectures)
            {
                switch (lec.weekday)
                {
                    case "월":
                        weekday = 1;
                        break;
                    case "화":
                        weekday = 2;
                        break;
                    case "수":
                        weekday = 3;
                        break;
                    case "목":
                        weekday = 4;
                        break;
                    case "금":
                        weekday = 5;
                        break;
                }
                SetSchedule(weekday, lec.strat_time, lec.end_time, lec.lecture_name);    
            }
            addTable();

            // 각각의 행에 내용을 입력합니다. 월 화 수 목 금
            //table.Rows.Add("09:00 ~ 09:50 ", "", "", "", "", "");
            //table.Rows.Add("10:00 ~ 10:50 ", "웹개발기획 프로젝트", "모바일 프로젝트", "비즈니스 모델설계", "", "");
            //table.Rows.Add("11:00 ~ 11:50 ", "웹개발기획 프로젝트", "모바일 프로젝트", "비즈니스 모델설계", "", "");
            //table.Rows.Add("12:00 ~ 12:50 ", "웹개발기획 프로젝트", "모바일 프로젝트", "비즈니스 모델설계", "", "");
            //table.Rows.Add("1:00 ~ 1:50", "", "", "취창업 멘토링", "", "");
            //table.Rows.Add("2:00 ~ 2:50", "정보보안", "기업솔루션 프로젝트", "캡스톤 디자인", "", "");
            //table.Rows.Add("3:00 ~ 3:50", "정보보안", "기업솔루션 프로젝트", "캡스톤 디자인", "", "");
            //table.Rows.Add("4:00 ~ 4:50", "정보보안", "기업솔루션 프로젝트", "캡스톤 디자인", "", "");
            //table.Rows.Add("5:00 ~ 5:50", "", "", "", "", "");


            // 값들이 입력된 테이블을 DataGridView에 입력
            dataGridView1.DataSource = table;

        }
        public void addTable()
        {
            for(int i = 0; i < 9; i++)
            {
                table.Rows.Add(sc[i, 0], sc[i, 1], sc[i, 2], sc[i, 3], sc[i, 4], sc[i, 5]);
            }            
        }
        public void SetSchedule(int a, string start_time, string end_time, string lec_name)
        {
            int i, c = 0;
            
            for (i = (Convert.ToInt32(start_time) / 100); i < (Convert.ToInt32(end_time) / 100); i++)
            {
                switch (i)
                {
                    case 9:
                        c = 0;
                        break;
                    case 10:
                        c = 1;
                        break;
                    case 11:
                        c = 2;
                        break;
                    case 12:
                        c = 3;
                        break;
                    case 13:
                        c = 4;
                        break;
                    case 14:
                        c = 5;
                        break;
                    case 15:
                        c = 6;
                        break;
                    case 16:
                        c = 7;
                        break;
                    case 17:
                        c = 8;
                        break;
                    case 18:
                        c = 9;
                        break;
                }
                sc[c, a] = lec_name;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
