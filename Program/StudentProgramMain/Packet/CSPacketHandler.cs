using StudentProgramMain;
using System;
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

        LoginForm.LoginResult = false;//실행(x)
        LoginForm.message_box("아이디 및 비밀번호를 다시 확인해주세요.");//test

    }

    public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
    {
        SS_LoginResult.Lecture result = packet as SS_LoginResult.Lecture;//중첩클래스

        LoginForm.LoginResult = true;
        LoginForm.message_box("접속 성공");

        //학생폼에 입력할 값 
        //result.

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

}