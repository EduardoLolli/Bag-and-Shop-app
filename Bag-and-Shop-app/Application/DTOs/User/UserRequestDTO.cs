using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.User
{
    public class UserRequestDTO
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email deve ser um endereço válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [MinLength(8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres.")]
        [RegularExpression(
            "^(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).*$",
            ErrorMessage = "A senha deve conter pelo menos uma letra maiúscula, uma minúscula e um caractere especial."
        )]
        public string Password { get; set; }= string.Empty;

    }
}
