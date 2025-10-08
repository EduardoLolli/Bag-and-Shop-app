using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<UserResponseDTO> addNewUser(User user);
        Task<User> findUserByEmail(string email);
        List<UserResponseDTO> getAllUsers();
    }
}
