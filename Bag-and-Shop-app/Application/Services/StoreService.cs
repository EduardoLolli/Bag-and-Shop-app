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
        private readonly IItemRepository _itemRepository;
        public StoreService(
            IStoreRepository storeRepository,
            IStoreItemRepository storeItemRepository,
            IItemRepository itemRepository)
        {
            _storeRepository = storeRepository;
            _storeItemRepository = storeItemRepository;
            _itemRepository = itemRepository;
        }

        public async Task<StoreItem> AddItemOnStore(StoreItem storeItem)
        {
            Boolean ItemExiasts = await _itemRepository.verifyItemExists(storeItem.ItemId);
            if (!ItemExiasts)
            {
                throw new Exception("Item inexistente");
            }


            Boolean itemExistsOnStore = await _storeItemRepository.VerifyItemExistsOnStore(storeItem);
            if (itemExistsOnStore)
            {
                throw new Exception("Item já existe na loja");
            }

            return storeItem;

        }
    }
}
