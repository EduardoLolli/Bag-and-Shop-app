using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class BodyRepository : IBodyRepository
    {
        private readonly BagAndShopDBContext _context;
        public BodyRepository(BagAndShopDBContext context)
        {
            _context = context;
        }

        public Task<BodyResponseDTO> CreateCharacterBody(int characterId)
        {
            try
            {
                Body newBody = new Body
                {
                    CharacterId = characterId
                };

                _context.Add(newBody);
                _context.SaveChanges();

                return Task.FromResult(new BodyResponseDTO
                {
                    Id = newBody.Id,
                    CharacterId = newBody.CharacterId,
                    WeaponId = newBody.WeaponId ?? 0,
                    ArmorId = newBody.ArmorId ?? 0,
                    ShieldId = newBody.ShieldId ?? 0,
                    BootsId = newBody.BootsId ?? 0,
                    GlovesId = newBody.GlovesId ?? 0,
                    AmuletId = newBody.AmuletId ?? 0,
                    RingId = newBody.RingId ?? 0
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar corpo do personagem: " + ex.Message);
            }
        }
    }
}