using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly BagAndShopDBContext _context;
        public StoreRepository(BagAndShopDBContext bagAndShopDBContext)
        {
            _context = bagAndShopDBContext;
        }

        public Task<Store> AddStore(Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
            return Task.FromResult(store);
        }
    }
}
