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
<<<<<<< HEAD
    public partial class Student_askf : MetroFramework.Forms.MetroForm
=======
    public partial class Student_askf : Form
>>>>>>> JM
    {
        public Student_askf()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        /*    private void btn_select_Click(object sender, EventArgs e)
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
            }*/


        Bitmap bmp = null;
=======
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
>>>>>>> JM

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PctClick frm = new PctClick();
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
<<<<<<< HEAD

=======
            
>>>>>>> JM
            //듀얼 모니터
            //Screen scr2 = Screen.AllScreens[1];

            //좌표
<<<<<<< HEAD
            Rectangle rect = scr.Bounds;

            //확면을 복사해 이미지 저장
            bmp = new Bitmap(rect.Width, rect.Height);


            //이미지를 변경하기 위해 Graphics객체를 가져옴.
=======
            Rectangle rect =  scr.Bounds;

            //이미지 저장
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);

>>>>>>> JM
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }

<<<<<<< HEAD
           
                pictureBox1.Image = (Image)bmp;

                //Image.FromFile(openFileDialog1.FileName);


            this.Show();
        }

        /*
              //폴더가 경로 있는지
              if( (Directory.Exists(@"C:\Temp2")==false)){
                  Directory.CreateDirectory(@"C:\Temp2");
              }
              else { 


                      //스크린샷 저장 경로
                      bmp.Save(@"C:\Temp2\scr.png", ImageFormat.Png);

                      bmp.Dispose();//스크린 복사후 더이상 Graphics를 사용안해 해제.


                  //스크린샷 끝난후 폼 다시 보여주기.
                  this.Show();



              }
          }
      */

       public byte[] bitmapToByteArray( Bitmap bitmap ) 
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

        private void Student_askf_Load(object sender, EventArgs e)
        {
            /*this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;*/
=======
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> JM
        }
    }
}
