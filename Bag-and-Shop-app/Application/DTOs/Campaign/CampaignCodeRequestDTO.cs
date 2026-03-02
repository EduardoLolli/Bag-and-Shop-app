using System.ComponentModel.DataAnnotations;

namespace BagAndShopApp.Application.DTOs.Character
{
    public class CampaignCodeRequestDTO
    {
        [Required(ErrorMessage = "O Código da campanha é obrigatório.")]
        public string CampaignCode { get; set; } = string.Empty;

    }

}