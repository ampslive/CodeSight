using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSight.Data.Models
{
    public class Project
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string DateCreated { get; set; }

        /// <summary>
        /// 1 - Save log to Flat File
        /// 2 - Azure Database
        /// 3 - SQL Database
        /// </summary>
        public int LogSaveFormat { get; set; }
        public List<MessageLog> MessageLogs { get; set; }
        public List<ExceptionLog> ExceptionLogs { get; set; }
    }

    
}
