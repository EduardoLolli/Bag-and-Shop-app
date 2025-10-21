using Bag_and_Shop_app.Application.DTOs.Character;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IBodyRepository
    {
        Task<BodyResponseDTO> CreateCharacterBody(int characterId);
    }
}