using Microsoft.AspNetCore.Mvc;
using API.Application;
using API.DTO;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] UserRegistrationDTO userRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userDetail = _userService.Register(userRegistration);
            return StatusCode(201, userDetail);
        }
    }
}
