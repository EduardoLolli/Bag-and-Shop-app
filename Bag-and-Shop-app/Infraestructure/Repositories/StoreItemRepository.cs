using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class StoreItemRepository : IStoreItemRepository
    {
        private readonly BagAndShopDBContext _context;
        public StoreItemRepository(BagAndShopDBContext context)
        {
            _context = context;
        }

        public async Task<StoreItem> AddOnStore(StoreItem storeItem)
        {
            try
            {
                StoreItem? Item = await _context.StoreItems.FirstOrDefaultAsync(si => si.ItemId == storeItem.ItemId);
                if (Item != null)
                {
                    Item.Quantity = storeItem.Quantity + Item.Quantity;
                    _context.StoreItems.Update(Item);
                    await _context.SaveChangesAsync();
                    return Item;
                }
                else
                {
                    await _context.StoreItems.AddAsync(storeItem);
                    await _context.SaveChangesAsync();
                    return storeItem;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar item na loja: " + ex.Message);
            }
        }
    }
}


