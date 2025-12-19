using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class ItensFromStoreDTO
    {
        public int Id { get; set; }
        public int name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public TypeEnum Type { get; set; }
        public RarityEnum Rarity { get; set; }

    }
}
