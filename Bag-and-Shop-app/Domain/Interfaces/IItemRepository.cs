using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IItemRepository
    {

        Task<ItemCreationResponseDTO> RegisterItem(Item character);
        Task<bool> VerifyItemExists(int itemId);
        Task<List<Item?>> GetItemsByStoreId(int storeId);

    }

}