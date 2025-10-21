using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    
    public interface IBagRepository
    {
        Task<BagResponseDTO> CreateBagForCharacter(int characterId);
    }
}