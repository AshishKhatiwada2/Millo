using Millo.BLL;
using Millo.Filters;
using Millo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Routing;

namespace Millo.Controllers
{
    public class UserController : ApiController
    {
        private MilloDbContext _dbContext { get; set; }
        public UserController()
        {
            _dbContext = new MilloDbContext();
        }
        
        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }
        [Route("CreateUser")]
        [ValidateModelState]
        // POST: api/User
        public void Post([FromBody]User value)
        {

        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
        [Route("Register")]
        [ValidateModelState]
        [AllowAnonymous]
        public async Task<string> register(User user)
        {
            PasswordManager passwordManager = new PasswordManager();
            user =await passwordManager.SecurePassword(user);
            JwtRsaTokenManager jwtRsaTokenManager = new JwtRsaTokenManager( user);
            user = jwtRsaTokenManager.InsertRsaKeys();

            //PasswordManager passMgr = new PasswordManager();
            //passMgr.SecurePassword(user);
            //passMgr.MakeJwtTokenKeys(user);


            //var tokenHandler = new JwtSecurityTokenHandler();
            //Claim claim = new Claim("userID",user.UserId);
            //claim
            //ClaimsIdentity claimsIdentity = new System.Security.Claims.ClaimsIdentity();
            //claimsIdentity.AddClaim()
            //tokenHandler.CreateJwtSecurityToken("millo", "", user, "", "", "", user.PublicToken);
              _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            string token = await jwtRsaTokenManager.CreateToken(user);
            
            return token;
            //var x = GetPrivateAndPublicKey();
        }
        [HttpGet,Route("GetToken")]
        [Authorize]
        
        public async Task<string> Login()
        {
            var identity = User.Identity as ClaimsIdentity;
            //var claims = identity.Claims;

            User user = new User();
            //user.UserId = claims.Where(x => x.Type == "Id");
            var x = identity.NameClaimType;
            user.UserName = identity.Claims.Where(c => c.Type.Contains("UserName"))
                   .Select(c => c.Value).SingleOrDefault();
            user.Role = identity.Claims.Where(c => c.Type==ClaimTypes.Role)
                               .Select(c => c.Value).SingleOrDefault();
            user.Email = identity.Claims.Where(c => c.Type.Contains("Email") )
                               .Select(c => c.Value).SingleOrDefault();
             user.PhoneNumber = identity.Claims.Where(c => c.Type.Contains("PhoneNumber"))
                               .Select(c => c.Value).SingleOrDefault();
            var issuer = identity.Claims.Where(c => c.Type.Contains("Issuer"))
                              .Select(c => c.Value).SingleOrDefault();
             var audience = identity.Claims.Where(c => c.Type.Contains("Audience"))
                              .Select(c => c.Value).SingleOrDefault();
             user.UserId = Convert.ToInt32( identity.Claims.Where(c => c.Type.Contains("Id"))
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
            JwtRsaTokenManager tokenManager = new JwtRsaTokenManager();
            string token = await tokenManager.CreateToken(user);

            return token;
        }

        [HttpGet,Route("DecodeToken")]
        [Authorize]

        public async Task<string> TokenDecode()
        {
            var identity = User.Identity as ClaimsIdentity;
            //var claims = identity.Claims;
            ClaimsUserManager claimsUserManager = new ClaimsUserManager();
            User user = await claimsUserManager.ConvertClaimIdentityToUser(identity);

            JwtRsaTokenManager tokenManager = new JwtRsaTokenManager();
            string token = await tokenManager.CreateToken(user);
            var handler = new JwtSecurityTokenHandler();
            var ReturnedToken = handler.ReadJwtToken(token);
            string[] id =new string[]{ ReturnedToken.Claims.Where(c => c.Type.Contains("id"))
                   .Select(c => c.Value).SingleOrDefault() };
            //var id1 = ReturnedToken.Claims;
            return id.ToString();
        }

        //public Dictionary<string,string> GetPrivateAndPublicKey()
        //{
        //    Dictionary<string, string> keys = new Dictionary<string, string>() ;
        //    Random random = new Random();
        //    string rando= random.Next().ToString();
        //    keys.Add("private", rando);
        //    keys.Add("public", random.NextDouble().ToString());
        //    return keys;

        //}
    }
}
