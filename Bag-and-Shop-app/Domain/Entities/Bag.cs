namespace Bag_and_Shop_app.Domain.Entities
{
    public class Bag
    {
        public int Id { get; set; }
        public int CharacterId { get; set; } // FK para Character
        public ICollection<BagItem> Items { get; set; } = new List<BagItem>();
    }
}
