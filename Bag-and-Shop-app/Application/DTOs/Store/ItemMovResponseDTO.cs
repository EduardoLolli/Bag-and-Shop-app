namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class ItemMovResponseDTO
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
