using PClient;
using System;
using System.Drawing;
using System.Windows.Forms;

class PacketHandler
{

    public static void SP_ResultHandler(PacketSession session, IPacket packet)
    {
        SP_Result result = packet as SP_Result;
        ServerSession serverSession = session as ServerSession;
        if (result.result == true)
        {
            if (PClientForm.pclientform.lbLogin.InvokeRequired == true)
            {
                PClientForm.pclientform.lbLogin.Invoke((MethodInvoker)delegate
                {
                    PClientForm.pclientform.lbLogin.Text = "�α��� : success";
                });
            }
            else
            {
                PClientForm.pclientform.lbLogin.Text = "�α��� : success";
            }
        }
        else
        {
            if (PClientForm.pclientform.lbLogin.InvokeRequired == true)
            {
                PClientForm.pclientform.lbLogin.Invoke((MethodInvoker)delegate
                {
                    PClientForm.pclientform.lbLogin.Text = "�α��� : Faild";
                });
            }
            else
            {
                PClientForm.pclientform.lbLogin.Text = "�α��� : Faild";
            }
        }
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


        PClientForm.pclientform.lbImg.Invoke((MethodInvoker)delegate
        {
            PClientForm.pclientform.lbImg.Text = "\n ����";
        });
        if (PClientForm.pclientform.txtBox.InvokeRequired == true)
        {
            PClientForm.pclientform.txtBox.Invoke((MethodInvoker)delegate
            {
                PClientForm.pclientform.txtBox.Text += sp_screenPacket.studentId;
                PClientForm.pclientform.txtBox.Text += "\n ����";
            });
        }
        else
        {
            PClientForm.pclientform.txtBox.Text = sp_screenPacket.studentId;
        }

        if (PClientForm.pclientform.ptBox.InvokeRequired == true)
        {
            PClientForm.pclientform.ptBox.Invoke((MethodInvoker)delegate
            {
                PClientForm.pclientform.ptBox.Image = bmp;
            });
        }
        else
        {
            PClientForm.pclientform.ptBox.Image = bmp;
        }
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