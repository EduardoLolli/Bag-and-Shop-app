using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class bagRepository : IBagRepository
    {
        private readonly BagAndShopDBContext _context;
        public bagRepository(BagAndShopDBContext bagAndShopDBContext)
        {
            _context = bagAndShopDBContext;
        }

        public Task<BagResponseDTO> CreateBagForCharacter(int character)
        {
            try
            {
                Bag newBag = new Bag
                {
                    CharacterId = character
                };

                _context.Bags.Add(newBag);
                _context.SaveChanges();

                return Task.FromResult(new BagResponseDTO
                {
                    Id = newBag.Id,
                    CharacterId = newBag.CharacterId,
                    Gold = newBag.Gold,
                    WeightLimit = newBag.WeightLimit,
                    CurrentWeight = newBag.CurrentWeight
                });
            }
            catch (Exception)
            {
                throw new Exception("Erro ao criar bolsa para o personagem.");
            }
        }
    }

}