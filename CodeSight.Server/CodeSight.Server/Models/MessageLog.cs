using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSight.Server.Models
{
    public class MessageLog : ILog
    {
        public string ProjectId { get; set; }
        public string MethodName { get; set; }
        public string LogType { set { LogType = "M"; } }
        public string Message { get; set; }
        public List<string> Parameters { get; set; }
        public DateTime DateCreated { set { DateCreated = DateTime.UtcNow; } }

        public void WriteLog()
        {

        }
    }
}
