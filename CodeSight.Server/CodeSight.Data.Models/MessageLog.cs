using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSight.Data.Models
{
    public class MessageLog : Log
    {
        protected override string LogType { set { value = "M"; } }
        public MessageLog()
        {

        }

        public override void WriteLog()
        {

        }
    }
}
