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
    public partial class StdAskCheckForm : Form
    {
        public static StdAskCheckForm stdAskCheckForm;
        public RichTextBox _rtbStdQuestion
        {
            get { return rtbStdQuestion; }
            set { _rtbStdQuestion = rtbStdQuestion; }
        }
        public PictureBox _pbQuestionImg
        {
            get { return pbQuestionImg; }
            set { _pbQuestionImg = pbQuestionImg; }
        }


        public StdAskCheckForm(SP_Qustion sp_Qustion) //학생 질문&이미지
        {
            InitializeComponent();
            stdAskCheckForm = this;

            Byte[] bytes = sp_Qustion.img;
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(bytes);
            Image image = Image.FromStream(memoryStream);
            StdAskCheckForm.stdAskCheckForm._pbQuestionImg.Image = (Image)image.Clone();
            StdAskCheckForm.stdAskCheckForm._rtbStdQuestion.Text = sp_Qustion.studentId + " 의 질문\n" + sp_Qustion.qustion;

        }
        
        public StdAskCheckForm(SP_QustionImg sp_QustionImg) //학생 이미지
        {
            InitializeComponent();
            stdAskCheckForm = this;

            Byte[] bytes = sp_QustionImg.img;
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(bytes);
            Image image = Image.FromStream(memoryStream);
            StdAskCheckForm.stdAskCheckForm._pbQuestionImg.Image = (Image)image.Clone();
            StdAskCheckForm.stdAskCheckForm._rtbStdQuestion.Text = sp_QustionImg.studentId + " 의 질문\n";

        }

        public StdAskCheckForm(SP_QustionText sp_QustionText) //학생 질문
        {
            InitializeComponent();
            stdAskCheckForm = this;
            StdAskCheckForm.stdAskCheckForm._rtbStdQuestion.Text = sp_QustionText.studentId + " 의 질문\n" + sp_QustionText.qustion;

        }

        private void pbQuestionImg_Click(object sender, EventArgs e)
        {
            //ImageForm imageForm = new ImageForm();
            //imageForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
