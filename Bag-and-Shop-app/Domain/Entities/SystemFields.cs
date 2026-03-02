using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class SystemFields

    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public SystemEntity System { get; set; } = null!;
        public string Field_name { get; set; } = string.Empty;
        public int Field_value { get; set; }
        public Fieldsenum Field_type { get; set; }
        public int Default_value { get; set; }
    }
}
