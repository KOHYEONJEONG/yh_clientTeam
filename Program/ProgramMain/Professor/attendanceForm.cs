﻿using System;
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
    public partial class attendanceForm : Form
    {

        String[,] teststu = {   {"000000001","가나다" },
                                {"000000002","라마바" },
                                {"000000003","아자차" } };
        public attendanceForm()
        {
            InitializeComponent();
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            

            for(int i = 0; i < teststu.Length / 2; i++) //학생 리스트에 학생 추가
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = teststu[i, 0];
                lvi.SubItems.Add(teststu[i, 1]);
                lvi.SubItems.Add("출석");
                attendList.Items.Add(lvi);

            }


            //subjectLb.Text = "수업이름" + " 출석부";
            //classLb.Text = "학년" + " / " + "반";
        }

        private void gradeLb_Click(object sender, EventArgs e)
        {

        }

    }
}
