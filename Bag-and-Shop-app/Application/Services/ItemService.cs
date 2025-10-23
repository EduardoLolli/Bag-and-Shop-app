using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{

    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<ItemCreationResponseDTO> CreateItem(Item item)
        {
            return await _itemRepository.RegisterItem(item);
        }
    }
}