#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
#endregion
namespace Group_Share_User.Class.Network
{
   public class PacketSender
   {
       #region 선언분
       Socket s;
       #endregion
       public PacketSender(Socket s)
        {
            this.s = s;
        }
      public void PressetionSender(string PW)
        {
            string PresstionData = "PR:" + PW;
            byte[] buffer = Encoding.Default.GetBytes(PresstionData);
            Send(buffer);
        }
       public void SourceShareSender(string pw,string Source)
      {
          string SourceShareData = "Sc:" + pw + ":" + Source;
          byte[] buffer = Encoding.Default.GetBytes(SourceShareData);
          Send(buffer);
      }
       public void FileStreamSender(string pw,string filename)
       {
           string Filestreamdata = "Fs:" + pw + ":" + filename;
           byte[] buffer = Encoding.Default.GetBytes(Filestreamdata);
           Send(buffer);
       }
      public void Send(byte[] data)
        {
         try
         {
            s.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(send_Callback), s);
          }catch { }
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
