using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Application.Interfaces
{

    public interface IItemService
    {
        Task<ItemCreationResponseDTO> CreateItem(Item item);
    }
}