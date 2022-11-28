using sbWpnActiveX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSBSS.Communication
{
    public class SBSSActivX
    {
        IsbWpnActiveXClient sbssActiveX = new sbWpnActiveXClient();
        public void init()
        {

            sbssActiveX.ClientName = "WpsSecs";
            sbssActiveX.UserName = "root";
            sbssActiveX.Port = 10073;
            sbssActiveX.Host = "localhost";
            sbssActiveX.Password = "wpn4sia";
            sbssActiveX.DoubleBuffered = false;
            sbssActiveX.Enabled = true;
            sbssActiveX.Visible = true;
            sbssActiveX.MultiInstance = true;
            sbssActiveX.Cursor = 0;
        }
        public void connect()
        {
            sbssActiveX.Open();
        }
        public IsbWpnActiveXClient get()
        {
            return sbssActiveX;
        }

    }
}
