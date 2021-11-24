using ProgramMain;
using System;
using System.Drawing;
using System.Windows.Forms;

class PacketHandler
{

    public static void SP_ResultHandler(PacketSession session, IPacket packet)
    {
       
    }
    
    public static void SP_LoginFailedHandler(PacketSession session, IPacket packet)
    {

    }     
    public static void SP_LoginResultHandler(PacketSession session, IPacket packet)
    {

    }     
    public static void SP_StudentInfoHandler(PacketSession session, IPacket packet)
    {

    }

    public static void SP_ScreenResultHandler(PacketSession session, IPacket packet)
    {
        SP_ScreenResult sp_screenPacket = packet as SP_ScreenResult;
        ServerSession serverSession = session as ServerSession;
        Bitmap bmp;
        bmp = ScreenCopy.GetBitmap(sp_screenPacket.img);

  
    }
    public static void SP_QustionTextHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QustionImgHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QustionHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QuizResultHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_EndClassHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_QuizOXResultHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_AddStudentHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_LeaveStudentHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SP_AddAtdHandler(PacketSession session, IPacket packet)
        {

        }
    

}