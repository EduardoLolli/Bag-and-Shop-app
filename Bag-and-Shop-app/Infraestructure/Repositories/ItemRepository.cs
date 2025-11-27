using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Item?>> GetItemsByStoreId(int storeId)
        {
            try
            {
                List<Item?> items = await _context.Items
        .Join(
            _context.StoreItems, // Tabela que vamos juntar (Join)
            item => item.Id,     // Chave primária da tabela Item
            storeItem => storeItem.ItemId, // Chave estrangeira na tabela StoreItem
            (item, storeItem) => new { item, storeItem } // Resultado do JOIN (Tipo anônimo)
        )
        .Where(joined => joined.storeItem.StoreId == storeId) // Filtra pelo StoreId
        .Select(joined => joined.item) // Seleciona apenas o objeto Item final
        .Distinct() // Garante que cada Item seja retornado apenas uma vez (se houver duplicatas no join)
        .ToListAsync();

                return items;

            }
            catch (Exception e)
            {
                throw new Exception("Falha ao buscar items");
            }
        }

        public Task<ItemCreationResponseDTO> RegisterItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            ItemCreationResponseDTO responseDto = TinyMapper.Map<ItemCreationResponseDTO>(item);
            return Task.FromResult(responseDto);
        }

        public async Task<bool> verifyItemExists(int itemId)
        {

            var item = await _context.Items
                                 .AsNoTracking()
                                 .AnyAsync(i => i.Id == itemId);

            if (!item)
            {
                return false;
            }

            return true;
        }

        public Task<bool> VerifyItemExists(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}