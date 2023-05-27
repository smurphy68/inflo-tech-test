using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.WinForm
{
    public class Log
    {
        Dictionary<string, string> userLogs = new Dictionary<string, string>();
        public Log(Dictionary<string, string> userLogs)
        {
            this.userLogs = userLogs;
        }
        
    }
}
