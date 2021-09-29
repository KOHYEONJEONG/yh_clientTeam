using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfessorMain
{
    public partial class ScreenshotsForm : Form
    {
        private String Sstime = DateTime.Now.ToString("g");

        public ScreenshotsForm()
        {
            InitializeComponent();
        }

        private void Screenshots_form_Load(object sender, EventArgs e)
        {
            /*
            //Resources에 저장된 이미지 가져오기
            // >> 썸네일?? Image th1 = img1.GetThumbnailImage();??
            Image img1 = Properties.Resources.sky1;
            Image img2 = Properties.Resources.sky2;
            Image img3 = Properties.Resources.sky3;
            Image img4 = Properties.Resources.sky4;

            //imageList1:이미지리스트에 이미지 추가
            imageList1.Images.Add(img1);
            imageList1.Images.Add(img2);
            imageList1.Images.Add(img3);
            imageList1.Images.Add(img4);

            imageList1.ImageSize = new Size(70, 70); // 이미지 사이즈 조정
            imageList1.ColorDepth = ColorDepth.Depth32Bit; // 이미지 해상도

            // listView1 :리스트뷰에 imageList1이미지 리스트 추가
            listView1.LargeImageList = imageList1;
            for(int i = 0; i < imageList1.Images.Count; i++)
            {
                //ListViewItem item = ListView.Items.Add("텍스트", "이미지 키");
                //ListViewItem item = ListView.Items.Add("텍스트", 0 );// 0 = 이미지 인덱스 
                //아이템 text = 이미지 이름
                ListViewItem item = new ListViewItem("sky" + (i+1).ToString(), i); 
                listView1.Items.Add(item);
            }

            //현재시간
            label1.Text += Sstime;
            */
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvItem = items[0];
                int selectedIdx = listView1.FocusedItem.Index;
                //아이템 text = 이미지 이름 가져오기
                String selectedImg = listView1.Items[selectedIdx].SubItems[0].Text.ToString();
                //MessageBox.Show("이미지 이름 : " + selectedImg);
                String img_name = selectedImg;

                //ImageForm : 선택한 이미지 하나 보여주기
                ImageForm img_form = new ImageForm(img_name, Sstime);
                img_form.ShowDialog();
            }
            */
        }
    }
}
