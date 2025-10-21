

using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;

namespace BagAndShopApp.Domain.Interfaces
{
    public interface ICharacterRepository
    {
        Task<CharacterResponseDTO> AddCharacter(Character character);
    }
}