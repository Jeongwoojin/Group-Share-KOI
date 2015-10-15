#region using...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
#endregion
namespace Group_Share_Admin.Class.Network
{
   public class Network_Manager
   {
      /*네트워크 관리 클래스*/
      #region 선언부
         static Thread th_Listen;
         static Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
         public delegate void ConnectionAddhandler(Socket s);
         public delegate void ConnectionRemovehandler(Socket s);
         static public event ConnectionRemovehandler ConnectionRemoveevent;
         static public ArrayList socklist = new ArrayList();
         static bool NMRunngin;
       #endregion
     static  public void ListenOn()
        {
          th_Listen = new Thread(new ThreadStart(Listen));
          th_Listen.Start();
        }
      static public void ListenOff()
     {
         th_Listen.Join(300);
         th_Listen.Abort();
         sock.Close();
         socklist.Clear();
         NMRunngin = false;
     }
      static void Listen()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Any,5026);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sock.Bind(iep);
                sock.Listen(300);
                NMRunngin = true;
                sock.BeginAccept(new AsyncCallback(accept_Callback), sock);
            }
            catch (SocketException er) { MessageBox.Show(er.Message); }
            while(NMRunngin)
            {
                ArrayList copylist = new ArrayList(socklist);
                try
                {
                    Socket.Select(copylist, null, null, 1000000);
                }
                catch { }

              foreach(Socket s in copylist)
              {
                  byte[] buffer = new byte[2024];
                  int sent = 0;

                  try
                  {
                      sent = s.Receive(buffer);

                  }
                  catch { SocketRemove(s); }

                  if (sent == 0)
                  {
                      SocketRemove(s);
                  }
                  Packet_Recevider PR = new Packet_Recevider(s);
                  PR.ReceviData(s,buffer);
              }
              Thread.Sleep(1000);
              Application.DoEvents();
            }
        }
    static  void SocketRemove(Socket s)
        {
            ConnectionRemoveevent(s);
            socklist.Remove(s);
            s.Close();
        }
       static void accept_Callback(IAsyncResult iar)
        {
            try
            {
                Socket old = (Socket)iar.AsyncState;
                Socket client = old.EndAccept(iar);
                socklist.Add(client);
                old.BeginAccept(new AsyncCallback(accept_Callback), old);
            }
            catch { }
        }
    }
}
