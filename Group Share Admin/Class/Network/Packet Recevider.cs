#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
#endregion
namespace Group_Share_Admin.Class.Network
{
   public class Packet_Recevider
   {
       #region 선언부
       public delegate void ConnectionAddhandler(Socket s,string pw);
       static public event ConnectionAddhandler ConnectionAddevent;
       Packet_Sender pk = new Packet_Sender();
       Socket sock;
       #endregion
       public Packet_Recevider(Socket sock)
       {
           this.sock = sock;
       }
     public void ReceviData(Socket s,byte[] data)
     {
         try
         {
             string Recevistr = Encoding.Default.GetString(data);
             string[] splitxt = Recevistr.Split(':');
             string[] remotepointsplit = sock.RemoteEndPoint.ToString().Split(':');
             switch (splitxt[0])
             {
                case "PR":
                    pk.PressetionSender(remotepointsplit[0], splitxt[1]);
                    break;
                case "Sc":
                    pk.SourceShare(splitxt[1], splitxt[2]);
                    break;
                case "Fs":
                    pk.FilestreamSender(splitxt[1], remotepointsplit[0], splitxt[2]);
                    break;
                 case "ST":
                    ConnectionAddevent(sock, splitxt[1]);
                    break;
             }
         }catch { }
    }
   }
}
       

