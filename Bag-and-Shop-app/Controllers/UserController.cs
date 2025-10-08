using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Application.Services;
using Bag_and_Shop_app.Domain.Entities;
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
        [HttpPost("register")]
        public async Task<ActionResult<UserResponseDTO>> Register([FromBody] UserRequestDTO dto)
        {
            try
            {
                User user = new User
                {
                    Username = dto.Username,
                    Email = dto.Email,
                    PasswordHash = dto.Password,
                    Role = "DEFAULT"
                };
                Boolean validEmail = await _userService.findUserByEmail(dto.Email) == null;
                if (!validEmail)
                {
                    throw new Exception("Email já cadastrado");
                }
                UserResponseDTO newuser = await _userService.addUser(user);
                return Ok(new
                {
                    error = false,
                    message = "Usuário cadastrado com sucesso",
                    data = newuser
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
