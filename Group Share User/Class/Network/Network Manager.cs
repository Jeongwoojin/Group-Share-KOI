#region using..
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
#endregion
namespace Group_Share_User.Class.Network
{
   static public class Network_Manager
   {
       #region 선언부
       static public PacketSender pk;
       static Socket sock;
       static IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5026);
       static byte[] packet_buffer = new byte[2024];
       #endregion        
       static public void ConnectOn()
        {
           sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           sock.BeginConnect(iep, new AsyncCallback(Connect_callback), sock);
           pk = new PacketSender(sock);
           byte[] Startup = Encoding.Default.GetBytes("ST:"+Class.PressetonInfo.PW);
           pk.Send(Startup);
        }
       static public void Filestream(string pw,string filename)
       {
           pk.FileStreamSender(pw, filename);
       }
     static public void SourceSharerequest(string pw,string source)
      {
           pk.SourceShareSender(pw, source);
      }
      static public void Pressetionrequest(string PW)
      {
          pk.PressetionSender(PW);
      }
      #region 콜백
      static void Connect_callback(IAsyncResult iar)
      {
         try
         {
             Socket client = (Socket)iar.AsyncState;
             client.EndConnect(iar);
             client.BeginReceive(packet_buffer, 0, packet_buffer.Length,SocketFlags.None, new AsyncCallback(Recevied_Callback), client);
         } catch { }
      }
      static void Recevied_Callback(IAsyncResult iar)
      {
          Socket client = (Socket)iar.AsyncState;
          int buffersize = client.EndReceive(iar);
          Packet_Recevieder pr = new Packet_Recevieder();
          pr.Recevied(BytesHelper.ArrayRTrim(packet_buffer));
          client.BeginReceive(packet_buffer, 0, packet_buffer.Length, SocketFlags.None, new AsyncCallback(Recevied_Callback), client);
      }
      #endregion
   }
}
