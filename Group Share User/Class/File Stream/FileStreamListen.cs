#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
#endregion
namespace Group_Share_User.File_Stream
{
    class FileStreamListen
    {
        public void Listen()
        {
            #region 선언부
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                TcpListener listen = new TcpListener(7894);
                TcpClient client = new TcpClient();
                NetworkStream ns;
            #endregion
                byte[] byte_file = File.ReadAllBytes(File_Stream.FileStreamInfo.filenamesend);
                listen.Start(1);
                while (!client.Connected)
                {
                    client = listen.AcceptTcpClient();
                }
                ns = client.GetStream();
                bf.Serialize(ns, byte_file);
                client.Close();
                listen.Stop();
            }
            catch { }
        }
    }
}
