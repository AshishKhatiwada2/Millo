using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class PhotoAlbum
    {
        public int Id { get; set; }
        public string CoverPhotoId { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
    }
}