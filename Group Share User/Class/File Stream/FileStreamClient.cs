#region using...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
#endregion
namespace Group_Share_User.File_Stream
{
    class FileStreamClient
    {
        public void Connect()
        {
            #region 선언부
            TcpClient client = new TcpClient();
            NetworkStream ns;
            BinaryFormatter bf = new BinaryFormatter();
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Download");
            #endregion

            string path = @"Download\" + File_Stream.FileStreamInfo.flierece;
            byte[] pathBytes = Encoding.Default.GetBytes(path);

            if (!di.Exists)
            {
                di.Create();
            }
            try
            {
                client.Connect(IPAddress.Parse(FileStreamInfo.IP), 7894);
            }catch (Exception) {  }
            ns = client.GetStream();
            byte[] byt_file = (byte[])bf.Deserialize(ns);
            try
            {
               File.WriteAllBytes(path, byt_file);
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            MessageBox.Show("파일을 전송받았습니다.");
            client.Close();
        }
    }
}