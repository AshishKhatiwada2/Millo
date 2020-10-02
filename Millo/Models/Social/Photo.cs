using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string AlbumId { get; set; }
        public string Caption { get; set; }
        public DateTime Created { get; set; }
        public string LargeSoruce { get; set; }
        public string Link { get; set; }
        public string MediumSource { get; set; }
        public string Owner { get; set; }
        public string PhotoId { get; set; }
        public string SmallSource { get; set; }
    }
}