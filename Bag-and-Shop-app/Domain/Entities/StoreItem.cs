using System.ComponentModel.DataAnnotations.Schema;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class StoreItem
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; } = null!;
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; } = null!;
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
    }
}
