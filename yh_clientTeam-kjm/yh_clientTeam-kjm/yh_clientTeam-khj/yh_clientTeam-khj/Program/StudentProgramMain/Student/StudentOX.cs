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
        public StudentOX()
        {
            InitializeComponent();
            lefttime.Start();
            lbl_lefttime.Text = "남은 시간 : ";
            lbl_q.Text = "Q)  ";
        }

        int left = 15;
        bool flag; //o=(true) x(false)

     

        private void lefttime_Tick(object sender, EventArgs e)
        {
            if (left < 1)
            {
                MessageBox.Show("시간이 초과되었습니다.");
                lefttime.Enabled = false;
            }
            else
            {
                left--;
                lbl_lefttime.Text = "남은 시간 :  " + left;
            }
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            flag = true;
            Application.Exit();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            flag = false;
            Application.Exit();
        }


        private void label2_Click(object sender, EventArgs e)
        {


        }
    }
}
