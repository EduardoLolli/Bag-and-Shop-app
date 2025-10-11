using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Campaign
{
    public class CampaignRequestDTO
    {
        [Required(ErrorMessage = "O Nome da campanha é obrigatório.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "O Sistema da campanha é obrigatório.")]
        public int SystemId { get; set; }
        [Required(ErrorMessage = "O nome da loja é obrigatório" )]
        public string StoreName { get; set; } = string.Empty;

    }
}
