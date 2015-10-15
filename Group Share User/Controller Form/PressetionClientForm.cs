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
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
#endregion
namespace Group_Share_User.Controller_Form
{
    public partial class PressetionClientForm : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream ns;
        bool Runing = true;
        public PressetionClientForm()
        {
            InitializeComponent();
        }
        Image DesktopImage()
        {
            Rectangle Rec_Bound;
            Bitmap bit_screen;
            Graphics gp_gr;
            Rec_Bound = Screen.PrimaryScreen.Bounds;
            bit_screen = new Bitmap(Rec_Bound.Width, Rec_Bound.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            gp_gr = Graphics.FromImage(bit_screen);
            gp_gr.CopyFromScreen(Rec_Bound.X, Rec_Bound.Y, 0, 0, Rec_Bound.Size, CopyPixelOperation.SourceCopy);
            return bit_screen;
        }
        void SendImage()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                ns = client.GetStream();
                bf.Serialize(ns, DesktopImage());
            }
            catch { Stop(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            client.Connect(IPAddress.Parse(Class.PressetonInfo.IP), 7800);
            }
            catch { }
            Sendtimer.Start();
            getimage.Start();
        }
        private void Sendtimer_Tick(object sender, EventArgs e)
        {
            SendImage();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stop();
        }
        void Stop()
        {
            try
            {
                Sendtimer.Stop();
                client.Close();
                getimage.Stop();
                pictureBox1.Image = null;
            }
            catch { }
        }
        private void getimage_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = DesktopImage();
        }
        private void PressetionClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
    }
}
