using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramMain.Student
{
    public partial class Student_askf : Form
    {

       // public static SessionManager sessionManager;//로그인폼에서 가져와야함.
        public static Boolean AskResult;// 핸들러클래스에서 결과값 받아오려고.
        public Student_askf()
        {
            InitializeComponent();
        }

        Bitmap bmp = null;

        private void pctBox_Click(object sender, EventArgs e)
        {
            PctClick frm = new PctClick();
            if (pctBox.Image == null)
            {
                return;
            }
            frm.img = pctBox.Image;
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
            Rectangle rect = scr.Bounds;

            //확면을 복사해 이미지 저장
            bmp = new Bitmap(rect.Width, rect.Height);


            //이미지를 변경하기 위해 Graphics객체를 가져옴.
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }


            pctBox.Image = bmp as Image;

            //Image.FromFile(openFileDialog1.FileName);


            this.Show();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            //byte[] imgByte = null;
            //var imgconv = new ImageConverter();
            byte[] buf = null;

            if (bmp != null)
            {
                //imgByte = (byte[])imgconv.ConvertTo(bmp, typeof(byte[]));//이미지 자체를 바이트로 변환한 값.
                //byte[] nbytes = BitConverter.GetBytes(imgByte.Length);//이미지에 길이를 바이트배열로 변환해서 넣음.

                MemoryStream ms = new MemoryStream(); 
                bmp.Save(ms, ImageFormat.Png); 
                buf = ms.ToArray();

            }

         

            if (chkImage.Checked && chkAsk.Checked)
            {
                LoginForm.sessionManager.ImgTextSend(buf, txtBox.Text);
                MessageBox.Show("이미지,질문 전송완료");
            }
            else
            {
                if (chkImage.Checked)
                {
                    LoginForm.sessionManager.ImgSend(buf);
                    MessageBox.Show("이미지만 전송완료");
                }else if (chkAsk.Checked)
                {
                    LoginForm.sessionManager.TextSend(txtBox.Text);
                    MessageBox.Show("질문만 전송완료");
                }
                else
                {
                    MessageBox.Show("전송할 대상이 없습니다.");
                    return;
                }
            }
        }

      
    }
}
