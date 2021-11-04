using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMain
{
    public partial class Student_answer : MetroFramework.Forms.MetroForm
    {
        public Student_answer()
        {
            InitializeComponent();
        }

        private void Student_answer_Load(object sender, EventArgs e)
        {
            this.StyleManager = StyleManager;
            StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            StyleManager.Style = MetroFramework.MetroColorStyle.Green;
        }
    }
}
