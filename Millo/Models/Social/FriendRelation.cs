using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    
    public class FriendRelation
    {
        public int Id { get; set; }
        public  bool AreFriends { get; set; }
        public string UserId1 { get; set; }
        public string UserId2 { get; set; }
    }
}