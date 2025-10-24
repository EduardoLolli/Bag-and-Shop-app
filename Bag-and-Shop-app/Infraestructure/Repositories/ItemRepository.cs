using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly BagAndShopDBContext _context;
        public ItemRepository(BagAndShopDBContext bagAndShopDBContext)
        {
            _context = bagAndShopDBContext;
        }

        public Task<ItemCreationResponseDTO> RegisterItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            ItemCreationResponseDTO responseDto = TinyMapper.Map<ItemCreationResponseDTO>(item);
            return Task.FromResult(responseDto);
        }
    }
}