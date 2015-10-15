#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;
#endregion
namespace Group_Share_Admin.Class.Network
{
    class Packet_Sender
    {
        public void PressetionSender(string IP,string PW)
        {
           ArrayList copylist=  new ArrayList(Network_Manager.socklist);
           Socket.Select(null, copylist, null, 1000000);
           foreach (Socket s in copylist)
           {
               string PressetionSendData = "PRE:"+IP+":"+PW;
               byte[] buffer = Encoding.Default.GetBytes(PressetionSendData);
               Send(s, buffer);
           }
        }
        public void SourceShare(string pw,string source)
        {
            ArrayList copylist = new ArrayList(Network_Manager.socklist);
            Socket.Select(null, copylist, null, 1000000);
            foreach(Socket s in copylist)
            {
                string SourceShareData = "Sc:" + pw + ":" + source;
                byte[] buffer = Encoding.Default.GetBytes(SourceShareData);
                Send(s, buffer);
            }
        }
        public void FilestreamSender(string pw,string ip,string filename)
        {
            ArrayList copylist = new ArrayList(Network_Manager.socklist);
            Socket.Select(null, copylist, null, 1000000);
            foreach (Socket s in copylist)
            {
                string Filestream = "Fs:" + pw + ":" +ip + ":" + filename;
                byte[] buffer = Encoding.Default.GetBytes(Filestream);
                Send(s, buffer);
            }
        }
        void Send(Socket s,byte[] data)
        {
            s.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(send_Callback), s);
        }
        #region 콜백
        void send_Callback(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
        }
        #endregion
    }
}
