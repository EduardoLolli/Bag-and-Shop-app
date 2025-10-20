using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Application.Interfaces;
using BagAndShopApp.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        public CharacterService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }
        public async Task<CharacterCreationResponseDTO> CreateCharacter(CharacterCreationRequestDTO character)
        {
            throw new NotImplementedException();
        }
    }
}