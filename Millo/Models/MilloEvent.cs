using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class MilloEvent
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime EndTime { get; set; }
        public string   EventId { get; set; }
        public string EventSubtype { get; set; }
        public string EventType { get; set; }
        public string Host { get; set; }
        public string LargePicture { get; set; }
        public string MediumPicture { get; set; }
        public string SmallPicture { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string NetworkId { get; set; }
        public string TagLine { get; set; }

    }
}