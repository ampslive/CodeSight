using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSight.Server.Models
{
    interface ILog
    {
        string ProjectId { get; set; }
        string MethodName { get; set; }
        string Message { get; set; }
        string LogType { set; }
        List<string> Parameters { get; set; }
        DateTime DateCreated { set; }

        void WriteLog();
    }
}
