using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //글자수 제한
            this.txt_id.MaxLength = 32;
            this.txt_pw.MaxLength = 32;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id.Text=="" || txt_pw.Text=="")
            {
                MessageBox.Show("ID와 PW를 입력해주세요.","알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_id.Text == "yuhan" || txt_pw.Text == "1")
                {
                    MessageBox.Show("정상 로그인", "확인", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
