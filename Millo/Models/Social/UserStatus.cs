using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class UserStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}