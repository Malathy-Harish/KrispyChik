using KrispyChik.Business_Contracts;
using KrispyChik.Business_Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace KrispyChik.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authmanager;
        public AuthController(IAuthManager authmanager)
        {
            _authmanager = authmanager;
        }
        [HttpGet]
        public string SignIn(string username, string password)
        {
            var result = _authmanager.CheckPassword(username, password);
            if (result)
            {
                var claimsdata = new[]
                {
                    new Claim("Email",username),
                    new Claim("Date", DateTime.Now.ToString())
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("w2SoigJvVvuydwAJKuAVT6oRbtalqNDy"));
                var signinCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

                var token = new JwtSecurityToken(
                    issuer: "http://localhost",
                    audience: "http://localhost",
                    expires: DateTime.Now.AddMinutes(100),
                    claims: claimsdata,
                    signingCredentials: signinCred
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                return (tokenString);
            }

            return ("User and password is wrong");
        }
    }
}


