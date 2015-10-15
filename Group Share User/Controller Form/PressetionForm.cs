#region using..
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.InteropServices;
#endregion
namespace Group_Share_User.Controller_Form
{
    public partial class PressetionForm : Form
    {
        #region 선언부

        TcpListener listener;
        TcpClient client;
        NetworkStream ns;
        Thread th_GetImage, th_Listen;
        #endregion
        public PressetionForm()
        {
            InitializeComponent();
        }
        public void Listene()
        {
            listener = new TcpListener(7800);
            client = new TcpClient();
            while (!client.Connected)
            {
                    listener.Start();
                    client = listener.AcceptTcpClient();
                    Application.DoEvents();
            }
            th_GetImage = new Thread(new ThreadStart(ReceviedI));
            th_GetImage.Start();
        }
        void ReceviedI()
        {
            BinaryFormatter bf = new BinaryFormatter();
            while (client.Connected)
            {
                try
                {
                    ns = client.GetStream();
                    pictureBox1.Image = (Image)bf.Deserialize(ns);
                }
                catch { Stop(); }
                Application.DoEvents();
            }
        }
        private void PressetionForm_Load(object sender, EventArgs e)
        {
            th_Listen = new Thread(new ThreadStart(Listene));
            th_Listen.Start();
            MessageBox.Show("계속 회색 화면일시 파트너가 화면공유 를 허용하지않은것입니다.", "알림", MessageBoxButtons.OK);
        }
        private void 중지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        void Stop()
        {
            try
            {
                listener.Stop();
                client.Close();
                th_GetImage.Join(300);
                th_GetImage.Abort();
                th_Listen.Join(300);
                th_Listen.Abort();
                pictureBox1.Image = null;
            }
            catch { }
        }
        private void PressetionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
        private void 중지ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          Stop();
        }
    }
}

