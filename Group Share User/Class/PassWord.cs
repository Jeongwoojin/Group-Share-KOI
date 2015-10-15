#region using..
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
#endregion
namespace Group_Share_User.Class
{
  static public class PassWord
    {
     static public void LoadHDPW()
      {
        ManagementObjectSearcher Os = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
        foreach(ManagementObject hd in Os.Get())
        {try{pw = hd["SerialNumber"].ToString().Trim().Substring(0,9);}catch { }}
      }
     #region 프로퍼티
     static private string pw;
       static  public string PW
        {
            get
            {
                return pw; 
            }
        }
     #endregion
    }
}
