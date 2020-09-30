using Millo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Security.Principal;
using System.IdentityModel.Tokens.Jwt;

namespace Millo.BLL
{
    public class ClaimsUserManager
    {
        public Claim[] ConvertUserToClaimArray(User user)
        {
            var claimCollection = new Claim[]
            {

                new Claim("Id",user.UserId.ToString()),
                new Claim(type: "UserName", user.UserName),
                new Claim(type: ClaimTypes.Role,user.Role),
                new Claim(type: "Email",user.Email),
                new Claim(type: "PhoneNumber",user.PhoneNumber),
                new Claim(type: "FullAddress",user.FullAddress),
                // you can add other standard or custom claims here based on your username/password lookup...
                new Claim(type: ClaimTypes.AuthenticationInstant, DateTime.UtcNow.ToString("o")),
                new Claim(type: "FullName",user.FullAddress),
                new Claim(type: "Issuer", "Millo"),
                new Claim(type: "Audience",user.UserName),
                new Claim(type: "PublicToken",user.PublicToken),
                new Claim(type: "PrivateToken",user.PrivateToken),
                new Claim(type: "PasswordSalt",user.PasswordSalt),
                new Claim(type: "PasswordHash",user.PasswordHash)
                // etc.
            };
            return claimCollection;
        }
        public IList<Claim> ConvertUserToClaimList(User user)
        {
            var claimCollection = new Claim[]
            {

                new Claim("Id",user.UserId.ToString()),
                new Claim(type: "UserName", user.UserName),
                new Claim(type: ClaimTypes.Role,user.Role),
                new Claim(type: "Email",user.Email),
                new Claim(type: "PhoneNumber",user.PhoneNumber),
                new Claim(type: "FullAddress",user.FullAddress),
                // you can add other standard or custom claims here based on your username/password lookup...
                new Claim(type: ClaimTypes.AuthenticationInstant, DateTime.UtcNow.ToString("o")),
                new Claim(type: "FullName",user.FullAddress),
                new Claim(type: "Issuer", "Millo"),
                new Claim(type: "Audience",user.UserName),
                new Claim(type: "PublicToken",user.PublicToken),
                new Claim(type: "PrivateToken",user.PrivateToken),
                new Claim(type: "PasswordSalt",user.PasswordSalt),
                new Claim(type: "PasswordHash",user.PasswordHash)
                // etc.
            };
            return claimCollection;
        }
        public async Task<User> ConvertClaimIdentityToUser(ClaimsIdentity claimsIdentity)
        {

            var identity = claimsIdentity;
            //var claims = identity.Claims;

            User user = new User();
            //user.UserId = claims.Where(x => x.Type == "Id");
            var x = identity.NameClaimType;
            user.UserName = identity.Claims.Where(c => c.Type.Contains("UserName"))
                   .Select(c => c.Value).SingleOrDefault();
            user.Role = identity.Claims.Where(c => c.Type == ClaimTypes.Role)
                               .Select(c => c.Value).SingleOrDefault();
            user.Email = identity.Claims.Where(c => c.Type.Contains("Email"))
                               .Select(c => c.Value).SingleOrDefault();
            user.PhoneNumber = identity.Claims.Where(c => c.Type.Contains("PhoneNumber"))
                              .Select(c => c.Value).SingleOrDefault();
            var issuer = identity.Claims.Where(c => c.Type.Contains("Issuer"))
                              .Select(c => c.Value).SingleOrDefault();
            var audience = identity.Claims.Where(c => c.Type.Contains("Audience"))
                             .Select(c => c.Value).SingleOrDefault();
            user.UserId = Convert.ToInt32(identity.Claims.Where(c => c.Type.Contains("Id"))
                             .Select(c => c.Value).SingleOrDefault());
            user.FullAddress = identity.Claims.Where(c => c.Type.Contains("FullAddress"))
                             .Select(c => c.Value).SingleOrDefault();
            user.PublicToken = identity.Claims.Where(c => c.Type.Contains("PublicToken"))
                             .Select(c => c.Value).SingleOrDefault();
            user.PrivateToken = identity.Claims.Where(c => c.Type.Contains("PrivateToken"))
                             .Select(c => c.Value).SingleOrDefault();
            user.PasswordHash = identity.Claims.Where(c => c.Type.Contains("PasswordHash"))
                             .Select(c => c.Value).SingleOrDefault();
            user.PasswordSalt = identity.Claims.Where(c => c.Type.Contains("PasswordSalt"))
                             .Select(c => c.Value).SingleOrDefault();
            //JwtRsaTokenManager tokenManager = new JwtRsaTokenManager();
            //string token = await tokenManager.CreateToken(user);
            //var handler = new JwtSecurityTokenHandler();
            //var ReturnedToken = handler.ReadJwtToken(token);
            //var id = Convert.ToInt32(ReturnedToken.Claims.Where(c => c.Type.Contains("id"))
            //       .Select(c => c.Value).SingleOrDefault());
            //var id1 = ReturnedToken.Claims;
            return user;
        }
        public void showData(string payload)
        {
            Console.WriteLine(payload);
            Console.ReadLine();
        }
        public string getClaimValue(string claimName,string JsonTokenString)
        {
            
            JwtSecurityTokenHandler JwtHandler = new JwtSecurityTokenHandler();
            var jwtReadToken = JwtHandler.ReadJwtToken(JsonTokenString);
            var s = jwtReadToken.Audiences;
            var audience = s.ToList();
            var x = audience[0];
            var claimss = jwtReadToken.Claims;
            var claiming = claimss.ToList();
            var oneClaim = claiming.Where(clam => clam.Type == claimName).FirstOrDefault();
            var claimValue = oneClaim.Value;
            return claimValue;
        }

    }
}