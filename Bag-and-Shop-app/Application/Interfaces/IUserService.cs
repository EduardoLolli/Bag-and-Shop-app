using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
namespace Bag_and_Shop_app.Application.Services
{

    public interface IUserService
    {
        Task<UserResponseDTO> AddUser(User user);
        Task<User?> FindUserByEmail(string email);
        Task<List<UserResponseDTO>> GetAllUsers();
    }
}
