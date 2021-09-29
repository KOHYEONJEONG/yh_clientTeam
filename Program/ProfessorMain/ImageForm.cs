using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfessorMain
{


    public partial class ImageForm : Form
    {

        //학생 정보
        private String stdName;
        private String stdNum;

        private String Sstime = DateTime.Now.ToString("g");
        Image image;
        public ImageForm()
        {
            InitializeComponent();
        }
        
        public ImageForm(string name, String time,Image image)//이미지 받아옴
        {
            InitializeComponent();

            //학생 정보 받아옴
            stdName = "고구마";
            stdNum = "20210915";
            this.image = image;//받아온 이미지 저장
        }

       

        private void ImageForm_Load(object sender, EventArgs e)
        {
            this.Text = "스크린샷";

            lblName.Text += stdName;
            lblNum.Text += stdNum;

            lblTime.Text += Sstime;
            pbScreenshot.Image = image;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }

        


    }
}
