﻿using System;
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

        public void ImgSend(byte[] img )
        {//이미지 전송
            lock (_lock)
            {
                CS_ScreenResult Img_packet = new CS_ScreenResult();
                Img_packet.studentId = "test";
                Img_packet.img = img;
                _sessions.Send(Img_packet.Write());              
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
    }
}

