using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Login
{
    public class LoginRequestDTO
    {
        [Required(ErrorMessage = "O email é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Password { get; set; }

    }
}


