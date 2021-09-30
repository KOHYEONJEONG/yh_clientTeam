using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ProgramMain
{
    public partial class ImageForm : Form
    {
        //학생 정보
        private String stdName;
        private String stdNum;

        //이미지
        /*수정필요*/
        private Bitmap image = new Bitmap("C:\\Users\\lolol\\Desktop\\Image\\test.jpg");

        //윈도우 해상도
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public ImageForm()
        {
            InitializeComponent();
        }
        
        public ImageForm(string name, Image image)//이미지 받아옴
        {
            InitializeComponent();

            //폼 크기 조정
            this.Width = screenWidth/3;
            this.Height = screenHeight/3;
            // 폼 위치 조정
            this.Location = new Point(screenWidth/5, screenHeight/3);
            //Picturebox 크기, 위치 조정
            this.PbScreenshot.Width = this.Width;
            this.PbScreenshot.Height = this.Height - this.gbInfo.Height - this.btnOK.Height;
            this.PbScreenshot.Top = this.gbInfo.Height;

            //학생 정보 받아옴
            stdName = "고구마";
            stdNum = "20210915";
            //this.image = (Bitmap)image;//받아온 이미지 저장

        }


        private void ImageForm_Load(object sender, EventArgs e)
        {
            this.Text = "스크린샷";

            this.lblName.Text += stdName;
            this.lblNum.Text += stdNum;

            /*수정필요*/
            //this.lblTime.Text += GetImageCeationDate("C:\\Users\\lolol\\Desktop\\Image\\test.jpg");
            this.PbScreenshot.Image = image;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }

        private void PbScreenshot_DoubleClick(object sender, EventArgs e)
        {
            if (this.PbScreenshot.Dock != DockStyle.Fill)
            {
                this.WindowState = FormWindowState.Maximized;
                this.PbScreenshot.Dock = DockStyle.Fill;
                this.gbInfo.Visible = false;
                this.btnOK.Visible = false;
            }
            else if (this.PbScreenshot.Dock == DockStyle.Fill)
            {
                this.WindowState = FormWindowState.Normal;
                this.PbScreenshot.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                this.PbScreenshot.Dock = DockStyle.None;
                this.gbInfo.Visible = true;
                this.btnOK.Visible = true;
            }
        }


        /*수정필요*/
        //촬영시간 가져오기
        //형식 bitmap? image? filepath?
        /* [방법1]
        private string GetImgDateTiem()
        {
            Image image1 = Image.FromFile("C:\\Users\\lolol\\Desktop\\Image\\test.jpg");
            PropertyItem propertyItem;
            try
            {   //ID is 0x0132 and the Property Tag is PropertyTagDateTime.
                propertyItem = image1.PropertyItems.FirstOrDefault(i => i.Id == 0x0132);
                //propertyItem = image1.GetPropertyItem(0x132);
                string asciiInfo ="";
                if (propertyItem != null)
                {
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    asciiInfo = encoding.GetString(propertyItem.Value, 0, propertyItem.Len - 1);
                }
                else
                {
                    asciiInfo = "propertyItem == null";
                }
                return asciiInfo;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        */

        /* [방법2]
        private string GetImageCeationDate(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BitmapSource source = BitmapFrame.Create(stream);
                BitmapMetadata metadata = source.Metadata as BitmapMetadata;
                if (metadata.DateTaken == null) { return null; }
                else
                {
                    string creationDate = metadata.DateTaken;
                    return creationDate;
                }
            }
        }
        */
    }
}
