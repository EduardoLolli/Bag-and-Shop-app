using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{
    public class CharacterCreationRequestDTO
    {
        [Required(ErrorMessage = "O nome do sistema é obrigatório.")]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Descrição é obrigatório.")]
        public string Description { get; set; } = string.Empty;
    }

}