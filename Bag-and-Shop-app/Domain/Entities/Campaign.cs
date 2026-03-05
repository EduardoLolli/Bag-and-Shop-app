using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Domain.Entities
{
  public class Campaign
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int SystemId { get; set; }
    public SystemEntity System { get; set; } = null!;
    public int Players_limit { get; set; } = 5;
    public int MasterId { get; set; }
    public User Master { get; set; } = null!;
    public string Campaign_code { get; set; } = string.Empty;
    public AttributeEnum Attribute_definition { get; set; }
    public Boolean Is_store_open { get; set; } = true;
    public Boolean Enable_multiclasses { get; set; } = true;
  }
}
