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
    public partial class StudentOX : Form
    {
        public StudentOX()
        {
            InitializeComponent();
        }


        int CountOrgNum = 60; // 초기 카운터
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
            //this.lbl_lefttime.Text = "남은 시간 : " + CountOrgNum;
            

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            { this.Timer.Enabled = false; 
                this.lbl_lefttime.Text = "시간 초과"; 
                MessageBox.Show("시간 초과되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
             CountOrgNum--;
            this.lbl_lefttime.Text = "남은 시간 : " + CountOrgNum;

            
        }

        private void pn_yes_Click(object sender, EventArgs e)
        {

            Application.Exit();
           
        }

        private void pn_no_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        private void pn_yes_MouseMove(object sender, MouseEventArgs e)
        {
            pn_yes.BackgroundImage = imageList1.Images[1];
        }

        private void pn_yes_MouseLeave(object sender, EventArgs e)
        {
           pn_yes.BackgroundImage = imageList1.Images[0];
        }
        */
    }
}
