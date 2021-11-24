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

namespace ProgramMain
{
    public partial class Student_askf : Form
    {
        public Student_askf()
        {
            InitializeComponent();
        }

        private void Student_askf_Load(object sender, EventArgs e)
        {
        }

        Bitmap bmp = null;

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pctBox.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }catch(Exception ex)
            {
                //Filter속성에서 이미지를 걸러내기 때문에 안적어도 됨.
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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


            pctBox.Image = (Image)bmp;

            //Image.FromFile(openFileDialog1.FileName);


            this.Show();

        }

        public byte[] bitmapToByteArray(Bitmap bitmap)
        {
            byte[] result = null;
            if (bitmap != null)
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, bitmap.RawFormat);
                result = stream.ToArray();
            }
            else
            {
                Console.WriteLine("Bitmap is null.");
            }
            return result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] imgByte = bitmapToByteArray(bmp);


            if (chkImage.Checked && chkAsk.Checked)
            {
                MessageBox.Show("이미지,질문 전송완료");
            }
            else
            {
                if (chkImage.Checked)
                {
                    MessageBox.Show("이미지 전송완료");
                }
                else
                {
                    if (chkAsk.Checked)
                    {
                        MessageBox.Show("질문 전송완료");
                    }
                }
            }
        }

     
    }
}
