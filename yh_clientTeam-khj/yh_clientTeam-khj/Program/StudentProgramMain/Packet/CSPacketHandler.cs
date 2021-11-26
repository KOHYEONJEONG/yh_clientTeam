using StudentProgramMain;
using StudentProgramMain.Student;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

class PacketHandler
{ //작성만 해주기( 클라이언트 코드에서는 불러서 작성하는 거 아님.)
  //LoginResult는 로그인 폼에서 결과값 받는 변수(static)
  //db로부터 패킷에 데이터를 받아와서, 폼에 결과를 주면됨.

    public static void SS_ResultHandler(PacketSession session, IPacket packet)
    {
        SS_Result result = packet as SS_Result;
        ServerSession serverSession = session as ServerSession;//다시 그 핸들러안에서 바로 패킷 다시 보내야할때만 사용하면 됨.

    }
    public static void SS_LoginFailedHandler(PacketSession session, IPacket packet)
    {
        //SS_LoginFailed result = packet as SS_LoginFailed;
        // ServerSession serverSession = session as ServerSession;

        //LoginForm.LoginResult = false;//실행(x)
        MessageBox.Show("로그인 실패");

    }

    public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
    {
        LoginForm.loginForm.loginCheck = 1;
        LoginForm.loginForm.ss_LoginResult = packet as SS_LoginResult;



        // 학번을 매칭 시켜할 거 같은데...
        MessageBox.Show("학생 값불러오는 중");
            

    }
    public static void SS_EnterRoomHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_QResultHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_AtdRequestHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_QuizOXHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_QuizHandler(PacketSession session, IPacket packet)
    {
        SS_Quiz result = packet as SS_Quiz;
        Student_answer.lblResult = result.quiz;

    }
    public static void SS_ImgSendFaildHandler(PacketSession session, IPacket packet)
    {
      
    }
    public static void SS_ScreenRequestHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_LogoutHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_EndOfClassHandler(PacketSession session, IPacket packet)
    {

    }

    public static void SS_QustionFaildHandler(PacketSession session, IPacket packet)
    {
        //교수한테 질문을 보냈는데 방에 없거나, 자리에 없을 시 실패
        MessageBox.Show("교수님이 현재 질문을 받을 수 없는 상태입니다.");
    }

}