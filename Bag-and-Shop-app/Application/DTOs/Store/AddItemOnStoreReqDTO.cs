namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class AddItemOnStoreReqDTO : StoreBaseReqDTO
    {
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
    }
}
