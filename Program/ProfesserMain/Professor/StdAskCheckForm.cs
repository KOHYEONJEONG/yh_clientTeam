using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMain.Professor
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


        public StdAskCheckForm()
        {
            InitializeComponent();
            stdAskCheckForm = this;

        }

        private void pbQuestionImg_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm();
            imageForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
