using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneDesign_0901;//StudentMain in student_main(폼) 네임스페이스
using ProfessorMain;


namespace LoginMain
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals("")|| txt_pw.Text.Equals(""))
            {
                MessageBox.Show("ID와 PW를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (txt_id.Text.Equals("p") && txt_pw.Text.Equals("1234"))
                {
                    MessageBox.Show("교수프로그램", "확인", MessageBoxButtons.OK);
                    ProfesserMain professerMain = new ProfesserMain();
                    professerMain.Show();
                    

                }
                else
                {
                    if (txt_id.Text.Equals("s") && txt_pw.Text.Equals("1234"))
                    {
                        
                        MessageBox.Show("학생프로그램", "확인", MessageBoxButtons.OK);

                      
                        student_main student = new student_main();
                        student.Show();
                        //this.Close();

                    }
                }

               

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //글자수 제한
            this.txt_id.MaxLength = 32;
            this.txt_pw.MaxLength = 32;
        }
    }
}
