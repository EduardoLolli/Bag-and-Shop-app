using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Infraestructure.Data;
using BagAndShopApp.Domain.Interfaces;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly BagAndShopDBContext _context;
        public CharacterRepository(BagAndShopDBContext bagAndShopDBContext)
        {
            _context = bagAndShopDBContext;
        }

        public Task<CharacterResponseDTO> AddCharacter(Character character)
        {
            try
            {
                _context.Characters.Add(character);
                _context.SaveChanges();
                return Task.FromResult(new CharacterResponseDTO
                {
                    Id = character.Id,
                    Name = character.Name,
                    UserId = character.UserId
                });
            }
            catch (Exception)
            {
                return Task.FromResult<CharacterResponseDTO>(null);
            }
        }
    }

}