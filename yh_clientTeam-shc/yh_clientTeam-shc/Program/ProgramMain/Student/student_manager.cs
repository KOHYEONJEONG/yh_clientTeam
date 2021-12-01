using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMain.Student
{
    public partial class student_manager : Form
    {
        public student_manager()
        {
            InitializeComponent();
        }

        //대화상자에 입력된 문자열이 저장될 변수
        public string Hak { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string day { get; set; }
        public string period { get; set; }
        public string classhour { get; set; }


        //student_main student = new student_main();

        //델리게이트 선언
        public delegate void ChildFormHandler(string HK, string name, string subject, string day,
            string period, string clssghour);

        //이벤트 선언
        public event ChildFormHandler childFormEvent;


        private void student_manager_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            
            this.Hak = this.tb_hak.Text;
            this.Name = this.tb_name.Text;
            this.Subject = this.tb_subject.Text;
            this.day = this.cbb_day.Text;
            this.period = this.tb_period.Text;
            this.classhour = this.tb_classhour.Text;

            //델리게이트 이벤트를 통해 부모폼으로 데이터 전송
            this.childFormEvent(Hak, Name, Subject, day, period, classhour);
            this.Close();



        }

        private void cbb_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
