using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string NotReplied { get; set; }
        public string Member { get; set; }
        public string Officer { get; set; }
        public bool Admin { get; set; }

    }
}