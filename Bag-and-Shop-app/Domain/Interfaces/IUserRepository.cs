using Bag_and_Shop_app.Application.DTOs.User;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IUserRepository
    {

        Task<List<UserResponseDTO>> GetAllUsers();
    }
}
