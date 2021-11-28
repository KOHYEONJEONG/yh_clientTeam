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
    public partial class ReplyYNForm : Form
    {
        private String answer;
        private String stdName;
        private String stdNum;


        public ReplyYNForm()
        {
            InitializeComponent();
        }

        public ReplyYNForm(String id, String name, String reply)
        {
            InitializeComponent();

            stdNum += id;
            stdName += name;
            answer = reply;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }

        private void ReplyYNForm_Load(object sender, EventArgs e)
        {
            this.lblName.Text += stdNum;
            this.lblNum.Text += stdName;
            if (answer == "O")
            {
                this.radioYes.Checked = true;
            }
            else
            {
                this.radioNo.Checked = true;
            }
        }
    }
}
