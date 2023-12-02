using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KrispyChik.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult SignIn(string username, string password)
        {
            if (true)
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

                return Ok(tokenString);
            }

            return Ok("User and password is wrong");
        }
    }
}
