using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class MilloGroup
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public string GroupId { get; set; }
        public string GroupSubType { get; set; }
        public string GroupType { get; set; }
        public string LargePicture { get; set; }
        public string MediumPicture { get; set; }
        public string SmallPicture { get; set; }
        public string Name { get; set; }
        public string NetworkId { get; set; }
        public string Office { get; set; }
        public string RecentNews { get; set; }
        public string UpdatedTime { get; set; }
        public string Website { get; set; }
    }
}