using KrispyChik.Business_Contracts;
using KrispyChik.Business_Manager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KrispyChik.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   // [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _usermanager;
        public UserController(IUserManager usermanager)
        { 
            _usermanager = usermanager;
        }


        [HttpGet]
        public IActionResult  GetAllUsers()
        {
            return Ok(_usermanager.GetAllUsers());
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok(true);
        }

        [HttpPost]
        public IActionResult AddUser() 
        {
            return Ok();
        }
    }
}
