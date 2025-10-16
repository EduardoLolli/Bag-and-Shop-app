using Bag_and_Shop_app.Application.DTOs.Character;

namespace Bag_and_Shop_app.Application.Interfaces
{
    public interface ICharacterService
    {
        Task<CharacterCreationResponseDTO> CreateCharacter(CharacterCreationRequestDTO character);
    }
}
