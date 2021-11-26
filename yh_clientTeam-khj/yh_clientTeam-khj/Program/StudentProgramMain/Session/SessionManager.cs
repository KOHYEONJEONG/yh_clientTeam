using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramMain
{
    public class SessionManager    {
        

        ServerSession _sessions;
        object _lock = new object();

       
        public void LoginSend()
        {
            lock (_lock)
            {
                CS_Login loging_packet = new CS_Login();
                
                    loging_packet.id = "test01010";
                    loging_packet.pwd = "test03401";
                    ArraySegment<byte> segment = loging_packet.Write();
                    _sessions.Send(segment);
            }

        }

        #region 로그인
        public void LoginSend(string id, string pwd)
        {
            lock (_lock)
            {
                CS_Login loging_packet = new CS_Login();

                loging_packet.id = id;
                loging_packet.pwd = pwd;
                ArraySegment<byte> segment = loging_packet.Write();
                _sessions.Send(segment);
            }

        }
        #endregion


        #region Student_askf폼 ( 이미지, 텍스트 전송 )
        public void ImgSend(byte[] img )
        {//이미지만 전송(askf폼)
            lock (_lock)
            {
                CS_QustionImg Img_packet = new CS_QustionImg();
                Img_packet.img = img;
                _sessions.Send(Img_packet.Write());//오류남    
            }
        }
        public void TextSend(string s)
        {//질문만 전송(askf폼)
            lock (_lock)
            {
                CS_QustionText Text_packet = new CS_QustionText();
                Text_packet.qustion = s as string;
                _sessions.Send(Text_packet.Write());//오류남
            }
        }

        public void ImgTextSend(byte[] img, string s)
        {//이미지,질문 두개 전송(askf폼)
            lock (_lock)
            {
                CS_Qustion ImgText_packet = new CS_Qustion();
                ImgText_packet.img = img;
                ImgText_packet.qustion = s;
                _sessions.Send(ImgText_packet.Write());//오류남
            }
        }
        #endregion

        #region Student_answer폼 퀴즈 답변하기
        public void QuizAnswer(string s)
        {
            CS_Quiz quizAnswer_packet = new CS_Quiz();
            quizAnswer_packet.result = s;
            _sessions.Send(quizAnswer_packet.Write());
        }
        #endregion

        public ServerSession Generate()
        {
            lock (_lock)
            {
                ServerSession session = new ServerSession();
                this._sessions = session;
                return session;
            }
        }
    }
}

