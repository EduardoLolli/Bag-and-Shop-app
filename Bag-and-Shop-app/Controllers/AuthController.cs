using Bag_and_Shop_app.Application.DTOs.Login;
using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Application.Services;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("v1/register")]
        public async Task<ActionResult<UserResponseDTO>> Register([FromBody] UserRequestDTO dto)
        {
            try
            {
                User user = new User
                {
                    Username = dto.Username,
                    Email = dto.Email,
                    PasswordHash = _authService.HashPass(dto.Password),
                    Role = "DEFAULT"
                };
                Boolean validEmail = await _userService.findUserByEmail(dto.Email) == null;
                if (!validEmail)
                {
                    throw new Exception("Endereço de email já cadastrado");
                }
                UserResponseDTO newuser = await _userService.addUser(user);
                string token = _authService.GenerateToken(user);
                return Ok(new
                {
                    error = false,
                    message = "Usuário cadastrado com sucesso",
                    data = new
                    {
                        user = newuser,
                        token = token
                    }
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
        [AllowAnonymous]
        [HttpPost("v1/login")]
        public async Task<ActionResult> Login([FromBody] LoginRequestDTO dto)
        {
            try
            {
                User user = await _userService.findUserByEmail(dto.Email);
                if (user == null)
                {
                    throw new Exception("Usuário ou senha inválidos");
                }

                Boolean validPass = _authService.VerifyPass(user.PasswordHash, dto.Password);
                if (!validPass)
                {
                    throw new Exception("Usuário ou senha inválidos");
                }
                string token = _authService.GenerateToken(user);
                return Ok(new
                {
                    error = false,
                    message = "Login realizado com sucesso",
                    data = new
                    {
                        token = token
                    }
                });
            }
            catch (Exception ex)
            {
                return Unauthorized(new
                {
                    error = true,
                    message = ex.Message
                });
            }


        }
    }
}
