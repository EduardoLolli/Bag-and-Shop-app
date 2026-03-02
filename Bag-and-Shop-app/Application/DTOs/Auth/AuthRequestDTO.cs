using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Auth
{
    public class AuthRequestDTO
    {
        [Required(ErrorMessage = "O token é obrigatório.")]
        public string Token { get; set; } = string.Empty;
    }
}
