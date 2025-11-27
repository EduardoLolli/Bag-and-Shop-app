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

        public async Task<StoreItem> GetItemById(int itemId)
        {
            try
            {
                StoreItem Item = await _context.StoreItems.FirstOrDefaultAsync(si => si.ItemId == itemId) ?? null!;
                return Item;
            }
            catch (Exception)
            {
                throw new Exception("Erro aa recuperar item:");
            }
        }
        public async Task<StoreItem> AddOnStore(StoreItem storeItem)
        {
            try
            {
                await _context.StoreItems.AddAsync(storeItem);
                await _context.SaveChangesAsync();
                return storeItem;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao adicionar item na loja.");
            }
        }

        public async Task UpdateOnStore(StoreItem storeItem)
        {
            try
            {
                _context.StoreItems.Update(storeItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao atualizar item na loja.");
            }
        }


        public async Task<StoreItem> RemoveFromStore(StoreItem storeItem)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao remover item da loja.");
            }
        }
    }
}


