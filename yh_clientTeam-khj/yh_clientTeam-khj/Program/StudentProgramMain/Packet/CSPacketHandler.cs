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
        //SS_LoginFailed result = packet as SS_LoginFailed;
        // ServerSession serverSession = session as ServerSession;

        //LoginForm.LoginResult = false;//����(x)
        MessageBox.Show("�α��� ����");

    }

    public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
    {
<<<<<<< HEAD

        SS_LoginResult loginResult_packet = packet as SS_LoginResult;
        // SS_LoginResult.Lecture result = packet as SS_LoginResult.Lecture;//��øŬ����
        //List<SS_LoginResult.Lecture> result = loginResult_packet.lectures;
        LoginForm.LoginResult = true;
        List<SS_LoginResult.Lecture> LectureResult = loginResult_packet.lectures;
        foreach (SS_LoginResult.Lecture result in LectureResult)
        {
            student_main.studentMain.no = result.lecture_code;
            student_main.studentMain.professorID = result.professor_id;
            student_main.studentMain.subject = result.lecture_name;
            student_main.studentMain.weekDay = result.weekday;
            student_main.studentMain.start = result.strat_time;
            student_main.studentMain.end = " ~ " + result.end_time;
        }
=======
        LoginForm.loginForm.loginCheck = 1;
        LoginForm.loginForm.ss_LoginResult = packet as SS_LoginResult;


>>>>>>> f50287d4599b65ff9af066eac25629b3c4bf45c6

        // �й��� ��Ī ������ �� ������...
        MessageBox.Show("�л� ���ҷ����� ��");
            
<<<<<<< HEAD
           
=======
>>>>>>> f50287d4599b65ff9af066eac25629b3c4bf45c6

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
        //�������� ������ ���´µ� �濡 ���ų�, �ڸ��� ���� �� ����
        MessageBox.Show("�������� ���� ������ ���� �� ���� �����Դϴ�.");
    }

}