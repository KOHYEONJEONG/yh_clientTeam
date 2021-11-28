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
        public Student_Schedule()
        {
            InitializeComponent();

            DataTable table = new DataTable();

            // column을 추가
            table.Columns.Add("시간", typeof(string));
            table.Columns.Add("월", typeof(string));
            table.Columns.Add("화", typeof(string));
            table.Columns.Add("수", typeof(string));
            table.Columns.Add("목", typeof(string));
            table.Columns.Add("금", typeof(string));

            // 각각의 행에 내용을 입력합니다. 월 화 수 목 금
            table.Rows.Add("09:00 ~ 09:50 ", "", "", "", "", "");
            table.Rows.Add("10:00 ~ 10:50 ", "웹개발기획 프로젝트", "모바일 프로젝트", "비즈니스 모델설계", "", "");
            table.Rows.Add("11:00 ~ 11:50 ", "웹개발기획 프로젝트", "모바일 프로젝트", "비즈니스 모델설계", "", "");
            table.Rows.Add("12:00 ~ 12:50 ", "웹개발기획 프로젝트", "모바일 프로젝트", "비즈니스 모델설계", "", "");
            table.Rows.Add("1:00 ~ 1:50", "", "", "취창업 멘토링", "", "");
            table.Rows.Add("2:00 ~ 2:50", "정보보안", "기업솔루션 프로젝트", "캡스톤 디자인", "", "");
            table.Rows.Add("3:00 ~ 3:50", "정보보안", "기업솔루션 프로젝트", "캡스톤 디자인", "", "");
            table.Rows.Add("4:00 ~ 4:50", "정보보안", "기업솔루션 프로젝트", "캡스톤 디자인", "", "");
            table.Rows.Add("5:00 ~ 5:50", "", "", "", "", "");


            // 값들이 입력된 테이블을 DataGridView에 입력
            dataGridView1.DataSource = table;

        }

        


    }
}
