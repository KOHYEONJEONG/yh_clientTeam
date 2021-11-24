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
    public partial class ReplyForm : Form
    {
        private String answer;
        private String stdName;
        private String stdNum;

        public ReplyForm()
        {
            InitializeComponent();

            //학생 정보 받아옴
            answer = "The US Federal Aviation Administration has grounded Virgin Galactic flights as it investigates how";
            stdName = "고구마";
            stdNum = "20210915";
    }

        private void ReplyForm_Load(object sender, EventArgs e)
        {
            lblName.Text += stdName;
            lblNum.Text += stdNum;
            txtAnswer.Text = answer;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }

    }
}
