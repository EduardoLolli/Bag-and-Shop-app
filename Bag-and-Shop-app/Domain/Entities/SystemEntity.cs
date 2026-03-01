using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Domain.Entities
{
  public class SystemEntity
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // Nome do sistema (Pathfinder, D&D, etc.)
    public string Description { get; set; } = string.Empty;
    public SystemEnum system_code { get; set; }
  }
}
