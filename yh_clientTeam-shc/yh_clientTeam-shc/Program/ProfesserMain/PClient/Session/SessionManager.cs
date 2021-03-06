using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PClient
{
    public class SessionManager
    {
        object _lock = new object();
        ServerSession _sessions = new ServerSession();
        public void LoginSend(String id, String pass)//로그인 정보 보내기
        {
            lock (_lock)
            {
                CP_Login loging_packet = new CP_Login();

                loging_packet.id = id;
                loging_packet.pwd = pass;
                ArraySegment<byte> segment = loging_packet.Write();
                _sessions.Send(segment);

                
            }

        }
        public void StudentListRequset()
        {
            lock (_lock)
            {
                CP_StudentList cp_StudentList = new CP_StudentList();
                _sessions.Send(cp_StudentList.Write());
            }
        }


        public void ScreenShotRequset(List<String> checkstu)//스크린샷 요청
        {
            lock (_lock)
            {
                CP_ScreenRequest cp_ScreenRequest = new CP_ScreenRequest();

                foreach (var s in checkstu)
                {
                    CP_ScreenRequest.Student student = new CP_ScreenRequest.Student();
                    student.studentId = s;


                    cp_ScreenRequest.students.Add(student);

                }

                _sessions.Send(cp_ScreenRequest.Write());
            }
        }

        public void QuizOXRequset(List<String> checkstu,String quiz)//OX퀴즈 요청
        {
            lock (_lock)
            {
                CP_QuizOX cp_QuizOX = new CP_QuizOX();

                foreach (var s in checkstu)
                {

                    CP_QuizOX.Student student = new CP_QuizOX.Student();
                    student.studentId = s;

                    cp_QuizOX.students.Add(student);

                }


                cp_QuizOX.quiz = quiz;
                _sessions.Send(cp_QuizOX.Write());
            }

        }

        public void QuizRequset(List<String> checkstu, String quiz)//퀴즈 요청
        {
            lock (_lock)
            {
                CP_Quiz cp_Quiz = new CP_Quiz();

                foreach (var s in checkstu)
                {
                    CP_Quiz.Student student = new CP_Quiz.Student();
                    student.studentId = s;

                    cp_Quiz.students.Add(student);

                }
                cp_Quiz.quiz = quiz;
                _sessions.Send(cp_Quiz.Write());
            }
        }

        public void QResultRequset(String id, string result)
        {
            lock (_lock)
            {
                CP_QResult cp_QResult = new CP_QResult();
                cp_QResult.studentId = id;
                cp_QResult.result = result;

                _sessions.Send(cp_QResult.Write());
            }
        }

        public void AtdRequest(int time, int week)
        {
            lock (_lock)
            {
                CP_Atd cp_Atd = new CP_Atd();
                cp_Atd.classTime = time;
                cp_Atd.week = week;

                _sessions.Send(cp_Atd.Write());
            }
        }

        public void AtdListRequest()
        {
            lock (_lock)
            {
                CP_AtdListRequest cp_AtdListRequest = new CP_AtdListRequest();
                _sessions.Send(cp_AtdListRequest.Write());
            }
        }

        public void EndOfClassRequset()
        {
            lock (_lock)
            {
                CP_EndOfClass cp_EndOfClass = new CP_EndOfClass();
                _sessions.Send(cp_EndOfClass.Write());
            }
        }

        public ServerSession Generate()
        {
            lock (_lock)
            {
                ServerSession session = new ServerSession();
                this._sessions = session;
                return session;
            }
        }

        public void CloseForm()
        {
            _sessions.Disconnect();
        }
    }
}

