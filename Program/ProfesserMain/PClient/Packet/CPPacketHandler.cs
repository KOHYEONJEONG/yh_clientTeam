using PClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProgramMain;
using ProgramMain.Professor;

class PacketHandler
{
    
    public static void SP_ResultHandler(PacketSession session, IPacket packet)
    {
        SP_Result result = packet as SP_Result;
        ServerSession serverSession = session as ServerSession;
        if (result.result == true)
        {

        }
    }

    public static void SP_LoginFailedHandler(PacketSession session, IPacket packet)
    {
        MessageBox.Show("로그인 실패");
        LoginForm.loginForm.loginCheck = 2;
    }

    public static void SP_LoginResultHandler(PacketSession session, IPacket packet)
    {
        LoginForm.loginForm.loginCheck = 1;
        LoginForm.loginForm.sp_LoginResult = packet as SP_LoginResult;

    }

    public static void SP_StudentInfoHandler(PacketSession session, IPacket packet)
    {
        /*SP_StudentInfo sp_StudentInfo = packet as SP_StudentInfo;
        ServerSession serverSession = session as ServerSession;
        foreach (var s in sp_StudentInfo.students)
        {
            //MessageBox.Show("asdasd");
            for (int i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
            {
                if (s.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
                {
                    //셀 흰색으로 변경 = 접속 중
                    ProfesserMain.professerMain._studList.Rows[i].Cells[0].Style.BackColor = Color.White;
                    ProfesserMain.professerMain._studList.Rows[i].Cells[1].Style.BackColor = Color.White;
                    ProfesserMain.professerMain._studList.Rows[i].Cells[2].Style.BackColor = Color.White;
                    ProfesserMain.professerMain._studList.Rows[i].Cells[3].Style.BackColor = Color.White;
                    ProfesserMain.professerMain._studList.Rows[i].Cells[4].Style.BackColor = Color.White;
                    ProfesserMain.professerMain._studList.Rows[i].Cells[5].Style.BackColor = Color.White;
                    ProfesserMain.professerMain._studList.Rows[i].Cells[3].Value = ProgramMain.Properties.Resources._default;
                }
            }
        }*/
    }

    public static void SP_ScreenResultHandler(PacketSession session, IPacket packet)
    {
        SP_ScreenResult sp_screenPacket = packet as SP_ScreenResult;
        //ServerSession serverSession = session as ServerSession;
        Bitmap bmp;
        bmp = ScreenCopy.GetBitmap(sp_screenPacket.img);
        /*ProfesserMain > studList_CellDoubleClick : ImageForm 확인 수정 필요*/
        for (int i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
        {
            if (sp_screenPacket.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
            {
                ProfesserMain.professerMain._studList.Rows[i].Cells[3].Value = bmp;
                break;
            }
        }

    }

    public static void SP_QustionTextHandler(PacketSession session, IPacket packet)
    {
        SP_QustionText sp_QustionText = packet as SP_QustionText;
        //ServerSession serverSession = session as ServerSession;
        StdAskCheckForm.stdAskCheckForm.Show();
        StdAskCheckForm.stdAskCheckForm._rtbStdQuestion.Text = sp_QustionText.studentId + " 의 질문\n" + sp_QustionText.qustion;
    }
    public static void SP_QustionImgHandler(PacketSession session, IPacket packet)
    {
        SP_QustionImg sp_QustionImg = packet as SP_QustionImg;

        Byte[] bytes = sp_QustionImg.img;
        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(bytes);
        Image image = Image.FromStream(memoryStream);

        StdAskCheckForm.stdAskCheckForm.Show();
        StdAskCheckForm.stdAskCheckForm._pbQuestionImg.Image = (Image)image.Clone();

        StdAskCheckForm.stdAskCheckForm._rtbStdQuestion.Text = sp_QustionImg.studentId + " 의 질문\n";
    }
    public static void SP_QustionHandler(PacketSession session, IPacket packet)
    {
        SP_Qustion sp_Qustion = packet as SP_Qustion;

        Byte[] bytes = sp_Qustion.img;
        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(bytes);
        Image image = Image.FromStream(memoryStream);

        StdAskCheckForm.stdAskCheckForm.Show();
        StdAskCheckForm.stdAskCheckForm._pbQuestionImg.Image = (Image)image.Clone();
        StdAskCheckForm.stdAskCheckForm._rtbStdQuestion.Text = sp_Qustion.studentId + " 의 질문\n" + sp_Qustion.qustion;

    }
    public static void SP_QuizResultHandler(PacketSession session, IPacket packet)
    {
        SP_QuizResult sp_QuizResult = packet as SP_QuizResult;
        for (int i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
        {
            if (sp_QuizResult.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
            {
                ProfesserMain.professerMain._studList.Rows[i].Cells[4].Value = sp_QuizResult.result;
                break;
            }
        }
    }
    public static void SP_EndClassHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QuizOXResultHandler(PacketSession session, IPacket packet)
    {
        SP_QuizOXResult sp_QuizOXResult = packet as SP_QuizOXResult;
        for (int i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
        {
            if (sp_QuizOXResult.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
            {
                ProfesserMain.professerMain._studList.Rows[i].Cells[4].Value = sp_QuizOXResult.result.ToString();
                break;
            }
        }
    }
    static int stuin = 0;
    public static void SP_AddStudentHandler(PacketSession session, IPacket packet)
    {
        stuin++;
        ProfesserMain.professerMain.stuin = stuin;
        SP_AddStudent sP_AddStudent = packet as SP_AddStudent;
        DataGridViewRow dataGrid = new DataGridViewRow();
        int i;
        for (i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
        {
            if (sP_AddStudent.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
            {
                //셀 흰색으로 변경 = 접속
                ProfesserMain.professerMain._studList.Rows[i].Cells[0].Style.BackColor = Color.White;
                ProfesserMain.professerMain._studList.Rows[i].Cells[1].Style.BackColor = Color.White;
                ProfesserMain.professerMain._studList.Rows[i].Cells[2].Style.BackColor = Color.White;
                ProfesserMain.professerMain._studList.Rows[i].Cells[3].Style.BackColor = Color.White;
                ProfesserMain.professerMain._studList.Rows[i].Cells[4].Style.BackColor = Color.White;
                ProfesserMain.professerMain._studList.Rows[i].Cells[5].Style.BackColor = Color.White;
                ProfesserMain.professerMain._studList.Rows[i].Cells[3].Value = ProgramMain.Properties.Resources._default;



                break;
            }
        }

        //정렬을 위한 임시 저장
        bool c0 = (bool)ProfesserMain.professerMain._studList.Rows[i].Cells[0].Value;
        string c1 = (string)ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value;
        string c2 = (string)ProfesserMain.professerMain._studList.Rows[i].Cells[2].Value;
        Bitmap c3 = (Bitmap)ProfesserMain.professerMain._studList.Rows[i].Cells[3].Value;
        string c4 = (string)ProfesserMain.professerMain._studList.Rows[i].Cells[4].Value;
        string c5 = (string)ProfesserMain.professerMain._studList.Rows[i].Cells[5].Value;
        Color color = (Color)ProfesserMain.professerMain._studList.Rows[i].Cells[0].Style.BackColor;




        for (int j = i; j > 0; j--)//뒤로 한칸씩 보내기
        {
           

            ProfesserMain.professerMain._studList.Rows[j].Cells[0].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[0].Style.BackColor;
            ProfesserMain.professerMain._studList.Rows[j].Cells[1].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Style.BackColor;
            ProfesserMain.professerMain._studList.Rows[j].Cells[2].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[2].Style.BackColor;
            ProfesserMain.professerMain._studList.Rows[j].Cells[3].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[3].Style.BackColor;
            ProfesserMain.professerMain._studList.Rows[j].Cells[4].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[4].Style.BackColor;
            ProfesserMain.professerMain._studList.Rows[j].Cells[5].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[5].Style.BackColor;

            ProfesserMain.professerMain._studList.Rows[j].Cells[0].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[0].Value;
            ProfesserMain.professerMain._studList.Rows[j].Cells[1].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Value;
            ProfesserMain.professerMain._studList.Rows[j].Cells[2].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[2].Value;
            ProfesserMain.professerMain._studList.Rows[j].Cells[3].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[3].Value;
            ProfesserMain.professerMain._studList.Rows[j].Cells[4].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[4].Value;
            ProfesserMain.professerMain._studList.Rows[j].Cells[5].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[5].Value;

        }

        ProfesserMain.professerMain._studList.Rows[0].Cells[0].Style.BackColor = color;
        ProfesserMain.professerMain._studList.Rows[0].Cells[1].Style.BackColor = color;
        ProfesserMain.professerMain._studList.Rows[0].Cells[2].Style.BackColor = color;
        ProfesserMain.professerMain._studList.Rows[0].Cells[3].Style.BackColor = color;
        ProfesserMain.professerMain._studList.Rows[0].Cells[4].Style.BackColor = color;
        ProfesserMain.professerMain._studList.Rows[0].Cells[5].Style.BackColor = color;

        ProfesserMain.professerMain._studList.Rows[0].Cells[0].Value = c0;
        ProfesserMain.professerMain._studList.Rows[0].Cells[1].Value = c1;
        ProfesserMain.professerMain._studList.Rows[0].Cells[2].Value = c2;
        ProfesserMain.professerMain._studList.Rows[0].Cells[3].Value = c3;
        ProfesserMain.professerMain._studList.Rows[0].Cells[4].Value = c4;
        ProfesserMain.professerMain._studList.Rows[0].Cells[5].Value = c5;
        



       for (int j = 1; j < stuin; j++)
        {
            if (Convert.ToInt32(ProfesserMain.professerMain._studList.Rows[j].Cells[1].Value) <
                                    Convert.ToInt32(ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Value))
            {
                //정렬을 위한 임시 저장
                c0 = (bool)ProfesserMain.professerMain._studList.Rows[j].Cells[0].Value;
                c1 = (string)ProfesserMain.professerMain._studList.Rows[j].Cells[1].Value;
                c2 = (string)ProfesserMain.professerMain._studList.Rows[j].Cells[2].Value;
                c3 = (Bitmap)ProfesserMain.professerMain._studList.Rows[j].Cells[3].Value;
                c4 = (string)ProfesserMain.professerMain._studList.Rows[j].Cells[4].Value;
                c5 = (string)ProfesserMain.professerMain._studList.Rows[j].Cells[5].Value;
                color = (Color)ProfesserMain.professerMain._studList.Rows[j].Cells[0].Style.BackColor;
 

                ProfesserMain.professerMain._studList.Rows[j].Cells[0].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[0].Style.BackColor;
                ProfesserMain.professerMain._studList.Rows[j].Cells[1].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Style.BackColor;
                ProfesserMain.professerMain._studList.Rows[j].Cells[2].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[2].Style.BackColor;
                ProfesserMain.professerMain._studList.Rows[j].Cells[3].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[3].Style.BackColor;
                ProfesserMain.professerMain._studList.Rows[j].Cells[4].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[4].Style.BackColor;
                ProfesserMain.professerMain._studList.Rows[j].Cells[5].Style.BackColor = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[5].Style.BackColor;

                ProfesserMain.professerMain._studList.Rows[j].Cells[0].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[0].Value;
                ProfesserMain.professerMain._studList.Rows[j].Cells[1].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Value;
                ProfesserMain.professerMain._studList.Rows[j].Cells[2].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[2].Value;
                ProfesserMain.professerMain._studList.Rows[j].Cells[3].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[3].Value;
                ProfesserMain.professerMain._studList.Rows[j].Cells[4].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[4].Value;
                ProfesserMain.professerMain._studList.Rows[j].Cells[5].Value = ProfesserMain.professerMain._studList.Rows[j - 1].Cells[5].Value;
 

                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[0].Style.BackColor = color;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Style.BackColor = color;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[2].Style.BackColor = color;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[3].Style.BackColor = color;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[4].Style.BackColor = color;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[5].Style.BackColor = color;

                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[0].Value = c0;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[1].Value = c1;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[2].Value = c2;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[3].Value = c3;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[4].Value = c4;
                ProfesserMain.professerMain._studList.Rows[j - 1].Cells[5].Value = c5;

            }
            else
            {
                break;
            }
        }

        
        


    }

    public static void SP_LeaveStudentHandler(PacketSession session, IPacket packet)
    {
        SP_LeaveStudent sp_LeaveStudent = packet as SP_LeaveStudent;
        for (int i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
        {
            if (sp_LeaveStudent.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
            {
                //셀 Gray 로 변경 = 미접속
                ProfesserMain.professerMain._studList.Rows[i].Cells[0].Style.BackColor = Color.Gray;
                ProfesserMain.professerMain._studList.Rows[i].Cells[1].Style.BackColor = Color.Gray;
                ProfesserMain.professerMain._studList.Rows[i].Cells[2].Style.BackColor = Color.Gray;
                ProfesserMain.professerMain._studList.Rows[i].Cells[3].Style.BackColor = Color.Gray;
                ProfesserMain.professerMain._studList.Rows[i].Cells[4].Style.BackColor = Color.Gray;
                ProfesserMain.professerMain._studList.Rows[i].Cells[5].Style.BackColor = Color.Gray;
                ProfesserMain.professerMain._studList.Rows[i].Cells[3].Value = ProgramMain.Properties.Resources.default1;
            }
        }
    }
    public static void SP_AddAtdHandler(PacketSession session, IPacket packet)
    {
        SP_AddAtd sp_AddAtd = packet as SP_AddAtd;

    }


}