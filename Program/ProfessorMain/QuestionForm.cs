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
    public partial class QuestionForm : Form
    {
        private int allStudent = 0; //button2 : 전체선택(0),삭제(1) 

        private string Question; //교수님이 질문
        private string Q_Type; // 질문 타입
        private List<string> checklist = new List<string>(); //선택된 학생 목록

        public QuestionForm()
        {
            InitializeComponent();
        }

        
        private void Question_form_Load(object sender, EventArgs e)
        {
            /* */
            //dataGridView1: 학생 리스트에 학생 정보 추가
            for (int i = 0; i < 10; i++)
            {
                string stdname = "학생" + (i+1);
                this.dataGridView1.Rows.Add(false, stdname, "2021090"+i);
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* GridView 에서 CheckBox 클릭 시 */
            //변경 적용
            this.dataGridView1.EndEdit(); 

            // GridView - Checkbox 검사
            bool allChk = false;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {   
                bool isChecked = Convert.ToBoolean(this.dataGridView1.Rows[i].Cells[0].Value);
                if (isChecked)
                {   // 하나라도 선택된 경우
                    allChk = true;
                    break;
                }
            }

            //btn_allChoice.text 변경
            if (allChk)
            {
                this.btn_allChoice.Text = "전체 취소";
                allStudent = 1;
            }
            else
            {
                this.btn_allChoice.Text = "전체 선택";
                allStudent = 0;
            }
        }
        

        private void btn_allChoice_Click(object sender, EventArgs e)
        {
            /* btn_allChoice 선택 버튼 클릭 시  */
            if (allStudent == 0) // 전체 선택일 때,
            {
                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {   // 체크박스 전체 선택
                    this.dataGridView1.Rows[i].Cells[0].Value = true;
                }
                //btn_allChoice.text 변경
                this.btn_allChoice.Text = "전체 취소";
                allStudent = 1;
            }
            else // button2 : 전체 취소일 때, (allStudent == 1)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    // 체크박스 전체 선택 해제
                    this.dataGridView1.Rows[i].Cells[0].Value = false;
                }
                //btn_allChoice.text 변경
                this.btn_allChoice.Text = "전체 선택";
                allStudent = 0;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            /*교수님 질문 & 타입 & 선택된 학생 정보 전송*/
            //1.교수님 질문
            Question = this.tb_question.Text;

            //2.타입 선택
            if (this.radio_write.Checked == true)
            {
                Q_Type = this.radio_write.Text;
            }
            else if (this.radio_yorn.Checked == true)
            {
                Q_Type = this.radio_yorn.Text;
            }

            //3.선택된 학생
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                bool isChecked = Convert.ToBoolean(this.dataGridView1.Rows[i].Cells[0].Value);
                if (isChecked)
                {
                    checklist.Add(Convert.ToString(this.dataGridView1.Rows[i].Cells[2].Value));
                }
            }

            //4.확인
            if (Question != "" && Q_Type != null && checklist.Count != 0)
            {
                String test = "질문 : " + Question + "\n타입 : " + Q_Type + "\n학생 목록\n";
                for(int i=0; i< checklist.Count; i++)
                {
                    test += "학번 : " + checklist[i] + "\n";
                }

                //MessageBox.Show(test, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (MessageBox.Show(test, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    //폼 닫기
                    this.Close();
                }
                else
                {
                    checklist.Clear();
                }
                
            }
            else
            {
                if(Question == "")
                    MessageBox.Show("질문을 입력해주세요.");
                else if (Q_Type == null)
                    MessageBox.Show("타입을 선택해주세요.");
                else if (checklist.Count == 0)
                    MessageBox.Show("학생을 선택해주세요.");
                checklist.Clear();
            }
          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }
    }
}
