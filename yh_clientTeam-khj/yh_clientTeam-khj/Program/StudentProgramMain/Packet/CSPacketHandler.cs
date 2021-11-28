using StudentProgramMain;
using StudentProgramMain.Student;
using System;
using System.Collections.Generic;
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
        SS_LoginFailed pkt = packet as SS_LoginFailed;
        if(pkt.result == 2)
        {
            MessageBox.Show("�α��� ����  : ���̵� �Ǵ� ��й�ȣ�� Ʋ�Ƚ��ϴ�.");
        }
        else if (pkt.result == 3)
        {
            MessageBox.Show("�α��� ����  : �̹� ���� ���̵�� ������ �л��� �ֽ��ϴ�. ");
        }

        LoginForm.loginForm.loginCheck = 2;

    }

    public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
    {
        LoginForm.loginForm.loginCheck = 1;
        LoginForm.loginForm.ss_LoginResult = packet as SS_LoginResult;

                  

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

        MessageBox.Show("�����Բ��� ��������.");
        //Student_answer.studentAnswer.ss_Quiz = packet as SS_Quiz;
        //Student_answer.studentAnswer.ss_Quiz = packet as SS_Quiz;
        //Student_answer.studentAnswer.ss_Quiz 

        student_main.studentMain.quizcheck = 1;//student_answer�� �������!!
        student_main.studentMain.ss_Quiz = packet as SS_Quiz;


        
    }
    public static void SS_ImgSendFaildHandler(PacketSession session, IPacket packet)
    {
      
    }
    public static void SS_ScreenRequestHandler(PacketSession session, IPacket packet)
    {
        MessageBox.Show("��ũ����");
        LoginForm.sessionManager.ImgSend();
    }
    public static void SS_LogoutHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_EndOfClassHandler(PacketSession session, IPacket packet)
    {

    }

    public static void SS_QustionFaildHandler(PacketSession session, IPacket packet)
    {
        //�������� ������ ���´µ� �濡 ���ų�, �ڸ��� ���� �� ����
        MessageBox.Show("�������� ���� ������ ���� �� ���� �����Դϴ�.");
    }

}