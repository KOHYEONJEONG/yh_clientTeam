using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfessorMain
{
    public partial class ReplyYNForm : Form
    {

        private int answer;
        private String stdName;
        private String stdNum;

        public ReplyYNForm()
        {
            InitializeComponent();

            //학생 정보 받아옴
            answer = 0;
            stdName = "고구마";
            stdNum = "20210915";

            this.lblName.Text = stdName;
            this.lblNum.Text = stdNum;

            if (answer == 0)
            {
                this.radioYes.Checked = true;
            }
            else
            {
                this.radioYes.Checked = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }
    }
}
