using System.ComponentModel.DataAnnotations;
using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Application.DTOs.Campaign
{
  public class CreateCampaignDTO
  {
    [Required(ErrorMessage = "O Nome da campanha é obrigatório.")]
    public string Name { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "O SystemId deve ser um valor válido.")]
    public int SystemId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "O Id do mestre é obrigatório e deve ser um valor válido.")]
    public int MasterId { get; set; }
    public int Players_limit { get; set; }
    public AttributeEnum Attribute_definition { get; set; }
    public Boolean Is_store_open { get; set; }
    public Boolean Enable_multiclasses { get; set; }
  }
}
