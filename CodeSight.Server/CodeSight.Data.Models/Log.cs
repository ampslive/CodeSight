using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSight.Data.Models
{
    public abstract class Log
    {
        protected string ProjectId { get; set; }
        protected string MethodName { get; set; }
        protected string Message { get; set; }
        protected abstract string LogType { set; }
        protected List<string> Parameters { get; set; }
        protected DateTime DateCreated { set { value = DateTime.Now; } }

        public abstract void WriteLog();
    }
}
