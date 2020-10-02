using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class WorkPlace
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
    }
}