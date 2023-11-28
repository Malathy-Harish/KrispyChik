using KrispyChik.Business_Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KrispyChik.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager _usermanager;
        public UserController(UserManager usermanager)
        { 
            _usermanager = usermanager;
        }


        [HttpGet]
        public IActionResult  GetAllUsers()
        {
            return Ok(_usermanager.GetAllUsers());
        }
    }
}
