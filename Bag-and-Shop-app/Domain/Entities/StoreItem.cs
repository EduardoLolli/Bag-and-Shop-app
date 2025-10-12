namespace Bag_and_Shop_app.Domain.Entities
{
    public class StoreItem
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public int Quantidade { get; set; } = 0;
        public int PrecoVenda { get; set; } = 0;
    }
}
