using System;
using System.Collections.Generic;
using System.Text;
using CodeSight.Publisher;
using Newtonsoft.Json;

namespace CodeSight.Data.Models
{
    public abstract class Log<T>
    {
        protected string ProjectId { get; set; }
        protected string MethodName { get; set; }
        protected string Message { get; set; }
        protected abstract string LogType { set; }
        protected List<string> Parameters { get; set; }
        protected DateTime DateCreated { set { value = DateTime.Now; } }

        public virtual void WriteLog(T log)
        {
            string jsonLog = LogSerializeToJSON(log);
            Publish.PublishJSON(jsonLog);
        }

        protected string LogSerializeToJSON(T log)
        {
            return JsonConvert.SerializeObject(log);
        }            
    }
}
