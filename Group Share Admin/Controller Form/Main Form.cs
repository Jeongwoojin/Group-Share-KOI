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
using System.Net.Sockets;
#endregion
namespace Group_Share_Admin
{
    public partial class Main_Form : Form
    {
        bool on_off = false;
        public Main_Form()
        {
            InitializeComponent();
        }
        private void bt_srcontrol_Click(object sender, EventArgs e)
        {
            if (on_off == false)
            {
                bt_srcontrol.Text = "Off";
                CheckForIllegalCrossThreadCalls = false;
                on_off = true;
                Class.Network.Network_Manager.ListenOn();
                Class.Network.Packet_Recevider.ConnectionAddevent += ConnectionAdd;
                Class.Network.Network_Manager.ConnectionRemoveevent += ConnectionRemove;
            }else
            {
                bt_srcontrol.Text = "On";
                on_off = false;
                Class.Network.Network_Manager.ListenOff();
            }
        }
     void ConnectionAdd(Socket sock,string PW)
        {
            ListViewItem item = new ListViewItem();
            item.Text = sock.RemoteEndPoint.ToString();
            item.SubItems.Add(PW);
            item.Tag = sock;
            lv_connectionlist.Items.Add(item);
           
        }
      void ConnectionRemove(Socket sock)
      {
          foreach (ListViewItem item in lv_connectionlist.Items)
          {
              if ((Socket)item.Tag == sock)
              {
                  item.Remove();
              }
          }
      }
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
