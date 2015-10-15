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
using System.Threading;
#endregion
namespace Group_Share_User
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            pwtextload();
            Connect();
            CheckForIllegalCrossThreadCalls = false;
        }
        void Connect()
        {
            Class.Network.Network_Manager.ConnectOn();
        }
       void pwtextload()
        {
            Class.PassWord.LoadHDPW();
            tx_pw.Text = Class.PassWord.PW;
            Class.PressetonInfo.PW = tx_pw.Text;
        }
       private void bt_pwrest_Click(object sender, EventArgs e)
       {
           pwtextload();
       }
       private void bt_Pressetion_Click(object sender, EventArgs e)
       {
           Class.Network.Network_Manager.Pressetionrequest(tx_partpw.Text);
           Controller_Form.PressetionForm Pressetion = new Controller_Form.PressetionForm();
           Pressetion.ShowDialog();
       }
       private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
       {
           if (cb_try.Checked)
           {
               e.Cancel = true;
               this.ShowInTaskbar = false;
               this.Visible = false;
               nf_try.Visible = true;
           }
       }
       private void ck_pressetion_CheckedChanged(object sender, EventArgs e)
       {
           if (ck_pressetion.Checked)
           {
               Class.PressetonInfo.PressetionAllow = true;
           }
         else
           {
               Class.PressetonInfo.PressetionAllow = false;
           }
       }
       private void button1_Click(object sender, EventArgs e)
       {
          Class.Network.Network_Manager.Pressetionrequest(tx_partpw.Text);
           try
           {
                Controller_Form.PressetionForm Pressetion = new Controller_Form.PressetionForm();
                Pressetion.ShowDialog();
           } catch { }
       }
       private void lk_Codeshare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           Controller_Form.CodeShareForm CSF = new Controller_Form.CodeShareForm();
           CSF.ShowDialog();
       }
       private void bt_filesend_Click(object sender, EventArgs e)
       {
           if (tb_filebrower.Text == String.Empty)
           {
               MessageBox.Show("경로가 잘못되었습니다.", "알림");
           }else if(tb_filepartpw.Text == String.Empty)
           {
               MessageBox.Show("파트너 비밀번호가 잘못되었습니다", "알림");
           }else
           {
               System.IO.FileInfo fi = new System.IO.FileInfo(tb_filebrower.Text);
               Class.Network.Network_Manager.Filestream(tb_filepartpw.Text, fi.Name);
               File_Stream.FileStreamInfo.filenamesend = tb_filebrower.Text;
               File_Stream.FileStreamListen listen = new File_Stream.FileStreamListen();
               Thread th_listen = new Thread(new ThreadStart(listen.Listen));
               th_listen.Start();
               th_listen.Join();
           }
       }
       private void button1_Click_1(object sender, EventArgs e)
       {
           OpenFileDialog of = new OpenFileDialog();
           if (DialogResult.OK == of.ShowDialog())
           {
               tb_filebrower.Text = of.FileName;
           }
       }
       private void cb_filestream_CheckedChanged(object sender, EventArgs e)
       {
           if (cb_filestream.Checked)
           {
               File_Stream.FileStreamInfo.filestreamallow = true;
           }
           else
           {
               File_Stream.FileStreamInfo.filestreamallow = false;
           }
       }
        void Exit()
       {
           nf_try.Visible = false;
           Application.Exit();
           System.Diagnostics.Process.GetCurrentProcess().Kill();
       }
       private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Exit();
       }
       private void cm_try_DoubleClick(object sender, EventArgs e)
       {
           this.ShowInTaskbar = true;
           this.Visible = true;
           nf_try.Visible = false;
       }

       private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.ShowInTaskbar = true;
           this.Visible = true;
           nf_try.Visible = false;
       }

       private void nf_try_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           this.ShowInTaskbar = true;
           this.Visible = true;
           nf_try.Visible = false;
       }

       private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Exit();
       }
       private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           Exit();
       }

       private void ms_main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
       {

       }

    }
}
