using System.ComponentModel.DataAnnotations.Schema;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class Bag
    {
        public int Id { get; set; }
        public decimal Gold { get; set; } = 0;
        public double WeightLimit { get; set; } = 20.0;
        public double CurrentWeight { get; set; } = 0.0;
        public int CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public Character Character { get; set; } = null!;
        public ICollection<BagItem> Items { get; set; } = new List<BagItem>();
    }
}
