using StudentProgramMain;
using System;
using System.Windows.Forms;

class PacketHandler
{ //�ۼ��� ���ֱ�( Ŭ���̾�Ʈ �ڵ忡���� �ҷ��� �ۼ��ϴ� �� �ƴ�.)
  //LoginResult�� �α��� ������ ����� �޴� ����(static)
  //db�κ��� ��Ŷ�� �����͸� �޾ƿͼ�, ���� ����� �ָ��.

    public static void SS_ResultHandler(PacketSession session, IPacket packet)
    {
        SS_Result result = packet as SS_Result;
        ServerSession serverSession = session as ServerSession;//�ٽ� �� �ڵ鷯�ȿ��� �ٷ� ��Ŷ �ٽ� �������Ҷ��� ����ϸ� ��.

    }
    public static void SS_LoginFailedHandler(PacketSession session, IPacket packet)
    {
        //SS_LoginFailed result = packet as SS_LoginFailed;
        // ServerSession serverSession = session as ServerSession;

        LoginForm.LoginResult = false;//����(x)
        LoginForm.message_box("���̵� �� ��й�ȣ�� �ٽ� Ȯ�����ּ���.");//test

    }

    public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
    {
        SS_LoginResult.Lecture result = packet as SS_LoginResult.Lecture;//��øŬ����

        LoginForm.LoginResult = true;
        LoginForm.message_box("���� ����");

        //�л����� �Է��� �� 
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