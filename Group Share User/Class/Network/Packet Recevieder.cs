#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
#endregion
namespace Group_Share_User.Class.Network
{
    class Packet_Recevieder
    {
        public void Recevied(byte[] id)
        {
            string Recevied= Encoding.Default.GetString(id);
            string[] ReceviedSplit = Recevied.Split(':');
            switch(ReceviedSplit[0])
            {
                case "PRE":
                    PressetionRecevied(ReceviedSplit);
                    break;
                case "Sc":
                    SourceShare(ReceviedSplit);
                    break;
                case "Fs":
                    FileStream(ReceviedSplit[1],ReceviedSplit[2], ReceviedSplit[3]);
                    break;
            }
        }
        void FileStream(string pw,string ip,string filename)
        {
            File_Stream.FileStreamInfo.IP = ip;
            if (pwcompare(pw))
            { 
                File_Stream.FileStreamClient client = new File_Stream.FileStreamClient();
                File_Stream.FileStreamInfo.flierece = filename;
                if (File_Stream.FileStreamInfo.filestreamallow)
            {
                Thread th_Connect = new Thread(new ThreadStart(client.Connect));
                th_Connect.Start();
                th_Connect.Join();
            }else if (DialogResult.Yes == MessageBox.Show("파일을 받으시겠습니까?", "알림", MessageBoxButtons.YesNo))
            {
                Thread th_Connect = new Thread(new ThreadStart(client.Connect));
                th_Connect.Start();
                th_Connect.Join();
              }
            }
        }
        void SourceShare(string[] RecevieData)
        {
          if (pwcompare(RecevieData[1]))
          {
              Controller_Form.CodeShareForm cf = new Controller_Form.CodeShareForm(RecevieData[2]);
              cf.ShowDialog();
          }
        }
        bool pwcompare(string pw)
        {
            if (0 == String.Compare(PressetonInfo.PW, pw))
            {
                return true;
            }else
            {
                return false;
            }
        }
        void PressetionRecevied(string[] ReceviedSplit)
        {
            if (pwcompare(ReceviedSplit[2]))
            {
                PressetonInfo.IP = ReceviedSplit[1];
                if(Class.PressetonInfo.PressetionAllow == true)
                {
                    Controller_Form.PressetionClientForm ClientForm = new Controller_Form.PressetionClientForm();
                    ClientForm.ShowDialog();
                }else if (DialogResult.Yes == MessageBox.Show("화면공유를 허용하기겠습니까?", "알림", MessageBoxButtons.YesNo))
                {
                    Controller_Form.PressetionClientForm ClientForm = new Controller_Form.PressetionClientForm();
                    ClientForm.ShowDialog();
                }
            }
        }
    }
}
