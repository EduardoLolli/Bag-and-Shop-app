using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IStoreRepository
    {
        Task<Store> AddStore(Store store);
    }
}
