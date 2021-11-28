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

        public static Student_answer studentAnswer;

        //public static PacketManager packetManager;

       

        
        public Student_answer(SS_Quiz quizResult)
        {
            InitializeComponent();
            studentAnswer = this;
            lbl_question.Text = quizResult.quiz;
        }

        public Student_answer()
        {
            InitializeComponent();
            studentAnswer = this;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
          // 질문에 맞는 답변 보내기.
                if (answer.Text.Equals(""))
                {
                    MessageBox.Show("답을 작성해주세요.");

                }
                else
                {
                    LoginForm.sessionManager.QuizAnswer(answer.Text);
                    MessageBox.Show("답변완료");
                    this.Close();
                }
            
        }

     
    }
}
