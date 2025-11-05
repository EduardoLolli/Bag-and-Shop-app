namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class AddItemOnStoreReqDTO
    {
        public int StoreId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; } = 0;
        public int Price { get; set; } = 0;
    }
}
