using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models.Social
{
    public class RelationshipStatus
    {
        public int Id { get; set; }
        public bool Engaged { get; set; }
        public bool InAnOpenRelationship { get; set; }
        public bool InARelationship { get; set; }
        public bool IsSingle { get; set; }
        public bool ItsComplicated { get; set; }
        public bool Married { get; set; }
        public bool Unspecified { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
    }
}