using SClient;
using System;
using System.Windows.Forms;

class PacketHandler
{

    public static void SS_ResultHandler(PacketSession session, IPacket packet)
    {
        SS_Result result = packet as SS_Result;
        ServerSession serverSession = session as ServerSession;
        if (result.result == true)
        {
            if (SClientForm.sclientform.lbLogin.InvokeRequired == true)
            {
                SClientForm.sclientform.lbLogin.Invoke((MethodInvoker)delegate
                {
                    SClientForm.sclientform.lbLogin.Text = "�α��� : success";
                });
            }
            else
            {
                SClientForm.sclientform.lbLogin.Text = "�α��� : success";
            }
        }
        else
        {
            if (SClientForm.sclientform.lbLogin.InvokeRequired == true)
            {
                SClientForm.sclientform.lbLogin.Invoke((MethodInvoker)delegate
                {
                    SClientForm.sclientform.lbLogin.Text = "�α��� : Faild";
                });
            }
            else
            {
                SClientForm.sclientform.lbLogin.Text = "�α��� : Faild";
            }
        }
    }
    public static void SS_LoginFailedHandler(PacketSession session, IPacket packet)
        {

        }     
        public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
        {

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