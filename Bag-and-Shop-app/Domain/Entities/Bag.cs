namespace Bag_and_Shop_app.Domain.Entities
{
    public class Bag
    {
        public int Id { get; set; }
        public int CharacterId { get; set; } // FK para Character
        public ICollection<Item> Items { get; set; } = new List<Item>();
        public decimal TotalWeight => Items.Sum(i => i.Weight);

    }
}
