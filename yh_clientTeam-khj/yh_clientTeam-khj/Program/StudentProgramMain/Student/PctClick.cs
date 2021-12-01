using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramMain.Student
{
    public partial class PctClick : MetroFramework.Forms.MetroForm
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

        private void PctClick_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD:Program/StudentProgramMain/Student/PctClick.cs
=======
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

>>>>>>> kjm:Program/ProgramMain/Student/PctClick.cs
            //폼이 로딩될때 Image와 크기 설정
            pictureBox1.Image = img;
            pictureBox1.Size = img.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
