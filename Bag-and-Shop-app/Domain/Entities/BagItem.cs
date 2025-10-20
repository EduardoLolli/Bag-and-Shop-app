using System.ComponentModel.DataAnnotations.Schema;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class BagItem
    {
        public int Id { get; set; }
        public int BagId { get; set; }
        [ForeignKey(nameof(BagId))]
        public Bag Bag { get; set; } = null!;

        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; } = null!;

        public int Quantity { get; set; }
        public double TotalWeight => (double)(Item.Weight * Quantity);
        public double Condition { get; set; } // Ex: 100%, 80%, etc
    }
}
