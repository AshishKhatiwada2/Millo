using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class GroupMembership
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
    }
}