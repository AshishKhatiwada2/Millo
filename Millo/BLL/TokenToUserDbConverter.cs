using Millo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.BLL
{
    public class TokenToUserDbConverter
    {
        public TokenToUserDbConverter()
        {

        }
        public User TokenToUser(string token)
        {
            ClaimsUserManager cum = new ClaimsUserManager();
            string Userid = cum.getClaimValue("Id", token);
            return null;
            
        }
    }
}