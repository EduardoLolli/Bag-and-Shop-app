using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class SystemEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public SystemEnum System_code { get; set; }
        public ICollection<Campaign> Campaigns { get; set; } = new List<Campaign>();
    }
}
