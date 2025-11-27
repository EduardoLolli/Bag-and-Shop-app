using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<UserResponseDTO> AddNewUser(User user);
        Task<User?> FindUserById(int id);
        Task<User?> FindUserByEmail(string email);
        Task<List<UserResponseDTO>> GetAllUsers();
    }
}
