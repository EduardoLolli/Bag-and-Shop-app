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
        public async Task<List<Item>> GetItemsByStore(int storeId)
        {
            try
            {
                Store store = await _storeRepository.VerifyStoreExists(storeId) ?? throw new Exception("Loja inexistente");
                List<Item> itemsList = await _itemRepository.GetItemsByStoreId(storeId);
                return itemsList;
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao recuperar itens: " + e);
            }
        }
        public async Task<StoreItem> AddItemOnStore(StoreItem storeItem)
        {
            try
            {
                Store store = await _storeRepository.VerifyStoreExists(storeItem.StoreId) ?? throw new Exception("Loja inexistente");
                Item ItemExists = await _itemRepository.VerifyItemExists(storeItem.ItemId) ?? throw new Exception("Item inexistente");
                StoreItem item = await _storeItemRepository.GetItemById(storeItem.ItemId, store.Id);
                if (item != null)
                {
                    if (ItemExists.IsStackable == false)
                    {
                        storeItem.Quantity = 1;
                        return await _storeItemRepository.AddOnStore(storeItem);
                    }
                    if (ItemExists.MaxStackSize < item.Quantity + storeItem.Quantity)
                    {
                        int newQuantity = ItemExists.MaxStackSize - item.Quantity;
                    }
                    item.Quantity += storeItem.Quantity;
                    item.Price = storeItem.Price;
                    await _storeItemRepository.UpdateOnStore(item);
                    return item;
                }
                if (ItemExists.IsStackable == false)
                {
                    storeItem.Quantity = 1;
                    return await _storeItemRepository.AddOnStore(storeItem);
                }
                storeItem = await _storeItemRepository.AddOnStore(storeItem);
                return storeItem;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar item na loja: " + ex.Message);
            }
        }

        public async Task<StoreItem> RemoveItemFromStore(StoreItem dto)
        {
            try
            {
                Store store = await _storeRepository.VerifyStoreExists(dto.StoreId) ?? throw new Exception("Loja inexistente");
                StoreItem item = await _storeItemRepository.GetItemById(dto.ItemId, store.Id);
                if (item.Quantity < 0) throw new Exception("Este item já foi esgotado na loja");
                if (item.Quantity < dto.Quantity) throw new Exception("Quantidade insuficiente deste item na loja");

                item.Quantity -= dto.Quantity;
                await _storeItemRepository.UpdateOnStore(item);
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover item da loja: " + ex.Message);
            }
        }
    }
}
