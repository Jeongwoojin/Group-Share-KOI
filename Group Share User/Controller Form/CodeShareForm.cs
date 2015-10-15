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
using System.Text.RegularExpressions;
using System.Threading;
#endregion
namespace Group_Share_User.Controller_Form
{
    public partial class CodeShareForm : Form
    {
        //http://msdn.microsoft.com/en-us/library/x53a06bb(VS.71).aspx MSDN C# keyword
        #region 키워드 선언
        public Regex csharpkeyWords = new Regex(
            "abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|" 
            + "foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|" 
            + "string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|volatile|void|while|");
        #endregion
        public CodeShareForm()
        {
            InitializeComponent();
        }
        public CodeShareForm(string source)
        {
            InitializeComponent();
            rt_ligth.Text = source;
        }
        void Codehighligth()
        {
            int Pos = rt_ligth.SelectionStart;
            foreach(Match key in csharpkeyWords.Matches(rt_ligth.Text))
            {
                rt_ligth.Select(key.Index, key.Length);
                rt_ligth.SelectionColor = Color.Blue;
                rt_ligth.SelectionStart = Pos;
                rt_ligth.SelectionColor = Color.Black;
            }
        }
        private void bt_sourcesend_Click(object sender, EventArgs e)
        {
            Class.Network.Network_Manager.SourceSharerequest(tb_pw.Text, rt_ligth.Text);
        }
        private void rt_ligth_TextChanged(object sender, EventArgs e)
        {
            Codehighligth();
        }
    }

}

