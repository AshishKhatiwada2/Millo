using Millo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.DAL
{
    public class ManageUser
    {
        public MilloDbContext _dbContext { get; set; }
        public ManageUser()
        {
            _dbContext = new MilloDbContext();

        }
        public User GetUserById(string id)
        {
            User user = null;

            int userid;
            try
            {
                userid = Convert.ToInt32(id);
                user = _dbContext.Users.Where(x => x.UserId == userid).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }

        public User GetUserByUsernameOrEmail(string username)
        {
            User user = null;
            try
            {
                user = _dbContext.Users.Where(x => x.Email == username || x.Email == username).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }
    }
}