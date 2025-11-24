using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(storeItem);
            _context.SaveChanges();
            return storeItem;

        }

        public async Task<bool> VerifyItemExistsOnStore(StoreItem storeItem)
        {
            if (storeItem == null)
            {
                throw new ArgumentNullException(nameof(storeItem));
            }
            var item = await _context.StoreItems
                                 .AsNoTracking()
                                 .AnyAsync(si => si.StoreId == storeItem.StoreId
                                               && si.ItemId == storeItem.ItemId);
            if (item)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


