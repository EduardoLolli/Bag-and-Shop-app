using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{
    public class CharacterCreationRequestDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "O código da campanha é obrigatório.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "A Nome do personagem é obrigatório.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O código da campanha é obrigatório.")]
        public string CampaignCode { get; set; } = string.Empty;
    }

}