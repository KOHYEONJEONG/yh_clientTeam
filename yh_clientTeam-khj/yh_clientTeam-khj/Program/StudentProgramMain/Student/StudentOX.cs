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
    public partial class StudentOX : Form
    {
        public StudentOX(SS_QuizOX ss_QuizOX)
        {
            InitializeComponent();
            lbl_lefttime.Text = "남은 시간 : ";
            lbl_q.Text = "Q)  " + ss_QuizOX.quiz;
        } 


        private void btn_o_Click(object sender, EventArgs e)
        {
            LoginForm.sessionManager.QuizOXAnswer(true);
            this.Close();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            LoginForm.sessionManager.QuizOXAnswer(false);
            this.Close();
        }


      
    }
}
