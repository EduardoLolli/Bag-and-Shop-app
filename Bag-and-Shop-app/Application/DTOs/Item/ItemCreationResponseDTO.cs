namespace Bag_and_Shop_app.Application.DTOs.Item
{
    public class ItemCreationResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Double Weight { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Rarity { get; set; } = string.Empty;
        public Double Price { get; set; }
        public int StockQuantity { get; set; }
    }
}