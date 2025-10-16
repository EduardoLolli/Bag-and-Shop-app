using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Application.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{
    public class CharacterService : ICharacterService
    {
        Task<CharacterCreationResponseDTO> ICharacterService.CreateCharacter(CharacterCreationRequestDTO character)
        {
            throw new NotImplementedException();
        }
    }
}