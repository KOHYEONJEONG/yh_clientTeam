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
    public partial class Student_answer : Form
    {
        //public static SessionManager sessionManager;
        public static Student_answer studentAnswer;
        SS_Quiz _ss_Quiz;

        public SS_Quiz ss_Quiz
        {
            get { return _ss_Quiz; }
            set {_ss_Quiz = value; }
        }

        


        public Student_answer()
        {
            InitializeComponent();
            studentAnswer = this;

        }

        private void Student_answer_Load(object sender, EventArgs e)
        {
            //lbl_question.Text = lblResult;
            lbl_question.Text = ss_Quiz.quiz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm.sessionManager.QuizAnswer(answer.Text);
            MessageBox.Show("답변완료");
        }
    }
}
