using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClient
{
    public class SessionManager
    {
        object _lock = new object();
        ServerSession _sessions = new ServerSession();
        public void LoginSend(String id, String pass)
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

