using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Ask
{
    public partial class Student_askf : Form
    {
        public Student_askf()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }catch(Exception ex)
            {
                //Filter속성에서 이미지를 걸러내기 때문에 안적어도 됨.
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.img = pictureBox1.Image;
            frm.ShowDialog();
        }

        private void btn_screenCopy_Click(object sender, EventArgs e)
        {
            //스크린샷 폼은 사라지게.
            this.Hide();
            Thread.Sleep(500);

            //스크린샷 버튼
            Screen scr = Screen.PrimaryScreen;
            
            //듀얼 모니터
            //Screen scr2 = Screen.AllScreens[1];

            //좌표
            Rectangle rect =  scr.Bounds;

            //이미지 저장
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }

            /*
           //이미지로부터 그래픽스 객체 가져오기
            Graphics g = Graphics.FromImage(bmp);//이미지를 변경하기 위해서

            g.CopyFromScreen(rect.Left,rect.Top, 0, 0, rect.Size);

            */

            //폴더가 경로 있는지
            if( (Directory.Exists(@"E:\Temp2")==false)){
                Directory.CreateDirectory(@"E:\Temp2");
            }
            
                //스크린샷 저장 경로
                bmp.Save(@"E:\Temp2\scr.jpg", ImageFormat.Png);
                bmp.Dispose();

                //스크린샷 끝난후 폼 다시 보여주기.
                this.Show();
         
        }
    }
}
