using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Application.Services;
using Microsoft.AspNetCore.Mvc;



namespace Bag_and_Shop_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            List<UserResponseDTO> users = await _userService.GetUsers();
            return Ok(users);
        }

    }
}
