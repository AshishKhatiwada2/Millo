using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class School
    {
        public int Id { get; set; }
        public string Concentrations { get; set; }
        
        public int GraduationYear { get; set; }
        public string Name { get; set; }
        public string SchoolId { get; set; }
    }
}