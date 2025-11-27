using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IStoreItemRepository
    {
        Task<StoreItem> GetItemById(int itemId);
        Task<StoreItem> AddOnStore(StoreItem storeItem);
        Task UpdateOnStore(StoreItem storeItem);
        Task<StoreItem> RemoveFromStore(StoreItem storeItem);
    }
}
