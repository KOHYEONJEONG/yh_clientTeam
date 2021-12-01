using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMain
{
    public partial class attendanceForm : Form
    {
        public static attendanceForm _attendanceForm;

        public ListView _attendList
        {
            get { return attendList; }
            set { attendList = value; }
        }

        int _weekcount = 0;
        public int weekcount
        {
            get { return _weekcount; }
            set { _weekcount = value; }
        }

        List<SP_AtdList.AtdList> _atdLists = null;

        public List<SP_AtdList.AtdList> atdLists
        {
            get { return _atdLists; }
            set { _atdLists = value; }
        }
        public attendanceForm(String className)
        {
            
            InitializeComponent();
            subjectLb.Text = className;
            _attendanceForm = this;
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            //dataGridView1: 학생 리스트에 학생 정보 추가
            for (int i = 0; i < ProfesserMain.professerMain._studList.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString();
                lvi.SubItems.Add(ProfesserMain.professerMain._studList.Rows[i].Cells[2].Value.ToString());
                attendList.Items.Add(lvi);
            }
            

            
        }

        private void gradeLb_Click(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (weekcount != 0)
            {
                for (int i = 1; i <= weekcount; i++)
                {
                    attendList.Columns.Add(i  + "주", 65, HorizontalAlignment.Left);

                    foreach (var s in atdLists)
                    {

                        if (s.week == i)
                        {

                            for (int j = 0; j < attendList.Items.Count; j++)
                            {
                                if (attendList.Items[j].SubItems[0].Text == s.studentId)
                                {
                                    

                                    String attd = "";

                                    if (s.first_class == 0)//결석
                                    {
                                        attd = "결 ";
                                    }
                                    else if (s.first_class == 1)//출석
                                    {
                                        attd = "출 ";
                                    }
                                    else if (s.first_class == 2)//지각
                                    {
                                        attd = "지 ";

                                    }
                                    else
                                    {

                                    }

                                    if (s.second_class == 0)//결석
                                    {
                                        attd += "결 ";
                                    }
                                    else if (s.second_class == 1)//출석
                                    {
                                        attd += "출 ";
                                    }
                                    else if (s.second_class == 2)//지각
                                    {
                                        attd += "지 ";

                                    }
                                    else
                                    {

                                    }

                                    if (s.third_class == 0)//결석
                                    {
                                        attd += "결 ";
                                    }
                                    else if (s.third_class == 1)//출석
                                    {
                                        attd += "출 ";
                                    }
                                    else if (s.third_class == 2)//지각
                                    {
                                        attd += "지 ";

                                    }
                                    else
                                    {

                                    }


                                    attendList.Items[j].SubItems.Add(attd);

                                }
                            }
                        }
                    }

                }
            }
            weekcount = 0;
        }
    }
}
