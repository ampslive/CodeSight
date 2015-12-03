using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSight.Server.Models
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
