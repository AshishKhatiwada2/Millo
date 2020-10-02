using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Unspecified { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
    }
}