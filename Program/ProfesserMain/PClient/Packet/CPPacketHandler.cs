using PClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProgramMain;

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
        LoginForm.loginForm._loginCheckTimer.Enabled = true;
    }     
    public static void SP_LoginResultHandler(PacketSession session, IPacket packet)
    {
        LoginForm.loginForm.loginCheck = 1;
        LoginForm.loginForm.sp_LoginResult = packet as SP_LoginResult;
    }     
    public static void SP_StudentInfoHandler(PacketSession session, IPacket packet)
    {
       /* SP_StudentInfo sp_StudentInfo = packet as SP_StudentInfo;

        foreach (var s in sp_StudentInfo.students) 
        {
            MessageBox.Show("asdasd");
            for (int i = 0; i < ProfesserMain.professerMain._studList.RowCount; i++)
            {
                if(s.studentId == ProfesserMain.professerMain._studList.Rows[i].Cells[1].Value.ToString())
                {
                    
                    ProfesserMain.professerMain._studList.Rows[i].Cells[0].Style.BackColor = Color.White;//셀 흰색으로 변경
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
        ServerSession serverSession = session as ServerSession;
        Bitmap bmp;
        bmp = ScreenCopy.GetBitmap(sp_screenPacket.img);


       
    }
    public static void SP_QustionTextHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QustionImgHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QustionHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QuizResultHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_EndClassHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QuizOXResultHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_AddStudentHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_LeaveStudentHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_AddAtdHandler(PacketSession session, IPacket packet)
        {

        }
    

}