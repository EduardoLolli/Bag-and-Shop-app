using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Application.DTOs.Campaign
{
  public class CreateCampaignResponseDTO
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int MasterId { get; set; }
    public int Players_limit { get; set; }
    public int SystemId { get; set; }
    public string Campaign_code { get; set; } = string.Empty;
    public int Store_id { get; set; }
    public AttributeEnum Attribute_definition { get; set; }
    public Boolean Is_store_open { get; set; }
    public Boolean Enable_multiclasses { get; set; }

  }
}
