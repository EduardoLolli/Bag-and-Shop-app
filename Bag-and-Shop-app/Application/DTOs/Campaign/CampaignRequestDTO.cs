using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Campaign
{
    public class CampaignRequestDTO
    {
        [Required(ErrorMessage = "O Nome da campanha é obrigatório.")]
        public string Name { get; set; } = string.Empty;
        [Range(1, int.MaxValue, ErrorMessage = "O SystemId deve ser um valor válido (maior que zero).")]
        public int SystemId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "O Id do mestre é obrigatório e deve ser um valor válido (maior que zero).")]
        public int MasterId { get; set; }
    }
}
