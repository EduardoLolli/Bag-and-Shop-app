using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int System_id { get; set; }
        public int Players_limit { get; set; } = 10;
        public SystemEntity System { get; set; } = null!;
        public int Master_id { get; set; }
        public User Master { get; set; } = null!;
        public string Campaign_code { get; set; } = string.Empty;
        public AttributeEnum Attribute_definition { get; set; }
        public Boolean Is_store_open { get; set; }
        public Boolean Enable_multiclasses { get; set; }
    }
}
