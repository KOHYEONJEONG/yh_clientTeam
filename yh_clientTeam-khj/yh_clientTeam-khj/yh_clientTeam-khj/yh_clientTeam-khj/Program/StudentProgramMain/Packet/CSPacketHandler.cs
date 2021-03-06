using StudentProgramMain;
using StudentProgramMain.Student;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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
        SS_LoginFailed pkt = packet as SS_LoginFailed;
        if(pkt.result == 2)
        {
            MessageBox.Show("로그인 실패  : 아이디 또는 비밀번호가 틀렸습니다.");
        }
        else if (pkt.result == 3)
        {
            MessageBox.Show("로그인 실패  : 이미 같은 아이디로 접속한 학생이 있습니다. ");
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
        Thread.Sleep(500);
        student_main.studentMain.viewBtn.Invoke((MethodInvoker)delegate {
            student_main.studentMain.viewBtn.Text = "수업 중";

        });
    }
    public static void SS_QResultHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_AtdRequestHandler(PacketSession session, IPacket packet)    {
        
        SS_AtdRequest ss_AtdRequest = packet as SS_AtdRequest;
             
        MessageBox.Show(ss_AtdRequest.week + "주" + ss_AtdRequest.classTime + "교시 출석요청");
        student_main.studentMain.atdRequest = ss_AtdRequest;

        student_main.studentMain._btn_absent.Invoke((MethodInvoker)delegate {
            student_main.studentMain._btn_absent.Text = ss_AtdRequest.classTime + "교시 출석하세요 ";
            student_main.studentMain._btn_absent.BackColor = Color.FromArgb(70, 110, 61);          
            student_main.studentMain._btn_absent.Enabled = true;
        });
        
    }
    public static void SS_QuizOXHandler(PacketSession session, IPacket packet)
    {
        student_main.studentMain.quizcheck = 2;//student_answer폼 열어줘라!!
        student_main.studentMain.ss_QuizOX = packet as SS_QuizOX;
    }
    public static void SS_QuizHandler(PacketSession session, IPacket packet)
    {

        //MessageBox.Show("교수님께서 문제.");
        //Student_answer.studentAnswer.ss_Quiz = packet as SS_Quiz;
        //Student_answer.studentAnswer.ss_Quiz = packet as SS_Quiz;
        //Student_answer.studentAnswer.ss_Quiz 

        student_main.studentMain.quizcheck = 1;//student_answer폼 열어줘라!!
        student_main.studentMain.ss_Quiz = packet as SS_Quiz;


        
    }
    public static void SS_ImgSendFaildHandler(PacketSession session, IPacket packet)
    {
      
    }

    public static void SS_ScreenRequestHandler(PacketSession session, IPacket packet)
    {        
        LoginForm.sessionManager.ImgSend();
        //MessageBox.Show("스크린샷");
    }
    public static void SS_LogoutHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_EndOfClassHandler(PacketSession session, IPacket packet)
    {

        SS_EndOfClass pkt = packet as SS_EndOfClass;
        Thread.Sleep(500);
        if(pkt.result == 1)
        {
            MessageBox.Show("수업 종료");
            student_main.studentMain.Invoke((MethodInvoker)delegate {
                student_main.studentMain.isClosing = true;
                student_main.studentMain.Close();
            });
        }
        else
        {
            Thread.Sleep(500);
            student_main.studentMain.viewBtn.Invoke((MethodInvoker)delegate {
                student_main.studentMain.viewBtn.Text = "수업 대기 중";
            });
        }
       
    }

    public static void SS_QustionFaildHandler(PacketSession session, IPacket packet)
    {
        //교수한테 질문을 보냈는데 방에 없거나, 자리에 없을 시 실패
        MessageBox.Show("교수님이 현재 질문을 받을 수 없는 상태입니다.");
    }
    
    public static void SS_AtdResultHandler(PacketSession session, IPacket packet)
    {
        SS_AtdResult pkt = packet as SS_AtdResult;
        string s = "";
        int r, g, b = 0;
        switch (pkt.result)
        {
            case 1:
                s = "출석";
                r = 0; g = 163; b = 133;
                break;
            case 2:
                s = "지각";
                r = 255; g = 128; b = 0;
                break;
            case 0:
                s = "결석";
                r = 239; g = 72; b = 72;
                break;
            default:
                s = "결석";
                r = 239; g = 72; b = 72;
                break;
        }
        student_main.studentMain._btn_absent.Invoke((MethodInvoker)delegate {
            student_main.studentMain._btn_absent.Text = pkt.classTime + "교시 : " + s;
            student_main.studentMain._btn_absent.BackColor = Color.FromArgb(r, g, b);

        });
    }


}