using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Ask
{
    public partial class PctClick : Form
    {
        public PctClick()
        {
            InitializeComponent();
        }

        public Image img
        {
            //외부로부터 Image참조 설정을 위한 속성
            set; get;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //폼이 로딩될때 Image와 크기 설정
            pictureBox1.Image = img;
            pictureBox1.Size = img.Size;

        }

       
    }
}
