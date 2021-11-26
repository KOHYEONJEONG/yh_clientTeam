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
    public partial class StudentSchedule : Form
    {
        public StudentSchedule()
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

            // 각각의 행에 내용을 입력합니다.
            table.Rows.Add("1", "        ");
            table.Rows.Add("2", "제목 2번");
            table.Rows.Add("3", "제목 3번");
            table.Rows.Add("4", "제목 4번");
            table.Rows.Add("5", "제목 4번");


            // 값들이 입력된 테이블을 DataGridView에 입력
            dataGridView1.DataSource = table;


        }

        
    }
}
