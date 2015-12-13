using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSight.Data.Models
{
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime DateCreated { get; set; }
        public Project Projects { get; set; }
    }
}
