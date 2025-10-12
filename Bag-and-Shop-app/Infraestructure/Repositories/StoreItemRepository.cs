namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class SotreItemRepository : IStoreItemRepository
    {
        private readonly BagAndShopDBContext _context;
        public SotreItemRepository(BagAndShopDBContext context)
        {
            _context = context;
        }


        public async Task<Boolean> AddStoreItem(StoreItem storeItem)
        {
            try
            {
                _context.Add(storeItem);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
