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
            try
            {
                Boolean ItemExiasts = await _itemRepository.verifyItemExists(storeItem.ItemId);
                if (!ItemExiasts)
                {
                    throw new Exception("Item inexistente");
                }
                storeItem = await _storeItemRepository.AddOnStore(storeItem);
                return storeItem;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar item na loja: " + ex.Message);
            }

        }
    }
}
