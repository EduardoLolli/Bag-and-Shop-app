using Bag_and_Shop_app.Application.DTOs.Store;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Application.Interfaces
{
    public interface IStoreService
    {
        Task<StoreItem> AddItemOnStore(AddItemOnStoreReqDTO dto);


    }
}
