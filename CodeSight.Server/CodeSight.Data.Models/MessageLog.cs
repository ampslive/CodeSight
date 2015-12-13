using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSight.Data.Models
{
    public class MessageLog : Log<MessageLog>
    {
        protected override string LogType { set { value = "M"; } }
        public MessageLog()
        {

        }

        //public override void WriteLog(MessageLog ml)
        //{

        //}

        public void WriteLog(string message)
        {
            //LogSerializeToJSON()
        }
    }
}
