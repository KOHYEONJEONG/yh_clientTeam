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

        public static PacketManager packetManager;

        public static Boolean answerResult;// 핸들러클래스에서 결과값 받아오려고.
        public static string lblResult = "";
        public Student_answer()
        {
            InitializeComponent();
        }

        private void Student_answer_Load(object sender, EventArgs e)
        {
            lbl_question.Text = lblResult;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm.sessionManager.QuizAnswer(answer.Text);
            MessageBox.Show("답변완료");
        }
    }
}
