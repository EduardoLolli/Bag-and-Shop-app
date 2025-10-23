using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly BagAndShopDBContext _context;
        private readonly IMapper _mapper;
        public ItemRepository(BagAndShopDBContext bagAndShopDBContext,
            IMapper mapper)
        {
            _context = bagAndShopDBContext;
            _mapper = mapper;
        }

        public Task<ItemCreationResponseDTO> RegisterItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            ItemCreationResponseDTO responseDto = _mapper.Map<ItemCreationResponseDTO>(item);
            return Task.FromResult(responseDto);
        }
    }
}