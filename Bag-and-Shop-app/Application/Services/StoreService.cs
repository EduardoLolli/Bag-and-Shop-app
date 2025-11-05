using Bag_and_Shop_app.Application.DTOs.Store;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Application.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IStoreItemRepository _storeItemRepository;
        public StoreService(IStoreRepository storeRepository, IStoreItemRepository storeItemRepository)
        {
            _storeRepository = storeRepository;
            _storeItemRepository = storeItemRepository;
        }

        public async Task<StoreItem> AddItemOnStore(AddItemOnStoreReqDTO dto)
        {
            StoreItem storeItem = TinyMapper.Map<StoreItem>(dto);

            return storeItem;

        }
    }
}
