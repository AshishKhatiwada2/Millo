using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class Affiliation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NID { get; set; }
        public string Status { get; set; }
        public int Year { get; set; }
    }
}