using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class StoreItemRepository: IStoreItemRepository
    {
        private readonly BagAndShopDBContext _context;
        public StoreItemRepository(BagAndShopDBContext context)
        {
            _context = context;
        }

        public async Task<Boolean> AddStoreItem(StoreItem storeItem)
        {
            _context.Add(storeItem);
            _context.SaveChanges();
            return true;

        }
    }
}


