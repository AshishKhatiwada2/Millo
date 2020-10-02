using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class RSVPStatus
    {
        public int Id { get; set; }
        public bool Attending { get; set; }
        public bool Declined { get; set; }
        public bool NotReplied { get; set; }
        public bool NotSpecified { get; set; }
        public bool Unsure { get; set; }
    }
}