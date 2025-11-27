using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

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
                Boolean ItemExiasts = await _itemRepository.VerifyItemExists(storeItem.ItemId);
                if (!ItemExiasts)
                {
                    throw new Exception("Item inexistente");
                }

                Boolean StoreExists = await _storeRepository.VerifyStoreExists(storeItem.StoreId);
                if (!StoreExists)
                {
                    throw new Exception("Loja inexistente");
                }

                storeItem = await _storeItemRepository.AddOnStore(storeItem);
                return storeItem;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar item na loja: " + ex.Message);
            }

        }

        public async Task<List<Item>> GetItemsByStore(int storeId)
        {
            try
            {
                Boolean store = await _storeRepository.VerifyStoreExists(storeId);
                if (!store)
                {
                    throw new Exception("Loja inexistente");
                }

                List<Item> itemsList = await _itemRepository.GetItemsByStoreId(storeId);


                return itemsList;
            }catch(Exception e)
            {
                throw new Exception("Falha ao recuperar itens: " + e);
            }
        }

        public Task<StoreItem> RemoveItemFromStore(StoreItem dto)
        {
            throw new NotImplementedException();
        }
    }
}
