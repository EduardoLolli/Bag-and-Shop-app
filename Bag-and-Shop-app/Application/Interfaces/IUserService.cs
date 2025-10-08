using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
namespace Bag_and_Shop_app.Application.Services
{

    public interface IUserService
    {
        Task<UserResponseDTO> addUser(User user);
        Task<User> findUserByEmail(string email);
        Task<List<UserResponseDTO>> getAllUsers();
    }
}
