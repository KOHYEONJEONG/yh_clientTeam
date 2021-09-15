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
    }
}
