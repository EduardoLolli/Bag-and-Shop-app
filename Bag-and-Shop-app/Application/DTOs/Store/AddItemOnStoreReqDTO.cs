namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class AddItemOnStoreReqDTO
    {
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
