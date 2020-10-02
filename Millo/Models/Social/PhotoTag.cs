using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class PhotoTag
    {
        public int Id { get; set; }
        public string PhotoId { get; set; }
        public string Position { get; set; }
        public string User { get; set; }
    }
}