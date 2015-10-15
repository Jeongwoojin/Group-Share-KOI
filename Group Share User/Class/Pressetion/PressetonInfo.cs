#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion
namespace Group_Share_User.Class
{
   class PressetonInfo
   {
       #region 프로퍼티
       static public string IP
        {
            get;
            set;
        }
       static public string PW
       {
           get;
           set;
       }
       static public bool PressetionAllow
       {
           get;
           set;
       }
       #endregion
   }
}
