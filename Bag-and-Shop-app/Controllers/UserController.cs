using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace Bag_and_Shop_app.Controllers
{
    [Authorize]
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
        public async Task<ActionResult<List<UserResponseDTO>>> allUsers()
        {
            try
            {
                Task<List<UserResponseDTO>> users = _userService.getAllUsers();
                return Ok(new
                {
                    error = false,
                    message = "",
                    data = users.Result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    message = ex.Message
                });
            }
        }
    }
}
